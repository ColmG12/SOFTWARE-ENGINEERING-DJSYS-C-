using DJSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DJSys
{
    class Analysis
    {
        //References for help with charts https://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-application/ & https://www.i-programmer.info/programming/uiux/2756-getting-started-with-net-charts.html &
        //https://www.i-programmer.info/programming/uiux/2756-getting-started-with-net-charts.html?start=1
        //This method 
        public static DataSet GetYear(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            String strSQL = "SELECT To_Char(Event_Date, 'YYYY') FROM Bookings ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchYear");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static DataTable GetRevenueByYear(DataTable dt, string Year)
        {
            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            //String strSQL = "SELECT TO_CHAR(Booking_DATE,’MM’), SUM(Total_Cost) FROM Bookings WHERE Booking_Date LIKE ‘%19’ ORDER BY TO_CHAR(BOOKING_DATE,’MM’) ";
            String strSQL = "SELECT TO_CHAR(Event_DATE,'MM'), SUM(Total_Cost) " +
                            "FROM Bookings " +
                            //"WHERE Event_DATE LIKE '%19' " +
                            "WHERE Event_DATE LIKE '%" + Year + "' " +
                            "GROUP BY TO_CHAR(Event_DATE, 'MM') " +
                            "ORDER BY TO_CHAR(Event_DATE, 'MM') ";

            //DataTable dt = new DataTable();

            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            //da.Fill(DS, "searchYear");
            da.Fill(dt);

            //close the DB Connection
            conn.Close();

            return dt;
        }

        public static DataTable GetRevenueByService(DataTable dt, string Year)
        {
            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            //String strSQL = "SELECT TO_CHAR(Booking_DATE,’MM’), SUM(Total_Cost) FROM Bookings WHERE Booking_Date LIKE ‘%19’ ORDER BY TO_CHAR(BOOKING_DATE,’MM’) ";
            String strSQL = "SELECT Service_ID, SUM(Total_Cost) " +
                            "FROM Bookings " +
                            "WHERE Event_DATE LIKE '%" + Year + "' " +
                            "GROUP BY Service_ID " +
                            "ORDER BY Service_ID ";

            //DataTable dt = new DataTable();

            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            //da.Fill(DS, "searchYear");
            da.Fill(dt);

            //close the DB Connection
            conn.Close();

            return dt;
        }

        //This method 
        public static DataSet GetServices(DataSet DS, string Service_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            string strSQL = "Select * from Services WHERE upper (SERVICE_ID) LIKE '%" + Service_ID + "%' ";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchServices");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }


    }
}
