using Oracle.ManagedDataAccess.Client;
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
    public partial class frmHomepage : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oraDB);
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mnuDriversHomepage_Click(object sender, EventArgs e)
        {
        }

        private void mnuAddDriverHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDriversAdd frmDriversAdd = new frmDriversAdd();
            frmDriversAdd.Show();
        }

        private void mnuUpdateDriverHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDriversUpdate frmDriversUpdate = new frmDriversUpdate();
            frmDriversUpdate.Show();
        }

        private void mnuDeleteDriverHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDriversDelete frmDriversDelete = new frmDriversDelete();
            frmDriversDelete.Show();
        }

        private void mnuAccountsHomepage_Click(object sender, EventArgs e)
        {
        }

        private void mnuAddAccountHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountsOpen frmAccountsOpen = new frmAccountsOpen();
            frmAccountsOpen.Show();
        }

        private void mnuUpdateAccountHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountsUpdate frmAccountsUpdate = new frmAccountsUpdate();
            frmAccountsUpdate.Show();
        }

        private void mnuBookTaxiHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingsBookTaxi frmBookingsBookTaxi = new frmBookingsBookTaxi();
            frmBookingsBookTaxi.Show();
        }

        private void mnuCancelTaxiHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingsCancelTaxi frmBookingsCancelTaxi = new frmBookingsCancelTaxi();
            frmBookingsCancelTaxi.Show();
        }

        private void mnuCalculateTaxiHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingsConcludeJourney frmBookingsConcludeJourney = new frmBookingsConcludeJourney();
            frmBookingsConcludeJourney.Show();
        }

        private void mnuIssueReceiptHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingsIssueReceipt frmBookingsIssueReceipt = new frmBookingsIssueReceipt();
            frmBookingsIssueReceipt.Show();
        }

        private void mnuRevenueReportHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminRevenueReport frmAdminRevenueReport = new frmAdminRevenueReport();
            frmAdminRevenueReport.Show();
        }

        private void mnuDeleteAccountHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountsDelete frmAccountsDelete = new frmAccountsDelete();
            frmAccountsDelete.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                lblStatus.Text = "CLOSED";
                lblStatus.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                conn.Open();
                lblStatus.Text = "OPEN";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
