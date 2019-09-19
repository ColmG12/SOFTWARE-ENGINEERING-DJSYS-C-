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
    public partial class frmLogService : Form
    {
        frmMainMenu parent;
        //create a datset to be used later
        //DataSet ds = new DataSet();
        public frmLogService()
        {
            InitializeComponent();
        }

        public frmLogService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmLogService_Load(object sender, EventArgs e)
        {
            txtServiceID.Select();
        }

        private void btnLogService_Click(object sender, EventArgs e)
        {
            string ServiceID = txtServiceID.Text;
            string Description = txtDescription.Text;
            //Reference to show how to allow numbers only inside a text box https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = Convert.ToDecimal(txtBaseRate.Text);

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

            Services service = new Services(txtServiceID.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDecimal(txtBaseRate.Text), "A");
            service.LogService();

            txtServiceID.Clear();
            txtDescription.Clear();
            txtBaseRate.Clear();

            txtServiceID.Focus();

            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " +  ServiceID.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Description: " + Description.ToUpper() +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);
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
