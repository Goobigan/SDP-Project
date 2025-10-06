namespace TaxiSys
{
    partial class frmDriversUpdate
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
            carDetailsGroupBox = new GroupBox();
            cboSeatNo = new ComboBox();
            cboModel = new ComboBox();
            cboMake = new ComboBox();
            txtRegNo = new TextBox();
            carDetailsSeatNumLbl = new Label();
            carDetailsModelLbl = new Label();
            carDetailsRegNoLbl = new Label();
            carDetailsMakeLbl = new Label();
            driverDetailsGroupBox = new GroupBox();
            txtDriverId = new TextBox();
            driverIdLbl = new Label();
            txtSurname = new TextBox();
            txtLicenseNo = new TextBox();
            txtPhoneNo = new TextBox();
            txtForename = new TextBox();
            btnUpdate = new Button();
            driverDetailsPhoneNoLbl = new Label();
            driverDetailsSurnameLbl = new Label();
            driverDetailsLicenseNoLbl = new Label();
            driverDetailsForenameLbl = new Label();
            backBtn = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            grdDrivers = new DataGridView();
            carDetailsGroupBox.SuspendLayout();
            driverDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDrivers).BeginInit();
            SuspendLayout();
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
            cboSeatNo.TabIndex = 12;
            // 
            // cboModel
            // 
            cboModel.FormattingEnabled = true;
            cboModel.Location = new Point(213, 57);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(121, 23);
            cboModel.TabIndex = 10;
            cboModel.Text = "Unselected";
            // 
            // cboMake
            // 
            cboMake.FormattingEnabled = true;
            cboMake.Location = new Point(213, 28);
            cboMake.Name = "cboMake";
            cboMake.Size = new Size(121, 23);
            cboMake.TabIndex = 9;
            cboMake.Text = "Unselected";
            cboMake.SelectedIndexChanged += carDetailsUpdateMakeComboBox_SelectedIndexChanged;
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(213, 89);
            txtRegNo.MaxLength = 15;
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(100, 23);
            txtRegNo.TabIndex = 11;
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
            // driverDetailsGroupBox
            // 
            driverDetailsGroupBox.Controls.Add(txtDriverId);
            driverDetailsGroupBox.Controls.Add(driverIdLbl);
            driverDetailsGroupBox.Controls.Add(txtSurname);
            driverDetailsGroupBox.Controls.Add(txtLicenseNo);
            driverDetailsGroupBox.Controls.Add(txtPhoneNo);
            driverDetailsGroupBox.Controls.Add(txtForename);
            driverDetailsGroupBox.Controls.Add(btnUpdate);
            driverDetailsGroupBox.Controls.Add(driverDetailsPhoneNoLbl);
            driverDetailsGroupBox.Controls.Add(carDetailsGroupBox);
            driverDetailsGroupBox.Controls.Add(driverDetailsSurnameLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsLicenseNoLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsForenameLbl);
            driverDetailsGroupBox.Location = new Point(343, 48);
            driverDetailsGroupBox.Name = "driverDetailsGroupBox";
            driverDetailsGroupBox.Size = new Size(445, 365);
            driverDetailsGroupBox.TabIndex = 4;
            driverDetailsGroupBox.TabStop = false;
            driverDetailsGroupBox.Text = "Driver Details";
            driverDetailsGroupBox.Visible = false;
            // 
            // txtDriverId
            // 
            txtDriverId.Enabled = false;
            txtDriverId.Location = new Point(213, 16);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(100, 23);
            txtDriverId.TabIndex = 4;
            // 
            // driverIdLbl
            // 
            driverIdLbl.AutoSize = true;
            driverIdLbl.Location = new Point(38, 19);
            driverIdLbl.Name = "driverIdLbl";
            driverIdLbl.Size = new Size(52, 15);
            driverIdLbl.TabIndex = 12;
            driverIdLbl.Text = "Driver ID";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(213, 79);
            txtSurname.MaxLength = 20;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 6;
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Location = new Point(213, 109);
            txtLicenseNo.MaxLength = 9;
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(100, 23);
            txtLicenseNo.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(213, 136);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 8;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(213, 48);
            txtForename.MaxLength = 20;
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(100, 23);
            txtForename.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(188, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += driverDetailsUpdateButton_Click;
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
            // driverDetailsForenameLbl
            // 
            driverDetailsForenameLbl.AutoSize = true;
            driverDetailsForenameLbl.Location = new Point(38, 51);
            driverDetailsForenameLbl.Name = "driverDetailsForenameLbl";
            driverDetailsForenameLbl.Size = new Size(60, 15);
            driverDetailsForenameLbl.TabIndex = 1;
            driverDetailsForenameLbl.Text = "Forename";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(722, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 3;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(123, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 14;
            label1.Text = "Enter Surname";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(263, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 21);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grdDrivers
            // 
            grdDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDrivers.Location = new Point(12, 85);
            grdDrivers.Name = "grdDrivers";
            grdDrivers.Size = new Size(313, 90);
            grdDrivers.TabIndex = 3;
            grdDrivers.Visible = false;
            grdDrivers.CellClick += grdDrivers_CellClick;
            // 
            // frmDriversUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdDrivers);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(driverDetailsGroupBox);
            Controls.Add(backBtn);
            Name = "frmDriversUpdate";
            Text = "Update Driver";
            carDetailsGroupBox.ResumeLayout(false);
            carDetailsGroupBox.PerformLayout();
            driverDetailsGroupBox.ResumeLayout(false);
            driverDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox carDetailsGroupBox;
        private ComboBox cboModel;
        private ComboBox cboMake;
        private TextBox txtRegNo;
        private Label carDetailsSeatNumLbl;
        private Label carDetailsModelLbl;
        private Label carDetailsRegNoLbl;
        private Label carDetailsMakeLbl;
        private GroupBox driverDetailsGroupBox;
        private TextBox txtSurname;
        private TextBox txtLicenseNo;
        private TextBox txtPhoneNo;
        private TextBox txtForename;
        private Button btnUpdate;
        private Label driverDetailsPhoneNoLbl;
        private Label driverDetailsSurnameLbl;
        private Label driverDetailsLicenseNoLbl;
        private Label driverDetailsForenameLbl;
        private Button backBtn;
        private TextBox txtDriverId;
        private Label driverIdLbl;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView grdDrivers;
        private ComboBox cboSeatNo;
    }
}