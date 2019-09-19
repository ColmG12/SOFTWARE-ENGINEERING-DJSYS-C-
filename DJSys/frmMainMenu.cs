using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJSys
{
    public partial class frmMainMenu : Form
    {

        frmMainMenu parent;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient AddClient = new frmAddClient(this);
            AddClient.ShowDialog();
        }

        private void mnuUpdateClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateClient UpdateClient = new frmUpdateClient(this);
            UpdateClient.ShowDialog();
        }

        private void mnuWithdrawClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWithdrawClient WithdrawClient = new frmWithdrawClient(this);
            WithdrawClient.ShowDialog();
        }

        private void mnuQueryClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryClient QueryClient = new frmQueryClient(this);
            QueryClient.ShowDialog();
        }

        private void mnuLogService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogService LogService = new frmLogService(this);
            LogService.ShowDialog();
        }

        private void mnuUpdateService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateService UpdateService = new frmUpdateService(this);
            UpdateService.ShowDialog();
        }

        private void mnuQueryService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryService QueryService = new frmQueryService(this);
            QueryService.ShowDialog();
        }

        private void mnuAddDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDJ AddDJ = new frmAddDJ(this);
            AddDJ.ShowDialog();
        }

        private void mnuWithdrawDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWithdrawDJ WithdrawDJ = new frmWithdrawDJ(this);
            WithdrawDJ.ShowDialog();
        }

        private void mnuShowDJSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowDJSchedule ShowDJSchedule = new frmShowDJSchedule(this);
            ShowDJSchedule.ShowDialog();
        }

        private void mnuMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking MakeBooking = new frmMakeBooking(this);
            MakeBooking.ShowDialog();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking CancelBooking = new frmCancelBooking(this);
            CancelBooking.ShowDialog();
        }

        private void mnuChangeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangeBooking ChangeBooking = new frmChangeBooking(this);
            ChangeBooking.ShowDialog();
        }

        private void mnuAnalyseRevenueByMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalyseRevenueByYear AnalyseRevenueByMonth = new frmAnalyseRevenueByYear(this);
            AnalyseRevenueByMonth.ShowDialog();
        }

        private void mnuAnalyseRevenueByService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalyseRevenueByService AnalyseRevenueByService = new frmAnalyseRevenueByService(this);
            AnalyseRevenueByService.ShowDialog();
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void picColmGBusinessCard_Click(object sender, EventArgs e)
        {

        }
    }
}
