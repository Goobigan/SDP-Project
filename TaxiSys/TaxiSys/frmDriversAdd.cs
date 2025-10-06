using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TaxiSys
{
    public partial class frmDriversAdd : Form
    {
        public frmDriversAdd()
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


        private void driverDetailsSubmitButton_Click(object sender, EventArgs e)
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
            if (txtLicenceNo.Text.Equals(""))
            {
                MessageBox.Show("Licence Number Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenceNo.Focus();
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

            if (txtLicenceNo.Text.Any(char.IsLetter) || txtLicenceNo.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("License Number must only contain digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenceNo.Focus();
                return;
            }
            if (txtLicenceNo.Text.Length != 9)
            {
                MessageBox.Show("License Number is not 9 digits long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenceNo.Focus();
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
            if (Driver.testUniqueLicence(txtLicenceNo.Text,0) > 0)
            {
                MessageBox.Show("License Number is taken!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenceNo.Focus();
                return;
            }
            if (Driver.testUniquePhone(txtPhoneNo.Text, 0) > 0)
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



            //save data in dtabase
            int driverID = Driver.getNextDriverId();
            Driver aDriver = new Driver(driverID, txtForename.Text, txtSurname.Text, txtPhoneNo.Text, txtLicenceNo.Text , cboModel.Text, cboMake.Text, txtRegNo.Text, Convert.ToInt32(cboSeatNo.Text), 'A');
            aDriver.addDriver();

            MessageBox.Show("Driver Successfully Added!\nYour ID is " + driverID, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtForename.Clear();
            txtSurname.Clear();
            txtPhoneNo.Clear();
            txtLicenceNo.Clear();
            cboMake.SelectedIndex = -1;
            cboSeatNo.SelectedIndex=-1;
            cboModel.SelectedIndex = -1;
            cboModel.Enabled = false;
            txtRegNo.Clear();
        }







        private void carDetailsMakeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string make = cboMake.Text;
            if (make != "Unselected" && make !="")
            {
                cboModel.Enabled = true;
                
                    cboModel.Items.Clear();
                    cboModel.Text = "Unselected";
                    this.cboModel = Utility.loadModels(cboModel, make);

            }
            else
            {
                cboModel.Enabled = false;
                cboModel.Items.Clear();
                cboModel.Text = "Unselected";
            }
        }
    }
}
