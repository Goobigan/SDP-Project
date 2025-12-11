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
    public partial class frmBookingsCancelTaxi : Form
    {

        Account theAccount = new Account();
        Booking theBooking = new Booking();
        Driver theDriver = new Driver();
        public frmBookingsCancelTaxi()
        {
            InitializeComponent();

        }

        private void cancelTaxiBtn_Click(object sender, EventArgs e)
        {
            if (theBooking == null)
            {
                MessageBox.Show("Please select a booking!", "Error");
                btnCancelTaxi.Enabled = false;
                return;
            }

            DialogResult dialogresult = MessageBox.Show("Are you sure you want to cancel booking?", "Confirm", MessageBoxButtons.OKCancel);
            if (dialogresult == DialogResult.OK)
            {

                theDriver.getDriver(theBooking.getDriverID().ToString());
                theDriver.setStatus('A');
                theDriver.updateDriver();
                Booking.cancelBooking(theBooking.getBookingID());
                MessageBox.Show("Booking Cancelled", "Success");
                this.Close();
                frmBookingsCancelTaxi frmBookingsCancelTaxi = new frmBookingsCancelTaxi();
                frmBookingsCancelTaxi.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            int count = theAccount.CheckUniqueUsername(txtUsernameSearch.Text);

            if (txtPasswordSearch.Text == "" || txtUsernameSearch.Text == "")
            {
                MessageBox.Show("No text entered!", "Error");
                return;
            }

            if (count != 1)
            {
                MessageBox.Show("Username not found.", "Sorry!");
                txtUsernameSearch.Focus();
                return;
            }
            if (theAccount.CheckStatus(txtUsernameSearch.Text) != "A")
            {
                MessageBox.Show("Username not found.", "Sorry!");
                txtUsernameSearch.Focus();
                return;
            }

            if (txtPasswordSearch.Text != theAccount.ReturnPassword(txtUsernameSearch.Text))
            {
                MessageBox.Show("Username and password do not match.", "Sorry!");
                txtPasswordSearch.Focus();
                return;
            }



            theAccount.GetAccount(txtUsernameSearch.Text);

            Booking.findBookingAccount(theAccount.getAccountID(), grdJourneyDetails);




            if (!(grdJourneyDetails.Rows.Count > 0))
            {
                MessageBox.Show("No bookings active!", "Error");
                return;
            }



            grdJourneyDetails.Visible = true;
            grdJourneyDetails.Enabled = true;
            btnCancelTaxi.Enabled = false;

        }

        private void grdJourneyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            string bookingID = grdJourneyDetails.Rows[grdJourneyDetails.CurrentCell.RowIndex].Cells[0].Value.ToString();

            theBooking.getBooking(Convert.ToInt32(bookingID));
            btnCancelTaxi.Enabled = true;

        }
    }
}
