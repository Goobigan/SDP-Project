using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiSys
{
    public partial class frmAdminRevenueReport : Form
    {
        public frmAdminRevenueReport()
        {
            InitializeComponent();
            
            this.cboReportChoice.Items.AddRange(new object[]
                {
                    "Revenue By Month",
                    "Revenue By Driver"
                }
            );
            
            this.grdRevenueReport.Columns.Clear();
            

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }


        private void cboReportChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdRevenueReport.Columns.Clear();

            if (cboReportChoice.Text == "Revenue By Month")
            {
                Report.monthlyRevenue(grdRevenueReport);
            }else if (cboReportChoice.Text == "Revenue By Driver")
            {
                Report.driverRevenue(grdRevenueReport);
            }
        }
    }
}
