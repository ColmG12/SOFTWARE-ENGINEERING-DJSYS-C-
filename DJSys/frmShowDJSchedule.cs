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
    public partial class frmShowDJSchedule : Form
    {
        frmMainMenu parent;
        public frmShowDJSchedule()
        {
            InitializeComponent();
        }

        public frmShowDJSchedule(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmShowDJSchedule_Load(object sender, EventArgs e)
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
            grdDJScheduleMatchingDJs.Visible = true;
            grpDJScheduleMatchingDJs.Visible = true;
            grdDJScheduleMatchingDJs.AllowUserToAddRows = false;
        }

        private void btnFindDJ_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterSurname.Text))
            {
                grpDJScheduleMatchingDJs.Visible = false;
                grdDJScheduleMatchingDJs.Visible = false;
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterSurname.Text))
            {
                grpDJScheduleMatchingDJs.Visible = false;
                grdDJScheduleMatchingDJs.Visible = false;
                MessageBox.Show("Surname cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSurname.Clear();
                txtEnterSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdDJScheduleMatchingDJs.DataSource = DJs.GetAllActiveDJs(ds, txtEnterName.Text.ToUpper()).Tables["DJs"];
                ds = DJs.GetAllActiveDJs(ds, ValidateData.apostChecker(txtEnterSurname.Text.ToUpper()));
                grdDJScheduleMatchingDJs.DataSource = ds.Tables["searchActiveDJs"];

                if (grdDJScheduleMatchingDJs.Rows.Count == 0)
                {
                    grdDJScheduleMatchingDJs.Visible = false;
                    grpDJScheduleMatchingDJs.Visible = false;
                    MessageBox.Show("No DJ found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterSurname.Clear();
                    txtEnterSurname.Focus();
                    return;
                }

                txtEnterSurname.Clear();
                grdDJScheduleMatchingDJs.Visible = true;
                grpDJScheduleMatchingDJs.Visible = true;
            }
        }

        private void grdDJScheduleMatchingDJs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDJScheduleMatchingDJs.Visible = true;
            grpDJScheduleDJ.Visible = true;
            //this is checking if the amount of rows in the grdDJScheduleMatchingDJs is greater than 0
            if (grdDJScheduleMatchingDJs.SelectedRows.Count > 0)
            {
                String DJID = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[0].Value + string.Empty;
                string Forename = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[1].Value + string.Empty;
                string Surname = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[2].Value + string.Empty;
                string Date = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[3].Value + string.Empty;
                String Contact = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[4].Value + string.Empty;
                String Email = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[5].Value + string.Empty;
                String Street = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[6].Value + string.Empty;
                String Town = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[7].Value + string.Empty;
                String City = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[8].Value + string.Empty;
                String County = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[9].Value + string.Empty;
                String Eircode = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[10].Value + string.Empty;
                String HourlyRate = grdDJScheduleMatchingDJs.SelectedRows[0].Cells[11].Value + string.Empty;

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
            grpDJScheduleMatchingDJs.Visible = false;
            grdDJScheduleDJActiveBookings.AllowUserToAddRows = false;

            DataSet ds = new DataSet();
            //grdDJScheduleDJsActiveBookings.DataSource = DJs.GetAllBookings(ds, txtEnterName.Text.ToUpper()).Tables["Bookings"];
            ds = DJs.GetAllBookings(ds, Convert.ToInt32(txtDJID.Text));
            grdDJScheduleDJActiveBookings.DataSource = ds.Tables["searchBookings"];

            if (grdDJScheduleDJActiveBookings.Rows.Count == 0)
            {
                grdDJScheduleDJActiveBookings.Visible = false;
                grpDJScheduleDJActiveBookings.Visible = false;
                MessageBox.Show(text: "No active bookings for DJ found.");
                return;
            }

            else
                grdDJScheduleDJActiveBookings.Visible = true;
                grpDJScheduleDJActiveBookings.Visible = true;
                grdDJScheduleDJActiveBookings.AllowUserToAddRows = false;
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
