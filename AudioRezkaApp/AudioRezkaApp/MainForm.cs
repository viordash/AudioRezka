using AudioRezkaApp.Helpers;

namespace AudioRezkaApp {
    public partial class MainForm : Form {
        bool recording;

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
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
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
            } else {
                btnRecord.BackColor = SystemColors.Control;
                btnRecord.Text = "PAUSE";
            }
        }

        private void btnSelectWorkFolder_Click(object sender, EventArgs e) {
            if(folderBrowserDialog1.ShowDialog() != DialogResult.OK) {
                return;
            }
            edWorkFolder.Text = folderBrowserDialog1.SelectedPath;
        }

    }
}
