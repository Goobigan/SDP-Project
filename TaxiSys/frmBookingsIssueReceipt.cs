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
    public partial class frmBookingsIssueReceipt : Form
    {
        Booking theBooking = new Booking();
        Account theAccount = new Account();
        Driver theDriver = new Driver();    
        public frmBookingsIssueReceipt()
        {
            InitializeComponent();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }

        private void issueReceiptBtn_Click(object sender, EventArgs e)
        {
            theDriver.getDriver(Convert.ToString(theBooking.getDriverID()));
            MessageBox.Show(theBooking.getDate()+"\nDriver Name: "+theDriver.getForename()+" "+theDriver.getSurname()+"\nPick-Up Location: "+theBooking.getPickUp()+"\nDestination: "+theBooking.getDestination()+"\nDistance: " + theBooking.getDistance() + "\nPassengers: " + theBooking.getPassengers() + "\nTotal cost: €" + theBooking.getCost(),"RECEIPT");
            grdJourneyDetails.Visible = false;
            issueReceiptBtn.Enabled = false;
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {

            Account account = new Account();
            int count = account.CheckUniqueUsername(txtUsernameSearch.Text);

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
            if (account.CheckStatus(txtUsernameSearch.Text) != "A")
            {
                MessageBox.Show("Username not found.", "Sorry!");
                txtUsernameSearch.Focus();
                return;
            }

            if (txtPasswordSearch.Text != account.ReturnPassword(txtUsernameSearch.Text))
            {
                MessageBox.Show("Username and password do not match.", "Sorry!");
                txtPasswordSearch.Focus();
                return;
            }

            theAccount.GetAccount(txtUsernameSearch.Text);


            txtPasswordSearch.Text = "";
            txtUsernameSearch.Text = "";

            grdJourneyDetails.Columns.Clear();
            Booking.getAllBookings(theAccount.getAccountID(), grdJourneyDetails);

            grdJourneyDetails.Visible = true;
            issueReceiptBtn.Enabled = false;
        }

        private void grdJourneyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            theBooking.getBooking(Convert.ToInt32(grdJourneyDetails.Rows[grdJourneyDetails.CurrentCell.RowIndex].Cells[0].Value));
            issueReceiptBtn.Enabled = true;
        }
    }
}
