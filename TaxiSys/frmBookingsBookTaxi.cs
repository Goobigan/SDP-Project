using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TaxiSys
{
    public partial class frmBookingsBookTaxi : Form
    {

        Account theAccount = new Account();
        Driver theDriver = new Driver();
        Booking booking = new Booking();

        public frmBookingsBookTaxi()
        {
            InitializeComponent();

            var random = new Random();
            var distances = new int[3];


            for (int i = 0; i <= 2; i++)
            {
                distances[i] = random.Next(20) + 1;
            }
            this.grdDriversDetails.Rows.Clear();


        }





        private void bookTaxiButton_Click(object sender, EventArgs e)
        {
            if (txtDestination.Text == "" || txtPickUp.Text == "")
            {
                MessageBox.Show("Destination and pick-up box must be filled", "Error!");
                return;
            }
            if (!(txtDistance.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("Distance must be in digits. \nSystem will convert to KM", "Error!");
                txtDistance.Focus();
                return;
            }

            if (!(Convert.ToInt32(txtDistance.Text) > 0 && Convert.ToInt32(txtDistance.Text) < 41))
            {
                MessageBox.Show("Distance must be between 1-40 \nSystem will convert to KM", "Sorry!");
                txtPassenger.Focus();
                return;
            }

            DialogResult dialogresult = MessageBox.Show("Are you sure you want to confirm booking?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                theDriver.setStatus('B');
                theDriver.updateDriver();
                int id = Booking.getNextBookingId();
                Booking booking = new Booking(id, theDriver.getDriverID(), theAccount.getAccountID(), DateTime.Now.ToString("dd/MMM/yyyy"), Convert.ToInt32(txtDistance.Text), txtDestination.Text, txtPickUp.Text, Convert.ToInt32(txtPassenger.Text), 0, 'A');
                booking.addBooking();
                MessageBox.Show("Booking Confirmed", "Success");
                this.Close();
                frmHomepage frmHomepage = new frmHomepage();
                frmHomepage.Show();

            }
            else
            {

                txtDestination.Text = "";
                txtDistance.Text = "";
                txtPickUp.Text = "";
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

            if (!(txtPassenger.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("Passengers must be in digits", "Sorry!");
                txtPassenger.Focus();
                return;
            }

            if (!(Convert.ToInt32(txtPassenger.Text) > 0 && Convert.ToInt32(txtPassenger.Text) < 8))
            {
                MessageBox.Show("Passengers must be between 1-7", "Sorry!");
                txtPassenger.Focus();
                return;
            }

            theAccount.GetAccount(txtUsernameSearch.Text);

            Driver.findAllDrivers(Convert.ToInt32(txtPassenger.Text), grdDriversDetails);




            if (!(grdDriversDetails.Rows.Count > 0))
            {
                MessageBox.Show("No Drivers Availabe! \nTry Again Later.", "Error");
                return;
            }

            txtDestination.Text = "";
            txtDistance.Text = "";

            txtPickUp.Text = "";


            grdDriversDetails.Visible = true;
            grdDriversDetails.Enabled = true;

        }

        private void grdDriverDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            journeyDetailsBox.Visible = true;

            txtDestination.Text = "";
            txtDistance.Text = "";

            txtPickUp.Text = "";


            string driverID = grdDriversDetails.Rows[grdDriversDetails.CurrentCell.RowIndex].Cells[0].Value.ToString();

            theDriver.getDriver(driverID);





        }

    }
}
