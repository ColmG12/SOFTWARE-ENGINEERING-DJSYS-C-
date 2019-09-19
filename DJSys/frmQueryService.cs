using DJSys;
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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace DJSys
{
    public partial class frmQueryService : Form
    {
        frmMainMenu parent;
        public frmQueryService()
        {
            InitializeComponent();
        }

        public frmQueryService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmQueryService_Load(object sender, EventArgs e)
        {
            txtEnterServiceID.Select();

            //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
            cmd = new OracleCommand("SELECT Service_ID FROM Services", myConn);
            myConn.Open();
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            txtEnterServiceID.AutoCompleteCustomSource = Collection;
            dr.Close();
            myConn.Close();
        }

        private void txtEnterServiceID_TextChanged(object sender, EventArgs e)
        {
            grdQueryMatchingServices.Visible = true;
            grpQueryMachingServices.Visible = true;
            grdQueryMatchingServices.AllowUserToAddRows = false;
        }

        private void btnFindService_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterServiceID.Text))
            {
                grpQueryMachingServices.Visible = false;
                grdQueryMatchingServices.Visible = false;
                MessageBox.Show("Service ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterServiceID.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterServiceID.Text))
            {
                grpQueryMachingServices.Visible = false;
                grdQueryMatchingServices.Visible = false;
                MessageBox.Show("Service ID cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterServiceID.Clear();
                txtEnterServiceID.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdQueryServices.DataSource = Services.GetAllActiveServices(ds, txtServiceID.Text.ToUpper()).Tables["Services"];
                ds = Services.GetAllActiveServices(ds, txtEnterServiceID.Text.ToUpper());
                grdQueryMatchingServices.DataSource = ds.Tables["searchActiveServices"];

                if (grdQueryMatchingServices.Rows.Count == 0)
                {
                    grdQueryMatchingServices.Visible = false;
                    grpQueryMachingServices.Visible = false;
                    MessageBox.Show("No Service found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterServiceID.Clear();
                    txtEnterServiceID.Focus();
                    return;
                }

                txtEnterServiceID.Clear();
                grdQueryMatchingServices.Visible = true;
                grpQueryMachingServices.Visible = true;
            }

        }

        private void grdQueryServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpQueryServices.Visible = true;

            //this is checking if the amount of rows in the grdWithdrawMatchingClients is greater than 0
            if (grdQueryMatchingServices.SelectedRows.Count > 0)
            {
                string ServiceID = grdQueryMatchingServices.SelectedRows[0].Cells[0].Value + string.Empty;
                string Description = grdQueryMatchingServices.SelectedRows[0].Cells[1].Value + string.Empty;
                string BaseRate = grdQueryMatchingServices.SelectedRows[0].Cells[2].Value + string.Empty;
                
                txtServiceID.Text = ServiceID;

                txtDescription.Text = Description;

                txtBaseRate.Text = BaseRate;
            }
        }

        private void btnCheckActiveBookings_Click(object sender, EventArgs e)
        {
            grpQueryMachingServices.Visible = false;
            grdQueryServicesActiveBookings.AllowUserToAddRows = false;

            DataSet ds = new DataSet();
            //grdQueryServicesActiveBookings.DataSource = Services.GetAllBookings(ds, txtServiceID.Text.ToUpper()).Tables["Bookings"];
            ds = Services.GetAllBookings(ds, txtServiceID.Text);
            grdQueryServicesActiveBookings.DataSource = ds.Tables["searchServiceBookings"];

            if (grdQueryServicesActiveBookings.Rows.Count == 0)
            {
                grdQueryServicesActiveBookings.Visible = false;
                grpQueryServicesActiveBookings.Visible = false;
                MessageBox.Show(text: "No active bookings for service found.");
                return;
            }

            else
                grdQueryServicesActiveBookings.Visible = true;
                grpQueryServicesActiveBookings.Visible = true;
                grdQueryServicesActiveBookings.AllowUserToAddRows = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }     
    }
}
