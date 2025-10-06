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
    public partial class frmDriversDelete : Form
    {
        Driver theDriver = new Driver();

        public frmDriversDelete()
        {
            InitializeComponent();

            this.cboSeatNo.Items.AddRange(new object[]
                {
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                }
            );

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
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

            grdDrivers.Visible = true;



            //Utility.formatDriversGrid(grdDrivers);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (theDriver.CheckDriverForDelete() > 0)
            {
                MessageBox.Show("Driver with active bookings cannot be deleted.\nPlease cancel or complete any bookings before deleting driver.", "Error!");
                return;

            }
            theDriver.DeleteDriver();
            MessageBox.Show("Driver Successfully Deleted", "Success");
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }

        private void grdDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtDriverId.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtLicenseNo.Text = "";
            txtPhoneNo.Text = "";
            cboMake.Text = "";
            cboModel.Text = "";
            txtRegNo.Text = "";
            cboSeatNo.Text = "";

            string driverID = grdDrivers.Rows[grdDrivers.CurrentCell.RowIndex].Cells[0].Value.ToString();

            theDriver.getDriver(driverID);

            txtDriverId.Text = Convert.ToString(theDriver.getDriverID());
            txtForename.Text = theDriver.getForename();
            txtSurname.Text = theDriver.getSurname();
            txtLicenseNo.Text = theDriver.getLicenseNo();
            txtPhoneNo.Text = theDriver.getPhoneNumber();
            cboMake.Text = theDriver.getCarMake();
            cboModel.Text = theDriver.getCarModel();
            txtRegNo.Text = theDriver.getCarRegNo();
            cboSeatNo.Text = Convert.ToString(theDriver.getCarNoSeats());

            driverDetailsGroupBox.Visible = true;
        }

      
    }
}
