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
            btnRecord = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnSelectWorkFolder = new Button();
            toolTip1 = new ToolTip(components);
            edWorkFolder = new TextBox();
            label1 = new Label();
            edPrefix = new TextBox();
            label2 = new Label();
            edStartNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)edStartNumber).BeginInit();
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
            btnSelectWorkFolder.Location = new Point(12, 12);
            btnSelectWorkFolder.Name = "btnSelectWorkFolder";
            btnSelectWorkFolder.Size = new Size(82, 23);
            btnSelectWorkFolder.TabIndex = 2;
            btnSelectWorkFolder.Text = "Work folder";
            toolTip1.SetToolTip(btnSelectWorkFolder, "Select work folder");
            btnSelectWorkFolder.UseVisualStyleBackColor = true;
            btnSelectWorkFolder.Click += btnSelectWorkFolder_Click;
            // 
            // edWorkFolder
            // 
            edWorkFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edWorkFolder.Location = new Point(100, 12);
            edWorkFolder.Name = "edWorkFolder";
            edWorkFolder.ReadOnly = true;
            edWorkFolder.Size = new Size(399, 23);
            edWorkFolder.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Prefix:";
            toolTip1.SetToolTip(label1, "Prefix of file names");
            // 
            // edPrefix
            // 
            edPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edPrefix.Location = new Point(100, 48);
            edPrefix.Name = "edPrefix";
            edPrefix.Size = new Size(399, 23);
            edPrefix.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "Start number:";
            toolTip1.SetToolTip(label2, "Prefix of file names");
            // 
            // edStartNumber
            // 
            edStartNumber.Location = new Point(100, 90);
            edStartNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            edStartNumber.Name = "edStartNumber";
            edStartNumber.Size = new Size(120, 23);
            edStartNumber.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 294);
            Controls.Add(edStartNumber);
            Controls.Add(label2);
            Controls.Add(edPrefix);
            Controls.Add(label1);
            Controls.Add(edWorkFolder);
            Controls.Add(btnSelectWorkFolder);
            Controls.Add(btnRecord);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(0, 320);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AudioRezka";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)edStartNumber).EndInit();
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
    }
}
