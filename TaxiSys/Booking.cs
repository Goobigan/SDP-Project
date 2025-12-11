using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSys
{
    internal class Booking
    {
        private int bookingID;
        private int driverID;
        private int accountID;
        private string date;
        private int distance;
        private string destination;
        private string pickUp;
        private int passengers;
        private double cost;
        private char status;

        public Booking(int bookingID, int driverID, int accountID, string date, int distance, string destination, string pickUp, int passengers, double cost, char status)
        {
            this.bookingID = bookingID;
            this.driverID = driverID;
            this.accountID = accountID;
            this.date = date;
            this.distance = distance;
            this.destination = destination;
            this.pickUp = pickUp;
            this.passengers = passengers;
            this.cost = cost;
            this.status = status;
        }

        public Booking()
        {
            this.bookingID = 0;
            this.driverID = 0;
            this.accountID = 0;
            this.date = "";
            this.distance = 0;
            this.destination = "";
            this.pickUp = "";
            this.passengers = 0;
            this.cost = 0;
            this.status = 'A';
        }

        public int getBookingID() {  return this.bookingID; }
        public int getDriverID() {  return this.driverID; }
        public int getAccountID() { return this.accountID; }
        public string getDate() { return this.date; }
        public int getDistance() { return this.distance;}
        public string getDestination() { return this.destination;}
        public string getPickUp() {  return this.pickUp;}
        public int getPassengers() {  return this.passengers;}
        public double getCost() { return this.cost;}
        public int getStatus() { return this.status;}

        public void setBookingID(int BookingID) { bookingID = BookingID; }
        public void setDriverID(int DriverID) {  driverID = DriverID; }
        public void setAccountID(int AccountID) {  accountID = AccountID; }
        public void setDate(string Date) {  date = Date; }
        public void setDistance(int Distance) {  distance = Distance; }
        public void setDestination(string Destination) {  destination = Destination; }
        public void setPickUp(string PickUp) { pickUp = PickUp; }
        public void setPassengers(int Passengers) { passengers = Passengers; }
        public void setCost(double Cost) { cost = Cost; }
        public void setStatus(char Status) { status = Status; }            
    

        public static int getNextBookingId()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = Convert.ToInt32(dr.GetString(0)) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }
        
        public void addBooking()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Bookings Values (" +
                this.bookingID + "," +
                this.driverID + ",'" +
                this.date + "'," +
                 this.accountID + "," +
                this.distance + ",'" +
                this.destination + "','" +
                this.pickUp + "'," +
                this.passengers + "," +
                this.cost + ",'" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getBooking(int bookingID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings WHERE bookingID = " + bookingID;

            conn.Open();

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setBookingID(Convert.ToInt32(dr.GetString(0)));
            setDriverID(Convert.ToInt32(dr.GetString(1)));
            setDate(dr.GetString(2));
            setAccountID(Convert.ToInt32(dr.GetString(3)));
            setDistance(Convert.ToInt32(dr.GetString(4)));
            setDestination(dr.GetString(5));
            setPickUp(dr.GetString(6));
            setPassengers(Convert.ToInt32(dr.GetString(7)));
            setCost(Convert.ToDouble(dr.GetString(8)));
            setStatus(Convert.ToChar(dr.GetString(9)));

            //close DB
            conn.Close();
        }

        public static void findBookingAccount(int accountID, DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings WHERE status = 'A' AND accountID = " + accountID ;
            //Execute the SQL query (OracleCommand)

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            
            OracleDataReader dr = cmd.ExecuteReader();
            dg.Columns.Clear();
            dg.Columns.Add("ID", "Booking ID");
            dg.Columns.Add("foreName", "Driver Name");
            dg.Columns.Add("pickUp", "Pick-up location");
            dg.Columns.Add("destination", "Destination");

            dg.Rows.Clear();

            while (dr.Read())
            {

                int driverID = Convert.ToInt32(dr.GetString(1));

                OracleConnection conn2 = new OracleConnection(DBConnect.oraDB);

                conn2.Open();

                String sqlQuery2 = "SELECT forename " +
                    "FROM Drivers WHERE driverID = " + driverID;
                
                //Execute the SQL query (OracleCommand)
                OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn2);

                OracleDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                //Close db connection

                dg.Rows.Add(dr["bookingId"],dr2["forename"], dr["pickup"], dr["destination"]);

                conn2.Close();

            }
            conn.Close();
            
        }

        public static void findBookingDriver(int driverID, DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings WHERE status = 'A' AND driverID = " + driverID;
            //Execute the SQL query (OracleCommand)

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            dg.Columns.Clear();
            dg.Columns.Add("ID", "Booking ID");
            dg.Columns.Add("username", "Username");
            dg.Columns.Add("pickUp", "Pick-up location");
            dg.Columns.Add("destination", "Destination");

            dg.Rows.Clear();

            while (dr.Read())
            {

                int accountID = Convert.ToInt32(dr.GetString(3));

                OracleConnection conn2 = new OracleConnection(DBConnect.oraDB);

                conn2.Open();

                String sqlQuery2 = "SELECT username " +
                    "FROM accounts WHERE accountID = " + accountID;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn2);

                OracleDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                //Close db connection

                dg.Rows.Add(dr["bookingId"], dr2["username"], dr["pickup"], dr["destination"]);

                conn2.Close();

            }
            conn.Close();

        }

        public static void cancelBooking(int bookingID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Bookings SET" +
                " Status = 'C'" +
                " WHERE bookingID = '" + bookingID + "'"; 

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateBooking()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Bookings SET" +
                " cost = '" + this.cost + "'" +
                ", status = 'F'" +
                " WHERE bookingID = '" + this.bookingID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static void getAllBookings(int accountID, DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings WHERE status = 'F' AND accountID = " + accountID;
            //Execute the SQL query (OracleCommand)

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            dg.Columns.Clear();
            dg.Columns.Add("bookingID", "Booking ID");
            dg.Columns.Add("foreName", "Driver Name");
            dg.Columns.Add("bookingdate","Date");
            dg.Columns.Add("pickUp", "Pick-up location");
            dg.Columns.Add("destination", "Destination");
            dg.Columns.Add("cost","Cost");

            dg.Rows.Clear();

            while (dr.Read())
            {

                int driverID = Convert.ToInt32(dr.GetString(1));

                OracleConnection conn2 = new OracleConnection(DBConnect.oraDB);

                conn2.Open();

                String sqlQuery2 = "SELECT forename " +
                    "FROM Drivers WHERE driverID = " + driverID;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn2);

                OracleDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                //Close db connection

                dg.Rows.Add(dr["bookingId"], dr2["forename"], dr["bookingdate"].ToString().Substring(0,10), dr["pickup"], dr["destination"], dr["cost"]);

                conn2.Close();

            }
            conn.Close();
        }

        
    }
}
