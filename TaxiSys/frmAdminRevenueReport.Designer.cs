namespace TaxiSys
{
    partial class frmAdminRevenueReport
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
            grdRevenueReport = new DataGridView();
            cboReportChoice = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grdRevenueReport).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 20;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // grdRevenueReport
            // 
            grdRevenueReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRevenueReport.Location = new Point(223, 53);
            grdRevenueReport.Name = "grdRevenueReport";
            grdRevenueReport.Size = new Size(537, 385);
            grdRevenueReport.TabIndex = 18;
            // 
            // cboReportChoice
            // 
            cboReportChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportChoice.FormattingEnabled = true;
            cboReportChoice.Location = new Point(96, 119);
            cboReportChoice.Name = "cboReportChoice";
            cboReportChoice.Size = new Size(121, 23);
            cboReportChoice.TabIndex = 21;
            cboReportChoice.SelectedIndexChanged += cboReportChoice_SelectedIndexChanged;
            // 
            // frmAdminRevenueReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboReportChoice);
            Controls.Add(backBtn);
            Controls.Add(grdRevenueReport);
            Name = "frmAdminRevenueReport";
            Text = "Revenue Report";
            ((System.ComponentModel.ISupportInitialize)grdRevenueReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button backBtn;
        private DataGridView grdRevenueReport;
        private ComboBox cboReportChoice;
    }
}