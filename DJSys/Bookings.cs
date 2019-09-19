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
    class Bookings
    {
        //instance Variables
        private int bookingID;
        private string booDate;
        private string booEventDate;
        private string booStartTime;
        private string booEndTime;
        private double booDuration;
        private string booLocation;
        private string booEircode;
        private decimal booTotalCost;
        private string booPaymentStatus;
        private int booRefundPerc;
        private decimal booRefundDue;
        private string booStatus;
        private int booClientID;
        private int booDJID;
        private string booServiceID;

        //no argument constructor
        public Bookings()
        {
            bookingID = 0;
            //booDate = "";
            booEventDate = "";
            booStartTime = "";
            booEndTime = "";
            booDuration = 0.0;
            booLocation = "";
            booEircode = "";
            booTotalCost = 0;
            booPaymentStatus = "";
            booRefundPerc = 0;
            booRefundDue = 0;
            booStatus = "";
            booClientID = 0;
            booDJID = 0;
            booServiceID = "";

        }

        // 12 Argument Constructor
        public Bookings(int booID, string bEventDate, string bStartTime, string bEndTime, double bDuration, 
                        string bLocation, string bEircode, decimal bTotalCost, string bPaymentStatus, int bRefundPerc, 
                        decimal bRefundDue, string bStatus, int bClientID, int bDJID, string bServiceID)
        {
            bookingID = booID;
            
            booEventDate = bEventDate;
            booStartTime = bStartTime;
            booEndTime = bEndTime;
            booDuration = bDuration;
            booLocation = bLocation;
            booEircode = bEircode;
            booTotalCost = bTotalCost;
            booPaymentStatus = bPaymentStatus;
            booRefundPerc = bRefundPerc;
            booRefundDue = bRefundDue;
            booStatus = bStatus;
            booClientID = bClientID;
            booDJID = bDJID;
            booServiceID = bServiceID;

        }

        //Define setters
        public void setBookingID(int bookingID)
        {
            this.bookingID = bookingID;
        }

        public void setBookingDate(string booDate)
        {
            this.booDate = booDate;
        }

        public void setBookingEventDate(string booEventDate)
        {
            this.booEventDate = booEventDate;
        }

        public void setBookingStartTime(string booStartTime)
        {
            this.booStartTime = booStartTime;
        }

        public void setBookingEndTime(string booEndTime)
        {
            this.booEndTime = booEndTime;
        }

        public void setBookingDuration(double booDuration)
        {
            this.booDuration = booDuration;
        }

        public void setBookingLocation(string booLocation)
        {
            this.booLocation = booLocation;
        }

        public void setBookingEircode(string booEircode)
        {
            this.booEircode = booEircode;
        }

        public void setBookingTotalCost(decimal booTotalCost)
        {
            this.booTotalCost = booTotalCost;
        }

        public void setBookingPaymentStatus(string booPaymentStatus)
        {
            this.booPaymentStatus = booPaymentStatus;
        }

        public void setBookingRefundPerc(int booRefundPerc)
        {
            this.booRefundPerc = booRefundPerc;
        }

        public void setBookingRefundDue(decimal booRefundDue)
        {
            this.booRefundDue = booRefundDue;
        }

        public void setBookingStatus(string booStatus)
        {
            this.booStatus = booStatus;
        }

        public void setBookingClientID(int booClientID)
        {
            this.booClientID = booClientID;
        }

        public void setBookingDJID(int booDJID)
        {
            this.booDJID = booDJID;
        }

        public void setBookingServiceID(string booServiceID)
        {
            this.booServiceID = booServiceID;
        }


        //Define getters
        public int BookingID()
        {
            return bookingID;
        }

        public string BookingDate()
        {
            return booDate;
        }

        public string BookingEventDate()    
        {
            return booEventDate;
        }

        public string BookingStartTime()
        {
            return booStartTime;
        }

        public string getBookingEndTime()
        {
            return booEndTime;
        }

        public double getBookingDuration()
        {
            return booDuration;
        }

        public string getBookingLocation()
        {
            return booLocation;
        }

        public string getBookingEircode()
        {
            return booEircode;
        }

        public decimal getBookingTotalCost()
        {
            return booTotalCost;
        }

        public string getBookingPaymentStatus()
        {
            return booPaymentStatus;
        }

        public decimal getBookingRefundPerc()
        {
            return booRefundPerc;
        }

        public decimal getBookingRefundDue()
        {
            return booRefundDue;
        }

        public string getBookingStatus()
        {
            return booStatus;
        }

        public int getBookingClientID()
        {
            return booClientID;
        }

        public int getBookingDJID()
        {
            return booDJID;
        }

        public string getBookingServiceID()
        {
            return booServiceID;
        }

        //define a static method to retrieve Client data
        public static DataSet GetAllBookings(DataSet DS, int Booking_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE booking_ID = " + Booking_ID + "ORDER BY Event_Date";

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
        public static DataSet GetAllActiveBookings(DataSet DS, int Event_Date)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE Event_Date = " + Event_Date + "AND STATUS = 'A' ORDER BY Event_Date, DJ_ID, Service_ID";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveBookings");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //Method to assign next available Booking ID
        public static int nextBookingID()
        {
            // variable to hold value to be returned
            int nextBookingID = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX clientID used
            String strSQL = "SELECT MAX(Booking_ID) FROM Bookings";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first Booking ID, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no Booking ID's in the Bookings File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //nextBookingID = Convert.ToInt32(dr.GetValue(0)) + 1;
                nextBookingID = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next clientID
            return nextBookingID;
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
        public static DataSet GetAllActiveBookingsByDate(DataSet DS, string Event_Date)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT DJ_ID, Service_ID From Bookings WHERE Event_Date = " + Event_Date + "ORDER BY Event_Date";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "searchActiveBookingsByDate");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static Boolean isDJAvailable(String Event_Date, int DJ_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT * From Bookings WHERE Event_Date = '" + Event_Date + "' AND DJ_ID = " + DJ_ID + "";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.HasRows)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        //Method to add a new Booking to the database
        public void AddBooking()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT Booking record
            String strSQL = "INSERT INTO BOOKINGS (Booking_ID, Event_Date, Start_Time, End_Time, Duration, Location, Eircode, Total_Cost, Payment_Status, Refund_Percentage, " +
                "                                   Refund_Due, Booking_Status, Client_ID, DJ_ID, Service_ID) VALUES(" +
                this.bookingID.ToString() + ",'" +
                this.booEventDate + "' , '" +
                this.booStartTime + "', '" +
                this.booEndTime + "' , '" +
                this.booDuration.ToString() + "' , '" +
                this.booLocation + "' , '" +
                this.booEircode + "' , '" +
                this.booTotalCost + "' , '" +
                this.booPaymentStatus + "' , '" +
                this.booRefundPerc + "' , '" +
                this.booRefundDue + "' , '" +
                this.booStatus + "' , '" +
                this.booClientID.ToString() + "' , '" +
                this.booDJID.ToString() + "' , '" +
                this.booServiceID + "')";

            //Execute the command 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //This method
        public static void updateBookings(int Booking_ID, string Booking_Date, string Start_Time, string End_Time, double Duration, string Location, string Eircode, decimal Total_Cost, 
                                            int DJ_ID, string Service_ID)
        {
            //Connect
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Bookings SET Booking_Date = '" + Booking_Date +
                "', Start_Time ='" + Start_Time +
                "', End_Time ='" + End_Time +
                "', Duration ='" + Duration +
                "', Location ='" + Location +
                "', Eircode ='" + Eircode +
                "', Total_Cost ='" + Total_Cost +
                "', DJ_ID ='" + DJ_ID +
                "', Service_ID ='" + Service_ID +
                "' WHERE Booking_ID =" + Booking_ID;

            //Execute sql
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Db
            myConn.Close();
        }

        //This method
        public static void updateBookingsWhereDJWithdrawn(int Booking_ID, int DJ_ID)
        {
            //Connect
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Bookings SET DJ_ID ='" + DJ_ID + "' WHERE Booking_ID =" + Booking_ID;

            //Execute sql
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Db
            myConn.Close();
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
        public static DataSet GetAllActiveBookingsByClientID(DataSet DS, int Client_ID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data 
            //connection name conn.Open(); 
            String strSQL = "SELECT EVENT_DATE, CLIENT_ID, BOOKING_ID, DJ_ID, SERVICE_ID, START_TIME, END_TIME, DURATION, LOCATION, EIRCODE, TOTAL_COST, BOOKING_DATE " +
                "            FROM Bookings WHERE Client_ID = " + Client_ID + " AND BOOKING_STATUS = 'A' AND Event_Date >= SYSDATE " +
                            "ORDER BY EVENT_DATE, BOOKING_ID, DJ_ID";

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

    }
}

