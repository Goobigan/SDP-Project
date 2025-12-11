using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace TaxiSys
{
    class Report
    {

        public static void monthlyRevenue(DataGridView dg)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT TO_CHAR(BOOKINGDATE, 'MM MONTH') as month," +
                " COUNT(BOOKINGDATE) as amount, SUM(COST) as cost FROM BOOKINGS WHERE STATUS = 'F' " +
                "GROUP BY TO_CHAR(BOOKINGDATE, 'MM MONTH') ORDER BY TO_CHAR(BOOKINGDATE, 'MM MONTH')";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            dg.Columns.Clear();
            dg.Columns.Add("month", "Month");
            dg.Columns.Add("amount", "Bookings");
            dg.Columns.Add("cost", "Total Earnings");

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["month"].ToString().Substring(2), dr["amount"], dr["cost"]);

            }
            conn.Close();
        }

        public static void driverRevenue(DataGridView dg)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT DriverID, COUNT(DriverID) as bookingNums," +
                " SUM(COST) as totalEarnings FROM BOOKINGS WHERE STATUS = 'F' " +
                "GROUP BY DriverID ORDER BY TO_NUMBER(DriverID)";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            dg.Columns.Clear();
            dg.Columns.Add("driverID", "Driver ID");
            dg.Columns.Add("forename", "Forename");
            dg.Columns.Add("surname", "Surname");
            dg.Columns.Add("bookingNums", "Bookings");
            dg.Columns.Add("totalAmount", "Total Earnings");

            dg.Rows.Clear();

            while (dr.Read())
            {

                int driverID = Convert.ToInt32(dr.GetString(1));

                OracleConnection conn2 = new OracleConnection(DBConnect.oraDB);

                conn2.Open();

                String sqlQuery2 = "SELECT forename, surname " +
                    "FROM Drivers WHERE driverID = " + driverID;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn2);

                OracleDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                //Close db connection

                dg.Rows.Add(dr["driverID"], dr2["forename"], dr2["surname"], dr["bookingNums"], dr["totalEarnings"]);

                conn2.Close();

            }
            conn.Close();
        }

    }
}
