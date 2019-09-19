using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DJSys
{
    class Services
    {
        //instance Variables
        private string serviceID;
        private string serDescription;
        private decimal serBaseRate;
        private string serStatus;

        //no argument constructor
        public Services()
        {
            serviceID = "";
            serDescription = "";
            serBaseRate = 0;
            serStatus = "";
        }

        // 12 Argument Constructor
        public Services(string serID, string serDesc, decimal serBR, string serStat)
        {
            serviceID = serID;
            serDescription = serDesc;
            serBaseRate = serBR;
            serStatus = serStat;
        }

        //Define setters
        public void setServiceID(string ServiceID)
        {
            this.serviceID = ServiceID;
        }

        public void setServiceDescription(string SerDescription)
        {
            this.serDescription = SerDescription;
        }

        public void setServiceBaseRate(decimal SerBaseRate)
        {
            this.serBaseRate = SerBaseRate;
        }

        public void setServiceStatus(string SerStatus)
        {
            this.serStatus = SerStatus;
        }


        //Define getters
        public string getServiceID()
        {
            return serviceID;
        }

        public string getServiceDescription()
        {
            return serDescription;
        }

        public decimal getServiceBaseRate()
        {
            return serBaseRate;
        }

        public string getServiceStatus()
        {
            return serStatus;
        }

        //Method to add a new client to the database
        public void LogService()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT Services record
            String strSQL = "INSERT INTO Services (SERVICE_ID, DESCRIPTION, BASE_RATE, STATUS) VALUES('" +
                serviceID + "','" +
                serDescription + "', " +
                serBaseRate + " , '" +
                serStatus + "')";

            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //This method
        public static void updateServices(string Service_ID, string Description, decimal Base_Rate)
        {
            //Connect
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql
            String strSQL = "UPDATE Services SET Service_ID ='" + Service_ID +
                "', Description ='" + Description +
                "', Base_Rate =" + Base_Rate +
                " WHERE Service_ID ='" + Service_ID + "'";

            //Execute sql
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Db
            myConn.Close();
        }

        //define a static method to retrieve Client data
        public static DataSet GetAllBookings(DataSet DS, string Service_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE upper (Service_ID) LIKE '%" + Service_ID + "%' AND BOOKING_STATUS = 'A' ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchServiceBookings");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //This method 
        public static DataSet GetAllActiveServices(DataSet DS, string Service_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            string strSQL = "Select * from Services WHERE upper (SERVICE_ID) LIKE '%" + Service_ID + "%' AND STATUS = 'A'";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveServices");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

    }    
}
