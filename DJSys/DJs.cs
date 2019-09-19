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
    class DJs
    {
        //instance Variables
        private int djID;
        private string djForename;
        private string djSurname;
        private string djDateOfBirth;
        private string djConNum;
        private string djEmail;
        private string djStreet;
        private string djTown;
        private string djCity;
        private string djCounty;
        private string djEircode;
        private decimal djHourlyRate;
        private string djStatus;

        //no argument constructor
        public DJs()
        {
            djID = 0;
            djForename = "";
            djSurname = "";
            djDateOfBirth = "";
            djConNum = "";
            djEmail = "";
            djStreet = "";
            djTown = "";
            djCity = "";
            djCounty = "";
            djEircode = "";
            djHourlyRate = 0;
            djStatus = "";

        }

        // 12 Argument Constructor
        public DJs(int deejayID, string djFname, string djSname, string djDOB, string djCNum, string djMail, string djStrt, string djTwn, string djCty, string djCnty,
                        string djEcode, decimal djHR, string djSta)
        {
            djID = deejayID;
            djForename = djFname;
            djSurname = djSname;
            djDateOfBirth = djDOB;
            djConNum = djCNum;
            djEmail = djMail;
            djStreet = djStrt;
            djTown = djTwn;
            djCity = djCty;
            djCounty = djCnty;
            djEircode = djEcode;
            djHourlyRate = djHR;
            djStatus = djSta;

        }

        //Define setters
        public void setdjID(int djID)
        {
            this.djID = djID;
        }

        public void setdjForename(string djForename)
        {
            this.djForename = djForename;
        }

        public void setdjSurname(string djSurname)
        {
            this.djSurname = djSurname;
        }

        public void setdjDob(string djDateOfBirth)
        {
            this.djDateOfBirth = djDateOfBirth;
        }

        public void setdjContact(string djConNum)
        {
            this.djConNum = djConNum;
        }

        public void setdjEmail(string djEmail)
        {
            this.djEmail = djEmail;
        }

        public void setdjStreet(string djStreet)
        {
            this.djStreet = djStreet;
        }

        public void setdjTown(string djTown)
        {
            this.djTown = djTown;
        }

        public void setdjCity(string djCity)
        {
            this.djCity = djCity;
        }

        public void setdjCounty(string djCounty)
        {
            this.djCounty = djCounty;
        }

        public void setdjEircode (string djEircode)
        {
            this.djEircode = djEircode;
        }

        public void setdjHourlyRate(decimal djHourlyRate)
        {
            this.djHourlyRate = djHourlyRate;
        }

        public void setdjStatus(string djStatus)
        {
            this.djStatus = djStatus;
        }


        //Define getters
        public int getDJID()
        {
            return djID;
        }

        public string getForename()
        {
            return djForename;
        }

        public string getSurname()
        {
            return djSurname;
        }

        public string getDateOfBirth()
        {
            return djDateOfBirth;
        }

        public string getConNum()
        {
            return djConNum;
        }

        public string getEmail()
        {
            return djEmail;
        }

        public string getStreet()
        {
            return djStreet;
        }

        public string getTown()
        {
            return djTown;
        }

        public string getCity()
        {
            return djCity;
        }

        public string getCounty()
        {
            return djCounty;
        }

        public string getEircode()
        {
            return djEircode;
        }

        public decimal getHourlyRate()
        {
            return djHourlyRate;
        }

        public string getStatus()
        {
            return djStatus;
        }

        //Method to assign next available DJ ID
        public static int nextDJID()
        {
            // variable to hold value to be returned
            int nextDJID = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX DJ ID used
            String strSQL = "SELECT MAX(DJ_ID) FROM DJs";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first DJ ID, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no DJ ID's in the Client File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //nextDJID = Convert.ToInt32(dr.GetValue(0)) + 1;
                nextDJID = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next DJ ID
            return nextDJID;
        }

        //Method to add a new DJ to the database
        public void AddDJ()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DJ record
            String strSQL = "INSERT INTO DJs (DJ_ID, Forename, Surname, Date_Of_Birth, Contact_No, Email, Street, Town, City, County, Eircode, Hourly_Rate, Status) VALUES(" +
                this.djID.ToString() + ",'" +
                this.djForename + "', '" +
                this.djSurname + "' , '" +
                this.djDateOfBirth + "', '" +
                this.djConNum + "' , '" +
                this.djEmail + "' , '" +
                this.djStreet + "' , '" +
                this.djTown + "' , '" +
                this.djCity + "' , '" +
                this.djCounty + "' , '" +
                this.djEircode + "' , '" +
                this.djHourlyRate + "' , '" +
                this.djStatus + "')";



            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //This method 
        public static void WithdrawDJ(int DJ_ID)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            //Define SQL query to updates DJ record
            string strSQL = "UPDATE DJs SET Status = 'W' " +
                            " WHERE DJ_ID = " + DJ_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //define a static method to retrieve DJ data
        public static DataSet GetAllBookings(DataSet DS, int DJ_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE DJ_ID = " + DJ_ID + "AND BOOKING_STATUS = 'A' AND Event_Date >= SYSDATE ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchBookings");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //define a static method to retrieve DJ data
        public static DataSet GetAllBookingsWithinNoticePeriod(DataSet DS, int DJ_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            //reference to get sysdate + 28 days https://stackoverflow.com/questions/6678560/showing-that-a-date-is-greater-than-current-date
            String strSQL = "SELECT * From Bookings WHERE DJ_ID = " + DJ_ID + "AND BOOKING_STATUS = 'A' AND Event_Date <= (SYSDATE+28) ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchBookingsByNotice");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //define a static method to retrieve DJ data
        public static DataSet GetAllBookingsOutsideNoticePeriod(DataSet DS, int DJ_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            //reference to get sysdate + 28 days https://stackoverflow.com/questions/6678560/showing-that-a-date-is-greater-than-current-date
            String strSQL = "SELECT * From Bookings WHERE DJ_ID = " + DJ_ID + "AND BOOKING_STATUS = 'A' AND Event_Date > (SYSDATE+28) ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchBookingsOutsideNotice");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //This method 
        public static DataSet GetAllActiveDJs(DataSet DS, string Surname)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            String strSQL = "SELECT * From DJs where upper (Surname) LIKE '%" + Surname + "%' AND STATUS = 'A' ORDER BY SURNAME, FORENAME";
            //To avoid issues with apostrophes...
            //https://stackoverflow.com/questions/3940984/how-to-search-data-from-oracle-database-which-contains-single-quote
            //string strSQL = "Select * from DJs WHERE upper (SURNAME) LIKE '%''%' AND STATUS = 'A' ORDER BY SURNAME, FORENAME";


            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveDJs");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //This method 
        public static DataSet GetCounty(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            //reference for eliminating duplicates https://stackoverflow.com/questions/37057116/c-sharp-how-to-eliminate-duplicate-values-from-combobox
            String strSQL = "SELECT distinct County FROM DJs ORDER by COUNTY";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchCounty");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }
    }
}
