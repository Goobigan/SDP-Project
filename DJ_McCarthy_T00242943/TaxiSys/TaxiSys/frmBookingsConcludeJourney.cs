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
    public partial class frmBookingsConcludeJourney : Form
    {

        Driver theDriver = new Driver();
        Booking theBooking = new Booking();

        public frmBookingsConcludeJourney()
        {

            InitializeComponent();

            var random = new Random();
            var distance = new double();
            distance = random.Next(20) + 1;

            this.grdJourneyDetails.Rows.Clear();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }

        private void calculateCostBtn_Click(object sender, EventArgs e)
        {
            
            
            double cost=Math.Round(1.5 * theBooking.getDistance() * (1 + (theBooking.getPassengers() / 10)),2);
            theBooking.setCost(cost);

            theDriver.setStatus('A');
            theDriver.updateDriver();
            theBooking.updateBooking();
            string totalCost = cost.ToString();
            MessageBox.Show("Distance: "+theBooking.getDistance()+"\nPassengers: " + theBooking.getPassengers() + "\nTotal cost: €" + totalCost,"Journey Concluded.");
            grdJourneyDetails.Visible = false;
            txtSearch.Text = "";
            calculateCostBtn.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check surname or part of is entered
            if (txtSearch.Text == "")
            {
                MessageBox.Show("No text entered!", "Error");
                return;
            }

            //call the method to retrieve the matching drivers
            Driver.findDrivers(txtSearch.Text, grdDrivers);

            if (!(grdDrivers.Rows.Count > 0))
            {
                MessageBox.Show("No Drivers Found!", "Error");
                return;
            }

            Utility.formatDriversGrid(grdDrivers);

            grdDrivers.Visible = true;




        }



        private void grdDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            string driverID = grdDrivers.Rows[grdDrivers.CurrentCell.RowIndex].Cells[0].Value.ToString();

            theDriver.getDriver(driverID);


            Booking.findBookingDriver(Convert.ToInt32(driverID), grdJourneyDetails);
            grdJourneyDetails.Visible = true;
            calculateCostBtn.Enabled = false;
        }

        private void grdJourneyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            theBooking.getBooking(Convert.ToInt32(grdJourneyDetails.Rows[grdJourneyDetails.CurrentCell.RowIndex].Cells[0].Value));
            calculateCostBtn.Enabled = true;
            calculateCostBtn.Visible = true;
        }
    }
}
