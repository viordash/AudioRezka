namespace AudioRezkaApp {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnRecord = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnSelectWorkFolder = new Button();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            edWorkFolder = new TextBox();
            edPrefix = new TextBox();
            edStartNumber = new NumericUpDown();
            edMinVoiceDuration = new NumericUpDown();
            edMinSilenceDuration = new NumericUpDown();
            edSilenceThreshold = new TrackBar();
            panel1 = new Panel();
            pbSignalLevel = new ProgressBar();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)edStartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edMinVoiceDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edMinSilenceDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edSilenceThreshold).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRecord
            // 
            btnRecord.BackColor = SystemColors.Control;
            btnRecord.Location = new Point(3, 101);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(340, 46);
            btnRecord.TabIndex = 0;
            btnRecord.Text = "PAUSE";
            btnRecord.UseCompatibleTextRendering = true;
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnSelectWorkFolder
            // 
            btnSelectWorkFolder.Location = new Point(323, 36);
            btnSelectWorkFolder.Name = "btnSelectWorkFolder";
            btnSelectWorkFolder.Size = new Size(27, 23);
            btnSelectWorkFolder.TabIndex = 2;
            btnSelectWorkFolder.Text = "...";
            toolTip1.SetToolTip(btnSelectWorkFolder, "Select work folder");
            btnSelectWorkFolder.UseVisualStyleBackColor = true;
            btnSelectWorkFolder.Click += btnSelectWorkFolder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 3);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 15;
            label4.Text = "Silence threshold:";
            toolTip1.SetToolTip(label4, "Minimum duration of audio data, sec");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 76);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 4;
            label1.Text = "Prefix of file names:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 131);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 7;
            label2.Text = "Numbered file name suffix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 187);
            label3.Name = "label3";
            label3.Size = new Size(207, 15);
            label3.TabIndex = 10;
            label3.Text = "Minimum duration of audio data, sec:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 245);
            label5.Name = "label5";
            label5.Size = new Size(198, 15);
            label5.TabIndex = 13;
            label5.Text = "Minimum duration of silence, msec:";
            // 
            // edWorkFolder
            // 
            edWorkFolder.Location = new Point(23, 36);
            edWorkFolder.Name = "edWorkFolder";
            edWorkFolder.ReadOnly = true;
            edWorkFolder.Size = new Size(298, 23);
            edWorkFolder.TabIndex = 3;
            // 
            // edPrefix
            // 
            edPrefix.Location = new Point(23, 94);
            edPrefix.Name = "edPrefix";
            edPrefix.Size = new Size(327, 23);
            edPrefix.TabIndex = 5;
            // 
            // edStartNumber
            // 
            edStartNumber.Location = new Point(23, 149);
            edStartNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edStartNumber.Name = "edStartNumber";
            edStartNumber.Size = new Size(97, 23);
            edStartNumber.TabIndex = 8;
            // 
            // edMinVoiceDuration
            // 
            edMinVoiceDuration.Location = new Point(23, 205);
            edMinVoiceDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edMinVoiceDuration.Name = "edMinVoiceDuration";
            edMinVoiceDuration.Size = new Size(97, 23);
            edMinVoiceDuration.TabIndex = 11;
            edMinVoiceDuration.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // edMinSilenceDuration
            // 
            edMinSilenceDuration.Location = new Point(23, 263);
            edMinSilenceDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edMinSilenceDuration.Name = "edMinSilenceDuration";
            edMinSilenceDuration.Size = new Size(97, 23);
            edMinSilenceDuration.TabIndex = 14;
            edMinSilenceDuration.Value = new decimal(new int[] { 700, 0, 0, 0 });
            // 
            // edSilenceThreshold
            // 
            edSilenceThreshold.Location = new Point(3, 25);
            edSilenceThreshold.Name = "edSilenceThreshold";
            edSilenceThreshold.Size = new Size(330, 45);
            edSilenceThreshold.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pbSignalLevel);
            panel1.Controls.Add(edSilenceThreshold);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRecord);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(5, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 152);
            panel1.TabIndex = 18;
            // 
            // pbSignalLevel
            // 
            pbSignalLevel.Location = new Point(11, 60);
            pbSignalLevel.Name = "pbSignalLevel";
            pbSignalLevel.Size = new Size(313, 8);
            pbSignalLevel.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 18);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 19;
            label6.Text = "Folder with working files:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 457);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(edMinSilenceDuration);
            Controls.Add(label5);
            Controls.Add(edMinVoiceDuration);
            Controls.Add(label3);
            Controls.Add(edStartNumber);
            Controls.Add(label2);
            Controls.Add(edPrefix);
            Controls.Add(label1);
            Controls.Add(edWorkFolder);
            Controls.Add(btnSelectWorkFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(300, 320);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AudioRezka";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)edStartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)edMinVoiceDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)edMinSilenceDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)edSilenceThreshold).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRecord;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnSelectWorkFolder;
        private ToolTip toolTip1;
        private TextBox edWorkFolder;
        private Label label1;
        private TextBox edPrefix;
        private Label label2;
        private NumericUpDown edStartNumber;
        private Label label3;
        private NumericUpDown edMinVoiceDuration;
        private NumericUpDown edMinSilenceDuration;
        private Label label5;
        private Label label4;
        private TrackBar edSilenceThreshold;
        private Panel panel1;
        private Label label6;
        private ProgressBar pbSignalLevel;
    }
}
