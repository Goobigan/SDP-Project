namespace TaxiSys
{
    partial class frmAccountsOpen
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
            accountUsernameLbl = new Label();
            accountPasswordLbl = new Label();
            accountEmailLbl = new Label();
            accountPhoneLbl = new Label();
            accountDetailsGroupBox = new GroupBox();
            accountCreateBtn = new Button();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            backBtn = new Button();
            accountDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // accountUsernameLbl
            // 
            accountUsernameLbl.AutoSize = true;
            accountUsernameLbl.Location = new Point(127, 42);
            accountUsernameLbl.Name = "accountUsernameLbl";
            accountUsernameLbl.Size = new Size(60, 15);
            accountUsernameLbl.TabIndex = 1;
            accountUsernameLbl.Text = "Username";
            // 
            // accountPasswordLbl
            // 
            accountPasswordLbl.AutoSize = true;
            accountPasswordLbl.Location = new Point(130, 86);
            accountPasswordLbl.Name = "accountPasswordLbl";
            accountPasswordLbl.Size = new Size(57, 15);
            accountPasswordLbl.TabIndex = 2;
            accountPasswordLbl.Text = "Password";
            // 
            // accountEmailLbl
            // 
            accountEmailLbl.AutoSize = true;
            accountEmailLbl.Location = new Point(106, 129);
            accountEmailLbl.Name = "accountEmailLbl";
            accountEmailLbl.Size = new Size(81, 15);
            accountEmailLbl.TabIndex = 3;
            accountEmailLbl.Text = "Email Address";
            // 
            // accountPhoneLbl
            // 
            accountPhoneLbl.AutoSize = true;
            accountPhoneLbl.Location = new Point(99, 173);
            accountPhoneLbl.Name = "accountPhoneLbl";
            accountPhoneLbl.Size = new Size(88, 15);
            accountPhoneLbl.TabIndex = 4;
            accountPhoneLbl.Text = "Phone Number";
            // 
            // accountDetailsGroupBox
            // 
            accountDetailsGroupBox.Controls.Add(accountCreateBtn);
            accountDetailsGroupBox.Controls.Add(txtPhone);
            accountDetailsGroupBox.Controls.Add(txtEmail);
            accountDetailsGroupBox.Controls.Add(txtPassword);
            accountDetailsGroupBox.Controls.Add(txtUsername);
            accountDetailsGroupBox.Controls.Add(accountUsernameLbl);
            accountDetailsGroupBox.Controls.Add(accountPasswordLbl);
            accountDetailsGroupBox.Controls.Add(accountPhoneLbl);
            accountDetailsGroupBox.Controls.Add(accountEmailLbl);
            accountDetailsGroupBox.Location = new Point(144, 72);
            accountDetailsGroupBox.Name = "accountDetailsGroupBox";
            accountDetailsGroupBox.Size = new Size(469, 261);
            accountDetailsGroupBox.TabIndex = 8;
            accountDetailsGroupBox.TabStop = false;
            accountDetailsGroupBox.Text = "Account Details";
            // 
            // accountCreateBtn
            // 
            accountCreateBtn.Location = new Point(204, 220);
            accountCreateBtn.Name = "accountCreateBtn";
            accountCreateBtn.Size = new Size(75, 23);
            accountCreateBtn.TabIndex = 8;
            accountCreateBtn.Text = "Create";
            accountCreateBtn.UseVisualStyleBackColor = true;
            accountCreateBtn.Click += accountCreateBtn_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(193, 170);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(133, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 126);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(193, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(133, 23);
            txtUsername.TabIndex = 2;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 9;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // frmAccountsOpen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(accountDetailsGroupBox);
            Name = "frmAccountsOpen";
            Text = "Open Account";
            accountDetailsGroupBox.ResumeLayout(false);
            accountDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label accountUsernameLbl;
        private Label accountPasswordLbl;
        private Label accountEmailLbl;
        private Label accountPhoneLbl;
        private GroupBox accountDetailsGroupBox;
        private Button accountCreateBtn;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button backBtn;
    }
}