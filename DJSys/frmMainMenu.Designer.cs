namespace DJSys
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdrawClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDJs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDJ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdrawDJ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowDJSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRevenueByYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRevenueByService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picColmGBusinessCard = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColmGBusinessCard)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClient,
            this.mnuServices,
            this.mnuDJs,
            this.mnuBookings,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1884, 35);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // mnuClient
            // 
            this.mnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddClient,
            this.mnuUpdateClient,
            this.mnuWithdrawClient,
            this.mnuQueryClient});
            this.mnuClient.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(93, 31);
            this.mnuClient.Text = "Client";
            // 
            // mnuAddClient
            // 
            this.mnuAddClient.Name = "mnuAddClient";
            this.mnuAddClient.Size = new System.Drawing.Size(277, 32);
            this.mnuAddClient.Text = "Add Client";
            this.mnuAddClient.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(277, 32);
            this.mnuUpdateClient.Text = "Update Client";
            this.mnuUpdateClient.Click += new System.EventHandler(this.mnuUpdateClient_Click);
            // 
            // mnuWithdrawClient
            // 
            this.mnuWithdrawClient.Name = "mnuWithdrawClient";
            this.mnuWithdrawClient.Size = new System.Drawing.Size(277, 32);
            this.mnuWithdrawClient.Text = "Withdraw Client";
            this.mnuWithdrawClient.Click += new System.EventHandler(this.mnuWithdrawClient_Click);
            // 
            // mnuQueryClient
            // 
            this.mnuQueryClient.Name = "mnuQueryClient";
            this.mnuQueryClient.Size = new System.Drawing.Size(277, 32);
            this.mnuQueryClient.Text = "Query Client";
            this.mnuQueryClient.Click += new System.EventHandler(this.mnuQueryClient_Click);
            // 
            // mnuServices
            // 
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogService,
            this.mnuUpdateService,
            this.mnuQueryService});
            this.mnuServices.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Size = new System.Drawing.Size(119, 31);
            this.mnuServices.Text = "Services";
            // 
            // mnuLogService
            // 
            this.mnuLogService.Name = "mnuLogService";
            this.mnuLogService.Size = new System.Drawing.Size(265, 32);
            this.mnuLogService.Text = "Log Service";
            this.mnuLogService.Click += new System.EventHandler(this.mnuLogService_Click);
            // 
            // mnuUpdateService
            // 
            this.mnuUpdateService.Name = "mnuUpdateService";
            this.mnuUpdateService.Size = new System.Drawing.Size(265, 32);
            this.mnuUpdateService.Text = "Update Service";
            this.mnuUpdateService.Click += new System.EventHandler(this.mnuUpdateService_Click);
            // 
            // mnuQueryService
            // 
            this.mnuQueryService.Name = "mnuQueryService";
            this.mnuQueryService.Size = new System.Drawing.Size(265, 32);
            this.mnuQueryService.Text = "Query Service";
            this.mnuQueryService.Click += new System.EventHandler(this.mnuQueryService_Click);
            // 
            // mnuDJs
            // 
            this.mnuDJs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDJ,
            this.mnuWithdrawDJ,
            this.mnuShowDJSchedule});
            this.mnuDJs.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDJs.Name = "mnuDJs";
            this.mnuDJs.Size = new System.Drawing.Size(63, 31);
            this.mnuDJs.Text = "DJs";
            // 
            // mnuAddDJ
            // 
            this.mnuAddDJ.Name = "mnuAddDJ";
            this.mnuAddDJ.Size = new System.Drawing.Size(297, 32);
            this.mnuAddDJ.Text = "Add DJ";
            this.mnuAddDJ.Click += new System.EventHandler(this.mnuAddDJ_Click);
            // 
            // mnuWithdrawDJ
            // 
            this.mnuWithdrawDJ.Name = "mnuWithdrawDJ";
            this.mnuWithdrawDJ.Size = new System.Drawing.Size(297, 32);
            this.mnuWithdrawDJ.Text = "Withdraw DJ";
            this.mnuWithdrawDJ.Click += new System.EventHandler(this.mnuWithdrawDJ_Click);
            // 
            // mnuShowDJSchedule
            // 
            this.mnuShowDJSchedule.Name = "mnuShowDJSchedule";
            this.mnuShowDJSchedule.Size = new System.Drawing.Size(297, 32);
            this.mnuShowDJSchedule.Text = "Show DJ Schedule";
            this.mnuShowDJSchedule.Click += new System.EventHandler(this.mnuShowDJSchedule_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuCancelBooking,
            this.mnuChangeBooking});
            this.mnuBookings.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(134, 31);
            this.mnuBookings.Text = "Bookings";
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(287, 32);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(287, 32);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuChangeBooking
            // 
            this.mnuChangeBooking.Name = "mnuChangeBooking";
            this.mnuChangeBooking.Size = new System.Drawing.Size(287, 32);
            this.mnuChangeBooking.Text = "Change Booking";
            this.mnuChangeBooking.Click += new System.EventHandler(this.mnuChangeBooking_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseRevenueByYear,
            this.mnuAnalyseRevenueByService});
            this.mnuAdmin.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(104, 31);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuAnalyseRevenueByYear
            // 
            this.mnuAnalyseRevenueByYear.Name = "mnuAnalyseRevenueByYear";
            this.mnuAnalyseRevenueByYear.Size = new System.Drawing.Size(417, 32);
            this.mnuAnalyseRevenueByYear.Text = "Analyse Revenue by Year";
            this.mnuAnalyseRevenueByYear.Click += new System.EventHandler(this.mnuAnalyseRevenueByMonth_Click);
            // 
            // mnuAnalyseRevenueByService
            // 
            this.mnuAnalyseRevenueByService.Name = "mnuAnalyseRevenueByService";
            this.mnuAnalyseRevenueByService.Size = new System.Drawing.Size(417, 32);
            this.mnuAnalyseRevenueByService.Text = "Analyse Revenue by Service";
            this.mnuAnalyseRevenueByService.Click += new System.EventHandler(this.mnuAnalyseRevenueByService_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(69, 31);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picColmGBusinessCard
            // 
            this.picColmGBusinessCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picColmGBusinessCard.Image = global::DJSys.Properties.Resources.ColmG_BusinessCard6;
            this.picColmGBusinessCard.Location = new System.Drawing.Point(6, 39);
            this.picColmGBusinessCard.Margin = new System.Windows.Forms.Padding(4);
            this.picColmGBusinessCard.Name = "picColmGBusinessCard";
            this.picColmGBusinessCard.Size = new System.Drawing.Size(1051, 523);
            this.picColmGBusinessCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picColmGBusinessCard.TabIndex = 0;
            this.picColmGBusinessCard.TabStop = false;
            this.picColmGBusinessCard.Click += new System.EventHandler(this.picColmGBusinessCard_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1884, 958);
            this.Controls.Add(this.picColmGBusinessCard);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainMenu";
            this.Text = "DJSys - MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColmGBusinessCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picColmGBusinessCard;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuAddClient;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdrawClient;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryClient;
        private System.Windows.Forms.ToolStripMenuItem mnuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuLogService;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateService;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryService;
        private System.Windows.Forms.ToolStripMenuItem mnuDJs;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDJ;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdrawDJ;
        private System.Windows.Forms.ToolStripMenuItem mnuShowDJSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRevenueByYear;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRevenueByService;
    }
}

