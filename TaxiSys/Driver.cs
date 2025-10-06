using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSys
{
    internal class Driver
    {
        private int driverID;
        private string forename;    
        private string surname;
        private string phoneNumber;
        private string licenseNo;
        private string carModel;
        private string carMake;
        private string carRegNo;
        private int carNoSeats;
        private char status;

        public Driver()
        {
            this.driverID = 0;
            this.forename = "";
            this.surname = "";
            this.phoneNumber = "";
            this.licenseNo = "";
            this.carModel = "";
            this.carMake = "";
            this.carRegNo = "";
            this.carNoSeats = 0;
            this.status = 'A';
        }

        public Driver(int driverID, string forename, string surname, string phoneNumber, string licenseNo, string carModel, string carMake, string carRegNo, int carNoSeats, char status)
        {
            this.driverID = driverID;
            this.forename = forename;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.licenseNo = licenseNo;
            this.carModel = carModel;
            this.carMake = carMake;
            this.carRegNo = carRegNo;
            this.carNoSeats = carNoSeats;
            this.status = status;
        }

        public int getDriverID() { return this.driverID; }
        public string getForename() { return this.forename; }
        public string getSurname() {  return this.surname; }
        public string getPhoneNumber() {  return this.phoneNumber; }
        public string getLicenseNo() {  return this.licenseNo; }
        public string getCarModel() { return this.carModel; }
        public string getCarMake() {  return this.carMake; }
        public string getCarRegNo() {  return this.carRegNo; }
        public int getCarNoSeats() {  return this.carNoSeats; }
        public char getStatus() { return this.status; } 


        public void setDriverID(int DriverID) { driverID = DriverID; }
        public void setForename(string Forename) { forename = Forename; }
        public void setSurname(string Surname) { surname = Surname; }
        public void setPhoneNumber(string PhoneNumber) { phoneNumber = PhoneNumber; }
        public void setLicenseNo(string LicenseNo) { licenseNo = LicenseNo; }
        public void setCarModel(string CarModel) { carModel = CarModel; }
        public void setCarMake(string CarMake) { carMake = CarMake; }
        public void setCarRegNo(string CarRegNo) { carRegNo = CarRegNo; }
        public void setCarNoSeats(int CarNoSeats) { carNoSeats = CarNoSeats; }
        public void setStatus(char Status) { status = Status; }


        public static int getNextDriverId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT COUNT(DriverID) FROM Drivers";

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

        public void addDriver()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Drivers Values (" +
                this.driverID + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.phoneNumber + "','" +
                this.licenseNo + "','" +
                this.carMake + "','" +
                this.carModel + "','" +
                this.carRegNo + "'," +
                this.carNoSeats + ",'" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateDriver()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Drivers SET" +
                " forename = '" + this.forename + "'" +
                ", surname = '" + this.surname + "'" +
                ", phoneNumber = '" + this.phoneNumber + "'" +
                ", licenseNo = '" + this.licenseNo + "'" +
                ", carModel = '" + this.carModel + "'" +
                ", carMake = '" + this.carMake + "'" +
                ", carRegNo = '" + this.carRegNo + "'" +
                ", carNoSeats = '" + this.carNoSeats + "'" +
                ", driverStatus = '" +this.status + "'" +
                " WHERE driverID = '" + this.driverID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public int CheckDriverForDelete()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT COUNT(driverID) as count FROM Bookings" +
               " WHERE driverID = '" + this.driverID + "' AND Status = 'A'";

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

        public void DeleteDriver()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Drivers SET" +
                " DriverStatus = 'I'" +
                " WHERE driverID = '" + this.driverID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet getAllDrivers()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Drivers WHERE DriverStatus != 'I' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getDriver(string driverID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Drivers WHERE driverID = " + driverID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setDriverID(Convert.ToInt32(dr.GetString(0)));
            setForename(dr.GetString(1));
            setSurname(dr.GetString(2));
            setPhoneNumber(dr.GetString(3));
            setLicenseNo(dr.GetString(4));
            setCarMake(dr.GetString(5));
            setCarModel(dr.GetString(6));
            setCarRegNo(dr.GetString(7));
            setCarNoSeats(dr.GetInt32(8));
            
            //close DB
            conn.Close();
        }


        public static void findDrivers(String driverName, DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT DriverId, forename, Surname FROM Drivers " +
                "WHERE surname LIKE '%" + driverName + "%' AND DriverStatus != 'I' ORDER BY surname,forename";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
           
            //Close db connection
            

            dg.Columns.Clear();
            dg.Columns.Add("DriverID", "ID");
            dg.Columns.Add("forename", "Forename");
            dg.Columns.Add("surname", "Surname");

            dg.Rows.Clear();
            while (dr.Read())
            {
                dg.Rows.Add(dr["DriverID"], dr["forename"], dr["surname"]);

            }
            conn.Close();
        }

        public static void findAllDrivers(int passengers,DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Drivers WHERE DriverStatus != 'I' AND carNoSeats >= "+passengers+" ORDER BY Surname";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            //Close db connection


            dg.Columns.Clear();
            dg.Columns.Add("driverid", "ID");
            dg.Columns.Add("forename", "Forename");
            dg.Columns.Add("surname", "Surname");
            dg.Columns.Add("phoneNumber", "Phone Number");
            dg.Columns.Add("carMake", "Car Make");
            dg.Columns.Add("carModel", "Car Model");
            dg.Columns.Add("carNoSeats","No. Seats");


            dg.Rows.Clear();
            while (dr.Read())
            {
                dg.Rows.Add(dr["driverid"], dr["forename"], dr["surname"], dr["phoneNumber"], dr["carMake"], dr["carModel"], dr["carNoSeats"]);

            }
            conn.Close();
        }

        public static DataSet getMakes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);


            String sqlQuery = "Select DISTINCT Makes FROM MakesModels ORDER BY Makes";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Makes");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getModels(String make)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "Select models FROM MakesModels " +
                "WHERE Makes = '"+make+ "' ORDER BY Models";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Models");

            conn.Close();

            return ds;
        }

        public static int testUniqueLicence(string licenseNo,int driverID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery;
            if (driverID != 0)
            {
                sqlQuery = "Select Count(phoneNumber) FROM Drivers " +
                "WHERE licenseNo = '" + licenseNo + "' AND driverID != '" + driverID + "'";
            }
            else
            {
                sqlQuery = "Select Count(phoneNumber) FROM Drivers " +
                "WHERE licenseNo = '" + licenseNo + "'";
            }

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?

            dr.Read();
            int count=Convert.ToInt32(dr.GetString(0));

            conn.Close();

            return count;

        }

        public static int testUniquePhone(string phoneNo,int driverID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery;
            if (driverID !=0) 
            {
                sqlQuery = "Select Count(phoneNumber) FROM Drivers " +
                "WHERE phoneNumber = '" + phoneNo + "' AND driverID != '"+driverID+"'";
            }
            else
            {
                sqlQuery = "Select Count(phoneNumber) FROM Drivers " +
                "WHERE phoneNumber = '" + phoneNo + "'";
            }
            

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?

            dr.Read();
            int count = Convert.ToInt32(dr.GetString(0));

            conn.Close();

            return count;
        }
    }
}
