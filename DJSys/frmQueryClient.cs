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
    public partial class frmQueryClient : Form
    {
        frmMainMenu parent;
        public frmQueryClient()
        {
            InitializeComponent();
        }

        public frmQueryClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmQueryClient_Load(object sender, EventArgs e)
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
        private void txtEnterSurname_TextChanged_1(object sender, EventArgs e)
        {
            grdQueryClients.Visible = true;
            grpQueryClients.Visible = true;
            grdQueryClients.AllowUserToAddRows = false;
        }

        private void btnFindClient_Click_1(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpQueryClients.Visible = false;
                grdQueryClients.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpQueryClients.Visible = false;
                grdQueryClients.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdQueryClients.DataSource = Client.GetAllActiveClients(ds, txtEnterName.Text.ToUpper()).Tables["Client"];
                ds = Client.GetAllActiveClients(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdQueryClients.DataSource = ds.Tables["searchActiveClient"];

                if (grdQueryClients.Rows.Count == 0)
                {
                    grdQueryClients.Visible = false;
                    grpQueryClients.Visible = false;
                    MessageBox.Show("No client found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdQueryClients.Visible = true;
                grpQueryClients.Visible = true;
            }
        }

        private void grdQueryClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpQueryClient.Visible = true;

            //this is checking if the amount of rows in the grdWithdrawMatchingClients is greater than 0
            if (grdQueryClients.SelectedRows.Count > 0)
            {
                String ClientID = grdQueryClients.SelectedRows[0].Cells[0].Value + string.Empty;
                string Forename = grdQueryClients.SelectedRows[0].Cells[1].Value + string.Empty;
                string Surname = grdQueryClients.SelectedRows[0].Cells[2].Value + string.Empty;
                string Date = grdQueryClients.SelectedRows[0].Cells[3].Value + string.Empty;
                String Contact = grdQueryClients.SelectedRows[0].Cells[4].Value + string.Empty;
                String Email = grdQueryClients.SelectedRows[0].Cells[5].Value + string.Empty;
                String Street = grdQueryClients.SelectedRows[0].Cells[6].Value + string.Empty;
                String Town = grdQueryClients.SelectedRows[0].Cells[7].Value + string.Empty;
                String City = grdQueryClients.SelectedRows[0].Cells[8].Value + string.Empty;
                String County = grdQueryClients.SelectedRows[0].Cells[9].Value + string.Empty;
                String Eircode = grdQueryClients.SelectedRows[0].Cells[10].Value + string.Empty;

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

        private void btnCheckActiveBookings_Click_1(object sender, EventArgs e)
        {
            grpQueryClients.Visible = false;
            grdQueryClientActiveBookings.AllowUserToAddRows = false;

            DataSet ds = new DataSet();
            //grdQueryClientActiveBookings.DataSource = Client.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = Client.GetAllActiveBookingsbyClientID(ds, Convert.ToInt32(txtClientID.Text));
            grdQueryClientActiveBookings.DataSource = ds.Tables["searchActiveBookingsbyClientID"];

            if (grdQueryClientActiveBookings.Rows.Count == 0)
            {
                grdQueryClientActiveBookings.Visible = false;
                grpQueryClientActiveBookings.Visible = false;
                MessageBox.Show(text: "No active bookings for client found.");
                return;
            }

            else
                grdQueryClientActiveBookings.Visible = true;
                grpQueryClientActiveBookings.Visible = true;
                grdQueryClientActiveBookings.AllowUserToAddRows = false;
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
