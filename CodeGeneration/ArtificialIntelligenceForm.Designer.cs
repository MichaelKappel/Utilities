namespace CodeGeneration
{
    partial class ArtificialIntelligenceForm
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
            txtQuestion = new TextBox();
            btnGo = new Button();
            txtAnswer = new TextBox();
            txtChatGptKey = new TextBox();
            lblChatGptKey = new Label();
            tvResponse = new TreeView();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.Location = new Point(4, 51);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(650, 322);
            txtQuestion.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGo.Location = new Point(896, 645);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Location = new Point(4, 429);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(650, 210);
            txtAnswer.TabIndex = 2;
            // 
            // txtChatGptKey
            // 
            txtChatGptKey.Location = new Point(125, 16);
            txtChatGptKey.Name = "txtChatGptKey";
            txtChatGptKey.Size = new Size(111, 23);
            txtChatGptKey.TabIndex = 3;
            // 
            // lblChatGptKey
            // 
            lblChatGptKey.AutoSize = true;
            lblChatGptKey.Location = new Point(23, 19);
            lblChatGptKey.Name = "lblChatGptKey";
            lblChatGptKey.Size = new Size(96, 15);
            lblChatGptKey.TabIndex = 4;
            lblChatGptKey.Text = "ChatGPT API Key";
            // 
            // tvResponse
            // 
            tvResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tvResponse.Location = new Point(670, 51);
            tvResponse.Name = "tvResponse";
            tvResponse.Size = new Size(291, 588);
            tvResponse.TabIndex = 5;
            // 
            // ArtificialIntelligenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 669);
            Controls.Add(tvResponse);
            Controls.Add(lblChatGptKey);
            Controls.Add(txtChatGptKey);
            Controls.Add(txtAnswer);
            Controls.Add(btnGo);
            Controls.Add(txtQuestion);
            Name = "ArtificialIntelligenceForm";
            Text = "ArtificialIntelligenceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private Button btnGo;
        private TextBox txtAnswer;
        private TextBox txtChatGptKey;
        private Label lblChatGptKey;
        private TreeView tvResponse;
    }
}