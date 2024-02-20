using AudioRezkaApp.Helpers;

namespace AudioRezkaApp {
    public partial class MainForm : Form {
        bool recording;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            FormsHelper.LoadLocation(Settings.Default.MainFormLocation, this);
            FormsHelper.LoadSize(Settings.Default.MainFormSize, this);
            edWorkFolder.Text = Settings.Default.WorkFolder;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.Default.MainFormLocation = Location;
            Settings.Default.MainFormSize = Size;
            Settings.Default.WorkFolder = edWorkFolder.Text;
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
