namespace CodeGeneration
{
    partial class CopyFilesWithChangesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fbdFolder = new FolderBrowserDialog();
            ofdOpen = new OpenFileDialog();
            txtFileContent = new TextBox();
            txtSourceFolder = new TextBox();
            txtSelectedFile = new TextBox();
            btnSelectFolder = new Button();
            btnSelectFile = new Button();
            btnGo = new Button();
            btnDestinationFolder = new Button();
            txtDestinationFolder = new TextBox();
            txtFileContentTestResult = new TextBox();
            txtFrom1 = new TextBox();
            lbl1 = new Label();
            txtTo1 = new TextBox();
            txtTo2 = new TextBox();
            lbl2 = new Label();
            txtFrom2 = new TextBox();
            txtTo3 = new TextBox();
            lbl3 = new Label();
            txtFrom3 = new TextBox();
            btnTest = new Button();
            SuspendLayout();
            // 
            // txtFileContent
            // 
            txtFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFileContent.Location = new Point(12, 81);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(782, 175);
            txtFileContent.TabIndex = 1;
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSourceFolder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSourceFolder.Location = new Point(61, 8);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.Size = new Size(733, 29);
            txtSourceFolder.TabIndex = 2;
            txtSourceFolder.Text = "No Source Folder Selected";
            // 
            // txtSelectedFile
            // 
            txtSelectedFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSelectedFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSelectedFile.Location = new Point(61, 46);
            txtSelectedFile.Name = "txtSelectedFile";
            txtSelectedFile.Size = new Size(733, 29);
            txtSelectedFile.TabIndex = 3;
            txtSelectedFile.Text = "No Template File Selected";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(12, 12);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(43, 23);
            btnSelectFolder.TabIndex = 4;
            btnSelectFolder.Text = "Edit";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 50);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(43, 23);
            btnSelectFile.TabIndex = 5;
            btnSelectFile.Text = "Edit";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGo.Location = new Point(719, 562);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 6;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDestinationFolder.Location = new Point(12, 526);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(43, 23);
            btnDestinationFolder.TabIndex = 8;
            btnDestinationFolder.Text = "Edit";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDestinationFolder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDestinationFolder.Location = new Point(61, 522);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.Size = new Size(733, 29);
            txtDestinationFolder.TabIndex = 7;
            txtDestinationFolder.Text = "No Destination Folder Selected";
            // 
            // txtFileContentTestResult
            // 
            txtFileContentTestResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFileContentTestResult.Location = new Point(12, 350);
            txtFileContentTestResult.Multiline = true;
            txtFileContentTestResult.Name = "txtFileContentTestResult";
            txtFileContentTestResult.Size = new Size(782, 154);
            txtFileContentTestResult.TabIndex = 9;
            // 
            // txtFrom1
            // 
            txtFrom1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFrom1.Location = new Point(12, 262);
            txtFrom1.Name = "txtFrom1";
            txtFrom1.Size = new Size(319, 23);
            txtFrom1.TabIndex = 10;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl1.AutoSize = true;
            lbl1.Location = new Point(337, 265);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(20, 15);
            lbl1.TabIndex = 11;
            lbl1.Text = "->";
            // 
            // txtTo1
            // 
            txtTo1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTo1.Location = new Point(363, 262);
            txtTo1.Name = "txtTo1";
            txtTo1.Size = new Size(307, 23);
            txtTo1.TabIndex = 12;
            // 
            // txtTo2
            // 
            txtTo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTo2.Location = new Point(363, 291);
            txtTo2.Name = "txtTo2";
            txtTo2.Size = new Size(307, 23);
            txtTo2.TabIndex = 15;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl2.AutoSize = true;
            lbl2.Location = new Point(337, 294);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(20, 15);
            lbl2.TabIndex = 14;
            lbl2.Text = "->";
            // 
            // txtFrom2
            // 
            txtFrom2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFrom2.Location = new Point(12, 291);
            txtFrom2.Name = "txtFrom2";
            txtFrom2.Size = new Size(319, 23);
            txtFrom2.TabIndex = 13;
            // 
            // txtTo3
            // 
            txtTo3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTo3.Location = new Point(363, 320);
            txtTo3.Name = "txtTo3";
            txtTo3.Size = new Size(307, 23);
            txtTo3.TabIndex = 18;
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl3.AutoSize = true;
            lbl3.Location = new Point(337, 323);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(20, 15);
            lbl3.TabIndex = 17;
            lbl3.Text = "->";
            // 
            // txtFrom3
            // 
            txtFrom3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFrom3.Location = new Point(12, 320);
            txtFrom3.Name = "txtFrom3";
            txtFrom3.Size = new Size(319, 23);
            txtFrom3.TabIndex = 16;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTest.Location = new Point(719, 315);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 19;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // CopyFilesWithChangesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 597);
            Controls.Add(btnTest);
            Controls.Add(txtTo3);
            Controls.Add(lbl3);
            Controls.Add(txtFrom3);
            Controls.Add(txtTo2);
            Controls.Add(lbl2);
            Controls.Add(txtFrom2);
            Controls.Add(txtTo1);
            Controls.Add(lbl1);
            Controls.Add(txtFrom1);
            Controls.Add(txtFileContentTestResult);
            Controls.Add(btnDestinationFolder);
            Controls.Add(txtDestinationFolder);
            Controls.Add(btnGo);
            Controls.Add(btnSelectFile);
            Controls.Add(btnSelectFolder);
            Controls.Add(txtSelectedFile);
            Controls.Add(txtSourceFolder);
            Controls.Add(txtFileContent);
            Name = "CopyFilesWithChangesForm";
            Text = "CopyFilesWithChangesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private FolderBrowserDialog fbdFolder;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem folderToolStripMenuItem;
        private OpenFileDialog openFileDialog2;
        private TextBox txtFileContent;
        private OpenFileDialog ofdOpen;
        private TextBox txtSelectedFile;
        private Button btnSelectFolder;
        private Button btnSelectFile;
        private Button btnGo;
        private TextBox txtSourceFolder;
        private Button btnDestinationFolder;
        private TextBox txtDestinationFolder;
        private TextBox txtFileContentTestResult;
        private TextBox txtFrom1;
        private Label lbl1;
        private TextBox txtTo1;
        private TextBox txtTo2;
        private Label lbl2;
        private TextBox txtFrom2;
        private TextBox txtTo3;
        private Label lbl3;
        private TextBox txtFrom3;
        private Button btnTest;
    }
}