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
    public partial class frmAddClient : Form
    {
        frmMainMenu parent;
        public frmAddClient()
        {
            InitializeComponent();
        }

        public frmAddClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            txtClientID.Text = Client.nextClientID().ToString("00000");
            txtClientID.Visible = true;

            //reference for eliminating duplicates https://stackoverflow.com/questions/37057116/c-sharp-how-to-eliminate-duplicate-values-from-combobox

            DataSet ds = new DataSet();
            ds = Client.GetCounty(ds);

            for (int i = 0; i < ds.Tables["searchCounty"].Rows.Count; i++)
            {
                cboCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCounty.SelectedIndex == -1)
            {
                return;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string ClientID = txtClientID.Text;

            string Forename = txtForename.Text;

            string Surname = txtSurname.Text;

            DateTime Date = dtpDateOfBirth.Value;

            string Contact = txtContactNo.Text;

            string Email = txtEmail.Text;

            string Street = txtStreet.Text;

            string Town = txtTown.Text;

            string City = txtCity.Text;

            string County = cboCounty.Text;

            string Eircode = txtEircode.Text;

            int parsedValue;
            int contact;

            if (!ValidateData.isBlank(txtForename.Text))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtForename.Text))
            {
                MessageBox.Show("Forename cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Clear();
                txtForename.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtSurname.Text))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtSurname.Text))
            {
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
                txtSurname.Focus();
                return;
            }

            if (!ValidateData.isValidDate2(dtpDateOfBirth.Value))

            {
                MessageBox.Show("Cannot be future Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateOfBirth.Focus();
                return;
            }

            else if (!ValidateData.isValidDate(dtpDateOfBirth.Value))

            {
                MessageBox.Show("You must be 18 or over to register", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateOfBirth.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtContactNo.Text))
            {
                MessageBox.Show("Contact number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return;
            }

            //Reference https://stackoverflow.com/questions/24279155/how-to-validate-only-number-in-winform

            else if (!int.TryParse(txtContactNo.Text, out contact))
                {
                MessageBox.Show("Contact Number must contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtEmail.Text))
            {
                MessageBox.Show("Email must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!ValidateData.isValidEmail(txtEmail.Text))
            {
                //if (!Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Email must be valid format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtEmail.Focus();
                    return;
                }
            }

            if (!ValidateData.isBlank(txtStreet.Text))
            {
                MessageBox.Show("Street must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }

            else if (int.TryParse(txtStreet.Text, out parsedValue))
            {
                MessageBox.Show("Street cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Clear();
                txtStreet.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtTown.Text))
            {
                MessageBox.Show("Town must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            else if (int.TryParse(txtTown.Text, out parsedValue))
            {
                MessageBox.Show("Town cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Clear();
                txtTown.Focus();
                return;
            }

            if (int.TryParse(txtCity.Text, out parsedValue))
            {
                MessageBox.Show("City cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Clear();
                txtCity.Focus();
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


            Client client = new Client(Convert.ToInt32(txtClientID.Text), ValidateData.apostChecker(txtForename.Text.ToUpper()), ValidateData.apostChecker(txtSurname.Text.ToUpper()), 
                                      dtpDateOfBirth.Text.ToUpper(), txtContactNo.Text.ToUpper(), txtEmail.Text.ToLower(), ValidateData.apostChecker(txtStreet.Text.ToUpper()), 
                                      ValidateData.apostChecker(txtTown.Text.ToUpper()), ValidateData.apostChecker(txtCity.Text.ToUpper()), cboCounty.Text.ToUpper(), txtEircode.Text.ToUpper(), "A");
            client.AddClient();

            txtClientID.Text = Client.nextClientID().ToString("00000");
            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            //reference for clearing combobox https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox & https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox
            cboCounty.Items.Clear();
            cboCounty.ResetText();
            txtCity.Clear();
            txtEircode.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            txtForename.Focus();

            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtForename.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Client details added!" +
            Environment.NewLine + Environment.NewLine + "Client ID: " + ClientID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Forename: " + Forename.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Surname: " + Surname.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Date of Birth: " + Date +
            Environment.NewLine + Environment.NewLine + "Contact No.: " + Contact.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Email: " + Email +
            Environment.NewLine + Environment.NewLine + "Street: " + Street.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Town: " + Town.ToUpper() +
            Environment.NewLine + Environment.NewLine + "City: " + City.ToUpper() +
            Environment.NewLine + Environment.NewLine + "County: " + County.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode.ToUpper());

            dtpDateOfBirth.Value = DateTime.Now;

            //Reference for being able to send emails http://karmic-development.blogspot.com/2013/10/send-email-from-aspnet-using-gmail-as.html
            //Reference to set up various security aspects to be able to send email through google mail https://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp/9572958#9572958
            //Reference on how to send an embedded link inside email 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
            mail.To.Add("colmg12@hotmail.co.uk");
            mail.IsBodyHtml = true;
            mail.Subject = "Client Registration";
            //string html = "";
            mail.Body =
                            "Dear " + Forename + "," +
                            "<br/><br/>Thank you for registering with Legend DJs." +
                            "<br/><br/>We look forward to a long and busy working relationship with you." +
                            "<br/><br/>Please check the details below to ensure that the information we have is correct. You can update this information at any time by contacting us." +
                            "<br/><br/><h1>Client details added!</h1>" +
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

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}

