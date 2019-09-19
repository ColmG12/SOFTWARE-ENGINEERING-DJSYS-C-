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
    public partial class frmAnalyseRevenueByYear : Form
    {
        frmMainMenu parent;
        public frmAnalyseRevenueByYear()
        {
            InitializeComponent();
        }

        public frmAnalyseRevenueByYear(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAnalyseRevenueByMonth_Load(object sender, EventArgs e)
        {
            cboYear.Select();
            chtAnalyseByYear.Visible = false;

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

            chtAnalyseByYear.Visible = true;
            btnPrintGraphAnalyseByYear.Visible = true;
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
            chtAnalyseByYear.Size = new Size(1300, 650);
            chtAnalyseByYear.ChartAreas[0].Name = "mainArea";
            chtAnalyseByYear.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtAnalyseByYear.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtAnalyseByYear.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtAnalyseByYear.ChartAreas["mainArea"].AxisY.Interval = 10000;
            chtAnalyseByYear.ChartAreas["mainArea"].AxisY.Title = "EUROS";

            chtAnalyseByYear.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtAnalyseByYear.ChartAreas["mainArea"].AxisX.Title = "MONTHS";
            
            chtAnalyseByYear.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chtAnalyseByYear.Titles.Add("Yearly Revenue");
        }

        private void defineSeries()
        {
            chtAnalyseByYear.Series.Clear();
            chtAnalyseByYear.Series.Add("ChartArea1");

            chtAnalyseByYear.Series["ChartArea1"].ChartType = SeriesChartType.Column;
            chtAnalyseByYear.Series["ChartArea1"].XValueType = ChartValueType.String;
        }

        private void displayChart()
        {
            chtAnalyseByYear.Series["ChartArea1"].Points.Clear();

            //Reference guide for using substring https://www.dotnetperls.com/substring
            string year = cboYear.Text.Substring(2, 2);

            DataTable dt = new DataTable();
            dt = Analysis.GetRevenueByYear(dt, year);

            string[] Months = new string[dt.Rows.Count];
            decimal[] Totals = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Months[i] = getMonth(Convert.ToInt32(dt.Rows[i][0]));
                Totals[i] = Convert.ToDecimal(dt.Rows[i][1]);
            }

            //order the arrays Months and Totals 

            chtAnalyseByYear.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtAnalyseByYear.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtAnalyseByYear.Series[0].LegendText = "Income in €";
            chtAnalyseByYear.Series[0].Points.DataBindXY(Months, Totals);
            chtAnalyseByYear.ChartAreas[0].AxisX.LabelStyle.Format = "MM";

            //chtSales.Series[0].Points[0] = "XXX";

            chtAnalyseByYear.Series[0].Label = "#VALY";
            //chtAnalyseByYear.ChartAreas[0].Label = "#VALX";

            chtAnalyseByYear.Visible = true;
        }

        public String getMonth(int month)
        {
            // switch statement which converts integer value to string         
            string getMonth = "";
            switch (month)
            {
                case 1:
                    
                        getMonth = "JAN";
                        break;
                    

                case 2:
                    
                        getMonth = "FEB";
                        break;
                    

                case 3:
                    
                        getMonth = "MAR";
                        break;
                    

                case 4:
                    
                        getMonth = "APR";
                        break;
                    
                case 5:
                    
                        getMonth = "MAY";
                        break;
                    

                case 6:
                    
                        getMonth = "JUN";
                        break;
                    

                case 7:
                    
                        getMonth = "JUL";
                        break;
                    

                case 8:
                    
                        getMonth = "AUG";
                        break;
                    
                case 9:
                    
                        getMonth = "SEP";
                        break;
                    

                case 10:
                    
                        getMonth = "OCT";
                        break;
                    

                case 11:
                    
                        getMonth = "NOV";
                        break;
                    

                case 12:
                    
                        getMonth = "DEC";
                        break;                 
            }

            return getMonth;
        }

        //Reference for printing a graph https://www.codeproject.com/Articles/196579/How-to-Print-Invoice-using-C
        private void btnPrintGraph_Click(object sender, EventArgs e)
        {
            chtAnalyseByYear.Printing.PrintPreview();
        }

        private void btnSelectAgain_Click(object sender, EventArgs e)
        {
            chtAnalyseByYear.Visible = false;
            chtAnalyseByYear.Hide();
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
