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
    public partial class frmUpdateService : Form
    {
        frmMainMenu parent;
        public frmUpdateService()
        {
            InitializeComponent();
        }

        public frmUpdateService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //reference for autocomplete textbox http://www.simplylearnprogramming.com/autocomplete-textbox-from-database-using-csharp/51
        //OracleConnection myConn = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id =System;Password =opalPukkatw3lv3;");
        OracleConnection myConn = new OracleConnection("Data Source = oracle/orcl; User Id = t00170514; Password = b7iyeab9;");
        OracleCommand cmd;
        OracleDataReader dr;

        private void frmUpdateService_Load(object sender, EventArgs e)
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
            grdUpdateMatchingServices.Visible = true;
            grpUpdateMatchingServices.Visible = true;
            grdUpdateMatchingServices.AllowUserToAddRows = false;
        }

        private void btnFindServiceID_Click(object sender, EventArgs e)
        {
            if (!ValidateData.isBlank(txtEnterServiceID.Text))
            {
                grpUpdateMatchingServices.Visible = false;
                grdUpdateMatchingServices.Visible = false;
                MessageBox.Show("Service ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterServiceID.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtEnterServiceID.Text))
            {
                grpUpdateMatchingServices.Visible = false;
                grdUpdateMatchingServices.Visible = false;
                MessageBox.Show("Service ID cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterServiceID.Clear();
                txtEnterServiceID.Focus();
                return;
            }

            else if (!ValidateData.containsSpaces(txtServiceID.Text))
            {
                MessageBox.Show("Service ID cannot contain spaces", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Clear();
                txtServiceID.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                //grdUpdateMatchingServices.DataSource = Client.GetAllActiveServices(ds, txtEnterName.Text.ToUpper()).Tables["Services"];
                ds = Services.GetAllActiveServices(ds, txtEnterServiceID.Text.ToUpper());
                grdUpdateMatchingServices.DataSource = ds.Tables["searchActiveServices"];

                if (grdUpdateMatchingServices.Rows.Count == 0)
                {
                    grdUpdateMatchingServices.Visible = false;
                    grpUpdateMatchingServices.Visible = false;
                    MessageBox.Show("No service found. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEnterServiceID.Clear();
                    txtEnterServiceID.Focus();
                    return;
                }

                txtEnterServiceID.Clear();
                grdUpdateMatchingServices.Visible = true;
                grpUpdateMatchingServices.Visible = true;
            }
        }

        private void grdUpdateMatchingServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpUpdateMatchingServices.Visible = true;
            grpUpdateServices.Visible = true;

            //this is checking if the amount of rows in the grdUpdateMatchingServices is greater than 0
            if (grdUpdateMatchingServices.SelectedRows.Count > 0)
            {
                String ServiceID = grdUpdateMatchingServices.SelectedRows[0].Cells[0].Value + string.Empty;
                string Description = grdUpdateMatchingServices.SelectedRows[0].Cells[1].Value + string.Empty;
                string BaseRate = grdUpdateMatchingServices.SelectedRows[0].Cells[2].Value + string.Empty;

                txtServiceID.Text = ServiceID;

                txtDescription.Text = Description;

                txtBaseRate.Text = BaseRate;
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            grpUpdateMatchingServices.Visible = false;

            String ServiceID = txtServiceID.Text;

            string Description = txtDescription.Text;

            string BaseRate = txtBaseRate.Text;

            decimal parsedValue;

            if (!ValidateData.isBlank(txtServiceID.Text))
            {
                MessageBox.Show("Service ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Focus();
                return;
            }

            else if (!ValidateData.containsNumbers(txtServiceID.Text))
            {
                MessageBox.Show("Service ID cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Clear();
                txtServiceID.Focus();
                return;
            }

            else if (!ValidateData.containsSpaces(txtServiceID.Text))
            {
                MessageBox.Show("Service ID cannot contain spaces", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Clear();
                txtServiceID.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtDescription.Text))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            if (!ValidateData.isBlank(txtBaseRate.Text))
            {
                MessageBox.Show("Rate must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseRate.Focus();
                return;
            }

            else if (!decimal.TryParse(txtBaseRate.Text, out parsedValue))
            {
                MessageBox.Show("Rate must contain numeric only values.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtBaseRate.Clear();
                txtBaseRate.Focus();
                return;
            }

            else
            {
                //Update the data in the database based on the details changed in the text boxes(if any)
                Services.updateServices(txtServiceID.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDecimal(txtBaseRate.Text));

                //Create a new data set and re-populates the datagrid with all Services including the updated details  
                DataSet ds = new DataSet();
                grdUpdateMatchingServices.DataSource = Services.GetAllActiveServices(ds, txtServiceID.Text).Tables["searchActiveServices"];
                grdUpdateMatchingServices.Visible = true;

                txtServiceID.Clear();
                txtDescription.Clear();
                txtBaseRate.Clear();
                
                txtServiceID.Focus();

                // I need to check if the content is valid before adding it to the form
                //MessageBox item = new MessageBox(this.txtForename.Text);
                //this.textBox1.Items.Add(item);
                MessageBox.Show(text: "Service details updated!" +
                    Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID.ToUpper() +
                    Environment.NewLine + Environment.NewLine + "Description: " + Description.ToUpper() +
                    Environment.NewLine + Environment.NewLine + "Base Rate: " + BaseRate);

                grpUpdateServices.Visible = false;
            }
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }
    }
    
}
