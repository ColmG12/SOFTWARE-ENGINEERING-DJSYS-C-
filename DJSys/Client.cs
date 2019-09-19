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
    class Client
    {
        //instance Variables
        private int clientID;
        private string cliForename;
        private string cliSurname;
        private string cliDateOfBirth;
        private string cliConNum;
        private string cliEmail;
        private string cliStreet;
        private string cliTown;
        private string cliCity;
        private string cliCounty;
        private string cliEircode;
        private string cliStatus;

        //no argument constructor
        public Client()
        {
            clientID = 0;
            cliForename = "";
            cliSurname = "";
            cliDateOfBirth = "";
            cliConNum = "";
            cliEmail = "";
            cliStreet = "";
            cliTown = "";
            cliCity = "";
            cliCounty = "";
            cliEircode = "";
            cliStatus = "";

        }

        // 12 Argument Constructor
        public Client(int cliID, string cliFname, string cliSname, string cliDOB, string cliCNum, string cliMail, string cliStrt, string cliTwn, string cliCty, string cliCnty,
                        string cliEcode, string cliSta)
        {
            clientID = cliID;
            cliForename = cliFname;
            cliSurname = cliSname;
            cliDateOfBirth = cliDOB;
            cliConNum = cliCNum;
            cliEmail = cliMail;
            cliStreet = cliStrt;
            cliTown = cliTwn;
            cliCity = cliCty;
            cliCounty = cliCnty;
            cliEircode = cliEcode;
            cliStatus = cliSta;

        }

        //Define setters
        public void setClientID(int clientID)
        {
            this.clientID = clientID;
        }

        public void setClientForename(string cliForename)
        {
            this.cliForename = cliForename;
        }

        public void setClientSurname(string cliSurname)
        {
            this.cliSurname = cliSurname;
        }

        public void setClientDob(string cliDateOfBirth)
        {
            this.cliDateOfBirth = cliDateOfBirth;
        }

        public void setClientContact(string cliConNum)
        {
            this.cliConNum = cliConNum;
        }

        public void setClientEmail(string cliEmail)
        {
            this.cliEmail = cliEmail;
        }

        public void setClientStreet(string cliStreet)
        {
            this.cliStreet = cliStreet;
        }

        public void setClientTown(string cliTown)
        {
            this.cliTown = cliTown;
        }

        public void setClientCity(string cliCity)
        {
            this.cliCity = cliCity;
        }

        public void setClientCounty(string cliCounty)
        {
            this.cliCounty = cliCounty;
        }

        public void setClientEircode(string cliEircode)
        {
            this.cliEircode = cliEircode;
        }

        public void setClientStatus(string cliStatus)
        {
            this.cliStatus = cliStatus;
        }


        //Define getters
        public int getClientID()
        {
            return clientID;
        }

        public string getForename()
        {
            return cliForename;
        }

        public string getSurname()
        {
            return cliSurname;
        }

        public string getDateOfBirth()
        {
            return cliDateOfBirth;
        }

        public string getConNum()
        {
            return cliConNum;
        }

        public string getEmail()
        {
            return cliEmail;
        }

        public string getStreet()
        {
            return cliStreet;
        }

        public string getTown()
        {
            return cliTown;
        }

        public string getCity()
        {
            return cliCity;
        }

        public string getCounty()
        {
            return cliCounty;
        }

        public string getEircode()
        {
            return cliEircode;
        }

        public string getStatus()
        {
            return cliStatus;
        }


        //define a static method to retrieve Client data
        public static DataSet GetAllClients(DataSet DS, string Surname)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            String strSQL = "SELECT * From Client where upper (Surname) LIKE '%" + Surname + "%'";
            //string strSQL = "Select * from Client WHERE upper (SURNAME) LIKE '" + "%' AND STATUS = 'A'";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchClient");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //Method to assign next available Client ID
        public static int nextClientID()
        {
            // variable to hold value to be returned
            int nextClientID = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX clientID used
            String strSQL = "SELECT MAX(Client_ID) FROM Client";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first clientID, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no clientID's in the Client File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //nextClientID = Convert.ToInt32(dr.GetValue(0)) + 1;
                nextClientID = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next clientID
            return nextClientID;
        }

        //Method to add a new client to the database
        public void AddClient()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT client record
            String strSQL = "INSERT INTO Client (Client_ID, Forename, Surname, Date_Of_Birth, Contact_No, Email, Street, Town, City, County, Eircode, Status) VALUES(" + 
                this.clientID.ToString() + ",'" + 
                this.cliForename + "', '" +
                this.cliSurname + "' , '" +
                this.cliDateOfBirth + "', '" +
                this.cliConNum + "' , '" +
                this.cliEmail + "' , '" +
                this.cliStreet + "' , '" +
                this.cliTown + "' , '" +
                this.cliCity + "' , '" +
                this.cliCounty + "' , '" +
                this.cliEircode + "' , '" +
                this.cliStatus + "')";



            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //This method
        public static void updateClient(int Client_ID, string Forename, string Surname, string Date_Of_Birth, string Contact_No,
                                    string Email, string Street, string Town, string City, string County,
                                    string Eircode)
        {
            //Connect
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql
            //DateTime dob = Convert.ToDateTime(cliDateOfBirth);

            //string date = dob.ToString("dd-MMM-yyyy");
            String strSQL = "UPDATE Client SET Forename ='" + Forename + 
                "', Surname ='" + Surname + 
                "', Date_Of_Birth ='" + Date_Of_Birth + 
                "', Contact_No ='" + Contact_No + 
                "', Email ='" + Email + 
                "', Street ='" + Street + 
                "', Town ='" + Town + 
                "', City ='" + City + 
                "', County ='" + County + 
                "', Eircode ='" + Eircode + 
                "' WHERE Client_ID =" + Client_ID;
           
        //Execute sql
        OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Db
            myConn.Close();
        }

        //This method 
        public static void WithdrawClient(int Client_ID)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            //Define SQL query to updates client record
            string strSQL = "UPDATE Client SET Status = 'W' " +
                "            WHERE Client_ID = " + Client_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //define a static method to retrieve Client data
        public static DataSet GetAllBookings(DataSet DS, int Client_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE Client_ID = " + Client_ID + "ORDER BY Event_Date";

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

        //define a static method to retrieve Client data
        public static DataSet GetAllActiveBookingsbyClientID(DataSet DS, int Client_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            //Reference to help with choosing dates active AFTER todays date https://stackoverflow.com/questions/15972188/why-is-the-getdate-an-invalid-identifier & https://stackoverflow.com/questions/13244288/error-calling-out-curdate
            String strSQL = "SELECT * From Bookings WHERE Client_ID = " + Client_ID + "AND BOOKING_STATUS = 'A' AND Event_Date >= SYSDATE ORDER BY Event_Date, Client_ID, DJ_ID, Service_ID";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveBookingsByClientID");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //define a static method to retrieve Client data
        public static DataSet GetAllActiveBookingsbyClientIDAndSum(DataSet DS, int Client_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT EVENT_DATE, CLIENT_ID, BOOKING_ID, DJ_ID, SERVICE_ID, START_TIME, END_TIME, DURATION, LOCATION, EIRCODE, TOTAL_COST, BOOKING_DATE, SUM(Total_Cost) " +
                            "FROM Bookings " + 
                            "WHERE Client_ID = " + Client_ID + 
                            "AND BOOKING_STATUS = 'A' AND Event_Date >= SYSDATE " +
                            "GROUP BY EVENT_DATE, CLIENT_ID, BOOKING_ID, DJ_ID, SERVICE_ID, START_TIME, END_TIME, DURATION, LOCATION, EIRCODE, TOTAL_COST, BOOKING_DATE " +
                            "ORDER BY EVENT_DATE, CLIENT_ID, BOOKING_ID, DJ_ID";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveBookingsByClientIDAndSum");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static DataTable GetWithdrawalTotalCost(DataTable dt, string Client_ID)
        {
            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
            //Reference for help in getting the sum of two fields https://stackoverflow.com/questions/14877797/how-to-sum-two-fields-within-an-sql-query
            String strSQL = "SELECT Client_ID, SUM(Total_Cost), SUM(Refund_Due) " +
                            "FROM Bookings " +
                            "WHERE Client_ID = " + Client_ID +
                            "AND BOOKING_STATUS = 'A' AND Event_Date >= SYSDATE " +
                            "GROUP BY Client_ID " +
                            "ORDER BY Client_ID ";

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
        public static void cancelBookings(int Booking_ID, decimal Total_Cost, string Payment_Status, int Refund_Percentage, decimal Refund_Due, string Booking_Status, int DJ_ID)
        {
            //Connect
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Bookings SET Total_Cost = '" + Total_Cost + "', Payment_Status = '" + Payment_Status + "', Refund_Percentage = '" + Refund_Percentage + "', " +
                "                                Refund_Due = '" + Refund_Due + "', Booking_Status = '" + Booking_Status + "', DJ_ID = '" + DJ_ID + "' " +
                "                            WHERE Booking_ID = " + Booking_ID;

            //Execute sql
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Db
            myConn.Close();

        }

        //This method 
        public static DataSet GetAllActiveClients(DataSet DS, string Surname)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open();
           String strSQL = "SELECT * From Client WHERE upper (Surname) LIKE '%" + Surname + "%' AND STATUS = 'A' ORDER BY SURNAME, FORENAME";
            //To avoid issues with apostrophes...
            //https://stackoverflow.com/questions/3940984/how-to-search-data-from-oracle-database-which-contains-single-quote 
            //string strSQL = "Select * from CLIENT WHERE upper (SURNAME) LIKE '%''%' AND STATUS = 'A' ORDER BY SURNAME, FORENAME";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveClient");

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
            String strSQL = "SELECT distinct County FROM Client ORDER by COUNTY";

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
