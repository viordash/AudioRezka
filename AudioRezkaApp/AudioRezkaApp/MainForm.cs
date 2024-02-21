using System.Diagnostics;
using AudioRezkaApp.Helpers;
using NAudio.Wave;

namespace AudioRezkaApp {
    public partial class MainForm : Form {
        bool recording;

        WaveInEvent? waveIn = null;
        WaveFileWriter? writer = null;
        object lockWrite = new();

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
            Settings.Default.SilenceThreshold = (int)edSilenceThreshold.Value;
            Settings.Default.Save();
        }

        private void btnRecord_Click(object sender, EventArgs e) {
            recording = !recording;

            if(recording) {
                btnRecord.BackColor = Color.FromArgb(255, 128, 128);
                btnRecord.Text = "RECORD";
                StartRecording();
            } else {
                btnRecord.BackColor = SystemColors.Control;
                btnRecord.Text = "PAUSE";
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
            waveIn.WaveFormat = new WaveFormat(44100, 16, 2);
            waveIn.DataAvailable += DataAvailable;
            waveIn?.StartRecording();
            Debug.WriteLine("OpenAudio... ok");
        }

        void CloseAudio() {
            Debug.WriteLine("CloseAudio...");
            if(waveIn == null) {
                return;
            }
            waveIn.StopRecording();
            waveIn.DataAvailable -= DataAvailable;
            waveIn.Dispose();
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
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            }
            Debug.WriteLine("StartRecording... ok");
        }

        void PauseRecording() {
            Debug.WriteLine("PauseRecording...");
            lock(lockWrite) {
                writer?.Flush();
                writer?.Dispose();
                writer = null;
            }
            edStartNumber.Value++;
            Debug.WriteLine("PauseRecording... ok");
        }

        void DataAvailable(object? sender, WaveInEventArgs args) {
            var peakValue = GetPeakValue(args.Buffer);

            ShowSignalLevel(peakValue);
            lock(lockWrite) {
                if(writer != null) {
                    writer.Write(args.Buffer, 0, args.BytesRecorded);

                    //if(writer.Position > waveIn.WaveFormat.AverageBytesPerSecond * 30) {
                    //    waveIn.StopRecording();
                    //}
                }
            }
        }

        float GetPeakValue(ReadOnlySpan<byte> pcm) {
            float max = 0;
            // interpret as 16 bit audio
            for(var index = 0; index < pcm.Length; index += 2) {
                short sample = (short)((pcm[index + 1] << 8) |
                                        pcm[index + 0]);

                var sample32 = sample / 32768f;
                if(sample32 < 0) sample32 = -sample32;
                if(sample32 > max) max = sample32;
            }
            return max;
        }

        DateTime updateSignalLevel = DateTime.Now;
        void ShowSignalLevel(float peakValue) {
            if(DateTime.Now - updateSignalLevel < TimeSpan.FromMilliseconds(200)) {
                return;
            }
            BeginInvoke(() => {
                pbSignalLevel.Value = (int)(pbSignalLevel.Maximum * peakValue);
                updateSignalLevel = DateTime.Now;

                Debug.WriteLine($"ShowSignalLevel: {updateSignalLevel.Millisecond}");
            });
        }
    }
}
