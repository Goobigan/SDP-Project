namespace TaxiSys
{
    partial class frmBookingsCancelTaxi
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
            JourneyDetailsLbl = new Label();
            grdJourneyDetails = new DataGridView();
            backBtn = new Button();
            btnCancelTaxi = new Button();
            btnSelect = new Button();
            txtPasswordSearch = new TextBox();
            txtUsernameSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).BeginInit();
            SuspendLayout();
            // 
            // JourneyDetailsLbl
            // 
            JourneyDetailsLbl.AutoSize = true;
            JourneyDetailsLbl.Location = new Point(367, 216);
            JourneyDetailsLbl.Name = "JourneyDetailsLbl";
            JourneyDetailsLbl.Size = new Size(86, 15);
            JourneyDetailsLbl.TabIndex = 4;
            JourneyDetailsLbl.Text = "Journey Details";
            // 
            // grdJourneyDetails
            // 
            grdJourneyDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJourneyDetails.Enabled = false;
            grdJourneyDetails.Location = new Point(173, 255);
            grdJourneyDetails.Name = "grdJourneyDetails";
            grdJourneyDetails.Size = new Size(455, 117);
            grdJourneyDetails.TabIndex = 3;
            grdJourneyDetails.CellClick += grdJourneyDetails_CellClick;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(696, 21);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 12;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // btnCancelTaxi
            // 
            btnCancelTaxi.Enabled = false;
            btnCancelTaxi.Location = new Point(367, 394);
            btnCancelTaxi.Name = "btnCancelTaxi";
            btnCancelTaxi.Size = new Size(72, 23);
            btnCancelTaxi.TabIndex = 13;
            btnCancelTaxi.Text = "Cancel Taxi";
            btnCancelTaxi.UseVisualStyleBackColor = true;
            btnCancelTaxi.Click += cancelTaxiBtn_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(313, 79);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 28;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtPasswordSearch
            // 
            txtPasswordSearch.Location = new Point(101, 94);
            txtPasswordSearch.Name = "txtPasswordSearch";
            txtPasswordSearch.PasswordChar = '*';
            txtPasswordSearch.Size = new Size(155, 23);
            txtPasswordSearch.TabIndex = 27;
            // 
            // txtUsernameSearch
            // 
            txtUsernameSearch.Location = new Point(101, 66);
            txtUsernameSearch.Name = "txtUsernameSearch";
            txtUsernameSearch.Size = new Size(155, 23);
            txtUsernameSearch.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 24;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 26;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 29);
            label5.Name = "label5";
            label5.Size = new Size(250, 15);
            label5.TabIndex = 29;
            label5.Text = "WARNING! This page is for customer use only.";
            // 
            // frmBookingsCancelTaxi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnSelect);
            Controls.Add(txtPasswordSearch);
            Controls.Add(txtUsernameSearch);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnCancelTaxi);
            Controls.Add(backBtn);
            Controls.Add(JourneyDetailsLbl);
            Controls.Add(grdJourneyDetails);
            Name = "frmBookingsCancelTaxi";
            Text = "Cancel Taxi";
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JourneyDetailsLbl;
        private DataGridView grdJourneyDetails;
        private Button backBtn;
        private Button btnCancelTaxi;
        private Button btnSelect;
        private TextBox txtPasswordSearch;
        private TextBox txtUsernameSearch;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}