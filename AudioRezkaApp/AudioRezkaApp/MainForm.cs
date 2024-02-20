using AudioRezkaApp.Helpers;

namespace AudioRezkaApp {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            FormsHelper.LoadLocation(Settings.Default.MainFormLocation, this);
            FormsHelper.LoadSize(Settings.Default.MainFormSize, this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.Default.MainFormLocation = Location;
            Settings.Default.MainFormSize = Size;
            Settings.Default.Save();
        }
    }
}
