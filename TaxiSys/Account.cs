using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSys
{
    internal class Account
    {
        private int accountID;
        private string username;
        private string password;
        private string phoneNumber;
        private string emailAddress;
        private char status;

        public Account(int accountID, string username, string password, string emailAddress, string phoneNumber, char status)
        {
            this.accountID = accountID;
            this.username = username;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.status = status;
        }

        public Account() 
        {
            this.accountID = 0;
            this.username = "";
            this.password = "";
            this.phoneNumber = "";
            this.emailAddress = "";
            this.status = 'A';

        }

        public int getAccountID() {  return this.accountID; }
        public string getUsername() { return this.username;}
        public string getPassword() { return this.password;}
        public string getEmailAddress() {  return this.emailAddress;}
        public string getPhoneNumber() { return this.phoneNumber;}
        public char getStatus() { return this.status;}  

        public void setAccountID(int AccountID) {  accountID = AccountID; }
        public void setUsername(string Username) {  username = Username; }
        public void setPassword(string Password) {  password = Password; }
        public void setEmailAddress(string EmailAddress) {  emailAddress = EmailAddress; }
        public void setPhoneNumber(string PhoneNumber) {  phoneNumber = PhoneNumber; }
        public void setStatus(char status) { status = 'A'; }

        public static int getNextAccountId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(AccountID) FROM Accounts";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = Convert.ToInt32(dr.GetString(0)) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public void addAccount()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Accounts Values (" +
                this.accountID + ",'" +
                this.username + "','" +
                this.password + "','" +
                this.emailAddress + "','" +
                this.phoneNumber + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateAccount()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Accounts SET" +
                " username = '" + this.username + "'" +
                ", password = '" + this.password + "'" +
                ", phoneNumber = '" + this.phoneNumber + "'" +
                ", emailAddress = '" + this.emailAddress + "'" +
                " WHERE accountID = '" + this.accountID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public int CheckAccountForDelete()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT COUNT(accountid) as count FROM Bookings" +
               " WHERE accountid = '" + this.accountID + "' AND Status = 'A'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            int count = Convert.ToInt32(dr.GetString(0));

            //Close db connection
            conn.Close();

            return count;
        }

        public void DeleteAccount()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Accounts SET" +
            " AccountStatus = 'I'" +
            " WHERE accountid = '" + this.accountID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public int CheckUniqueUsername(string username) 
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT COUNT (username) FROM Accounts " +
                "WHERE username = '" + username + "'";

            //Execute the SQL query (OracleCommand)

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            int count = Convert.ToInt32(dr.GetString(0));

            //Close db connection
            conn.Close();
            
            return count;
            
        }

        public string CheckStatus(string username)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT accountStatus FROM Accounts " +
                "WHERE username = '" + username + "'";

            //Execute the SQL query (OracleCommand)

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            string status = dr.GetString(0);

            //Close db connection
            conn.Close();

            return status;

        }

        public string ReturnPassword(string username)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Password FROM Accounts " +
                "WHERE username = '" + username + "' AND accountStatus != 'I'";

            //Execute the SQL query (OracleCommand)

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            string password = dr.GetString(0);

            //Close db connection
            conn.Close();

            return password;
        }

        public void GetAccount(string username)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Accounts WHERE username = '" + username + "' AND accountStatus != 'I'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setAccountID(Convert.ToInt32(dr.GetString(0)));
            setUsername(dr.GetString(1));
            setPassword(dr.GetString(2));
            setEmailAddress(dr.GetString(3));
            setPhoneNumber(dr.GetString(4));

            //close DB
            conn.Close();
        }

    }
}
