using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiSys
{
    public partial class frmDriversUpdate : Form
    {

        Driver theDriver = new Driver();

        public frmDriversUpdate()
        {
            InitializeComponent();
            cboModel.Text = "Unselected";

            this.cboMake = Utility.loadMakes(cboMake);

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



        private void carDetailsUpdateMakeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string make = cboMake.Text;
            if (make != "Unselected")
            {
                cboModel.Enabled = true;
                if (make == "Hyundai")
                {
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    cboModel.Items.AddRange(new object[] { "Unselected", "i10", "i20", "i30" });
                }
                else if (make == "Toyota")
                {
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    cboModel.Items.AddRange(new object[] { "Unselected", "Corrolla", "Yaris", "Prius" });
                }
                else if (make == "Renault")
                {
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    cboModel.Items.AddRange(new object[] { "Unselected", "Clio", "Megane" });
                }
                else if (make == "Ford")
                {
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    cboModel.Items.AddRange(new object[] { "Unselected", "Focus", "Fiesta" });
                }
                else if (make == "Honda")
                {
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    cboModel.Items.AddRange(new object[] { "Unselected", "Civic", "Accord", "Type R" });
                }

            }
            else
            {
                cboModel.Enabled = false;
            }
        }

        private void driverDetailsUpdateButton_Click(object sender, EventArgs e)
        {
            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            if (txtLicenseNo.Text.Equals(""))
            {
                MessageBox.Show("Licence Number Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNo.Focus();
                return;
            }
            if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            if (cboMake.Text.Equals(""))
            {
                MessageBox.Show("Make Must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMake.Focus();
                return;
            }
            if (cboModel.Text.Equals(""))
            {
                MessageBox.Show("Model Must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboModel.Focus();
                return;
            }
            if (txtRegNo.Text.Equals(""))
            {
                MessageBox.Show("Registration Number Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();
                return;
            }
            if (cboSeatNo.Text.Equals(""))
            {
                MessageBox.Show("Seat Number Must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSeatNo.Focus();
                return;
            }

            if (txtLicenseNo.Text.Any(char.IsLetter) || txtLicenseNo.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("License Number must only contain digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNo.Focus();
                return;
            }
            if (txtLicenseNo.Text.Length != 9)
            {
                MessageBox.Show("License Number is not 9 digits long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNo.Focus();
                return;

            }
            if (txtPhoneNo.Text.Any(char.IsLetter) || txtPhoneNo.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("Phone Number must only contain digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;

            }
            if (txtPhoneNo.Text.Length != 10)
            {
                MessageBox.Show("Phone Number is not 10 digits long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            if (Driver.testUniqueLicence(txtLicenseNo.Text,theDriver.getDriverID()) > 0)
            {
                MessageBox.Show("License Number is taken!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNo.Focus();
                return;
            }
            if (Driver.testUniquePhone(txtPhoneNo.Text, theDriver.getDriverID()) > 0)
            {
                MessageBox.Show("Phone Number is taken!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }

            char[] reg = txtRegNo.Text.ToCharArray();
            int dashAmount = 0;
            int[] dashes = new int[2];
            String[] counties = { "C", "CE", "CN", "CW", "D", "DL", "G", "KE", "KK", "KY", "L", "LD", "LD", "LH", "LK", "LM", "LS", "MH", "MN", "MO", "OY", "SO", "RN", "TN", "TS", "W", "WD", "WH", "WX", "WW" };
            for (int i = 0; i < txtRegNo.Text.Length; i++)
            {
                if (reg[i] == '-')
                {
                    dashes[dashAmount] = i;
                    dashAmount++;
                }
            }
            if (dashAmount != 2)
            {

                MessageBox.Show("Registration Number must be in a similar format to 11-KY-121 or 181-D-15", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();
                return;

            }
            if (dashes[0] == 2)
            {
                if ((txtRegNo.Text.Substring(0, 2).Any(char.IsLetter) || txtRegNo.Text.Substring(0, 2).Any(char.IsSymbol)))
                {

                    MessageBox.Show("Year not valid", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Focus();
                    return;
                }
                bool countyFound = false;
                string county = txtRegNo.Text.Substring(dashes[0] + 1, dashes[1] - dashes[0] - 1);
                for (int i = 0; i < counties.Length; i++)
                {
                    if (counties[i] == county)
                    {
                        countyFound = true;
                    }
                }
                if (!countyFound)
                {
                    MessageBox.Show("County code not found", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Focus();
                    return;
                }
                if (txtRegNo.Text[dashes[1]..].Any(char.IsLetter) || txtRegNo.Text[dashes[1]..].Any(char.IsSymbol))
                {
                    MessageBox.Show("Characters afer second dash must be digits", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Focus();
                    return;
                }
            }
            else if (dashes[0] == 3)
            {
                if (reg[0] == '1' || reg[0] == '2' && reg[1] >= '0' && reg[1] <= '9' && reg[0] == '1' || reg[0] == '2')
                {
                    bool countyFound = false;
                    string county = txtRegNo.Text.Substring(dashes[0] + 1, dashes[1] - dashes[0] - 1);
                    for (int i = 0; i < counties.Length; i++)
                    {
                        if (counties[i] == county)
                        {
                            countyFound = true;
                        }
                    }
                    if (!countyFound)
                    {
                        MessageBox.Show("County code not found", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRegNo.Focus();
                        return;
                    }
                    if (txtRegNo.Text[dashes[1]..].Any(char.IsLetter) || txtRegNo.Text[dashes[1]..].Any(char.IsSymbol))
                    {
                        MessageBox.Show("Characters afer second dash must be digits", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRegNo.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Year not valid", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Focus();
                    return;

                }
            }

            else
            {
                MessageBox.Show("Registration Number must be in a similar format to 11-KY-121 or 181-D-15", "Registration Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();
                return;

            }

            Driver aDriver = new Driver(theDriver.getDriverID(), txtForename.Text, txtSurname.Text, txtPhoneNo.Text, txtLicenseNo.Text, cboModel.Text, cboMake.Text, txtRegNo.Text, Convert.ToInt32(cboSeatNo.Text), 'A');
            aDriver.updateDriver();

            MessageBox.Show("Driver Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtForename.Clear();
            txtSurname.Clear();
            txtPhoneNo.Clear();
            txtLicenseNo.Clear();
            cboMake.SelectedIndex = -1;
            cboSeatNo.SelectedIndex = -1;
            cboModel.SelectedIndex = -1;
            cboModel.Enabled = false;
            txtRegNo.Clear();
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
