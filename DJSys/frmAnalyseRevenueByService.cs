using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using DJSys;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using JR.Utils.GUI.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DJSys
{
    public partial class frmAnalyseRevenueByService : Form
    {
        frmMainMenu parent;
        public frmAnalyseRevenueByService()
        {
            InitializeComponent();
        }

        public frmAnalyseRevenueByService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAnalyseRevenueByService_Load(object sender, EventArgs e)
        {
            cboYear.Select();
            chtAnalyseByService.Visible = false;

            //reference for eliminating duplicates https://stackoverflow.com/questions/13208457/allow-only-distinct-values-in-combobox
            DataSet ds = new DataSet();
            ds = Analysis.GetYear(ds);

            for (int i = 0; i < ds.Tables["searchYear"].Rows.Count; i++)
            {
                var val = ds.Tables[0].Rows[i][0].ToString();

                //check if it already exists
                if (!cboYear.Items.Contains(val))
                {
                    cboYear.Items.Add(val);
                }
            }

            //define chart
            defineChart();

            //Define the chart series
            defineSeries();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex == -1)
            {
                return;
            }

            chtAnalyseByService.Visible = true;
            btnPrintGraphAnalyseByService.Visible = true;
            btnSelectAgain.Visible = true;

            //fill Chart
            displayChart();

            //Attempt to clear chart from overlapping by clearing combobox https://stackoverflow.com/questions/9999458/clear-combobox-selected-text/29588637
            //cboYear.Text = "";

            cboYear.Visible = false;
        }

        private void defineChart()
        {
            //define chart
            chtAnalyseByService.Size = new Size(1300, 650);
            chtAnalyseByService.ChartAreas[0].Name = "mainArea";
            chtAnalyseByService.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtAnalyseByService.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtAnalyseByService.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtAnalyseByService.ChartAreas["mainArea"].AxisY.Interval = 1000;
            chtAnalyseByService.ChartAreas["mainArea"].AxisY.Title = "EUROS";

            chtAnalyseByService.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtAnalyseByService.ChartAreas["mainArea"].AxisX.Title = "SERVICES";

            chtAnalyseByService.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chtAnalyseByService.Titles.Add(cboYear.Text.ToString() + "Service Revenue");
        }

        private void defineSeries()
        {
            chtAnalyseByService.Series.Clear();
            chtAnalyseByService.Series.Add("ChartArea1");

            chtAnalyseByService.Series["ChartArea1"].ChartType = SeriesChartType.Column;
            chtAnalyseByService.Series["ChartArea1"].XValueType = ChartValueType.String;
        }

        private void displayChart()
        {
            chtAnalyseByService.Series["ChartArea1"].Points.Clear();

            //Reference guide for using substring https://www.dotnetperls.com/substring
            string year = cboYear.Text.Substring(2, 2);

            DataTable dt = new DataTable();
            dt = Analysis.GetRevenueByService(dt, year);

            string[] Services = new string[dt.Rows.Count];
            decimal[] Totals = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Services[i] = Convert.ToString(dt.Rows[i][0]);
                Totals[i] = Convert.ToDecimal(dt.Rows[i][1]);
            }
             
            chtAnalyseByService.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtAnalyseByService.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtAnalyseByService.Series[0].LegendText = "Income in € by Service";
            chtAnalyseByService.Series[0].Points.DataBindXY(Services, Totals);
            chtAnalyseByService.ChartAreas[0].AxisX.LabelStyle.Format = "MM";
            chtAnalyseByService.ChartAreas[0].AxisX.ToString();
   
            //chtSales.Series[0].Points[0] = "XXX";

            chtAnalyseByService.Series[0].Label = "#VALY";
            //chtAnalyseByYear.ChartAreas[0].Label = "#VALX";

            chtAnalyseByService.Visible = true;
        }

        //Reference for printing a graph https://www.codeproject.com/Articles/196579/How-to-Print-Invoice-using-C
        private void btnPrintGraphAnalyseByService_Click_1(object sender, EventArgs e)
        {
            chtAnalyseByService.Printing.PrintPreview();
        }

        private void btnSelectAgain_Click(object sender, EventArgs e)
        {
            chtAnalyseByService.Visible = false;
            chtAnalyseByService.Hide();
            cboYear.Visible = true;
            cboYear.Select();
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
