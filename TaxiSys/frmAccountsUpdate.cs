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
    public partial class frmAccountsUpdate : Form
    {
        Account theAccount=new Account();
        public frmAccountsUpdate()
        {
            InitializeComponent();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
        }



        private void accountUpdateBtn_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtEmail.Text.Equals("") || txtPhone.Text.Equals(""))
            {
                MessageBox.Show("All textboxes must contain valid data", "Error!");
                return;
            }

            if (txtPhone.Text.Any(char.IsLetter) || txtPhone.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("Phone Number must only contain digits", "Error!");
                txtPhone.Focus();
                return;
            }

            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone Number is not 10 digits long", "Error!");
                txtPhone.Focus();
                return;
            }

            if (!(txtPassword.Text.Length >= 8 && txtPassword.Text.Any(char.IsLetter) && (txtPassword.Text.Any(char.IsSymbol) || txtPassword.Text.Any(char.IsPunctuation)) && txtPassword.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("Password must contain at least 8 characters, including at least one letter, one number and one symbol", "Error!");
                txtPassword.Focus();
                return;
            }

            if (!txtEmail.Text.EndsWith(".ie") && !txtEmail.Text.EndsWith(".com") && !txtEmail.Text.EndsWith(".net"))
            {
                MessageBox.Show("Email address must end in .ie,.com or .net", "Error!");
                txtEmail.Focus();
                return;
            }


            char[] emails = txtEmail.Text.ToCharArray();
            int atCount = 0;
            int at;
            for (int i = 0; i < txtEmail.Text.Length; i++)
            {
                if (emails[i] == '@')
                {
                    at = i;
                    atCount++;
                }
            }
            if (atCount != 1)
            {
                MessageBox.Show("There must be 1 @ symbol in email address", "Error!");
                txtEmail.Focus();
                return;

            }


            Account account = new Account();
            int count = account.CheckUniqueUsername(txtUsername.Text);
            if (count > 0 && txtUsername.Text!=theAccount.getUsername())
            {
                MessageBox.Show("Username already taken", "Sorry!");
                txtUsername.Focus();
                return;
            }

            
            Account updatedAccount = new Account(theAccount.getAccountID(), txtUsername.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text, 'A');
            updatedAccount.updateAccount();
            MessageBox.Show("Account Successfully Updated", "Success!");
            this.Close();
            frmHomepage frmHomepage = new frmHomepage();
            frmHomepage.Show();
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

            if (count !=1)
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

            txtID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPasswordSearch.Text = "";
            txtUsernameSearch.Text = "";

            txtID.Text = Convert.ToString(theAccount.getAccountID());
            txtUsername.Text = theAccount.getUsername();
            txtPassword.Text = theAccount.getPassword();
            txtEmail.Text = theAccount.getEmailAddress();
            txtPhone.Text = theAccount.getPhoneNumber();

            accountDetailsGroupBox.Visible = true;

        }
    }
}
