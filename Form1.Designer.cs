namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtMessege = new TextBox();
            lstMessege = new ListBox();
            btnSend = new Button();
            lblCount = new Label();
            btnDelete = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Blue;
            lblName.Location = new Point(52, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(337, 48);
            lblName.TabIndex = 0;
            lblName.Text = "Echo Messenger";
            // 
            // txtMessege
            // 
            txtMessege.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtMessege.Location = new Point(52, 368);
            txtMessege.Name = "txtMessege";
            txtMessege.Size = new Size(526, 29);
            txtMessege.TabIndex = 1;
            txtMessege.TextChanged += txtMessege_TextChanged;
            txtMessege.PreviewKeyDown += txtMessege_PreviewKeyDown;
            // 
            // lstMessege
            // 
            lstMessege.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstMessege.FormattingEnabled = true;
            lstMessege.Location = new Point(52, 93);
            lstMessege.Name = "lstMessege";
            lstMessege.Size = new Size(658, 229);
            lstMessege.TabIndex = 2;
            lstMessege.SelectedIndexChanged += lstMessege_SelectedIndexChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(128, 255, 128);
            btnSend.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(593, 348);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(117, 64);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(52, 334);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(716, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 64);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(128, 128, 255);
            btnClearAll.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClearAll.Location = new Point(593, 418);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(227, 45);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "대화 기록 삭제\r\n";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(842, 475);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(lstMessege);
            Controls.Add(txtMessege);
            Controls.Add(lblName);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtMessege;
        private ListBox lstMessege;
        private Button btnSend;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClearAll;
    }
}
