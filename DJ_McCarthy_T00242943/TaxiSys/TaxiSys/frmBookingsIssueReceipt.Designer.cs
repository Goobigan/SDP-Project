namespace TaxiSys
{
    partial class frmBookingsIssueReceipt
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
            issueReceiptBtn = new Button();
            journeyDetailsLbl = new Label();
            grdJourneyDetails = new DataGridView();
            btnSelect = new Button();
            txtPasswordSearch = new TextBox();
            txtUsernameSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 18;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // issueReceiptBtn
            // 
            issueReceiptBtn.Enabled = false;
            issueReceiptBtn.Location = new Point(335, 392);
            issueReceiptBtn.Name = "issueReceiptBtn";
            issueReceiptBtn.Size = new Size(75, 23);
            issueReceiptBtn.TabIndex = 17;
            issueReceiptBtn.Text = "Issue Receipt";
            issueReceiptBtn.UseVisualStyleBackColor = true;
            issueReceiptBtn.Click += issueReceiptBtn_Click;
            // 
            // journeyDetailsLbl
            // 
            journeyDetailsLbl.AutoSize = true;
            journeyDetailsLbl.Location = new Point(80, 138);
            journeyDetailsLbl.Name = "journeyDetailsLbl";
            journeyDetailsLbl.Size = new Size(86, 15);
            journeyDetailsLbl.TabIndex = 13;
            journeyDetailsLbl.Text = "Journey Details";
            // 
            // grdJourneyDetails
            // 
            grdJourneyDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJourneyDetails.Location = new Point(57, 168);
            grdJourneyDetails.Name = "grdJourneyDetails";
            grdJourneyDetails.Size = new Size(639, 209);
            grdJourneyDetails.TabIndex = 12;
            grdJourneyDetails.Visible = false;
            grdJourneyDetails.CellClick += grdJourneyDetails_CellClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(340, 128);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 28;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtPasswordSearch
            // 
            txtPasswordSearch.Location = new Point(310, 81);
            txtPasswordSearch.Name = "txtPasswordSearch";
            txtPasswordSearch.PasswordChar = '*';
            txtPasswordSearch.Size = new Size(155, 23);
            txtPasswordSearch.TabIndex = 27;
            // 
            // txtUsernameSearch
            // 
            txtUsernameSearch.Location = new Point(310, 53);
            txtUsernameSearch.Name = "txtUsernameSearch";
            txtUsernameSearch.Size = new Size(155, 23);
            txtUsernameSearch.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 56);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 24;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 84);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 26;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 16);
            label5.Name = "label5";
            label5.Size = new Size(230, 15);
            label5.TabIndex = 29;
            label5.Text = "WARNING! This page is for driver use only.";
            // 
            // frmBookingsIssueReceipt
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
            Controls.Add(backBtn);
            Controls.Add(issueReceiptBtn);
            Controls.Add(journeyDetailsLbl);
            Controls.Add(grdJourneyDetails);
            Name = "frmBookingsIssueReceipt";
            Text = "Issue Receipt";
            ((System.ComponentModel.ISupportInitialize)grdJourneyDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button issueReceiptBtn;
        private Label journeyDetailsLbl;
        private DataGridView grdJourneyDetails;
        private Button btnSelect;
        private TextBox txtPasswordSearch;
        private TextBox txtUsernameSearch;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}