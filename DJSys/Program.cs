using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJSys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
            Application.Run(new frmAddClient());
            Application.Run(new frmUpdateClient());
            Application.Run(new frmWithdrawClient());
            Application.Run(new frmQueryClient());
            Application.Run(new frmLogService());
            Application.Run(new frmUpdateService());
            Application.Run(new frmQueryService());
            Application.Run(new frmAddDJ());
            Application.Run(new frmWithdrawDJ());
            Application.Run(new frmShowDJSchedule());
            Application.Run(new frmMakeBooking());
            Application.Run(new frmCancelBooking());
            Application.Run(new frmChangeBooking());
            Application.Run(new frmAnalyseRevenueByYear());
            Application.Run(new frmAnalyseRevenueByService());
        }
    }
}
