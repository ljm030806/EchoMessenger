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
            label1 = new Label();
            txtMessege = new TextBox();
            lstMessege = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(52, 38);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // txtMessege
            // 
            txtMessege.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtMessege.Location = new Point(52, 353);
            txtMessege.Name = "txtMessege";
            txtMessege.Size = new Size(556, 29);
            txtMessege.TabIndex = 1;
            txtMessege.TextChanged += txtMessege_TextChanged;
            txtMessege.PreviewKeyDown += txtMessege_PreviewKeyDown;
            // 
            // lstMessege
            // 
            lstMessege.FormattingEnabled = true;
            lstMessege.Location = new Point(52, 93);
            lstMessege.Name = "lstMessege";
            lstMessege.Size = new Size(658, 229);
            lstMessege.TabIndex = 2;
            lstMessege.SelectedIndexChanged += lstMessege_SelectedIndexChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.White;
            btnSend.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.ForeColor = Color.Red;
            btnSend.Location = new Point(625, 338);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(87, 54);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.MouseDown += btnSend_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 475);
            Controls.Add(btnSend);
            Controls.Add(lstMessege);
            Controls.Add(txtMessege);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMessege;
        private ListBox lstMessege;
        private Button btnSend;
    }
}
