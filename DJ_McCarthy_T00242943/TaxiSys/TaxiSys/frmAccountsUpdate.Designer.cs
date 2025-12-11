namespace TaxiSys
{
    partial class frmAccountsUpdate
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
            backBtn = new Button();
            accountDetailsGroupBox = new GroupBox();
            txtID = new TextBox();
            label1 = new Label();
            accountUpdateBtn = new Button();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            accountUsernameLbl = new Label();
            accountPasswordLbl = new Label();
            accountPhoneLbl = new Label();
            accountEmailLbl = new Label();
            txtPasswordSearch = new TextBox();
            txtUsernameSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSelect = new Button();
            accountDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 11;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // accountDetailsGroupBox
            // 
            accountDetailsGroupBox.Controls.Add(txtID);
            accountDetailsGroupBox.Controls.Add(label1);
            accountDetailsGroupBox.Controls.Add(accountUpdateBtn);
            accountDetailsGroupBox.Controls.Add(txtPhone);
            accountDetailsGroupBox.Controls.Add(txtEmail);
            accountDetailsGroupBox.Controls.Add(txtPassword);
            accountDetailsGroupBox.Controls.Add(txtUsername);
            accountDetailsGroupBox.Controls.Add(accountUsernameLbl);
            accountDetailsGroupBox.Controls.Add(accountPasswordLbl);
            accountDetailsGroupBox.Controls.Add(accountPhoneLbl);
            accountDetailsGroupBox.Controls.Add(accountEmailLbl);
            accountDetailsGroupBox.Location = new Point(299, 59);
            accountDetailsGroupBox.Name = "accountDetailsGroupBox";
            accountDetailsGroupBox.Size = new Size(469, 335);
            accountDetailsGroupBox.TabIndex = 10;
            accountDetailsGroupBox.TabStop = false;
            accountDetailsGroupBox.Text = "Account Details";
            accountDetailsGroupBox.Visible = false;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(193, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "Account ID";
            // 
            // accountUpdateBtn
            // 
            accountUpdateBtn.Location = new Point(207, 264);
            accountUpdateBtn.Name = "accountUpdateBtn";
            accountUpdateBtn.Size = new Size(75, 23);
            accountUpdateBtn.TabIndex = 8;
            accountUpdateBtn.Text = "Update";
            accountUpdateBtn.UseVisualStyleBackColor = true;
            accountUpdateBtn.Click += accountUpdateBtn_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(193, 175);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(155, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 148);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(193, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 23);
            txtUsername.TabIndex = 2;
            // 
            // accountUsernameLbl
            // 
            accountUsernameLbl.AutoSize = true;
            accountUsernameLbl.Location = new Point(127, 97);
            accountUsernameLbl.Name = "accountUsernameLbl";
            accountUsernameLbl.Size = new Size(60, 15);
            accountUsernameLbl.TabIndex = 1;
            accountUsernameLbl.Text = "Username";
            // 
            // accountPasswordLbl
            // 
            accountPasswordLbl.AutoSize = true;
            accountPasswordLbl.Location = new Point(130, 125);
            accountPasswordLbl.Name = "accountPasswordLbl";
            accountPasswordLbl.Size = new Size(57, 15);
            accountPasswordLbl.TabIndex = 2;
            accountPasswordLbl.Text = "Password";
            // 
            // accountPhoneLbl
            // 
            accountPhoneLbl.AutoSize = true;
            accountPhoneLbl.Location = new Point(99, 178);
            accountPhoneLbl.Name = "accountPhoneLbl";
            accountPhoneLbl.Size = new Size(88, 15);
            accountPhoneLbl.TabIndex = 4;
            accountPhoneLbl.Text = "Phone Number";
            // 
            // accountEmailLbl
            // 
            accountEmailLbl.AutoSize = true;
            accountEmailLbl.Location = new Point(106, 151);
            accountEmailLbl.Name = "accountEmailLbl";
            accountEmailLbl.Size = new Size(81, 15);
            accountEmailLbl.TabIndex = 3;
            accountEmailLbl.Text = "Email Address";
            // 
            // txtPasswordSearch
            // 
            txtPasswordSearch.Location = new Point(90, 167);
            txtPasswordSearch.Name = "txtPasswordSearch";
            txtPasswordSearch.PasswordChar = '*';
            txtPasswordSearch.Size = new Size(155, 23);
            txtPasswordSearch.TabIndex = 15;
            // 
            // txtUsernameSearch
            // 
            txtUsernameSearch.Location = new Point(90, 139);
            txtUsernameSearch.Name = "txtUsernameSearch";
            txtUsernameSearch.Size = new Size(155, 23);
            txtUsernameSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 142);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 170);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(121, 233);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 16;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmAccountsUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(txtPasswordSearch);
            Controls.Add(txtUsernameSearch);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(backBtn);
            Controls.Add(accountDetailsGroupBox);
            Name = "frmAccountsUpdate";
            Text = "Update Account";
            accountDetailsGroupBox.ResumeLayout(false);
            accountDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private GroupBox accountDetailsGroupBox;
        private Button accountUpdateBtn;

        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label accountUsernameLbl;
        private Label accountPasswordLbl;
        private Label accountPhoneLbl;
        private Label accountEmailLbl;
        private TextBox txtID;
        private Label label1;
        private TextBox txtPasswordSearch;
        private TextBox txtUsernameSearch;
        private Label label2;
        private Label label3;
        private Button btnSelect;
    }
}