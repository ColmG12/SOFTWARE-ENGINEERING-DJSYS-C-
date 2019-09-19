using DJSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DJSys
{
    public partial class frmWithdrawClient : Form
    {
        frmMainMenu parent;
        public frmWithdrawClient()
        {
            InitializeComponent();
        }

        public frmWithdrawClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmWithdrawClient_Load(object sender, EventArgs e)
        {
            txtEnterSurname.Select();

            //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
            cmd = new OracleCommand("SELECT Surname FROM Client", myConn);
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

        //Gets rid of unused row in grid
        private void txtEnterSurname_TextChanged(object sender, EventArgs e)
        {
            grdWithdrawMatchingClients.Visible = true;
            grpWithdrawMatchingClients.Visible = true;
            grdWithdrawMatchingClients.AllowUserToAddRows = false;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpWithdrawMatchingClients.Visible = false;
                grdWithdrawMatchingClients.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpWithdrawMatchingClients.Visible = false;
                grdWithdrawMatchingClients.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdWithdrawMatchingClients.DataSource = Client.GetAllActiveClients(ds, txtEnterName.Text.ToUpper()).Tables["Client"];
                ds = Client.GetAllActiveClients(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdWithdrawMatchingClients.DataSource = ds.Tables["searchActiveClient"];

                if (grdWithdrawMatchingClients.Rows.Count == 0)
                {
                    grdWithdrawMatchingClients.Visible = false;
                    grpWithdrawMatchingClients.Visible = false;
                    MessageBox.Show("No client found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdWithdrawMatchingClients.Visible = true;
                grpWithdrawMatchingClients.Visible = true;
            }
        }

        private void grdWithdrawMatchingClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpWithdrawMatchingClients.Visible = true;
            grpWithdrawClient.Visible = true;
            //this is checking if the amount of rows in the grdWithdrawMatchingClients is greater than 0
            if (grdWithdrawMatchingClients.SelectedRows.Count > 0)
            {
                String ClientID = grdWithdrawMatchingClients.SelectedRows[0].Cells[0].Value + string.Empty;
                string Forename = grdWithdrawMatchingClients.SelectedRows[0].Cells[1].Value + string.Empty;
                string Surname = grdWithdrawMatchingClients.SelectedRows[0].Cells[2].Value + string.Empty;
                string Date = grdWithdrawMatchingClients.SelectedRows[0].Cells[3].Value + string.Empty;
                String Contact = grdWithdrawMatchingClients.SelectedRows[0].Cells[4].Value + string.Empty;
                String Email = grdWithdrawMatchingClients.SelectedRows[0].Cells[5].Value + string.Empty;
                String Street = grdWithdrawMatchingClients.SelectedRows[0].Cells[6].Value + string.Empty;
                String Town = grdWithdrawMatchingClients.SelectedRows[0].Cells[7].Value + string.Empty;
                String City = grdWithdrawMatchingClients.SelectedRows[0].Cells[8].Value + string.Empty;
                String County = grdWithdrawMatchingClients.SelectedRows[0].Cells[9].Value + string.Empty;
                String Eircode = grdWithdrawMatchingClients.SelectedRows[0].Cells[10].Value + string.Empty;

                txtClientID.Text = ClientID;

                txtForename.Text = Forename;

                txtSurname.Text = Surname;

                dtpDateOfBirth.Text = Date;

                txtContactNo.Text = Contact;

                txtEmail.Text = Email;

                txtStreet.Text = Street;

                txtTown.Text = Town;

                txtCity.Text = City;

                txtCounty.Text = County;

                txtEircode.Text = Eircode;
            }
        }

        private void btnCheckActiveBookings_Click(object sender, EventArgs e)
        {
            //grpWithdrawClientActiveBookings.Visible = true;
            grpWithdrawMatchingClients.Visible = false;
            grdWithdrawClientActiveBookings.AllowUserToAddRows = false;

            DataSet ds = new DataSet();
            //grdWithdrawClientActiveBookings.DataSource = Client.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = Client.GetAllActiveBookingsbyClientID(ds, Convert.ToInt32(txtClientID.Text));
            grdWithdrawClientActiveBookings.DataSource = ds.Tables["searchActiveBookingsByClientID"];

            if (grdWithdrawClientActiveBookings.Rows.Count == 0)
            {
                grdWithdrawClientActiveBookings.Visible = false;
                grpWithdrawClientActiveBookings.Visible = false;
                MessageBox.Show(text: "No active bookings for client found.");
                btnLegendDJsNoBookingsWithdrawClient.Visible = true;
                btnClientNoBookingsWithdrawClient.Visible = true;
                return;
            }

            else

                grdWithdrawClientActiveBookings.Visible = true;
                grpWithdrawClientActiveBookings.Visible = true;
                grdWithdrawClientActiveBookings.AllowUserToAddRows = false;
                btnLegendDJsWithBookingsWithdrawClient.Visible = false;
                btnClientWithBookingsWithdrawClient.Visible = false;
                btnWithdrawClientPrintInvoice.Visible = false;
                btnSelectAll.Visible = true;

            var result =
            FlexibleMessageBox.Show("Is it the choice of the CLIENT to withdraw? If so, click 'Yes'." +
            Environment.NewLine + Environment.NewLine +
            "If it is the ADMINS choice to withdraw the client, click 'No'", "Client or Admin?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                btnTotalRefundDueLegendDJs.Visible = true;
                btnTotalRefundDue.Visible = false;
            }

            else
            {
                btnTotalRefundDueLegendDJs.Visible = false;
                btnTotalRefundDue.Visible = true;
            }
        }

        private void btnLegendDJsNoBookingsWithdrawClient_Click(object sender, EventArgs e)
        {
            String Forename = txtForename.Text;

            Client.WithdrawClient(Convert.ToInt32(txtClientID.Text));
            MessageBox.Show(text: "Client Withdrawn");
            grdWithdrawClientActiveBookings.Visible = false;
            grpWithdrawClientActiveBookings.Visible = false;
            //grdWithdrawDJsActiveBookings.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawClient.Visible = false;
            btnWithdrawClientPrintInvoice.Visible = false;

            txtClientID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCity.Clear();
            txtEircode.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Client Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>As you have no outstanding bookings, and in accordance with our terms & conditions, you have now been deregistered from Legend DJs' system." +
                            "<br/><br/>We would like to thank you for booking our services." +
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
            MessageBox.Show(text: "Confirmation email sent to Client");

            grpWithdrawClient.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnClientNoBookingsWithdrawClient_Click(object sender, EventArgs e)
        {
            String Forename = txtForename.Text;

            Client.WithdrawClient(Convert.ToInt32(txtClientID.Text));
            MessageBox.Show(text: "Client Withdrawn");
            grdWithdrawClientActiveBookings.Visible = false;
            grpWithdrawClientActiveBookings.Visible = false;
            //grdWithdrawDJsActiveBookings.AllowUserToAddRows = false;
            btnLegendDJsNoBookingsWithdrawClient.Visible = false;
            btnWithdrawClientPrintInvoice.Visible = false;

            txtClientID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCity.Clear();
            txtEircode.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Client Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>In relation to your request to withdraw your details form Legend DJs' system, as you have no outstanding bookings, we are informing you that you have now been deregistered." +
                            "<br/><br/>We would like to sincerely thank you for booking our services in the past, and hope to work with you again soon." +
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
            MessageBox.Show(text: "Confirmation email sent to Client");

            grpWithdrawClient.Visible = false;

            txtEnterSurname.Select();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            //I've disabled this button as it does not achieve what I wanted to which was to select all rows to edit on one click of a button.
            //grdWithdrawClientActiveBookings.SelectAll();
        }

        private void btnTotalRefundDueLegendDJs_Click(object sender, EventArgs e)
        {
            getRefundPercentageLegendDJs();
            getRefundDueLegendDJs();
            getCostEstimationLegendDJs();

            for (int i = 0; i < grdWithdrawClientActiveBookings.Rows.Count - 1; i++)
            {
                DataGridViewRow row = grdWithdrawClientActiveBookings.Rows[i];

                grdWithdrawClientActiveBookings.Rows[i].Cells[0].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[0].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[9].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[9].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[10].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[10].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[12].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[12].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[14].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[14].Value.ToString();
            }

            getTotalSum();
            getTotalRefundDue();

            btnLegendDJsWithBookingsWithdrawClient.Visible = true;
        }

        private void btnTotalRefundDue_Click(object sender, EventArgs e)
        {
            getRefundPercentage();
            getRefundDue();
            getCostEstimation();

            for (int i = 0; i < grdWithdrawClientActiveBookings.Rows.Count - 1; i++)
            {
                DataGridViewRow row = grdWithdrawClientActiveBookings.Rows[i];

                grdWithdrawClientActiveBookings.Rows[i].Cells[0].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[0].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[9].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[9].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[10].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[10].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[12].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[12].Value.ToString();
                grdWithdrawClientActiveBookings.Rows[i].Cells[14].Value = grdWithdrawClientActiveBookings.Rows[i].Cells[14].Value.ToString();
            }

            getTotalSum();
            getTotalRefundDue();

            btnClientWithBookingsWithdrawClient.Visible = true;
        }

        private void btnLegendDJsWithBookingsWithdrawClient_Click(object sender, EventArgs e)
        {
            btnClientWithBookingsWithdrawClient.Visible = false;
            btnLegendDJsWithBookingsWithdrawClient.Visible = false;

            String ClientID = txtClientID.Text;

            DataTable dt = new DataTable();
            dt = Client.GetWithdrawalTotalCost(dt, ClientID);

            decimal TotalOriginalCost;
            //decimal TotalRefundDue;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TotalOriginalCost = Convert.ToDecimal(dt.Rows[i][1].ToString());
                txtOriginalTotalCost.Text = TotalOriginalCost.ToString("N2");
            }

            //grpWithdrawClienActiveBookings.Visible = true;
            grpWithdrawMatchingClients.Visible = false;
            grdWithdrawClientActiveBookings.AllowUserToAddRows = false;
            btnClientWithBookingsWithdrawClient.Visible = false;

            DataSet ds = new DataSet();
            //grdWithdrawClientActiveBookings.DataSource = Client.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = Client.GetAllActiveBookingsbyClientID(ds, Convert.ToInt32(txtClientID.Text));
            grdWithdrawClientActiveBookings.DataSource = ds.Tables["searchActiveBookingsByClientID"];

            //reference fellow student Carraig McNulty for help with foreach loop to declare array

            string message = "";
            int count = 0;
            foreach (DataRow row in ds.Tables["searchActiveBookingsByClientID"].Rows)
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
                        "Dear " + txtForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, a list of bookings which will be cancelled with immediate effect as we confirm that you have now been deregistered from Legend DJs' system." +
                        Environment.NewLine + Environment.NewLine +
                        "In accordance with our terms and conditions on cancellations, you will be refunded, in full, on all bookings." +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        (message) +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        "The total cost of your remaining bookings amounts to: €" + Convert.ToDecimal(txtOriginalTotalCost.Text) +
                        Environment.NewLine + Environment.NewLine +
                        "The total refund due to you will be: €" + Convert.ToDecimal(txtTotalRefundDue.Text));

            FlexibleMessageBox.Show("*****ADMIN - PLEASE PRESS 'CALCULATE REFUND DUE' AGAIN FOR EACH BOOKING BEFORE PRINTING INVOICE*****", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            btnWithdrawClientPrintInvoice.Visible = false;
            btnWithdrawClientPrintInvoiceLegendDJs.Visible = true;
        }

        private void btnClientWithBookingsWithdrawClient_Click(object sender, EventArgs e)
        {
            btnLegendDJsWithBookingsWithdrawClient.Visible = false;
            btnClientWithBookingsWithdrawClient.Visible = false;

            String ClientID = txtClientID.Text;

            DataTable dt = new DataTable();
            dt = Client.GetWithdrawalTotalCost(dt, ClientID);

            decimal TotalOriginalCost;
            //decimal TotalRefundDue;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TotalOriginalCost = Convert.ToDecimal(dt.Rows[i][1].ToString());
                txtOriginalTotalCost.Text = TotalOriginalCost.ToString("N2");
                
            }

            //grpWithdrawClienActiveBookings.Visible = true;
            grpWithdrawMatchingClients.Visible = false;
            grdWithdrawClientActiveBookings.AllowUserToAddRows = false;
            btnLegendDJsWithBookingsWithdrawClient.Visible = false;

            DataSet ds = new DataSet();
            //grdWithdrawClientActiveBookings.DataSource = Client.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = Client.GetAllActiveBookingsbyClientID(ds, Convert.ToInt32(txtClientID.Text));
            grdWithdrawClientActiveBookings.DataSource = ds.Tables["searchActiveBookingsByClientID"];

            //reference fellow student Carraig McNulty for help with foreach loop to declare array

            string message = "";
            int count = 0;
            foreach (DataRow row in ds.Tables["searchActiveBookingsByClientID"].Rows)
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
                        "Dear " + txtForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, a list of remaining bookings to be fulfilled before we can confirm your withdrawal." +
                        Environment.NewLine + Environment.NewLine +
                        "In accordance with our terms and conditions on cancellations, you may not be entitled to refunds on all bookings." +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        (message) +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        "The total cost of your remaining bookings amounts to: €" + Convert.ToDecimal(txtOriginalTotalCost.Text) +
                        Environment.NewLine + Environment.NewLine +
                        "The total refund due to you will be: €" + Convert.ToDecimal(txtTotalRefundDue.Text));

            var result =
            FlexibleMessageBox.Show("Would you like to cancel all bookings and be withdrawn from Legend DJs' system?", "Confirm?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                // parent.Show();
                // this.Dispose()
                parent.Show();
                this.Dispose();
            }

            else

                FlexibleMessageBox.Show("*****ADMIN - PLEASE PRESS 'CALCULATE REFUND DUE' AGAIN FOR EACH BOOKING BEFORE PRINTING INVOICE*****", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnWithdrawClientPrintInvoice.Visible = true;
                btnWithdrawClientPrintInvoiceLegendDJs.Visible = false;
        }

        public int getRefundPercentageLegendDJs()
        {
            int refundPercentageLegendDJs = 100;

            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[10].Value = refundPercentageLegendDJs;

            return refundPercentageLegendDJs;
        }

        public int getRefundPercentage()
        {
            int refundPercentage;

            DateTime eventDate = Convert.ToDateTime(grdWithdrawClientActiveBookings.SelectedRows[0].Cells[2].Value + string.Empty);

            if (eventDate > DateTime.Now.AddDays(+14) && eventDate < DateTime.Now.AddDays(+28))
            {
                refundPercentage = 75;
            }

            else if (eventDate > DateTime.Now.AddDays(+7) && eventDate < DateTime.Now.AddDays(+14))
            {
                refundPercentage = 50;
            }

            else if (eventDate < DateTime.Now.AddDays(+7))
            {
                refundPercentage = 0;
            }

            else
                refundPercentage = 100;

            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[10].Value = refundPercentage;

            return refundPercentage;
        }

        public double getRefundDueLegendDJs()
        {
            int refundPercentage = getRefundPercentageLegendDJs();
            double refundDueLegendDJs;

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value.ToString());
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            refundDueLegendDJs = (totalCost / 100) * refundPercentage;
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[11].Value = refundDueLegendDJs.ToString("N2");
            return refundDueLegendDJs;
        }

        public double getRefundDue()
        {
            int refundPercentage = getRefundPercentage();
            double refundDue;

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value.ToString());
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            refundDue = (totalCost / 100) * refundPercentage;
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[11].Value = refundDue.ToString("N2");
            return refundDue;
        }

        public double getCostEstimationLegendDJs()
        {
            double refundDueLegendDJs = getRefundDueLegendDJs();

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value.ToString());
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            totalCost = totalCost - refundDueLegendDJs;

            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            return totalCost;
        }

        public double getCostEstimation()
        {
            double refundDue = getRefundDue();

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value.ToString());
            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            totalCost = totalCost - refundDue;

            grdWithdrawClientActiveBookings.SelectedRows[0].Cells[8].Value = totalCost.ToString("N2");

            return totalCost;
        }

        public double getTotalSum()
        {
            double TotalCostSum = 0;
            for (int i = 0; i < grdWithdrawClientActiveBookings.Rows.Count; i++)
            {
                TotalCostSum += Convert.ToInt32(grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value);
            }

            txtTotalCostSum.Text = TotalCostSum.ToString("N2");
            return TotalCostSum;
        }

        public double getTotalRefundDue()
        {
            double TotalRefundDue = 0;
            for (int i = 0; i < grdWithdrawClientActiveBookings.Rows.Count; i++)
            {
                TotalRefundDue += Convert.ToInt32(grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value);
            }

            txtTotalRefundDue.Text = TotalRefundDue.ToString("N2");
            return TotalRefundDue;
        }

        public void UpdateAllRecords()
        {
            StringBuilder query = new StringBuilder();
            for (int i = 0; i < grdWithdrawClientActiveBookings.Rows.Count; i++)
            {
                DataGridViewRow row = grdWithdrawClientActiveBookings.Rows[i];

                Client.cancelBookings(Convert.ToInt32(grdWithdrawClientActiveBookings.Rows[i].Cells[0].Value), Convert.ToDecimal(grdWithdrawClientActiveBookings.Rows[i].Cells[8].Value), "R",
                                    Convert.ToInt32(grdWithdrawClientActiveBookings.Rows[i].Cells[10].Value), Convert.ToDecimal(grdWithdrawClientActiveBookings.Rows[i].Cells[11].Value), "C",
                                    Convert.ToInt32(15));
            }
        }

        private void btnWithdrawClientPrintInvoiceLegendDJs_Click(object sender, EventArgs e)
        {
            String ClientID = txtClientID.Text;
            String Forename = txtForename.Text;

            grpWithdrawMatchingClients.Visible = false;
            grdWithdrawClientActiveBookings.AllowUserToAddRows = false;
            grdWithdrawClientActiveBookings.Visible = false;
            grpWithdrawClientActiveBookings.Visible = false;
            btnWithdrawClientPrintInvoice.Visible = false;
            btnWithdrawClientPrintInvoiceLegendDJs.Visible = false;
            grpWithdrawClient.Visible = false;
            btnSelectAll.Visible = false;
            btnTotalRefundDueLegendDJs.Visible = false;
            btnLegendDJsWithBookingsWithdrawClient.Visible = false;
            btnClientWithBookingsWithdrawClient.Visible = false;

            UpdateAllRecords();

            Client.WithdrawClient(Convert.ToInt32(txtClientID.Text));

            MessageBox.Show(text: "Client Withdrawn");

            txtClientID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCity.Clear();
            txtEircode.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Client Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>Please find attached a final invoice from Legend DJs.  All monies owed will be refunded to your account within 5 working days." +
                            "<br/><br/>The total refund due to you will be: €" + Convert.ToDecimal(txtTotalRefundDue.Text) +
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
            MessageBox.Show(text: "Confirmation email sent to Client");

            txtEnterSurname.Select();
        }

        private void btnWithdrawClientPrintInvoice_Click(object sender, EventArgs e)
        {
            String ClientID = txtClientID.Text;
            String Forename = txtForename.Text;

            grpWithdrawMatchingClients.Visible = false;
            grdWithdrawClientActiveBookings.AllowUserToAddRows = false;
            grdWithdrawClientActiveBookings.Visible = false;
            grpWithdrawClientActiveBookings.Visible = false;
            btnWithdrawClientPrintInvoice.Visible = false;
            btnWithdrawClientPrintInvoiceLegendDJs.Visible = false;
            grpWithdrawClient.Visible = false;
            btnSelectAll.Visible = false;
            btnTotalRefundDue.Visible = false;
            btnLegendDJsWithBookingsWithdrawClient.Visible = false;
            btnClientWithBookingsWithdrawClient.Visible = false;

            UpdateAllRecords();

            Client.WithdrawClient(Convert.ToInt32(txtClientID.Text));

            MessageBox.Show(text: "Client Withdrawn");

            txtClientID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCity.Clear();
            txtEircode.Clear();

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Client Withdrawn";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>In relation to your request to withdraw your details form Legend DJs' system, as you have agreed to the refund conditions outlined in our terms & conditions, " +
                            "we are informing you that you have now been deregistered." +
                            "<br/><br/>Any monies owed will be refunded to your account within 5 working days." +
                            "<br/><br/>The total refund due to you will be: €" + Convert.ToDecimal(txtTotalRefundDue.Text) +
                            "<br/><br/>We would like to sincerely thank you for booking our services in the past, and hope to work with you again soon." +
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
            MessageBox.Show(text: "Confirmation email sent to Client");

            txtEnterSurname.Select();
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }

      
    }       
}
