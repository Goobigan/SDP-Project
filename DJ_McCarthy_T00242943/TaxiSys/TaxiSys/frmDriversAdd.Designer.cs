namespace TaxiSys
{
    partial class frmDriversAdd
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
            driverDetailsForenameLbl = new Label();
            driverDetailsGroupBox = new GroupBox();
            txtSurname = new TextBox();
            txtLicenceNo = new TextBox();
            txtPhoneNo = new TextBox();
            txtForename = new TextBox();
            driverDetailsSubmitButton = new Button();
            driverDetailsPhoneNoLbl = new Label();
            carDetailsGroupBox = new GroupBox();
            cboSeatNo = new ComboBox();
            cboModel = new ComboBox();
            cboMake = new ComboBox();
            txtRegNo = new TextBox();
            carDetailsSeatNumLbl = new Label();
            carDetailsModelLbl = new Label();
            carDetailsRegNoLbl = new Label();
            carDetailsMakeLbl = new Label();
            driverDetailsSurnameLbl = new Label();
            driverDetailsLicenseNoLbl = new Label();
            driverDetailsGroupBox.SuspendLayout();
            carDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 10;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // driverDetailsForenameLbl
            // 
            driverDetailsForenameLbl.AutoSize = true;
            driverDetailsForenameLbl.Location = new Point(38, 51);
            driverDetailsForenameLbl.Name = "driverDetailsForenameLbl";
            driverDetailsForenameLbl.Size = new Size(60, 15);
            driverDetailsForenameLbl.TabIndex = 1;
            driverDetailsForenameLbl.Text = "Forename";
            // 
            // driverDetailsGroupBox
            // 
            driverDetailsGroupBox.Controls.Add(txtSurname);
            driverDetailsGroupBox.Controls.Add(txtLicenceNo);
            driverDetailsGroupBox.Controls.Add(txtPhoneNo);
            driverDetailsGroupBox.Controls.Add(txtForename);
            driverDetailsGroupBox.Controls.Add(driverDetailsSubmitButton);
            driverDetailsGroupBox.Controls.Add(driverDetailsPhoneNoLbl);
            driverDetailsGroupBox.Controls.Add(carDetailsGroupBox);
            driverDetailsGroupBox.Controls.Add(driverDetailsSurnameLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsLicenseNoLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsForenameLbl);
            driverDetailsGroupBox.Location = new Point(157, 48);
            driverDetailsGroupBox.Name = "driverDetailsGroupBox";
            driverDetailsGroupBox.Size = new Size(445, 365);
            driverDetailsGroupBox.TabIndex = 2;
            driverDetailsGroupBox.TabStop = false;
            driverDetailsGroupBox.Text = "Driver Details";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(213, 79);
            txtSurname.MaxLength = 20;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtLicenceNo
            // 
            txtLicenceNo.Location = new Point(213, 109);
            txtLicenceNo.MaxLength = 9;
            txtLicenceNo.Name = "txtLicenceNo";
            txtLicenceNo.Size = new Size(100, 23);
            txtLicenceNo.TabIndex = 3;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(213, 136);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 4;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(213, 48);
            txtForename.MaxLength = 20;
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(100, 23);
            txtForename.TabIndex = 1;
            // 
            // driverDetailsSubmitButton
            // 
            driverDetailsSubmitButton.Location = new Point(188, 336);
            driverDetailsSubmitButton.Name = "driverDetailsSubmitButton";
            driverDetailsSubmitButton.Size = new Size(75, 23);
            driverDetailsSubmitButton.TabIndex = 9;
            driverDetailsSubmitButton.Text = "Submit";
            driverDetailsSubmitButton.UseVisualStyleBackColor = true;
            driverDetailsSubmitButton.Click += driverDetailsSubmitButton_Click;
            // 
            // driverDetailsPhoneNoLbl
            // 
            driverDetailsPhoneNoLbl.AutoSize = true;
            driverDetailsPhoneNoLbl.Location = new Point(38, 139);
            driverDetailsPhoneNoLbl.Name = "driverDetailsPhoneNoLbl";
            driverDetailsPhoneNoLbl.Size = new Size(63, 15);
            driverDetailsPhoneNoLbl.TabIndex = 5;
            driverDetailsPhoneNoLbl.Text = "Phone No.";
            // 
            // carDetailsGroupBox
            // 
            carDetailsGroupBox.Controls.Add(cboSeatNo);
            carDetailsGroupBox.Controls.Add(cboModel);
            carDetailsGroupBox.Controls.Add(cboMake);
            carDetailsGroupBox.Controls.Add(txtRegNo);
            carDetailsGroupBox.Controls.Add(carDetailsSeatNumLbl);
            carDetailsGroupBox.Controls.Add(carDetailsModelLbl);
            carDetailsGroupBox.Controls.Add(carDetailsRegNoLbl);
            carDetailsGroupBox.Controls.Add(carDetailsMakeLbl);
            carDetailsGroupBox.Location = new Point(0, 163);
            carDetailsGroupBox.Name = "carDetailsGroupBox";
            carDetailsGroupBox.Size = new Size(445, 152);
            carDetailsGroupBox.TabIndex = 4;
            carDetailsGroupBox.TabStop = false;
            carDetailsGroupBox.Text = "Car Details";
            // 
            // cboSeatNo
            // 
            cboSeatNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeatNo.FormattingEnabled = true;
            cboSeatNo.Location = new Point(213, 116);
            cboSeatNo.Name = "cboSeatNo";
            cboSeatNo.Size = new Size(59, 23);
            cboSeatNo.TabIndex = 8;
            // 
            // cboModel
            // 
            cboModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModel.Enabled = false;
            cboModel.FormattingEnabled = true;
            cboModel.Location = new Point(213, 57);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(121, 23);
            cboModel.TabIndex = 6;
            // 
            // cboMake
            // 
            cboMake.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMake.FormattingEnabled = true;
            cboMake.Location = new Point(213, 28);
            cboMake.Name = "cboMake";
            cboMake.Size = new Size(121, 23);
            cboMake.TabIndex = 5;
            cboMake.SelectedIndexChanged += carDetailsMakeComboBox_SelectedIndexChanged;
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(213, 89);
            txtRegNo.MaxLength = 15;
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(100, 23);
            txtRegNo.TabIndex = 7;
            // 
            // carDetailsSeatNumLbl
            // 
            carDetailsSeatNumLbl.AutoSize = true;
            carDetailsSeatNumLbl.Location = new Point(38, 119);
            carDetailsSeatNumLbl.Name = "carDetailsSeatNumLbl";
            carDetailsSeatNumLbl.Size = new Size(94, 15);
            carDetailsSeatNumLbl.TabIndex = 6;
            carDetailsSeatNumLbl.Text = "Number of seats";
            // 
            // carDetailsModelLbl
            // 
            carDetailsModelLbl.AutoSize = true;
            carDetailsModelLbl.Location = new Point(38, 60);
            carDetailsModelLbl.Name = "carDetailsModelLbl";
            carDetailsModelLbl.Size = new Size(41, 15);
            carDetailsModelLbl.TabIndex = 3;
            carDetailsModelLbl.Text = "Model";
            // 
            // carDetailsRegNoLbl
            // 
            carDetailsRegNoLbl.AutoSize = true;
            carDetailsRegNoLbl.Location = new Point(38, 89);
            carDetailsRegNoLbl.Name = "carDetailsRegNoLbl";
            carDetailsRegNoLbl.Size = new Size(49, 15);
            carDetailsRegNoLbl.TabIndex = 2;
            carDetailsRegNoLbl.Text = "Reg No.";
            // 
            // carDetailsMakeLbl
            // 
            carDetailsMakeLbl.AutoSize = true;
            carDetailsMakeLbl.Location = new Point(38, 31);
            carDetailsMakeLbl.Name = "carDetailsMakeLbl";
            carDetailsMakeLbl.Size = new Size(36, 15);
            carDetailsMakeLbl.TabIndex = 1;
            carDetailsMakeLbl.Text = "Make";
            // 
            // driverDetailsSurnameLbl
            // 
            driverDetailsSurnameLbl.AutoSize = true;
            driverDetailsSurnameLbl.Location = new Point(38, 82);
            driverDetailsSurnameLbl.Name = "driverDetailsSurnameLbl";
            driverDetailsSurnameLbl.Size = new Size(54, 15);
            driverDetailsSurnameLbl.TabIndex = 3;
            driverDetailsSurnameLbl.Text = "Surname";
            // 
            // driverDetailsLicenseNoLbl
            // 
            driverDetailsLicenseNoLbl.AutoSize = true;
            driverDetailsLicenseNoLbl.Location = new Point(38, 112);
            driverDetailsLicenseNoLbl.Name = "driverDetailsLicenseNoLbl";
            driverDetailsLicenseNoLbl.Size = new Size(68, 15);
            driverDetailsLicenseNoLbl.TabIndex = 2;
            driverDetailsLicenseNoLbl.Text = "License No.";
            // 
            // frmDriversAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(driverDetailsGroupBox);
            Controls.Add(backBtn);
            Name = "frmDriversAdd";
            Text = "Add Driver";
            driverDetailsGroupBox.ResumeLayout(false);
            driverDetailsGroupBox.PerformLayout();
            carDetailsGroupBox.ResumeLayout(false);
            carDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Label driverDetailsForenameLbl;
        private GroupBox driverDetailsGroupBox;
        private Label driverDetailsPhoneNoLbl;
        private GroupBox carDetailsGroupBox;
        private Label carDetailsModelLbl;
        private Label carDetailsRegNoLbl;
        private Label carDetailsMakeLbl;
        private Label driverDetailsSurnameLbl;
        private Label driverDetailsLicenseNoLbl;
        private Label carDetailsSeatNumLbl;
        private Button driverDetailsSubmitButton;
        private TextBox txtSurname;
        private TextBox txtLicenceNo;
        private TextBox txtPhoneNo;
        private TextBox txtForename;
        private TextBox txtRegNo;
        private ComboBox cboMake;
        private ComboBox cboModel;
        private ComboBox cboSeatNo;
    }
}