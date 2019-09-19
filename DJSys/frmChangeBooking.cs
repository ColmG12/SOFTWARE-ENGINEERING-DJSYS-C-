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
    public partial class frmChangeBooking : Form
    {
        frmMainMenu parent;
        public frmChangeBooking()
        {
            InitializeComponent();
        }

        public frmChangeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmChangeBooking_Load(object sender, EventArgs e)
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
            grdChangeBookingMatchingClients.Visible = true;
            grpChangeBookingMatchingClients.Visible = true;
            grdChangeBookingMatchingClients.AllowUserToAddRows = false;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpChangeBookingMatchingClients.Visible = false;
                grdChangeBookingMatchingClients.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpChangeBookingMatchingClients.Visible = false;
                grdChangeBookingMatchingClients.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdChangeBookingMatchingClients.DataSource = Bookings.GetAllActiveBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
                ds = Bookings.GetAllActiveClients(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdChangeBookingMatchingClients.DataSource = ds.Tables["searchActiveClient"];

                if (grdChangeBookingMatchingClients.Rows.Count == 0)
                {
                    grdChangeBookingMatchingClients.Visible = false;
                    grpChangeBookingMatchingClients.Visible = false;
                    MessageBox.Show("No clients found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdChangeBookingMatchingClients.Visible = true;
                grpChangeBookingMatchingClients.Visible = true;
                grdChangeBookingActiveBookings.AllowUserToAddRows = false;
            }
        }

        private void grdChangeBookingMatchingClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpChangeBookingMatchingClients.Visible = true;

            //this is checking if the amount of rows in the grdChangeBookingMatchingClients is greater than 0
            if (grdChangeBookingMatchingClients.SelectedRows.Count > 0)
            {
                String ClientID = grdChangeBookingMatchingClients.SelectedRows[0].Cells[0].Value + string.Empty;

                txtClientID.Text = ClientID;

                DataSet ds = new DataSet();
                ds = Bookings.GetAllActiveBookingsByClientID(ds, Convert.ToInt32(txtClientID.Text));
                grdChangeBookingActiveBookings.DataSource = ds.Tables["searchActiveBookingsByClientID"];

                if (grdChangeBookingActiveBookings.Rows.Count == 0)
                {
                    grdChangeBookingActiveBookings.Visible = false;
                    grdChangeBookingActiveBookings.Visible = false;
                    MessageBox.Show(text: "No active bookings for client found.");
                    return;
                }

                else
                    grdChangeBookingActiveBookings.Visible = true;
                    grpChangeBookingActiveBookings.Visible = true;
                    grdChangeBookingActiveBookings.AllowUserToAddRows = false;
                    grpChangeBooking.Visible = true;
            }
        }

        private void grdChangeBookingActiveBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this is checking if the amount of rows in the grdChangeBookingActiveDJs is greater than 0
            if (grdChangeBookingActiveBookings.SelectedRows.Count > 0)
            {
                string DJID = grdChangeBookingActiveBookings.SelectedRows[0].Cells[3].Value + string.Empty;
                string ServiceID = grdChangeBookingActiveBookings.SelectedRows[0].Cells[4].Value + string.Empty;
                string EventDate = grdChangeBookingActiveBookings.SelectedRows[0].Cells[0].Value + string.Empty;
                string BookingID = grdChangeBookingActiveBookings.SelectedRows[0].Cells[2].Value + string.Empty;
                string Location = grdChangeBookingActiveBookings.SelectedRows[0].Cells[8].Value + string.Empty;
                string Eircode = grdChangeBookingActiveBookings.SelectedRows[0].Cells[9].Value + string.Empty;

                dtpEventDate.Text = EventDate;

                txtDJID.Text = DJID;

                txtServiceID.Text = ServiceID;

                txtBookingID.Text = BookingID;

                if (!ValidateData.isValidDate28(dtpEventDate.Value))

                {
                    //Reference for message box options https://www.functionx.com/vb/functions/msgbox.htm
                    DialogResult dialog = MessageBox.Show("Sorry, booking cannot be changed less than 28 days before the event date. \n\nWould you like to choose another booking?", "Error",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (dialog == DialogResult.No)
                    {
                        // parent.Show();
                        // this.Dispose()
                        parent.Show();
                        this.Dispose();
                    }

                    else
                    {
                        grdChangeBookingActiveBookings.Select();
                    }

                    return;
                }

                grdChangeBookingActiveServices.Visible = true;
                grpChangeBookingActiveServices.Visible = true;
                grdChangeBookingActiveServices.AllowUserToAddRows = false;
                
                DataSet ds = new DataSet();
                string Service_ID = null;
                //grChangeBookingActiveServices.DataSource = Bookings.GetAllActiveServices(ds, txtEnterName.Text.ToUpper()).Tables["Services"];
                ds = Bookings.GetAllActiveServices(ds, Service_ID);
                grdChangeBookingActiveServices.DataSource = ds.Tables["searchActiveServices"];

                txtServiceID.Select();
            }
        }

        private void grdChangeBookingActiveServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grdChangeBookingActiveDJs.Visible = true;
            grpChangeBookingActiveDJs.Visible = true;
            grdChangeBookingActiveDJs.AllowUserToAddRows = false;

            //this is checking if the amount of rows in the grdChangeBookingActiveServices is greater than 0
            if (grdChangeBookingActiveServices.SelectedRows.Count > 0)
            {
                string ServiceID = grdChangeBookingActiveServices.SelectedRows[0].Cells[0].Value + string.Empty;
                
                txtServiceID.Text = ServiceID;
            }

            DataSet ds = new DataSet();
            string DJ_ID = null;
            //grdChangeBookingActiveDJs.DataSource = Bookings.GetAllActiveDJs(ds, txtEnterName.Text.ToUpper()).Tables["DJs"];
            ds = Bookings.GetAllActiveDJs(ds, DJ_ID);
            grdChangeBookingActiveDJs.DataSource = ds.Tables["searchActiveDJs"];

            grdChangeBookingActiveDJs.AllowUserToAddRows = false;

            txtDJID.Select();
        }

        private void grdChangeBookingActiveDJs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this is checking if the amount of rows in the grdMakeBookingActiveDJs is greater than 0
            if (grdChangeBookingActiveDJs.SelectedRows.Count > 0)
            {
                string DJID = grdChangeBookingActiveDJs.SelectedRows[0].Cells[0].Value + string.Empty;
                
                txtDJID.Text = DJID;
            }

            grpChangeBooking.Visible = true;
        }

        public double getDuration()
        {
            double duration;
            int startIndex = cboStartTime.SelectedIndex;
            int endIndex = cboEndTime.SelectedIndex;

            if (endIndex < startIndex)
            {
                endIndex += 48; //Number of half hours
            }

            duration = ((double)endIndex - (double)startIndex) / 2;
            txtDuration.Text = duration.ToString();
            return duration;
        }

        public void getCostEstimation()
        {
            double duration = getDuration();

            double totalCost;

            int baseRate = Convert.ToInt32(grdChangeBookingActiveServices.SelectedRows[0].Cells[2].Value);
            int hourlyRate = Convert.ToInt32(grdChangeBookingActiveDJs.SelectedRows[0].Cells[11].Value);

            totalCost = (hourlyRate * duration) + baseRate;
            txtTotalCost.Text = totalCost.ToString();
        }

        private void cboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method activates each time the combo box StartTime is changed 
            getCostEstimation();
        }

        private void cboEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method activates each time the combo box EndTime is changed 
            getCostEstimation();
        }

        private void btnCheckAvailibility_Click(object sender, EventArgs e)
        {
            if (!Bookings.isDJAvailable(dtpEventDate.Text, Convert.ToInt32(txtDJID.Text)))
                {
                //Reference for message box options https://www.functionx.com/vb/functions/msgbox.htm
                DialogResult dialog = MessageBox.Show("This DJ selected is not available on this date. Would you like to choose another DJ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialog == DialogResult.No)
                {
                    // parent.Show();
                    // this.Dispose()
                    parent.Show();
                    this.Dispose();
                }

                else
                {
                    grdChangeBookingActiveDJs.Select();
                }
            }

            else
            {
                //Reference for message box options https://www.functionx.com/vb/functions/msgbox.htm
                DialogResult dialog = MessageBox.Show("Great! The DJ selected is available on this date. Would you like to complete booking form?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.No)
                {
                    // parent.Show();
                    // this.Dispose()
                    parent.Show();
                    this.Dispose();
                }

                else
                {
                    //reference to lock cells from being edited once inputed data is made https://social.msdn.microsoft.com/Forums/en-US/00b513aa-6fc2-4e70-a951-752aa12dd0c6/datagridview-get-selected-value-on-mouseclick-then-click-edit-button?forum=csharplanguage
                    grdChangeBookingMatchingClients.Enabled = false;
                    grdChangeBookingActiveBookings.Enabled = false;
                    grdChangeBookingActiveServices.Enabled = false;
                    grdChangeBookingActiveDJs.Enabled = false;
                    btnCheckAvailibility.Visible = false;
                    pnlChangeBooking.Visible = true;
                    grpChangeBooking.Select();
                    cboStartTime.Focus();
                }
            }
        }

        private void btnConfirmBooking_Click_1(object sender, EventArgs e)
        {
            grpChangeBookingMatchingClients.Visible = false;
            grpChangeBookingActiveBookings.Visible = false;
            grpChangeBookingActiveServices.Visible = false;
            grpChangeBookingActiveDJs.Visible = false;
            grpChangeBooking.Visible = false;

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

            string Forename = grdChangeBookingMatchingClients.SelectedRows[0].Cells[1].Value + string.Empty;

            int parsedValueInt;

            if (!ValidateData.isBlank(txtLocation.Text))
            {
                MessageBox.Show("Location must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            else if (int.TryParse(txtLocation.Text, out parsedValueInt))
            {
                MessageBox.Show("Location cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Clear();
                txtLocation.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtEircode.Text))
            {
                MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            else if (!ValidateData.containsSpaces(txtEircode.Text))
            {
                MessageBox.Show("Eircode cannot contain spaces", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Clear();
                txtEircode.Focus();
                return;
            }

            else if (!ValidateData.isValidEircode(txtEircode.Text))
            {
                MessageBox.Show("Eircode must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Clear();
                txtEircode.Focus();
                return;
            }

            //Update the data in the database based on the details changed in the text boxes(if any)
            Bookings.updateBookings(Convert.ToInt32(txtBookingID.Text), dtpBookingDate.Text, cboStartTime.Text.ToUpper(), cboEndTime.Text.ToUpper(),
                                            double.Parse(txtDuration.Text), ValidateData.apostChecker(txtLocation.Text.ToUpper()), txtEircode.Text.ToUpper(), Convert.ToDecimal(txtTotalCost.Text),
                                            Convert.ToInt32(txtDJID.Text), txtServiceID.Text.ToUpper());

            txtBookingID.Clear();
            cboStartTime.SelectedIndex = -1;
            cboEndTime.SelectedIndex = -1;
            txtDuration.Clear();
            txtLocation.Clear();
            txtEircode.Clear();
            txtTotalCost.Clear();
            txtClientID.Clear();
            txtServiceID.Clear();
            txtDJID.Clear();

            txtEnterSurname.Select();

            // I need to check if the content is valid before adding it to the form
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Booking details changed!" +
            Environment.NewLine + Environment.NewLine + "Booking ID: " + BookingID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Booking Date: " + BookingDate +
            Environment.NewLine + Environment.NewLine + "Event Date: " + EventDate +
            Environment.NewLine + Environment.NewLine + "Start Time: " + StartTime +
            Environment.NewLine + Environment.NewLine + "End Time: " + EndTime +
            Environment.NewLine + Environment.NewLine + "Duration: " + Duration +
            Environment.NewLine + Environment.NewLine + "Location: " + Location.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Total Cost: €" + TotalCost +
            Environment.NewLine + Environment.NewLine + "Client ID: " + ClientID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "DJ ID: " + DJID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID.ToUpper());

            dtpEventDate.Visible = false;
            dtpBookingDate.Visible = false;

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            //Reference on how to send an embedded link inside email 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Booking updated";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>Your booking with Legend DJs has been updated." +
                            "<br/><br/>Please check the details below to ensure that the updated booking information we have is correct. We look forward to seeing you on the day." +
                            "<br/><br/><h1>Booking details updated!</h1>" +
                            "<br/><br/>Booking ID: " + BookingID.ToUpper() +
                            "<br/>Event Date: " + EventDate +
                            "<br/>Start Time: " + StartTime +
                            "<br/>End Time: " + EndTime +
                            "<br/>Duration: " + Duration +
                            "<br/>Location: " + Location.ToUpper() +
                            "<br/>Eircode: " + Eircode.ToUpper() +
                            "<br/>Total Cost: €" + TotalCost +
                            "<br/>DJ ID: " + DJID.ToUpper() +
                            "<br/>Service ID: " + ServiceID.ToUpper() +
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
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
