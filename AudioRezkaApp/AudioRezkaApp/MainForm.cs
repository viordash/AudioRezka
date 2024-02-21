using System.Diagnostics;
using System.Runtime.InteropServices;
using AudioRezkaApp.Helpers;
using NAudio.Wave;

namespace AudioRezkaApp {
    public partial class MainForm : Form {
        bool recording;

        WaveInEvent? waveIn = null;
        WaveFileWriter? writer = null;
        object lockWrite = new();

        float silenceThreshold;
        int minSilenceDuration;
        int minVoiceDuration;
        DateTime timerSilence;
        DateTime timerSignalLevel;
        float avgSignalLevel;
        int cntSignalLevel;

        int SampleRate {
            get => int.TryParse(edSampleRate.Text, out int sampleRate)
                ? sampleRate
                : Settings.Default.SampleRate;
        }

        int BitsPerSample {
            get => int.TryParse(edBitsPerSample.Text, out int bitsPerSample)
                ? bitsPerSample
                : Settings.Default.BitsPerSample;
        }

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            FormsHelper.LoadLocation(Settings.Default.MainFormLocation, this);
            edWorkFolder.Text = Settings.Default.WorkFolder;
            edFilenamePrefix.Text = Settings.Default.FilenamePrefix;
            edStartNumber.Value = Settings.Default.StartNumber;
            edMinVoiceDuration.Value = Settings.Default.MinVoiceDuration;
            edMinSilenceDuration.Value = Settings.Default.MinSilenceDuration;
            edSilenceThreshold.Value = Settings.Default.SilenceThreshold;
            edSampleRate.Text = Settings.Default.SampleRate.ToString();
            edBitsPerSample.Text = Settings.Default.BitsPerSample.ToString();

            silenceThreshold = edSilenceThreshold.Value / 100f;
            minSilenceDuration = (int)edMinSilenceDuration.Value;
            minVoiceDuration = (int)edMinVoiceDuration.Value;
            OpenAudio();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            CloseAudio();
            Settings.Default.MainFormLocation = Location;
            Settings.Default.WorkFolder = edWorkFolder.Text;
            Settings.Default.FilenamePrefix = edFilenamePrefix.Text;
            Settings.Default.StartNumber = (int)edStartNumber.Value;
            Settings.Default.MinVoiceDuration = (int)edMinVoiceDuration.Value;
            Settings.Default.MinSilenceDuration = (int)edMinSilenceDuration.Value;
            Settings.Default.SilenceThreshold = edSilenceThreshold.Value;
            Settings.Default.SampleRate = SampleRate;
            Settings.Default.BitsPerSample = BitsPerSample;
            Settings.Default.Save();
        }

        private void btnRecord_Click(object sender, EventArgs e) {
            if(!recording) {
                StartRecording();
            } else {
                PauseRecording();
            }
        }

