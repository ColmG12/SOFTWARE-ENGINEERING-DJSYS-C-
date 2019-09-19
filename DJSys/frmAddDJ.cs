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
using DJSys;
using System.Net;
using System.Net.Mail;
using Oracle.ManagedDataAccess.Client;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DJSys
{
    public partial class frmAddDJ : Form
    {
        frmMainMenu parent;
        public frmAddDJ()
        {
            InitializeComponent();
        }

        public frmAddDJ(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddDJ_Load(object sender, EventArgs e)
        {
            txtDJID.Text = DJs.nextDJID().ToString("000");
            txtDJID.Visible = true;

            //reference for eliminating duplicates https://stackoverflow.com/questions/37057116/c-sharp-how-to-eliminate-duplicate-values-from-combobox

            DataSet ds = new DataSet();
            ds = DJs.GetCounty(ds);

            for (int i = 0; i < ds.Tables["searchCounty"].Rows.Count; i++)
            {
                cboDJCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
            }
        }

        private void cboDJCounty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboDJCounty.SelectedIndex == -1)
            {
                return;
            }
        }

        private void btnAddDJ_Click(object sender, EventArgs e)
        {
            string DJID = txtDJID.Text;

            string Forename = txtDJForename.Text;

            string Surname = txtDJSurname.Text;

            DateTime Date = dtpDJDateOfBirth.Value;

            string Contact = txtDJContactNo.Text;

            string Email = txtDJEmail.Text;

            string Street = txtDJStreet.Text;

            string Town = txtDJTown.Text;

            string City = txtDJCity.Text;

            string County = cboDJCounty.Text;

            string Eircode = txtDJEircode.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal HourlyRate = Convert.ToDecimal(txtDJHourlyRate.Text);

            int parsedValueInt;
            int contact;
            decimal parsedValueDec;

            if (!ValidateData.isBlank(txtDJForename.Text))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJForename.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtDJForename.Text))
            {
                MessageBox.Show("Forename cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJForename.Clear();
                txtDJForename.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJSurname.Text))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtDJSurname.Text))
            {
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJSurname.Clear();
                txtDJSurname.Focus();
                return;
            }

            if (!ValidateData.isValidDate2(dtpDJDateOfBirth.Value))

            {
                MessageBox.Show("Cannot be future Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDJDateOfBirth.Focus();
                return;
            }

            else if (!ValidateData.isValidDate(dtpDJDateOfBirth.Value))

            {
                MessageBox.Show("You must be 18 or over to register", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDJDateOfBirth.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJContactNo.Text))
            {
                MessageBox.Show("Contact number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJContactNo.Focus();
                return;
            }

            //Reference https://stackoverflow.com/questions/24279155/how-to-validate-only-number-in-winform

            else if (!int.TryParse(txtDJContactNo.Text, out contact))
            {
                MessageBox.Show("Contact Number must contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJContactNo.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJEmail.Text))
            {
                MessageBox.Show("Email must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEmail.Focus();
                return;
            }

            if (!ValidateData.isValidEmail(txtDJEmail.Text))
            {
                if (!Regex.IsMatch(txtDJEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    //MessageBox.Show("Email must be valid format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDJEmail.Clear();
                    txtDJEmail.Focus();
                    return;
                }
            }

            if (!ValidateData.isBlank(txtDJStreet.Text))
            {
                MessageBox.Show("Street must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJStreet.Focus();
                return;
            }

            else if (int.TryParse(txtDJStreet.Text, out parsedValueInt))
            //else if (!ValidateData.onlyNumbers(txtDJStreet.Text))
            {
                MessageBox.Show("Street cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJStreet.Clear();
                txtDJStreet.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJTown.Text))
            {
                MessageBox.Show("Town must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJTown.Focus();
                return;
            }

            else if (int.TryParse(txtDJTown.Text, out parsedValueInt))
            //else if (!ValidateData.onlyNumbers(txtDJTown.Text))
            {
                MessageBox.Show("Town cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJTown.Clear();
                txtDJTown.Focus();
                return;
            }

            if (int.TryParse(txtDJCity.Text, out parsedValueInt))
            //if (!ValidateData.onlyNumbers(txtDJCity.Text))
            {
                MessageBox.Show("City cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCity.Clear();
                txtDJCity.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJEircode.Text))
            {
                MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEircode.Focus();
                return;
            }

            else if (!ValidateData.containsSpaces(txtDJEircode.Text))
            {
                MessageBox.Show("Eircode cannot contain spaces", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEircode.Clear();
                txtDJEircode.Focus();
                return;
            }

            else if (!ValidateData.isValidEircode(txtDJEircode.Text))
            {
                MessageBox.Show("Eircode must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEircode.Clear();
                txtDJEircode.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDJHourlyRate.Text))
            {
                MessageBox.Show("Rate must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJHourlyRate.Focus();
                return;
            }

            else if (!decimal.TryParse(txtDJHourlyRate.Text, out parsedValueDec))
            {
                MessageBox.Show("Rate must contain numeric only values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJHourlyRate.Clear();
                txtDJHourlyRate.Focus();
                return;
            }

            DJs dj = new DJs(Convert.ToInt32(txtDJID.Text), ValidateData.apostChecker(txtDJForename.Text.ToUpper()), ValidateData.apostChecker(txtDJSurname.Text.ToUpper()), dtpDJDateOfBirth.Text.ToUpper(),
                                            txtDJContactNo.Text.ToUpper(), txtDJEmail.Text.ToLower(), ValidateData.apostChecker(txtDJStreet.Text.ToUpper()), ValidateData.apostChecker(txtDJTown.Text.ToUpper()),
                                            ValidateData.apostChecker(txtDJCity.Text.ToUpper()), cboDJCounty.Text.ToUpper(), txtDJEircode.Text.ToUpper(), Convert.ToDecimal(txtDJHourlyRate.Text), "A");
            dj.AddDJ();

            txtDJID.Text = DJs.nextDJID().ToString("000");
            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            //reference for clearing combobox https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox & https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox
            cboDJCounty.Items.Clear();
            cboDJCounty.ResetText();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            txtDJHourlyRate.Clear();
            dtpDJDateOfBirth.Value = DateTime.Now;
            txtDJForename.Focus();

            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtForename.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Client details added!" +
            Environment.NewLine + Environment.NewLine + "Client ID: " + DJID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Forename: " + Forename.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Surname: " + Surname.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Date of Birth: " + Date +
            Environment.NewLine + Environment.NewLine + "Contact No.: " + Contact.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Email: " + Email +
            Environment.NewLine + Environment.NewLine + "Street: " + Street.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Town: " + Town.ToUpper() +
            Environment.NewLine + Environment.NewLine + "City: " + City.ToUpper() +
            Environment.NewLine + Environment.NewLine + "County: " + County.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Hourly Rate: €" + Convert.ToDecimal(HourlyRate) +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode.ToUpper());

            dtpDJDateOfBirth.Value = DateTime.Now;

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            //Reference on how to send an embedded link inside email 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "DJ Registration";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>Welcome to the team at Legend DJs!" +
                            "<br/><br/>We look forward to a long and busy working relationship with you." +
                            "<br/><br/>Please check the details below to ensure that the information we have is correct. You can update this information at any time by contacting us." +
                            "<br/><br/><h1>DJ details added!</h1>" +
                            "<br/><br/>Forename: " + Forename.ToUpper() +
                            "<br/>Surname: " + Surname.ToUpper() +
                            "<br/>Date of Birth: " + Date +
                            "<br/>Contact No.: " + Contact.ToUpper() +
                            "<br/>Email: " + Email +
                            "<br/>Street: " + Street.ToUpper() +
                            "<br/>Town: " + Town.ToUpper() +
                            "<br/>City: " + City.ToUpper() +
                            "<br/>County: " + County.ToUpper() +
                            "<br/>Eircode: " + Eircode.ToUpper() +
                            "<br/>Hourly Rate: €" + Convert.ToDecimal(HourlyRate) +
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
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }    
}
