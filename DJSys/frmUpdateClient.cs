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
    public partial class frmUpdateClient : Form
    {
        frmMainMenu parent;
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        public frmUpdateClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmUpdateClient_Load(object sender, EventArgs e)
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
        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            grdUpdateMatchingClients.Visible = true;
            grpUpdateMatchingClients.Visible = true;
            grdUpdateMatchingClients.AllowUserToAddRows = false;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            //grpUpdateMatchingClients.Visible = true;

            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpUpdateMatchingClients.Visible = false;
                grdUpdateMatchingClients.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpUpdateMatchingClients.Visible = false;
                grdUpdateMatchingClients.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdUpdateMatchingClients.DataSource = Client.GetAllActiveClients(ds, txtEnterName.Text.ToUpper()).Tables["Client"];
                ds = Client.GetAllActiveClients(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdUpdateMatchingClients.DataSource = ds.Tables["searchActiveClient"];

                if (grdUpdateMatchingClients.Rows.Count == 0)
                {
                    grdUpdateMatchingClients.Visible = false;
                    grpUpdateMatchingClients.Visible = false;
                    MessageBox.Show("No client found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdUpdateMatchingClients.Visible = true;
                grpUpdateMatchingClients.Visible = true;
            }
        }

        private void grdUpdateMatchingClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpUpdateMatchingClients.Visible = true;
            grpUpdateClient.Visible = true;
            //this is checking if the amount of rows in the grdUpdateMatchingClients is greater than 0
            if (grdUpdateMatchingClients.SelectedRows.Count > 0)
            {
                String ClientID = grdUpdateMatchingClients.SelectedRows[0].Cells[0].Value + string.Empty;
                string Forename = grdUpdateMatchingClients.SelectedRows[0].Cells[1].Value + string.Empty;
                string Surname = grdUpdateMatchingClients.SelectedRows[0].Cells[2].Value + string.Empty;
                string Date = grdUpdateMatchingClients.SelectedRows[0].Cells[3].Value + string.Empty;
                String Contact = grdUpdateMatchingClients.SelectedRows[0].Cells[4].Value + string.Empty;
                String Email = grdUpdateMatchingClients.SelectedRows[0].Cells[5].Value + string.Empty;
                String Street = grdUpdateMatchingClients.SelectedRows[0].Cells[6].Value + string.Empty;
                String Town = grdUpdateMatchingClients.SelectedRows[0].Cells[7].Value + string.Empty;
                String City = grdUpdateMatchingClients.SelectedRows[0].Cells[8].Value + string.Empty;
                String County = grdUpdateMatchingClients.SelectedRows[0].Cells[9].Value + string.Empty;
                String Eircode = grdUpdateMatchingClients.SelectedRows[0].Cells[10].Value + string.Empty;

                txtClientID.Text = ClientID;

                txtForename.Text = Forename;

                txtSurname.Text = Surname;

                dtpDateOfBirth.Text = Date;

                txtContactNo.Text = Contact;

                txtEmail.Text = Email;

                txtStreet.Text = Street;

                txtTown.Text = Town;

                txtCity.Text = City;

                cboCounty.Text = County;

                txtEircode.Text = Eircode;

                //reference for eliminating duplicates https://stackoverflow.com/questions/37057116/c-sharp-how-to-eliminate-duplicate-values-from-combobox

                DataSet ds = new DataSet();
                ds = Client.GetCounty(ds);

                for (int i = 0; i < ds.Tables["searchCounty"].Rows.Count; i++)
                {
                    cboCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
                }
            }
        }

        private void cboCounty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCounty.SelectedIndex == -1)
            {
                return;
            }
        }

        private void btnUpdateClient_Click_1(object sender, EventArgs e)
        {

            grpUpdateMatchingClients.Visible = false;

            String ClientID = txtClientID.Text;

            String Forename = txtForename.Text;

            String Surname = txtSurname.Text;

            DateTime Date = dtpDateOfBirth.Value;

            String Contact = txtContactNo.Text;

            String Email = txtEmail.Text;

            String Street = txtStreet.Text;

            String Town = txtTown.Text;

            String City = txtCity.Text;

            String County = cboCounty.Text;

            String Eircode = txtEircode.Text;

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
                if (!Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    //MessageBox.Show("Email must be valid format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //else if (!ValidateData.onlyNumbers(txtStreet.Text))
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
            //else if (!ValidateData.onlyNumbers(txtTown.Text))
            {
                MessageBox.Show("Town cannot contain numbers only", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Clear();
                txtTown.Focus();
                return;
            }

            if (int.TryParse(txtCity.Text, out parsedValue))
            //if (!ValidateData.onlyNumbers(txtCity.Text))
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

            else
                {
                    //Update the data in the database based on the details changed in the text boxes(if any)
                    Client.updateClient(Convert.ToInt16(txtClientID.Text), ValidateData.apostChecker(txtForename.Text.ToUpper()), ValidateData.apostChecker(txtSurname.Text.ToUpper()), 
                                        dtpDateOfBirth.Text.ToUpper(), txtContactNo.Text.ToUpper(), txtEmail.Text.ToLower(), ValidateData.apostChecker(txtStreet.Text.ToUpper()), 
                                        ValidateData.apostChecker(txtTown.Text.ToUpper()), ValidateData.apostChecker(txtCity.Text.ToUpper()), cboCounty.Text.ToUpper(), txtEircode.Text.ToUpper());

                    txtClientID.Clear();
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
                    txtEnterSurname.Focus();


                // I need to check if the content is valid before adding it to the form
                //MessageBox item = new MessageBox(this.txtForename.Text);
                //this.textBox1.Items.Add(item);
                MessageBox.Show(text: "Client details updated!" +
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
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("colmgdjsystem@gmail.com", "Legend DJs");
                mail.To.Add("colmg12@hotmail.co.uk");
                mail.IsBodyHtml = true;
                mail.Subject = "Updated Client details";
                //string html = "";
                mail.Body =
                                "Dear " + Forename + "," +
                                "<br/><br/>Thanks for updating your information details with Legend DJs." +
                                "<br/><br/>We look forward to continuing our great working relationship with you." +
                                "<br/><br/>Please check the details below to ensure that the information you updated is correct. You can update this information again, at any time, by contacting us." +
                                "<br/><br/><h1>Client details updated!</h1>" +
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

                grpUpdateClient.Visible = false;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
                this.Close();
                parent.Visible = true;
        }
    }
}


    
    

