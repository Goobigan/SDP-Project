namespace TaxiSys
{
    partial class frmHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomepage));
            headingLblHomepage = new Label();
            mnuHomepage = new MenuStrip();
            mnuDriversHomepage = new ToolStripMenuItem();
            mnuAddDriverHomepage = new ToolStripMenuItem();
            mnuUpdateDriverHomepage = new ToolStripMenuItem();
            mnuDeleteDriverHomepage = new ToolStripMenuItem();
            mnuAccountsHomepage = new ToolStripMenuItem();
            mnuAddAccountHomepage = new ToolStripMenuItem();
            mnuUpdateAccountHomepage = new ToolStripMenuItem();
            mnuDeleteAccountHomepage = new ToolStripMenuItem();
            mnuBookingsHomepage = new ToolStripMenuItem();
            mnuBookTaxiHomepage = new ToolStripMenuItem();
            mnuCancelTaxiHomepage = new ToolStripMenuItem();
            mnuCalculateTaxiHomepage = new ToolStripMenuItem();
            mnuIssueReceiptHomepage = new ToolStripMenuItem();
            mnuAdminHomepage = new ToolStripMenuItem();
            mnuRevenueReportHomepage = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnConnect = new Button();
            lblStatus = new Label();
            mnuHomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headingLblHomepage
            // 
            headingLblHomepage.AutoSize = true;
            headingLblHomepage.Font = new Font("Segoe UI", 20F);
            headingLblHomepage.Location = new Point(341, 50);
            headingLblHomepage.Name = "headingLblHomepage";
            headingLblHomepage.Size = new Size(94, 37);
            headingLblHomepage.TabIndex = 4;
            headingLblHomepage.Text = "TaxiCo";
            headingLblHomepage.Click += label1_Click;
            // 
            // mnuHomepage
            // 
            mnuHomepage.Items.AddRange(new ToolStripItem[] { mnuDriversHomepage, mnuAccountsHomepage, mnuBookingsHomepage, mnuAdminHomepage });
            mnuHomepage.Location = new Point(0, 0);
            mnuHomepage.Name = "mnuHomepage";
            mnuHomepage.Size = new Size(800, 24);
            mnuHomepage.TabIndex = 5;
            mnuHomepage.Text = "menuStrip1";
            // 
            // mnuDriversHomepage
            // 
            mnuDriversHomepage.DropDownItems.AddRange(new ToolStripItem[] { mnuAddDriverHomepage, mnuUpdateDriverHomepage, mnuDeleteDriverHomepage });
            mnuDriversHomepage.Name = "mnuDriversHomepage";
            mnuDriversHomepage.Size = new Size(55, 20);
            mnuDriversHomepage.Text = "Drivers";
            mnuDriversHomepage.Click += mnuDriversHomepage_Click;
            // 
            // mnuAddDriverHomepage
            // 
            mnuAddDriverHomepage.Name = "mnuAddDriverHomepage";
            mnuAddDriverHomepage.Size = new Size(146, 22);
            mnuAddDriverHomepage.Text = "Add Driver";
            mnuAddDriverHomepage.Click += mnuAddDriverHomepage_Click;
            // 
            // mnuUpdateDriverHomepage
            // 
            mnuUpdateDriverHomepage.Name = "mnuUpdateDriverHomepage";
            mnuUpdateDriverHomepage.Size = new Size(146, 22);
            mnuUpdateDriverHomepage.Text = "Update Driver";
            mnuUpdateDriverHomepage.Click += mnuUpdateDriverHomepage_Click;
            // 
            // mnuDeleteDriverHomepage
            // 
            mnuDeleteDriverHomepage.Name = "mnuDeleteDriverHomepage";
            mnuDeleteDriverHomepage.Size = new Size(146, 22);
            mnuDeleteDriverHomepage.Text = "Delete Driver";
            mnuDeleteDriverHomepage.Click += mnuDeleteDriverHomepage_Click;
            // 
            // mnuAccountsHomepage
            // 
            mnuAccountsHomepage.DropDownItems.AddRange(new ToolStripItem[] { mnuAddAccountHomepage, mnuUpdateAccountHomepage, mnuDeleteAccountHomepage });
            mnuAccountsHomepage.Name = "mnuAccountsHomepage";
            mnuAccountsHomepage.Size = new Size(69, 20);
            mnuAccountsHomepage.Text = "Accounts";
            mnuAccountsHomepage.Click += mnuAccountsHomepage_Click;
            // 
            // mnuAddAccountHomepage
            // 
            mnuAddAccountHomepage.Name = "mnuAddAccountHomepage";
            mnuAddAccountHomepage.Size = new Size(160, 22);
            mnuAddAccountHomepage.Text = "Add Account";
            mnuAddAccountHomepage.Click += mnuAddAccountHomepage_Click;
            // 
            // mnuUpdateAccountHomepage
            // 
            mnuUpdateAccountHomepage.Name = "mnuUpdateAccountHomepage";
            mnuUpdateAccountHomepage.Size = new Size(160, 22);
            mnuUpdateAccountHomepage.Text = "Update Account";
            mnuUpdateAccountHomepage.Click += mnuUpdateAccountHomepage_Click;
            // 
            // mnuDeleteAccountHomepage
            // 
            mnuDeleteAccountHomepage.Name = "mnuDeleteAccountHomepage";
            mnuDeleteAccountHomepage.Size = new Size(160, 22);
            mnuDeleteAccountHomepage.Text = "Delete Account";
            mnuDeleteAccountHomepage.Click += mnuDeleteAccountHomepage_Click;
            // 
            // mnuBookingsHomepage
            // 
            mnuBookingsHomepage.DropDownItems.AddRange(new ToolStripItem[] { mnuBookTaxiHomepage, mnuCancelTaxiHomepage, mnuCalculateTaxiHomepage, mnuIssueReceiptHomepage });
            mnuBookingsHomepage.Name = "mnuBookingsHomepage";
            mnuBookingsHomepage.Size = new Size(68, 20);
            mnuBookingsHomepage.Text = "Bookings";
            // 
            // mnuBookTaxiHomepage
            // 
            mnuBookTaxiHomepage.Name = "mnuBookTaxiHomepage";
            mnuBookTaxiHomepage.Size = new Size(180, 22);
            mnuBookTaxiHomepage.Text = "Book Taxi";
            mnuBookTaxiHomepage.Click += mnuBookTaxiHomepage_Click;
            // 
            // mnuCancelTaxiHomepage
            // 
            mnuCancelTaxiHomepage.Name = "mnuCancelTaxiHomepage";
            mnuCancelTaxiHomepage.Size = new Size(180, 22);
            mnuCancelTaxiHomepage.Text = "Cancel Taxi";
            mnuCancelTaxiHomepage.Click += mnuCancelTaxiHomepage_Click;
            // 
            // mnuCalculateTaxiHomepage
            // 
            mnuCalculateTaxiHomepage.Name = "mnuCalculateTaxiHomepage";
            mnuCalculateTaxiHomepage.Size = new Size(180, 22);
            mnuCalculateTaxiHomepage.Text = "Conclude Journey";
            mnuCalculateTaxiHomepage.Click += mnuCalculateTaxiHomepage_Click;
            // 
            // mnuIssueReceiptHomepage
            // 
            mnuIssueReceiptHomepage.Name = "mnuIssueReceiptHomepage";
            mnuIssueReceiptHomepage.Size = new Size(180, 22);
            mnuIssueReceiptHomepage.Text = "Issue Receipt";
            mnuIssueReceiptHomepage.Click += mnuIssueReceiptHomepage_Click;
            // 
            // mnuAdminHomepage
            // 
            mnuAdminHomepage.DropDownItems.AddRange(new ToolStripItem[] { mnuRevenueReportHomepage });
            mnuAdminHomepage.Name = "mnuAdminHomepage";
            mnuAdminHomepage.Size = new Size(55, 20);
            mnuAdminHomepage.Text = "Admin";
            // 
            // mnuRevenueReportHomepage
            // 
            mnuRevenueReportHomepage.Name = "mnuRevenueReportHomepage";
            mnuRevenueReportHomepage.Size = new Size(157, 22);
            mnuRevenueReportHomepage.Text = "Revenue Report";
            mnuRevenueReportHomepage.Click += mnuRevenueReportHomepage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 348);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(312, 221);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(160, 33);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect/Disconnect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Location = new Point(367, 319);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Closed";
            // 
            // frmHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnConnect);
            Controls.Add(headingLblHomepage);
            Controls.Add(mnuHomepage);
            Controls.Add(pictureBox1);
            MainMenuStrip = mnuHomepage;
            Name = "frmHomepage";
            Text = "Home";
            Load += frmHomepage_Load;
            mnuHomepage.ResumeLayout(false);
            mnuHomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label headingLblHomepage;
        private MenuStrip mnuHomepage;
        private ToolStripMenuItem mnuDriversHomepage;
        private ToolStripMenuItem mnuAccountsHomepage;
        private ToolStripMenuItem mnuBookingsHomepage;
        private ToolStripMenuItem mnuAdminHomepage;
        private ToolStripMenuItem mnuAddDriverHomepage;
        private ToolStripMenuItem mnuUpdateDriverHomepage;
        private ToolStripMenuItem mnuDeleteDriverHomepage;
        private ToolStripMenuItem mnuAddAccountHomepage;
        private ToolStripMenuItem mnuUpdateAccountHomepage;
        private ToolStripMenuItem mnuDeleteAccountHomepage;
        private ToolStripMenuItem mnuBookTaxiHomepage;
        private ToolStripMenuItem mnuCancelTaxiHomepage;
        private ToolStripMenuItem mnuCalculateTaxiHomepage;
        private ToolStripMenuItem mnuIssueReceiptHomepage;
        private ToolStripMenuItem mnuRevenueReportHomepage;
        private PictureBox pictureBox1;
        private Button btnConnect;
        private Label lblStatus;
    }
}