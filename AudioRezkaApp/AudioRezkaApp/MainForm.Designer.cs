﻿namespace AudioRezkaApp {
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
            edFilenamePrefix = new TextBox();
            edStartNumber = new NumericUpDown();
            edMinVoiceDuration = new NumericUpDown();
            edMinSilenceDuration = new NumericUpDown();
            edSilenceThreshold = new TrackBar();
            panel1 = new Panel();
            pbSignalLevel = new ProgressBar();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            edSampleRate = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            edBitsPerSample = new ComboBox();
            edWaveInDevice = new ComboBox();
            label11 = new Label();
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
            btnRecord.Location = new Point(3, 83);
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
            label1.Location = new Point(10, 74);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 4;
            label1.Text = "Prefix of file names:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 75);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 7;
            label2.Text = "Numbered file name suffix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 242);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 10;
            label3.Text = "Min duration of audio data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 242);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 13;
            label5.Text = "Min duration of silence:";
            // 
            // edWorkFolder
            // 
            edWorkFolder.Location = new Point(23, 36);
            edWorkFolder.Name = "edWorkFolder";
            edWorkFolder.ReadOnly = true;
            edWorkFolder.Size = new Size(298, 23);
            edWorkFolder.TabIndex = 3;
            // 
            // edFilenamePrefix
            // 
            edFilenamePrefix.Location = new Point(23, 92);
            edFilenamePrefix.Name = "edFilenamePrefix";
            edFilenamePrefix.Size = new Size(138, 23);
            edFilenamePrefix.TabIndex = 5;
            // 
            // edStartNumber
            // 
            edStartNumber.Location = new Point(196, 93);
            edStartNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edStartNumber.Name = "edStartNumber";
            edStartNumber.Size = new Size(85, 23);
            edStartNumber.TabIndex = 8;
            // 
            // edMinVoiceDuration
            // 
            edMinVoiceDuration.Location = new Point(23, 260);
            edMinVoiceDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edMinVoiceDuration.Name = "edMinVoiceDuration";
            edMinVoiceDuration.Size = new Size(85, 23);
            edMinVoiceDuration.TabIndex = 11;
            edMinVoiceDuration.Value = new decimal(new int[] { 3, 0, 0, 0 });
            edMinVoiceDuration.ValueChanged += edMinVoiceDuration_ValueChanged;
            // 
            // edMinSilenceDuration
            // 
            edMinSilenceDuration.Location = new Point(196, 260);
            edMinSilenceDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edMinSilenceDuration.Name = "edMinSilenceDuration";
            edMinSilenceDuration.Size = new Size(85, 23);
            edMinSilenceDuration.TabIndex = 14;
            edMinSilenceDuration.Value = new decimal(new int[] { 700, 0, 0, 0 });
            edMinSilenceDuration.ValueChanged += edMinSilenceDuration_ValueChanged;
            // 
            // edSilenceThreshold
            // 
            edSilenceThreshold.Location = new Point(3, 25);
            edSilenceThreshold.Maximum = 100;
            edSilenceThreshold.Name = "edSilenceThreshold";
            edSilenceThreshold.Size = new Size(340, 45);
            edSilenceThreshold.TabIndex = 16;
            edSilenceThreshold.TickFrequency = 10;
            edSilenceThreshold.Scroll += edSilenceThreshold_Scroll;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pbSignalLevel);
            panel1.Controls.Add(edSilenceThreshold);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRecord);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(5, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 135);
            panel1.TabIndex = 18;
            // 
            // pbSignalLevel
            // 
            pbSignalLevel.Location = new Point(11, 60);
            pbSignalLevel.Name = "pbSignalLevel";
            pbSignalLevel.Size = new Size(323, 8);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 264);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 20;
            label7.Text = "secs";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 264);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 21;
            label8.Text = "msecs";
            // 
            // edSampleRate
            // 
            edSampleRate.DropDownStyle = ComboBoxStyle.DropDownList;
            edSampleRate.FormattingEnabled = true;
            edSampleRate.Items.AddRange(new object[] { "8000", "16000", "22050", "32000", "44100", "48000" });
            edSampleRate.Location = new Point(23, 204);
            edSampleRate.Name = "edSampleRate";
            edSampleRate.Size = new Size(85, 23);
            edSampleRate.TabIndex = 22;
            edSampleRate.SelectedIndexChanged += edSampleRate_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 186);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 23;
            label9.Text = "Sample rate:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(182, 186);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 25;
            label10.Text = "Bits per sample:";
            // 
            // edBitsPerSample
            // 
            edBitsPerSample.DropDownStyle = ComboBoxStyle.DropDownList;
            edBitsPerSample.FormattingEnabled = true;
            edBitsPerSample.Items.AddRange(new object[] { "8", "16", "24", "32" });
            edBitsPerSample.Location = new Point(196, 204);
            edBitsPerSample.Name = "edBitsPerSample";
            edBitsPerSample.Size = new Size(85, 23);
            edBitsPerSample.TabIndex = 24;
            edBitsPerSample.SelectedIndexChanged += edSampleRate_SelectedIndexChanged;
            // 
            // edWaveInDevice
            // 
            edWaveInDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            edWaveInDevice.FormattingEnabled = true;
            edWaveInDevice.Location = new Point(23, 149);
            edWaveInDevice.Name = "edWaveInDevice";
            edWaveInDevice.Size = new Size(327, 23);
            edWaveInDevice.TabIndex = 26;
            edWaveInDevice.SelectedIndexChanged += edSampleRate_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 131);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 27;
            label11.Text = "Input device:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 439);
            Controls.Add(label11);
            Controls.Add(edWaveInDevice);
            Controls.Add(label10);
            Controls.Add(edBitsPerSample);
            Controls.Add(label9);
            Controls.Add(edSampleRate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(edMinSilenceDuration);
            Controls.Add(label5);
            Controls.Add(edMinVoiceDuration);
            Controls.Add(label3);
            Controls.Add(edStartNumber);
            Controls.Add(label2);
            Controls.Add(edFilenamePrefix);
            Controls.Add(label1);
            Controls.Add(edWorkFolder);
            Controls.Add(btnSelectWorkFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private TextBox edFilenamePrefix;
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
        private Label label7;
        private Label label8;
        private ComboBox edSampleRate;
        private Label label9;
        private Label label10;
        private ComboBox edBitsPerSample;
        private ComboBox edWaveInDevice;
        private Label label11;
    }
}
