namespace TaxiSys
{
    partial class frmBookingsBookTaxi
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
            label1 = new Label();
            grdDriversDetails = new DataGridView();
            driverDetailsLbl = new Label();
            journeyDetailsBox = new GroupBox();
            txtPickUp = new TextBox();
            bookTaxiButton = new Button();
            txtDistance = new TextBox();
            label2 = new Label();
            lblDistance = new Label();
            txtDestination = new TextBox();
            destinationLbl = new Label();
            txtPassenger = new TextBox();
            passengersLbl = new Label();
            backBtn = new Button();
            btnSelect = new Button();
            txtPasswordSearch = new TextBox();
            txtUsernameSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdDriversDetails).BeginInit();
            journeyDetailsBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // grdDriversDetails
            // 
            grdDriversDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDriversDetails.Enabled = false;
            grdDriversDetails.Location = new Point(244, 97);
            grdDriversDetails.Name = "grdDriversDetails";
            grdDriversDetails.Size = new Size(544, 140);
            grdDriversDetails.TabIndex = 5;
            grdDriversDetails.CellClick += grdDriverDetails_CellClick;
            // 
            // driverDetailsLbl
            // 
            driverDetailsLbl.AutoSize = true;
            driverDetailsLbl.Location = new Point(244, 79);
            driverDetailsLbl.Name = "driverDetailsLbl";
            driverDetailsLbl.Size = new Size(76, 15);
            driverDetailsLbl.TabIndex = 2;
            driverDetailsLbl.Text = "Driver Details";
            // 
            // journeyDetailsBox
            // 
            journeyDetailsBox.Controls.Add(txtPickUp);
            journeyDetailsBox.Controls.Add(bookTaxiButton);
            journeyDetailsBox.Controls.Add(txtDistance);
            journeyDetailsBox.Controls.Add(label2);
            journeyDetailsBox.Controls.Add(lblDistance);
            journeyDetailsBox.Controls.Add(txtDestination);
            journeyDetailsBox.Controls.Add(destinationLbl);
            journeyDetailsBox.Location = new Point(244, 254);
            journeyDetailsBox.Name = "journeyDetailsBox";
            journeyDetailsBox.Size = new Size(400, 157);
            journeyDetailsBox.TabIndex = 7;
            journeyDetailsBox.TabStop = false;
            journeyDetailsBox.Text = "Journey Details";
            journeyDetailsBox.Visible = false;
            // 
            // txtPickUp
            // 
            txtPickUp.Location = new Point(130, 60);
            txtPickUp.Name = "txtPickUp";
            txtPickUp.Size = new Size(136, 23);
            txtPickUp.TabIndex = 7;
            // 
            // bookTaxiButton
            // 
            bookTaxiButton.Location = new Point(298, 73);
            bookTaxiButton.Name = "bookTaxiButton";
            bookTaxiButton.Size = new Size(75, 23);
            bookTaxiButton.TabIndex = 9;
            bookTaxiButton.Text = "Book Taxi";
            bookTaxiButton.UseVisualStyleBackColor = true;
            bookTaxiButton.Click += bookTaxiButton_Click;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(130, 31);
            txtDistance.MaxLength = 3;
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(67, 23);
            txtDistance.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 63);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 13;
            label2.Text = "Pick Up Location";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(72, 34);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(52, 15);
            lblDistance.TabIndex = 12;
            lblDistance.Text = "Distance";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(130, 88);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(136, 23);
            txtDestination.TabIndex = 8;
            // 
            // destinationLbl
            // 
            destinationLbl.AutoSize = true;
            destinationLbl.Location = new Point(57, 91);
            destinationLbl.Name = "destinationLbl";
            destinationLbl.Size = new Size(67, 15);
            destinationLbl.TabIndex = 0;
            destinationLbl.Text = "Destination";
            // 
            // txtPassenger
            // 
            txtPassenger.Location = new Point(187, 167);
            txtPassenger.MaxLength = 1;
            txtPassenger.Name = "txtPassenger";
            txtPassenger.Size = new Size(51, 23);
            txtPassenger.TabIndex = 3;
            // 
            // passengersLbl
            // 
            passengersLbl.AutoSize = true;
            passengersLbl.Location = new Point(25, 170);
            passengersLbl.Name = "passengersLbl";
            passengersLbl.Size = new Size(107, 15);
            passengersLbl.TabIndex = 1;
            passengersLbl.Text = "Passenger Amount";
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
            // btnSelect
            // 
            btnSelect.Location = new Point(114, 204);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtPasswordSearch
            // 
            txtPasswordSearch.Location = new Point(83, 138);
            txtPasswordSearch.Name = "txtPasswordSearch";
            txtPasswordSearch.PasswordChar = '*';
            txtPasswordSearch.Size = new Size(155, 23);
            txtPasswordSearch.TabIndex = 2;
            // 
            // txtUsernameSearch
            // 
            txtUsernameSearch.Location = new Point(83, 110);
            txtUsernameSearch.Name = "txtUsernameSearch";
            txtUsernameSearch.Size = new Size(155, 23);
            txtUsernameSearch.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 17;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 141);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 49);
            label5.Name = "label5";
            label5.Size = new Size(250, 15);
            label5.TabIndex = 20;
            label5.Text = "WARNING! This page is for customer use only.";
            // 
            // frmBookingsBookTaxi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnSelect);
            Controls.Add(txtPasswordSearch);
            Controls.Add(txtUsernameSearch);
            Controls.Add(label3);
            Controls.Add(txtPassenger);
            Controls.Add(label4);
            Controls.Add(backBtn);
            Controls.Add(passengersLbl);
            Controls.Add(journeyDetailsBox);
            Controls.Add(driverDetailsLbl);
            Controls.Add(grdDriversDetails);
            Controls.Add(label1);
            Name = "frmBookingsBookTaxi";
            Text = "Book Taxi";
            ((System.ComponentModel.ISupportInitialize)grdDriversDetails).EndInit();
            journeyDetailsBox.ResumeLayout(false);
            journeyDetailsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView grdDriversDetails;
        private Label driverDetailsLbl;
        private GroupBox journeyDetailsBox;
        private Label destinationLbl;
        private Label passengersLbl;
        private TextBox txtPassenger;
        private TextBox txtDestination;
        private Button bookTaxiButton;
        private Button backBtn;
        private TextBox txtPickUp;
        private TextBox txtDistance;
        private Label label2;
        private Label lblDistance;
        private Button btnSelect;
        private TextBox txtPasswordSearch;
        private TextBox txtUsernameSearch;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}