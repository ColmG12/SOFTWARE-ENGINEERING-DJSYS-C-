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
using System.Net;
using System.Net.Mail;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DJSys
{
    public partial class frmWithdrawDJ : Form
    {
        frmMainMenu parent;
        public frmWithdrawDJ()
        {
            InitializeComponent();
        }

        public frmWithdrawDJ(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmWithdrawDJ_Load(object sender, EventArgs e)
        {
            txtEnterSurname.Select();

            //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
            cmd = new OracleCommand("SELECT Surname FROM DJs", myConn);
            myConn.Open();
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            txtEnterSurname.AutoCompleteCustomSource = Collection;
            dr.Close();
            myConn.Close();
        }

        private void txtEnterSurname_TextChanged(object sender, EventArgs e)
        {
            grdWithdrawMatchingDJs.Visible = true;
            grpWithdrawMatchingDJs.Visible = true;
            grdWithdrawMatchingDJs.AllowUserToAddRows = false;
        }

        private void btnFindDJ_Click_2(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpWithdrawMatchingDJs.Visible = false;
                grdWithdrawMatchingDJs.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpWithdrawMatchingDJs.Visible = false;
                grdWithdrawMatchingDJs.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdWithdrawMatchingDJs.DataSource = DJs.GetAllActiveDJs(ds, txtEnterName.Text.ToUpper()).Tables["DJs"];
                ds = DJs.GetAllActiveDJs(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdWithdrawMatchingDJs.DataSource = ds.Tables["searchActiveDJs"];

                if (grdWithdrawMatchingDJs.Rows.Count == 0)
                {
                    grdWithdrawMatchingDJs.Visible = false;
                    grpWithdrawMatchingDJs.Visible = false;
                    MessageBox.Show("No DJ found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdWithdrawMatchingDJs.Visible = true;
                grpWithdrawMatchingDJs.Visible = true;
            }
        }

        private void grdWithdrawMatchingDJs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpWithdrawMatchingDJs.Visible = true;
            grpWithdrawDJ.Visible = true;
            //this is checking if the amount of rows in the grdWithdrawMatchingDJs is greater than 0
            if (grdWithdrawMatchingDJs.SelectedRows.Count > 0)
            {
                String DJID = grdWithdrawMatchingDJs.SelectedRows[0].Cells[0].Value + string.Empty;
                string Forename = grdWithdrawMatchingDJs.SelectedRows[0].Cells[1].Value + string.Empty;
                string Surname = grdWithdrawMatchingDJs.SelectedRows[0].Cells[2].Value + string.Empty;
                string Date = grdWithdrawMatchingDJs.SelectedRows[0].Cells[3].Value + string.Empty;
                String Contact = grdWithdrawMatchingDJs.SelectedRows[0].Cells[4].Value + string.Empty;
                String Email = grdWithdrawMatchingDJs.SelectedRows[0].Cells[5].Value + string.Empty;
                String Street = grdWithdrawMatchingDJs.SelectedRows[0].Cells[6].Value + string.Empty;
                String Town = grdWithdrawMatchingDJs.SelectedRows[0].Cells[7].Value + string.Empty;
                String City = grdWithdrawMatchingDJs.SelectedRows[0].Cells[8].Value + string.Empty;
                String County = grdWithdrawMatchingDJs.SelectedRows[0].Cells[9].Value + string.Empty;
                String Eircode = grdWithdrawMatchingDJs.SelectedRows[0].Cells[10].Value + string.Empty;
                String HourlyRate = grdWithdrawMatchingDJs.SelectedRows[0].Cells[11].Value + string.Empty;

                txtDJID.Text = DJID;

                txtDJForename.Text = Forename;

                txtDJSurname.Text = Surname;

                dtpDJDateOfBirth.Text = Date;

                txtDJContactNo.Text = Contact;

                txtDJEmail.Text = Email;

                txtDJStreet.Text = Street;

                txtDJTown.Text = Town;

                txtDJCity.Text = City;

                txtDJCounty.Text = County;

                txtDJEircode.Text = Eircode;

                txtDJHourlyRate.Text = HourlyRate;
            }
        }

        private void btnCheckActiveBookings_Click(object sender, EventArgs e)
        {
            //grpWithdrawDJsActiveBookings.Visible = true;
            grpWithdrawMatchingDJs.Visible = false;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;

            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookings(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings.DataSource = ds.Tables["searchBookings"];

            if (grdWithdrawDJActiveBookings.Rows.Count == 0)
            {
                grdWithdrawDJActiveBookings.Visible = false;
                grpWithdrawDJActiveBookings.Visible = false;
                btnDJWithBookingsWithdrawDJ.Visible = false;
                btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
                MessageBox.Show(text: "No active bookings for DJ found.");
                btnLegendDJsNoBookingsWithdrawDJ.Visible = true;
                btnDJNoBookingsWithdrawDJ.Visible = true;
                return;
            }

            else
                grdWithdrawDJActiveBookings.Visible = true;
                grpWithdrawDJActiveBookings.Visible = true;
                //grdWithdrawDJsActiveBookings.AllowUserToAddRows = false;
                btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
                btnDJNoBookingsWithdrawDJ.Visible = false;
                btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
                btnDJWithBookingsWithdrawDJ.Visible = false;
                btnSelectAll.Visible = true;
                btnDJWithdrawDJPrintBookings.Visible = false;

            var result =
            FlexibleMessageBox.Show("Is it the choice of the DJ to withdraw? If so, click 'Yes'." +
            Environment.NewLine + Environment.NewLine +
            "If it is the ADMINS choice to withdraw the DJ, click 'No'", "DJ or Admin?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
                btnDJNoBookingsWithdrawDJ.Visible = false;
                btnLegendDJsWithBookingsWithdrawDJ.Visible = true;
                btnDJWithBookingsWithdrawDJ.Visible = false;
            }

            else
            {
                btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
                btnDJNoBookingsWithdrawDJ.Visible = false;
                btnDJWithBookingsWithdrawDJ.Visible = true;
                btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            }
        }

        private void btnLegendDJsNoBookingsWithdrawDJ_Click(object sender, EventArgs e)
        {
            String Forename = txtDJForename.Text;

            DJs.WithdrawDJ(Convert.ToInt32(txtDJID.Text));
            MessageBox.Show(text: "DJ Withdrawn");
            grdWithdrawDJActiveBookings.Visible = false;
            grpWithdrawDJActiveBookings.Visible = false;
            //grdWithdrawDJsActiveBookings.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
            btnDJWithdrawDJPrintBookings.Visible = false;

            txtDJID.Clear();
            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            txtDJCounty.Clear();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            txtDJHourlyRate.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "DJ Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>As you have no outstanding bookings, and in accordance with our terms & conditions, your employment has now been terminated " +
                            "and you are now deregistered from Legend DJs' system." +
                            "<br/><br/>We would like to thank you for your great service to this point." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<br/><br/><h1>Contact Us</h1>" +
                            "<br/><br/>Legend DJs" +
                            "<br/>Main Street" +
                            "<br/>Tralee" +
                            "<br/>Co. Kerry" +
                            "<br/>087 170 1459" +
                            "<br/><br/><html><body><a href=\"http://www.livinglegendcolmg.com/\" > LegendDJs.com</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.facebook.com/colm.l.gallagher/\" > LegendDJs @ facebook</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://twitter.com/LivingLegendDJ/\" > LegendDJs @ twitter</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.instagram.com/livinglegendcolmg/?hl=en/\" > LegendDJs @ instagram</a></body></html>";

            mail.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("colmgdjsystem@gmail.com", "jcxvqxkvqrfanhqj");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

            //send email to client
            MessageBox.Show(text: "Confirmation email sent to DJ");

            grpWithdrawDJ.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnDJNoBookingsWithdrawDJ_Click(object sender, EventArgs e)
        {
            String Forename = txtDJForename.Text;

            DJs.WithdrawDJ(Convert.ToInt32(txtDJID.Text));
            MessageBox.Show(text: "DJ Withdrawn");
            grdWithdrawDJActiveBookings.Visible = false;
            grpWithdrawDJActiveBookings.Visible = false;
            //grdWithdrawDJsActiveBookings.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
            btnDJWithdrawDJPrintBookings.Visible = false;

            txtDJID.Clear();
            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            txtDJCounty.Clear();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            txtDJHourlyRate.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "DJ Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>In relation to your request to withdraw your details form Legend DJs' system, as you have no outstanding bookings, we are informing you that your contract has been terminated, " +
                            "and you have now been deregistered." +
                            "<br/><br/>We would like to sincerely thank you for giving the company such great service in the past, and hope to work with you again soon." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<br/><br/><h1>Contact Us</h1>" +
                            "<br/><br/>Legend DJs" +
                            "<br/>Main Street" +
                            "<br/>Tralee" +
                            "<br/>Co. Kerry" +
                            "<br/>087 170 1459" +
                            "<br/><br/><html><body><a href=\"http://www.livinglegendcolmg.com/\" > LegendDJs.com</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.facebook.com/colm.l.gallagher/\" > LegendDJs @ facebook</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://twitter.com/LivingLegendDJ/\" > LegendDJs @ twitter</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.instagram.com/livinglegendcolmg/?hl=en/\" > LegendDJs @ instagram</a></body></html>";

            mail.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("colmgdjsystem@gmail.com", "jcxvqxkvqrfanhqj");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

            //send email to client
            MessageBox.Show(text: "Confirmation email sent to DJ");

            grpWithdrawDJ.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnLegendDJsWithBookingsWithdrawDJ_Click(object sender, EventArgs e)
        {
            btnDJWithBookingsWithdrawDJ.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;

            grpWithdrawMatchingDJs.Visible = false;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;

            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookingsWithinNoticePeriod(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings2.DataSource = ds.Tables["searchBookingsByNotice"];

            //reference fellow student Carraig McNulty for help with foreach loop to declare array

            string message = "";
            int count = 0;
            foreach (DataRow row in ds.Tables["searchBookingsByNotice"].Rows)
            {

                String tablerow = "Event Date:          " + " " + row[2].ToString() + "\n" +
                                  "Start Time:           " + " " + row[3].ToString() + "\n" +
                                  "End Time:             " + " " + row[4].ToString() + "\n" +
                                  "Location:              " + " " + row[6].ToString() + "\n" +
                                  "Eircode:                " + " " + row[7].ToString() + "\n" +
                                  "Total Cost:           " + " " + "€" + row[8].ToString() + "\n" +
                                  "Payment Status:  " + " " + row[9].ToString() + "\n\n"
                                  ;
                message += tablerow;
                count++;
            }

            //Reference for a flexible message box which enables the message box to scroll to see all text.  The standard message box inside Visual Studio cannot display a lot of text by default.
            //https://www.codeproject.com/Articles/601900/FlexibleMessageBox-A-Flexible-Replacement-for-the

            FlexibleMessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Dear " + txtDJForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                       "In accordance with the terms and conditions of your employment, we will be withdrawing you from our system." +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, a list of remaining bookings to be fulfilled in the remaining 28 day notice period of your contract." +
                        Environment.NewLine + Environment.NewLine +
                        "Any bookings after 28 days from this date will be allocated to another Legend DJs employee." +
                        Environment.NewLine + Environment.NewLine +
                        "We would like to thank you for your great service to this point." +
                        Environment.NewLine + Environment.NewLine +
                        "Kind regards, " +
                        Environment.NewLine + Environment.NewLine +
                        "Legend DJs" +
                        Environment.NewLine + Environment.NewLine +
                        (message));

            grdWithdrawDJActiveBookings.Visible = true;
            grpWithdrawDJActiveBookings.Visible = true;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings2.Visible = true;
            grpWithdrawDJActiveBookings2.Visible = true;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
            btnDJNoBookingsWithdrawDJ.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            btnDJWithdrawDJPrintBookings.Visible = false;
            btnLegendDJsWithdrawDJPrintBookings.Visible = true;

            FlexibleMessageBox.Show("*****ADMIN - PLEASE PRESS 'PRINT BOOKINGS' TO ATTACH TO DJ CONFIRMATION EMAIL*****", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDJWithBookingsWithdrawDJ_Click(object sender, EventArgs e)
        {
            btnDJWithBookingsWithdrawDJ.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;

            grpWithdrawMatchingDJs.Visible = false;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;

            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookingsWithinNoticePeriod(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings2.DataSource = ds.Tables["searchBookingsByNotice"];

            //reference fellow student Carraig McNulty for help with foreach loop to declare array

            string message = "";
            int count = 0;
            foreach (DataRow row in ds.Tables["searchBookingsByNotice"].Rows)
            {

                String tablerow = "Event Date:          " + " " + row[2].ToString() + "\n" +
                                  "Start Time:           " + " " + row[3].ToString() + "\n" +
                                  "End Time:             " + " " + row[4].ToString() + "\n" +
                                  "Location:              " + " " + row[6].ToString() + "\n" +
                                  "Eircode:                " + " " + row[7].ToString() + "\n" +
                                  "Total Cost:           " + " " + "€" + row[8].ToString() + "\n" +
                                  "Payment Status:  " + " " + row[9].ToString() + "\n\n"
                                  ;
                message += tablerow;
                count++;
            }

            //Reference for a flexible message box which enables the message box to scroll to see all text.  The standard message box inside Visual Studio cannot display a lot of text by default.
            //https://www.codeproject.com/Articles/601900/FlexibleMessageBox-A-Flexible-Replacement-for-the

            FlexibleMessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Dear " + txtDJForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                       "In relation to your request to withdraw your services form Legend DJs' system, and in accordance with the terms and conditions of your employment, we will be withdrawing you from our system." +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, a list of remaining bookings to be fulfilled in the remaining 28 day notice period of your contract." +
                        Environment.NewLine + Environment.NewLine +
                        "Any bookings after 28 days from this date will be allocated to another Legend DJs employee." +
                        Environment.NewLine + Environment.NewLine +
                        "We would like to sincerely thank you for giving the company such great service in the past, and hope to work with you again soon." +
                        Environment.NewLine + Environment.NewLine +
                        "Kind regards, " +
                        Environment.NewLine + Environment.NewLine +
                        "Legend DJs" +
                        Environment.NewLine + Environment.NewLine +
                        (message));

            grdWithdrawDJActiveBookings.Visible = true;
            grpWithdrawDJActiveBookings.Visible = true;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings2.Visible = true;
            grpWithdrawDJActiveBookings2.Visible = true;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawDJ.Visible = false;
            btnDJNoBookingsWithdrawDJ.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            btnDJWithdrawDJPrintBookings.Visible = true;
            btnLegendDJsWithdrawDJPrintBookings.Visible = false;
            
            FlexibleMessageBox.Show("*****ADMIN - PLEASE PRESS 'PRINT BOOKINGS' TO ATTACH TO DJ CONFIRMATION EMAIL*****", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    
        public void UpdateAllRecords()
        {
            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookingsOutsideNoticePeriod(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings3.DataSource = ds.Tables["searchBookingsOutsideNotice"];

            //reference fellow student Carraig McNulty for help with foreach loop to declare array

            foreach (DataRow row in ds.Tables["searchBookingsOutsideNotice"].Rows)
            {
                StringBuilder query = new StringBuilder();
                for (int i = 0; i < grdWithdrawDJActiveBookings3.Rows.Count; i++)
                {
                    //DataGridViewRow row = grdWithdrawDJActiveBookings3.Rows[i];
                    Bookings.updateBookingsWhereDJWithdrawn(Convert.ToInt32(grdWithdrawDJActiveBookings3.Rows[i].Cells[0].Value), Convert.ToInt32(15));
                }
            }
        }

        private void btnLegendDJsWithdrawDJPrintBookings_Click(object sender, EventArgs e)
        {
            String ClientID = txtDJID.Text;
            String Forename = txtDJForename.Text;

            grpWithdrawMatchingDJs.Visible = false;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings.Visible = true;
            grpWithdrawDJActiveBookings.Visible = true;
            grdWithdrawDJActiveBookings2.Visible = true;
            grpWithdrawDJActiveBookings2.Visible = true;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnDJWithdrawDJPrintBookings.Visible = false;
            btnLegendDJsWithdrawDJPrintBookings.Visible = false;
            grpWithdrawDJ.Visible = false;
            btnSelectAll.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            grdWithdrawDJActiveBookings3.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings3.Visible = true;
            grpWithdrawDJActiveBookings3.Visible = true;

            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookingsOutsideNoticePeriod(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings3.DataSource = ds.Tables["searchBookingsOutsideNotice"];

            UpdateAllRecords();

            DJs.WithdrawDJ(Convert.ToInt32(txtDJID.Text));

            MessageBox.Show(text: "DJ Withdrawn");

            txtDJID.Clear();
            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            txtDJCounty.Clear();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            txtDJHourlyRate.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "DJ Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>In accordance with the terms and conditions of your employment, we will be withdrawing you from our system." +
                            "<br/><br/>Please find attached a list of final bookings to fulfil before you officially leave Legend DJs." +
                            "<br/><br/>We would like to thank you, again, for your great service to this point." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<br/><br/><h1>Contact Us</h1>" +
                            "<br/><br/>Legend DJs" +
                            "<br/>Main Street" +
                            "<br/>Tralee" +
                            "<br/>Co. Kerry" +
                            "<br/>087 170 1459" +
                            "<br/><br/><html><body><a href=\"http://www.livinglegendcolmg.com/\" > LegendDJs.com</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.facebook.com/colm.l.gallagher/\" > LegendDJs @ facebook</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://twitter.com/LivingLegendDJ/\" > LegendDJs @ twitter</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.instagram.com/livinglegendcolmg/?hl=en/\" > LegendDJs @ instagram</a></body></html>";

            mail.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("colmgdjsystem@gmail.com", "jcxvqxkvqrfanhqj");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

            //send email to client
            MessageBox.Show(text: "Confirmation email sent to DJ");

            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings.Visible = false;
            grpWithdrawDJActiveBookings.Visible = false;
            grdWithdrawDJActiveBookings2.Visible = false;
            grpWithdrawDJActiveBookings2.Visible = false;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnDJWithdrawDJPrintBookings.Visible = false;
            btnLegendDJsWithdrawDJPrintBookings.Visible = false;
            grpWithdrawDJ.Visible = false;
            btnSelectAll.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            grdWithdrawDJActiveBookings3.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings3.Visible = false;
            grpWithdrawDJActiveBookings3.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnWithdrawDJPrintBookings_Click(object sender, EventArgs e)
        {
            String ClientID = txtDJID.Text;
            String Forename = txtDJForename.Text;

            grpWithdrawMatchingDJs.Visible = false;
            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings.Visible = true;
            grpWithdrawDJActiveBookings.Visible = true;
            grdWithdrawDJActiveBookings2.Visible = true;
            grpWithdrawDJActiveBookings2.Visible = true;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnDJWithdrawDJPrintBookings.Visible = false;
            btnLegendDJsWithdrawDJPrintBookings.Visible = false;
            grpWithdrawDJ.Visible = false;
            btnSelectAll.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            grdWithdrawDJActiveBookings3.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings3.Visible = true;
            grpWithdrawDJActiveBookings3.Visible = true;

            DataSet ds = new DataSet();
            //grdWithdrawDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookingsOutsideNoticePeriod(ds, Convert.ToInt32(txtDJID.Text));
            grdWithdrawDJActiveBookings3.DataSource = ds.Tables["searchBookingsOutsideNotice"];

            UpdateAllRecords();

            DJs.WithdrawDJ(Convert.ToInt32(txtDJID.Text));

            MessageBox.Show(text: "DJ Withdrawn");

            txtDJID.Clear();
            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            txtDJCounty.Clear();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            txtDJHourlyRate.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "DJ Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>In relation to your request to withdraw your services form Legend DJs' system, and in accordance with the terms and conditions of your employment, " +
                            "we will be withdrawing you from our system." +
                            "<br/><br/>Please find attached a list of final bookings to fulfil before you officially leave Legend DJs." +
                            "<br/><br/>We would like to thank you, again, for your great service to this point." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<br/><br/><h1>Contact Us</h1>" +
                            "<br/><br/>Legend DJs" +
                            "<br/>Main Street" +
                            "<br/>Tralee" +
                            "<br/>Co. Kerry" +
                            "<br/>087 170 1459" +
                            "<br/><br/><html><body><a href=\"http://www.livinglegendcolmg.com/\" > LegendDJs.com</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.facebook.com/colm.l.gallagher/\" > LegendDJs @ facebook</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://twitter.com/LivingLegendDJ/\" > LegendDJs @ twitter</a></body></html>" +
                            "<br/><br/><html><body><a href=\"https://www.instagram.com/livinglegendcolmg/?hl=en/\" > LegendDJs @ instagram</a></body></html>";

            mail.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("colmgdjsystem@gmail.com", "jcxvqxkvqrfanhqj");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

            //send email to client
            MessageBox.Show(text: "Confirmation email sent to DJ");

            grdWithdrawDJActiveBookings.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings.Visible = false;
            grpWithdrawDJActiveBookings.Visible = false;
            grdWithdrawDJActiveBookings2.Visible = false;
            grpWithdrawDJActiveBookings2.Visible = false;
            grdWithdrawDJActiveBookings2.AllowUserToAddRows = false;
            btnDJWithdrawDJPrintBookings.Visible = false;
            btnLegendDJsWithdrawDJPrintBookings.Visible = false;
            grpWithdrawDJ.Visible = false;
            btnSelectAll.Visible = false;
            btnLegendDJsWithBookingsWithdrawDJ.Visible = false;
            btnDJWithBookingsWithdrawDJ.Visible = false;
            grdWithdrawDJActiveBookings3.AllowUserToAddRows = false;
            grdWithdrawDJActiveBookings3.Visible = false;
            grpWithdrawDJActiveBookings3.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }
    }    
}