        private void btnSelectWorkFolder_Click(object sender, EventArgs e) {
            if(folderBrowserDialog1.ShowDialog() != DialogResult.OK) {
                return;
            }
            edWorkFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        void OpenAudio() {
            Debug.WriteLine("OpenAudio...");
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(SampleRate, BitsPerSample, 1);
            waveIn.DataAvailable += DataAvailable;
            waveIn.RecordingStopped += RecordingStopped;
            waveIn.StartRecording();
            Debug.WriteLine($"OpenAudio... ok, format: {waveIn.WaveFormat.SampleRate} Hz, {waveIn.WaveFormat.BitsPerSample}");
        }

        void CloseAudio() {
            Debug.WriteLine("CloseAudio...");
            if(waveIn == null) {
                return;
            }
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn.DataAvailable -= DataAvailable;
            waveIn.RecordingStopped -= RecordingStopped;
            waveIn = null;
            Debug.WriteLine("CloseAudio... ok");
        }

        void StartRecording() {
            Debug.WriteLine("StartRecording...");
            if(waveIn == null) {
                throw new Exception("WaveInEvent not ready");
            }

            var outputFolder = edWorkFolder.Text;
            Directory.CreateDirectory(outputFolder);
            var outputFilePath = Path.Combine(outputFolder, $"{edFilenamePrefix.Text}{edStartNumber.Value.ToString()}");
            outputFilePath = Path.ChangeExtension(outputFilePath, ".wav");

            lock(lockWrite) {
                timerSilence = DateTime.Now;
                timerSignalLevel = DateTime.Now;
                avgSignalLevel = 0;
                cntSignalLevel = 0;
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            }
            btnRecord.BackColor = Color.FromArgb(255, 128, 128);
            btnRecord.Text = "RECORD";
            recording = true;
            Debug.WriteLine($"StartRecording... ok");
        }

        void PauseRecording() {
            Debug.WriteLine("PauseRecording...");
            btnRecord.BackColor = SystemColors.Control;
            btnRecord.Text = "PAUSE";
            recording = false;

            lock(lockWrite) {
                writer?.Flush();
                writer?.Dispose();
                writer = null;
            }
            edStartNumber.Value++;
            Debug.WriteLine("PauseRecording... ok");
        }

        void DataAvailable(object? sender, WaveInEventArgs args) {
            var peakValue = PeakCalcHelper.GetPeak(waveIn!.WaveFormat.BitsPerSample, args.Buffer);
            ShowSignalLevel(peakValue);

            lock(lockWrite) {
                if(writer != null) {
                    writer.Write(args.Buffer, 0, args.BytesRecorded);

                    if(DetectSilence(peakValue)) {
                        if(writer.Position > waveIn!.WaveFormat.AverageBytesPerSecond * minVoiceDuration) {
                            BeginInvoke(() => {
                                PauseRecording();
                            });
                        }
                    }
                }
            }
        }

        void RecordingStopped(object? sender, StoppedEventArgs args) {
            Debug.WriteLine("RecordingStopped...");
            PauseRecording();
            Debug.WriteLine("RecordingStopped... ok");
        }

        bool DetectSilence(float peakValue) {
            if(peakValue >= silenceThreshold) {
                timerSilence = DateTime.Now;

                Debug.WriteLine($"DetectSilence peak: {peakValue}");
                return false;
            }
            if(DateTime.Now - timerSilence < TimeSpan.FromMilliseconds(minSilenceDuration)) {
                return false;
            }

            Debug.WriteLine($"DetectSilence detected: {peakValue}");
            return true;
        }

        void ShowSignalLevel(float peakValue) {
            if(DateTime.Now - timerSignalLevel < TimeSpan.FromMilliseconds(200)) {
                avgSignalLevel += peakValue;
                cntSignalLevel++;
                return;
            }

            BeginInvoke(() => {
                pbSignalLevel.Value = cntSignalLevel > 0
                    ? (int)(pbSignalLevel.Maximum * (avgSignalLevel / cntSignalLevel))
                    : 0;
                timerSignalLevel = DateTime.Now;
                //Debug.WriteLine($"ShowSignalLevel: {cntSignalLevel}");
                avgSignalLevel = 0;
                cntSignalLevel = 0;
            });
        }

        private void edMinSilenceDuration_ValueChanged(object sender, EventArgs e) {
            minSilenceDuration = (int)edMinSilenceDuration.Value;
        }

        private void edSilenceThreshold_Scroll(object sender, EventArgs e) {
            silenceThreshold = edSilenceThreshold.Value / 100f;
        }

        private void edMinVoiceDuration_ValueChanged(object sender, EventArgs e) {
            minVoiceDuration = (int)edMinVoiceDuration.Value;
        }

        private void edSampleRate_SelectedIndexChanged(object sender, EventArgs e) {
            if(waveIn == null) {
                return;
            }
            if(waveIn.WaveFormat.SampleRate != SampleRate
                || waveIn.WaveFormat.BitsPerSample != BitsPerSample) {
                CloseAudio();
                OpenAudio();
            }
        }
    }
}
