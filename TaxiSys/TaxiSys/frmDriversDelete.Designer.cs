namespace TaxiSys
{
    partial class frmDriversDelete
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
            grdDrivers = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            driverDetailsGroupBox = new GroupBox();
            txtDriverId = new TextBox();
            driverIdLbl = new Label();
            txtSurname = new TextBox();
            txtLicenseNo = new TextBox();
            txtPhoneNo = new TextBox();
            txtForename = new TextBox();
            btnDelete = new Button();
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
            driverDetailsForenameLbl = new Label();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)grdDrivers).BeginInit();
            driverDetailsGroupBox.SuspendLayout();
            carDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // grdDrivers
            // 
            grdDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDrivers.Location = new Point(12, 88);
            grdDrivers.Name = "grdDrivers";
            grdDrivers.RowTemplate.Height = 25;
            grdDrivers.Size = new Size(313, 132);
            grdDrivers.TabIndex = 23;
            grdDrivers.Visible = false;
            grdDrivers.CellClick += grdDrivers_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(263, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 21);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(123, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 23);
            txtSearch.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 20;
            label1.Text = "Enter Surname";
            // 
            // driverDetailsGroupBox
            // 
            driverDetailsGroupBox.Controls.Add(txtDriverId);
            driverDetailsGroupBox.Controls.Add(driverIdLbl);
            driverDetailsGroupBox.Controls.Add(txtSurname);
            driverDetailsGroupBox.Controls.Add(txtLicenseNo);
            driverDetailsGroupBox.Controls.Add(txtPhoneNo);
            driverDetailsGroupBox.Controls.Add(txtForename);
            driverDetailsGroupBox.Controls.Add(btnDelete);
            driverDetailsGroupBox.Controls.Add(driverDetailsPhoneNoLbl);
            driverDetailsGroupBox.Controls.Add(carDetailsGroupBox);
            driverDetailsGroupBox.Controls.Add(driverDetailsSurnameLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsLicenseNoLbl);
            driverDetailsGroupBox.Controls.Add(driverDetailsForenameLbl);
            driverDetailsGroupBox.Location = new Point(343, 51);
            driverDetailsGroupBox.Name = "driverDetailsGroupBox";
            driverDetailsGroupBox.Size = new Size(445, 365);
            driverDetailsGroupBox.TabIndex = 19;
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
            txtDriverId.TabIndex = 13;
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
            txtSurname.Enabled = false;
            txtSurname.Location = new Point(213, 79);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 11;
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Enabled = false;
            txtLicenseNo.Location = new Point(213, 109);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(100, 23);
            txtLicenseNo.TabIndex = 10;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Enabled = false;
            txtPhoneNo.Location = new Point(213, 136);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 9;
            // 
            // txtForename
            // 
            txtForename.Enabled = false;
            txtForename.Location = new Point(213, 48);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(100, 23);
            txtForename.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(188, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            cboSeatNo.Enabled = false;
            cboSeatNo.FormattingEnabled = true;
            cboSeatNo.Location = new Point(213, 116);
            cboSeatNo.Name = "cboSeatNo";
            cboSeatNo.Size = new Size(59, 23);
            cboSeatNo.TabIndex = 18;
            // 
            // cboModel
            // 
            cboModel.Enabled = false;
            cboModel.FormattingEnabled = true;
            cboModel.Location = new Point(213, 57);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(121, 23);
            cboModel.TabIndex = 16;
            cboModel.Text = "Unselected";
            // 
            // cboMake
            // 
            cboMake.Enabled = false;
            cboMake.FormattingEnabled = true;
            cboMake.Location = new Point(213, 28);
            cboMake.Name = "cboMake";
            cboMake.Size = new Size(121, 23);
            cboMake.TabIndex = 15;
            cboMake.Text = "Unselected";
            // 
            // txtRegNo
            // 
            txtRegNo.Enabled = false;
            txtRegNo.Location = new Point(213, 89);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(100, 23);
            txtRegNo.TabIndex = 14;
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
            backBtn.Location = new Point(722, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 18;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // frmDriversDelete
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
            Name = "frmDriversDelete";
            Text = "Delete Driver";
            ((System.ComponentModel.ISupportInitialize)grdDrivers).EndInit();
            driverDetailsGroupBox.ResumeLayout(false);
            driverDetailsGroupBox.PerformLayout();
            carDetailsGroupBox.ResumeLayout(false);
            carDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdDrivers;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox driverDetailsGroupBox;
        private TextBox txtDriverId;
        private Label driverIdLbl;
        private TextBox txtSurname;
        private TextBox txtLicenseNo;
        private TextBox txtPhoneNo;
        private TextBox txtForename;
        private Button btnDelete;
        private Label driverDetailsPhoneNoLbl;
        private GroupBox carDetailsGroupBox;
        private ComboBox cboSeatNo;
        private ComboBox cboModel;
        private ComboBox cboMake;
        private TextBox txtRegNo;
        private Label carDetailsSeatNumLbl;
        private Label carDetailsModelLbl;
        private Label carDetailsRegNoLbl;
        private Label carDetailsMakeLbl;
        private Label driverDetailsSurnameLbl;
        private Label driverDetailsLicenseNoLbl;
        private Label driverDetailsForenameLbl;
        private Button backBtn;
    }
}