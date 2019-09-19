using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using DJSys;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DJSys
{
    public partial class frmCancelBooking : Form
    {
        frmMainMenu parent;
        public frmCancelBooking()
        {
            InitializeComponent();
        }

        public frmCancelBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmCancelBooking_Load(object sender, EventArgs e)
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

        private void txtEnterSurname_TextChanged(object sender, EventArgs e)
        {
            grdCancelBookingMatchingClients.Visible = true;
            grpCancelBookingMatchingClients.Visible = true;
            grdCancelBookingMatchingClients.AllowUserToAddRows = false;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpCancelBookingMatchingClients.Visible = false;
                grdCancelBookingMatchingClients.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpCancelBookingMatchingClients.Visible = false;
                grdCancelBookingMatchingClients.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdCancelBookingMatchingClients.DataSource = Bookings.GetAllActiveBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
                ds = Bookings.GetAllActiveClients(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdCancelBookingMatchingClients.DataSource = ds.Tables["searchActiveClient"];

                if (grdCancelBookingMatchingClients.Rows.Count == 0)
                {
                    grdCancelBookingMatchingClients.Visible = false;
                    grpCancelBookingMatchingClients.Visible = false;
                    MessageBox.Show("No clients found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdCancelBookingMatchingClients.Visible = true;
                grpCancelBookingMatchingClients.Visible = true;
                grdCancelBookingMatchingClients.AllowUserToAddRows = false;
            }
        }

        private void grdCancelBookingMatchingClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpCancelBookingMatchingClients.Visible = true;

            //this is checking if the amount of rows in the grdCancelBookingMatchingClients is greater than 0
            if (grdCancelBookingMatchingClients.SelectedRows.Count > 0)
            {
                String ClientID = grdCancelBookingMatchingClients.SelectedRows[0].Cells[0].Value + string.Empty;
                String Forename = grdCancelBookingMatchingClients.SelectedRows[0].Cells[1].Value + string.Empty;

                txtClientID.Text = ClientID;
                txtForename.Text = Forename;

                DataSet ds = new DataSet();
                ds = Bookings.GetAllActiveBookingsByClientID(ds, Convert.ToInt32(txtClientID.Text));
                grdCancelBookingActiveBookings.DataSource = ds.Tables["searchActiveBookingsByClientID"];

                if (grdCancelBookingActiveBookings.Rows.Count == 0)
                {
                    grdCancelBookingActiveBookings.Visible = false;
                    grdCancelBookingActiveBookings.Visible = false;
                    MessageBox.Show(text: "No active bookings for client found.");
                    return;
                }

                else
                    grdCancelBookingActiveBookings.Visible = true;
                    grpCancelBookingActiveBookings.Visible = true;
                    grdCancelBookingActiveBookings.AllowUserToAddRows = false;
            }
        }

        private void grdCancelBookingActiveBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this is checking if the amount of rows in the grdCancelBookingActiveBookings is greater than 0
            if (grdCancelBookingActiveBookings.SelectedRows.Count > 0)
            {
                string DJID = grdCancelBookingActiveBookings.SelectedRows[0].Cells[3].Value + string.Empty;
                string ServiceID = grdCancelBookingActiveBookings.SelectedRows[0].Cells[4].Value + string.Empty;
                string EventDate = grdCancelBookingActiveBookings.SelectedRows[0].Cells[0].Value + string.Empty;
                string BookingID = grdCancelBookingActiveBookings.SelectedRows[0].Cells[2].Value + string.Empty;
                string StartTime = grdCancelBookingActiveBookings.SelectedRows[0].Cells[5].Value + string.Empty;
                string EndTime = grdCancelBookingActiveBookings.SelectedRows[0].Cells[6].Value + string.Empty;
                string Duration = grdCancelBookingActiveBookings.SelectedRows[0].Cells[7].Value + string.Empty;
                string Location = grdCancelBookingActiveBookings.SelectedRows[0].Cells[8].Value + string.Empty;
                string Eircode = grdCancelBookingActiveBookings.SelectedRows[0].Cells[9].Value + string.Empty;
                string TotalCost = grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value + string.Empty;
                string BookingDate = grdCancelBookingActiveBookings.SelectedRows[0].Cells[11].Value + string.Empty;

                dtpEventDate.Text = EventDate;

                txtDJID.Text = DJID;

                txtServiceID.Text = ServiceID;

                txtBookingID.Text = BookingID;

                cboStartTime.Text = StartTime;

                cboEndTime.Text = EndTime;

                txtDuration.Text = Duration;

                txtLocation.Text = Location;

                txtEircode.Text = Eircode;

                txtTotalCost.Text = "€" + TotalCost;

                dtpBookingDate.Text = BookingDate;

                grpCancelBooking.Visible = true;
                pnlCancelBooking.Visible = true;
            }
        }

        private void btnLegendDJsCancelBooking_Click(object sender, EventArgs e)
        {
            pnlCancelBooking2.Visible = true;
            grdCancelBookingActiveBookings.Visible = true;
            btnClientCancelBooking.Visible = false;

            getRefundPercentageLegendDJs();
            getRefundDueLegendDJs();
            getCostEstimationLegendDJs();

            btnClientLegendDJsCancellation.Visible = true;
        }

        private void btnClientCancelBooking_Click(object sender, EventArgs e)
        {
            pnlCancelBooking2.Visible = true;
            grdCancelBookingActiveBookings.Visible = true;
            btnLegendDJsCancelBooking.Visible = false;

            getRefundPercentage();
            getRefundDue();
            getCostEstimation();

            btnClientConfirmCancellation.Visible = true;
        }

        public int getRefundPercentageLegendDJs()
        {
            int refundPercentageLegendDJs = 100;

            txtRefundPercentage.Text = refundPercentageLegendDJs.ToString();
            return refundPercentageLegendDJs;
        }

        public double getRefundDueLegendDJs()
        {
            int refundPercentage = getRefundPercentageLegendDJs();
            double refundDueLegendDJs;

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value.ToString());
            grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value = totalCost.ToString("N2");

            refundDueLegendDJs = (totalCost / 100) * refundPercentage;
            txtRefundDue.Text = refundDueLegendDJs.ToString("N2");
            return refundDueLegendDJs;
        }

        public double getCostEstimationLegendDJs()
        {
            double refundDueLegendDJs = getRefundDueLegendDJs();

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value.ToString());
            grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value = totalCost.ToString("N2");

            totalCost = totalCost - refundDueLegendDJs;
            txtTotalCost.Text = totalCost.ToString("N2");

            return totalCost;
        }

        public int getRefundPercentage()
        {
            int refundPercentage;
            DateTime eventDate = dtpEventDate.Value;

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

            txtRefundPercentage.Text = refundPercentage.ToString();
            return refundPercentage;
        }

        public double getRefundDue()
        {
            int refundPercentage = getRefundPercentage();
            double refundDue;

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value.ToString());
            grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value = totalCost.ToString("N2");

            refundDue = (totalCost / 100) * refundPercentage;
            txtRefundDue.Text = refundDue.ToString("N2");
            return refundDue;
        }

        public double getCostEstimation()
        {
            double refundDue = getRefundDue();

            //reference to convert datagrid value as a decimal to 2 places
            double totalCost = double.Parse(grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value.ToString());
            grdCancelBookingActiveBookings.SelectedRows[0].Cells[10].Value = totalCost.ToString("N2");

            totalCost = totalCost - refundDue;

            txtTotalCost.Text = totalCost.ToString();

            //To fix a bug which gave incorrect returns for totalCosts of '440', '880', and '920' 
            if (double.Parse(txtTotalCost.Text) < 2)
            {
                totalCost = 0;
            }
            txtTotalCost.Text = totalCost.ToString("N2");

            return totalCost;
        }

        private void btnClientLegendDJsCancellation_Click(object sender, EventArgs e)
        {
            //Update the data in the database based on the details changed in the text boxes(if any)
            Bookings.cancelBookings(Convert.ToInt32(txtBookingID.Text), Convert.ToDecimal(txtTotalCost.Text), "R", Convert.ToInt32(txtRefundPercentage.Text),
                                    Convert.ToDecimal(txtRefundDue.Text), "C", Convert.ToInt32(15));

            grpCancelBooking.Visible = false;
            pnlCancelBooking.Visible = false;
            pnlCancelBooking2.Visible = false;

            MessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Booking cancellation confirmed!" +
                        Environment.NewLine + Environment.NewLine +
                        "Please click on 'Print Invoice' below to send comfirmation email to client.");

            btnCancelBookingLegendDJsPrintInvoice.Visible = true;
        }

        private void btnCancelBookingLegendDJsPrintInvoice_Click(object sender, EventArgs e)
        {
            string Forename = txtForename.Text;

            string BookingID = txtBookingID.Text;

            DateTime BookingDate = dtpBookingDate.Value = DateTime.Now;

            DateTime EventDate = dtpEventDate.Value;

            string StartTime = cboStartTime.Text;

            string EndTime = cboEndTime.Text;

            string Duration = txtDuration.Text;

            string Location = txtLocation.Text;

            string Eircode = txtEircode.Text;

            string TotalCost = txtTotalCost.Text;

            string ClientID = txtClientID.Text;

            string DJID = txtDJID.Text;

            string ServiceID = txtServiceID.Text;

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            //Reference on how to send an embedded link inside email 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Booking cancellation";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>We regret to inform you, that unfortunately, we will have to cancel the following booking detailed." +
                            "<br/><br/>Please find below, an invoice of your booking cancellation. We will provide a full refund which will be deposited to your account within 5 working days." +
                            "<br/><br/>We hope you will accept our sincerest apologies." +
                            "<br/><br/>Thanks for the great relationship we have enjoyed to date. We look forward to future bookings with you." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<br/><br/><h1>Booking cancelled!</h1>" +
                            "<br/><br/>Booking ID: " + txtBookingID.Text.ToUpper() +
                            "<br/>Client ID: " + txtClientID.Text.ToUpper() +
                            "<br/>DJ ID: " + txtDJID.Text.ToUpper() +
                            "<br/>Service ID: " + txtServiceID.Text.ToUpper() +
                            "<br/>Event Date: " + dtpEventDate.Text +
                            "<br/>Start Time: " + cboStartTime.Text +
                            "<br/>End Time: " + cboEndTime.Text +
                            "<br/>Location: " + txtLocation.Text.ToUpper() +
                            "<br/>Eircode: " + txtEircode.Text.ToUpper() +
                            "<br/>Refund Percentage: " + Convert.ToInt32(txtRefundPercentage.Text) + "%" +
                            "<br/>Refund Due to Client: €" + Convert.ToDecimal(txtRefundDue.Text) +
                            "<br/>Revised Total Cost: €" + Convert.ToDecimal(txtTotalCost.Text) +
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

            grpCancelBooking.Visible = false;
            pnlCancelBooking.Visible = false;
            pnlCancelBooking2.Visible = false;
            grdCancelBookingMatchingClients.Visible = false;
            grpCancelBookingMatchingClients.Visible = false;
            grdCancelBookingMatchingClients.AllowUserToAddRows = false;
            grdCancelBookingActiveBookings.Visible = false;
            grpCancelBookingActiveBookings.Visible = false;
            grdCancelBookingActiveBookings.AllowUserToAddRows = false;

            MessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Dear " + txtForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, an invoice of your booking cancellation." +
                        Environment.NewLine + Environment.NewLine +
                        "Any refund amount due will be deposited within 5 business days." +
                        Environment.NewLine + Environment.NewLine +
                        "Thanks for the great relationship we have enjoyed to date. We look forward to future bookings with you." +
                        Environment.NewLine + Environment.NewLine +
                        "Kind regards," +
                        Environment.NewLine + Environment.NewLine +
                        "Legend DJs" +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        "Preview of updated booking details:" +
                Environment.NewLine + Environment.NewLine + "Booking ID: " + txtBookingID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Client ID: " + txtClientID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "DJ ID: " + txtDJID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Service ID: " + txtServiceID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Event Date: " + dtpEventDate.Text +
                Environment.NewLine + Environment.NewLine + "Start Time: " + cboStartTime.Text +
                Environment.NewLine + Environment.NewLine + "End Time: " + cboEndTime.Text +
                Environment.NewLine + Environment.NewLine + "Location: " + txtLocation.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Eircode: " + txtEircode.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Refund Percentage: " + Convert.ToInt32(txtRefundPercentage.Text) + "%" +
                Environment.NewLine + Environment.NewLine + "Refund Due to Client: €" + Convert.ToDecimal(txtRefundDue.Text) +
                Environment.NewLine + Environment.NewLine + "Revised Total Cost: €" + Convert.ToDecimal(txtTotalCost.Text));

            txtEnterSurname.Select();
        }

        private void btnConfirmCancellation_Click(object sender, EventArgs e)
        {
            //Update the data in the database based on the details changed in the text boxes(if any)
            Bookings.cancelBookings(Convert.ToInt32(txtBookingID.Text), Convert.ToDecimal(txtTotalCost.Text), "R", Convert.ToInt32(txtRefundPercentage.Text),
                                    Convert.ToDecimal(txtRefundDue.Text), "C", Convert.ToInt32(15));

            grpCancelBooking.Visible = false;
            pnlCancelBooking.Visible = false;
            pnlCancelBooking2.Visible = false;

            MessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Booking cancellation confirmed!" +
                        Environment.NewLine + Environment.NewLine +
                        "Please click on 'Print Invoice' below to send comfirmation email to client.");

            btnCancelBookingClientPrintInvoice.Visible = true;

        }

        private void btnWithdrawClientPrintInvoice_Click(object sender, EventArgs e)
        {
            grpCancelBooking.Visible = false;
            pnlCancelBooking.Visible = false;
            pnlCancelBooking2.Visible = false;

            string Forename = txtForename.Text;

            string BookingID = txtBookingID.Text;

            DateTime BookingDate = dtpBookingDate.Value = DateTime.Now;

            DateTime EventDate = dtpEventDate.Value;

            string StartTime = cboStartTime.Text;

            string EndTime = cboEndTime.Text;

            string Duration = txtDuration.Text;

            string Location = txtLocation.Text;

            string Eircode = txtEircode.Text;

            string TotalCost = txtTotalCost.Text;

            string ClientID = txtClientID.Text;

            string DJID = txtDJID.Text;

            string ServiceID = txtServiceID.Text;

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            //Reference on how to send an embedded link inside email 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Booking cancellation";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>Please find below, an invoice of your booking cancellation." +
                            "<br/><br/>Any refund amount due will be deposited within 5 business days." +
                            "<br/><br/>Thanks for the great relationship we have enjoyed to date. We look forward to future bookings with you." +
                            "<br/><br/><br/>Kind regards," +
                            "<br/><br/>Legend DJs" +
                            "<h1>Booking cancelled!</h1>" +
                            "<br/><br/>Booking ID: " + txtBookingID.Text.ToUpper() +
                            "<br/>Client ID: " + txtClientID.Text.ToUpper() +
                            "<br/>DJ ID: " + txtDJID.Text.ToUpper() +
                            "<br/>Service ID: " + txtServiceID.Text.ToUpper() +
                            "<br/>Event Date: " + dtpEventDate.Text +
                            "<br/>Start Time: " + cboStartTime.Text +
                            "<br/>End Time: " + cboEndTime.Text +
                            "<br/>Location: " + txtLocation.Text.ToUpper() +
                            "<br/>Eircode: " + txtEircode.Text.ToUpper() +
                            "<br/>Refund Percentage: " + Convert.ToInt32(txtRefundPercentage.Text) + "%" +
                            "<br/>Refund Due to Client: €" + Convert.ToDecimal(txtRefundDue.Text) +
                            "<br/>Revised Total Cost: €" + Convert.ToDecimal(txtTotalCost.Text) +
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


            grpCancelBooking.Visible = false;
            pnlCancelBooking.Visible = false;
            pnlCancelBooking2.Visible = false;
            grdCancelBookingMatchingClients.Visible = false;
            grpCancelBookingMatchingClients.Visible = false;
            grdCancelBookingMatchingClients.AllowUserToAddRows = false;
            grdCancelBookingActiveBookings.Visible = false;
            grpCancelBookingActiveBookings.Visible = false;
            grdCancelBookingActiveBookings.AllowUserToAddRows = false;

            MessageBox.Show(text:
                        Environment.NewLine + Environment.NewLine +
                        "Dear " + txtForename.Text + "," +
                        Environment.NewLine + Environment.NewLine +
                        "Please find below, an invoice of your booking cancellation." +
                        Environment.NewLine + Environment.NewLine +
                        "Any refund amount due will be deposited within 5 business days." +
                        Environment.NewLine + Environment.NewLine +
                        "Thanks for the great relationship we have enjoyed to date. We look forward to future bookings with you." +
                        Environment.NewLine + Environment.NewLine +
                        "Kind regards," +
                        Environment.NewLine + Environment.NewLine +
                        "Legend DJs" +
                        Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine +
                        "Preview of updated booking details:" +
                Environment.NewLine + Environment.NewLine + "Booking ID: " + txtBookingID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Client ID: " + txtClientID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "DJ ID: " + txtDJID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Service ID: " + txtServiceID.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Event Date: " + dtpEventDate.Text +
                Environment.NewLine + Environment.NewLine + "Start Time: " + cboStartTime.Text +
                Environment.NewLine + Environment.NewLine + "End Time: " + cboEndTime.Text +
                Environment.NewLine + Environment.NewLine + "Location: " + txtLocation.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Eircode: " + txtEircode.Text.ToUpper() +
                Environment.NewLine + Environment.NewLine + "Refund Percentage: " + Convert.ToInt32(txtRefundPercentage.Text) + "%" +
                Environment.NewLine + Environment.NewLine + "Refund Due to Client: €" + Convert.ToDecimal(txtRefundDue.Text) +
                Environment.NewLine + Environment.NewLine + "Revised Total Cost: €" + Convert.ToDecimal(txtTotalCost.Text));

            txtEnterSurname.Select();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
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


                