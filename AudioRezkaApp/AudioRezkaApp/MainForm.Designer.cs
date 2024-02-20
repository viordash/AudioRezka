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
            label1 = new Label();
            label2 = new Label();
            edWorkFolder = new TextBox();
            edPrefix = new TextBox();
            edStartNumber = new NumericUpDown();
            trackBar1 = new TrackBar();
            label3 = new Label();
            edMinDuration = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)edStartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edMinDuration).BeginInit();
            SuspendLayout();
            // 
            // btnRecord
            // 
            btnRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRecord.BackColor = SystemColors.Control;
            btnRecord.Location = new Point(12, 236);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(487, 46);
            btnRecord.TabIndex = 0;
            btnRecord.Text = "PAUSE";
            btnRecord.UseCompatibleTextRendering = true;
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnSelectWorkFolder
            // 
            btnSelectWorkFolder.Location = new Point(20, 12);
            btnSelectWorkFolder.Name = "btnSelectWorkFolder";
            btnSelectWorkFolder.Size = new Size(82, 23);
            btnSelectWorkFolder.TabIndex = 2;
            btnSelectWorkFolder.Text = "Work folder";
            toolTip1.SetToolTip(btnSelectWorkFolder, "Select work folder");
            btnSelectWorkFolder.UseVisualStyleBackColor = true;
            btnSelectWorkFolder.Click += btnSelectWorkFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Prefix:";
            toolTip1.SetToolTip(label1, "Prefix of file names");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "Start number:";
            toolTip1.SetToolTip(label2, "Numbered file name suffix");
            // 
            // edWorkFolder
            // 
            edWorkFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edWorkFolder.Location = new Point(109, 12);
            edWorkFolder.Name = "edWorkFolder";
            edWorkFolder.ReadOnly = true;
            edWorkFolder.Size = new Size(390, 23);
            edWorkFolder.TabIndex = 3;
            // 
            // edPrefix
            // 
            edPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edPrefix.Location = new Point(109, 48);
            edPrefix.Name = "edPrefix";
            edPrefix.Size = new Size(390, 23);
            edPrefix.TabIndex = 5;
            // 
            // edStartNumber
            // 
            edStartNumber.Location = new Point(109, 90);
            edStartNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edStartNumber.Name = "edStartNumber";
            edStartNumber.Size = new Size(120, 23);
            edStartNumber.TabIndex = 8;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(109, 175);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(233, 45);
            trackBar1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "Min duration, s:";
            toolTip1.SetToolTip(label3, "Minimum duration of audio data, sec");
            // 
            // edMinDuration
            // 
            edMinDuration.Location = new Point(109, 131);
            edMinDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edMinDuration.Name = "edMinDuration";
            edMinDuration.Size = new Size(120, 23);
            edMinDuration.TabIndex = 11;
            edMinDuration.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Threshold:";
            toolTip1.SetToolTip(label4, "Threshold of silence");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 294);
            Controls.Add(label4);
            Controls.Add(edMinDuration);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(edStartNumber);
            Controls.Add(label2);
            Controls.Add(edPrefix);
            Controls.Add(label1);
            Controls.Add(edWorkFolder);
            Controls.Add(btnSelectWorkFolder);
            Controls.Add(btnRecord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(0, 320);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AudioRezka";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)edStartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)edMinDuration).EndInit();
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
        private TrackBar trackBar1;
        private Label label3;
        private NumericUpDown edMinDuration;
        private Label label4;
    }
}
