namespace CodeGeneration
{
    partial class StartForm
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
            txtInput = new TextBox();
            btnGo = new Button();
            txtInheritance = new TextBox();
            txtPrefix = new TextBox();
            lblPrefix = new Label();
            lblInheritance = new Label();
            txtTemplate = new TextBox();
            ddlTemplate = new ComboBox();
            btnUpdateTemplate = new Button();
            btnAskAi = new Button();
            btnCopyFiles = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(28, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(889, 289);
            txtInput.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGo.Location = new Point(823, 654);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtInheritance
            // 
            txtInheritance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInheritance.Location = new Point(445, 329);
            txtInheritance.Name = "txtInheritance";
            txtInheritance.Size = new Size(342, 23);
            txtInheritance.TabIndex = 2;
            // 
            // txtPrefix
            // 
            txtPrefix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPrefix.Location = new Point(225, 329);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(123, 23);
            txtPrefix.TabIndex = 3;
            // 
            // lblPrefix
            // 
            lblPrefix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrefix.AutoSize = true;
            lblPrefix.Location = new Point(175, 332);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(40, 15);
            lblPrefix.TabIndex = 4;
            lblPrefix.Text = "Prefix:";
            // 
            // lblInheritance
            // 
            lblInheritance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInheritance.AutoSize = true;
            lblInheritance.Location = new Point(370, 332);
            lblInheritance.Name = "lblInheritance";
            lblInheritance.Size = new Size(69, 15);
            lblInheritance.TabIndex = 5;
            lblInheritance.Text = "Inheritance:";
            // 
            // txtTemplate
            // 
            txtTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTemplate.Location = new Point(28, 371);
            txtTemplate.Multiline = true;
            txtTemplate.Name = "txtTemplate";
            txtTemplate.Size = new Size(889, 221);
            txtTemplate.TabIndex = 6;
            // 
            // ddlTemplate
            // 
            ddlTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ddlTemplate.FormattingEnabled = true;
            ddlTemplate.Location = new Point(28, 329);
            ddlTemplate.Name = "ddlTemplate";
            ddlTemplate.Size = new Size(121, 23);
            ddlTemplate.TabIndex = 7;
            // 
            // btnUpdateTemplate
            // 
            btnUpdateTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateTemplate.Location = new Point(806, 328);
            btnUpdateTemplate.Name = "btnUpdateTemplate";
            btnUpdateTemplate.Size = new Size(111, 23);
            btnUpdateTemplate.TabIndex = 8;
            btnUpdateTemplate.Text = "Update Template";
            btnUpdateTemplate.UseVisualStyleBackColor = true;
            btnUpdateTemplate.Click += btnUpdateTemplate_Click;
            // 
            // btnAskAi
            // 
            btnAskAi.Location = new Point(28, 654);
            btnAskAi.Name = "btnAskAi";
            btnAskAi.Size = new Size(75, 23);
            btnAskAi.TabIndex = 9;
            btnAskAi.Text = "Ask Ai";
            btnAskAi.UseVisualStyleBackColor = true;
            btnAskAi.Click += btnAskAi_Click;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.Location = new Point(109, 654);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new Size(75, 23);
            btnCopyFiles.TabIndex = 10;
            btnCopyFiles.Text = "Copy Files";
            btnCopyFiles.UseVisualStyleBackColor = true;
            btnCopyFiles.Click += btnCopyFiles_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 702);
            Controls.Add(btnCopyFiles);
            Controls.Add(btnAskAi);
            Controls.Add(btnUpdateTemplate);
            Controls.Add(ddlTemplate);
            Controls.Add(txtTemplate);
            Controls.Add(lblInheritance);
            Controls.Add(lblPrefix);
            Controls.Add(txtPrefix);
            Controls.Add(txtInheritance);
            Controls.Add(btnGo);
            Controls.Add(txtInput);
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnGo;
        private TextBox txtInheritance;
        private TextBox txtPrefix;
        private Label lblPrefix;
        private Label lblInheritance;
        private TextBox txtTemplate;
        private ComboBox ddlTemplate;
        private Button btnUpdateTemplate;
        private Button btnAskAi;
        private Button btnCopyFiles;
    }
}