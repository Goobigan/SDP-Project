namespace TaxiSys
{
    partial class frmBookingsConcludeJourney
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
            calculateCostBtn = new Button();
            backBtn = new Button();
            JourneyDetailsLbl = new Label();
            grdJourneyDetails = new DataGridView();
            grdDrivers = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdDrivers).BeginInit();
            SuspendLayout();
            // 
            // calculateCostBtn
            // 
            calculateCostBtn.Location = new Point(373, 406);
            calculateCostBtn.Name = "calculateCostBtn";
            calculateCostBtn.Size = new Size(75, 23);
            calculateCostBtn.TabIndex = 17;
            calculateCostBtn.Text = "Calculate";
            calculateCostBtn.UseVisualStyleBackColor = true;
            calculateCostBtn.Click += calculateCostBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 16;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // JourneyDetailsLbl
            // 
            JourneyDetailsLbl.AutoSize = true;
            JourneyDetailsLbl.Location = new Point(362, 247);
            JourneyDetailsLbl.Name = "JourneyDetailsLbl";
            JourneyDetailsLbl.Size = new Size(86, 15);
            JourneyDetailsLbl.TabIndex = 15;
            JourneyDetailsLbl.Text = "Journey Details";
            // 
            // grdJourneyDetails
            // 
            grdJourneyDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJourneyDetails.Location = new Point(180, 265);
            grdJourneyDetails.Name = "grdJourneyDetails";
            grdJourneyDetails.Size = new Size(441, 135);
            grdJourneyDetails.TabIndex = 14;
            grdJourneyDetails.CellClick += grdJourneyDetails_CellClick;
            // 
            // grdDrivers
            // 
            grdDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDrivers.Location = new Point(234, 112);
            grdDrivers.Name = "grdDrivers";
            grdDrivers.Size = new Size(313, 132);
            grdDrivers.TabIndex = 27;
            grdDrivers.Visible = false;
            grdDrivers.CellClick += grdDrivers_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(485, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 21);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(345, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 23);
            txtSearch.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 66);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 24;
            label1.Text = "Enter Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 20);
            label5.Name = "label5";
            label5.Size = new Size(230, 15);
            label5.TabIndex = 28;
            label5.Text = "WARNING! This page is for driver use only.";
            // 
            // frmBookingsCalculateCost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(grdDrivers);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(calculateCostBtn);
            Controls.Add(backBtn);
            Controls.Add(JourneyDetailsLbl);
            Controls.Add(grdJourneyDetails);
            Name = "frmBookingsCalculateCost";
            Text = "Calculate Cost";
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateCostBtn;
        private Button backBtn;
        private Label JourneyDetailsLbl;
        private DataGridView grdJourneyDetails;
        private DataGridView grdDrivers;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label5;
    }
}