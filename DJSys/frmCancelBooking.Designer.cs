namespace DJSys
{
    partial class frmCancelBooking
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
            this.btnMain = new System.Windows.Forms.Button();
            this.grpCancelBookingActiveBookings = new System.Windows.Forms.GroupBox();
            this.grdCancelBookingActiveBookings = new System.Windows.Forms.DataGridView();
            this.grpCancelBooking = new System.Windows.Forms.GroupBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnClientLegendDJsCancellation = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnClientConfirmCancellation = new System.Windows.Forms.Button();
            this.pnlCancelBooking2 = new System.Windows.Forms.Panel();
            this.lblRefundDue = new System.Windows.Forms.Label();
            this.lblRefundPercentage = new System.Windows.Forms.Label();
            this.txtRefundPercentage = new System.Windows.Forms.TextBox();
            this.txtRefundDue = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.pnlCancelBooking = new System.Windows.Forms.Panel();
            this.btnClientCancelBooking = new System.Windows.Forms.Button();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.btnLegendDJsCancelBooking = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtDJID = new System.Windows.Forms.TextBox();
            this.lblDJID = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.grpCancelBookingMatchingClients = new System.Windows.Forms.GroupBox();
            this.grdCancelBookingMatchingClients = new System.Windows.Forms.DataGridView();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.btnCancelBookingClientPrintInvoice = new System.Windows.Forms.Button();
            this.btnCancelBookingLegendDJsPrintInvoice = new System.Windows.Forms.Button();
            this.grpCancelBookingActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBookingActiveBookings)).BeginInit();
            this.grpCancelBooking.SuspendLayout();
            this.pnlCancelBooking2.SuspendLayout();
            this.pnlCancelBooking.SuspendLayout();
            this.grpCancelBookingMatchingClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBookingMatchingClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 834);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 37;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // grpCancelBookingActiveBookings
            // 
            this.grpCancelBookingActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpCancelBookingActiveBookings.Controls.Add(this.grdCancelBookingActiveBookings);
            this.grpCancelBookingActiveBookings.Location = new System.Drawing.Point(764, 88);
            this.grpCancelBookingActiveBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBookingActiveBookings.Name = "grpCancelBookingActiveBookings";
            this.grpCancelBookingActiveBookings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBookingActiveBookings.Size = new System.Drawing.Size(759, 497);
            this.grpCancelBookingActiveBookings.TabIndex = 58;
            this.grpCancelBookingActiveBookings.TabStop = false;
            this.grpCancelBookingActiveBookings.Text = "Active Bookings";
            this.grpCancelBookingActiveBookings.Visible = false;
            // 
            // grdCancelBookingActiveBookings
            // 
            this.grdCancelBookingActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdCancelBookingActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCancelBookingActiveBookings.Location = new System.Drawing.Point(7, 21);
            this.grdCancelBookingActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdCancelBookingActiveBookings.Name = "grdCancelBookingActiveBookings";
            this.grdCancelBookingActiveBookings.ReadOnly = true;
            this.grdCancelBookingActiveBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCancelBookingActiveBookings.Size = new System.Drawing.Size(744, 460);
            this.grdCancelBookingActiveBookings.TabIndex = 1;
            this.grdCancelBookingActiveBookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCancelBookingActiveBookings_CellDoubleClick);
            // 
            // grpCancelBooking
            // 
            this.grpCancelBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpCancelBooking.Controls.Add(this.dtpEventDate);
            this.grpCancelBooking.Controls.Add(this.btnClientLegendDJsCancellation);
            this.grpCancelBooking.Controls.Add(this.lblForename);
            this.grpCancelBooking.Controls.Add(this.txtForename);
            this.grpCancelBooking.Controls.Add(this.btnClientConfirmCancellation);
            this.grpCancelBooking.Controls.Add(this.pnlCancelBooking2);
            this.grpCancelBooking.Controls.Add(this.dtpBookingDate);
            this.grpCancelBooking.Controls.Add(this.lblBookingDate);
            this.grpCancelBooking.Controls.Add(this.lblBookingID);
            this.grpCancelBooking.Controls.Add(this.txtBookingID);
            this.grpCancelBooking.Controls.Add(this.pnlCancelBooking);
            this.grpCancelBooking.Controls.Add(this.lblEventDate);
            this.grpCancelBooking.Controls.Add(this.txtDJID);
            this.grpCancelBooking.Controls.Add(this.lblDJID);
            this.grpCancelBooking.Controls.Add(this.lblServiceID);
            this.grpCancelBooking.Controls.Add(this.txtServiceID);
            this.grpCancelBooking.Controls.Add(this.txtClientID);
            this.grpCancelBooking.Controls.Add(this.lblClientID);
            this.grpCancelBooking.Location = new System.Drawing.Point(1578, 30);
            this.grpCancelBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpCancelBooking.Name = "grpCancelBooking";
            this.grpCancelBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpCancelBooking.Size = new System.Drawing.Size(812, 711);
            this.grpCancelBooking.TabIndex = 57;
            this.grpCancelBooking.TabStop = false;
            this.grpCancelBooking.Text = "Booking Details";
            this.grpCancelBooking.Visible = false;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CalendarFont = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.CustomFormat = "dd-MMM-yy";
            this.dtpEventDate.Enabled = false;
            this.dtpEventDate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(244, 138);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEventDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(171, 25);
            this.dtpEventDate.TabIndex = 56;
            // 
            // btnClientLegendDJsCancellation
            // 
            this.btnClientLegendDJsCancellation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientLegendDJsCancellation.Location = new System.Drawing.Point(12, 654);
            this.btnClientLegendDJsCancellation.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientLegendDJsCancellation.Name = "btnClientLegendDJsCancellation";
            this.btnClientLegendDJsCancellation.Size = new System.Drawing.Size(383, 49);
            this.btnClientLegendDJsCancellation.TabIndex = 55;
            this.btnClientLegendDJsCancellation.Text = "Confirm Cancellation";
            this.btnClientLegendDJsCancellation.UseVisualStyleBackColor = true;
            this.btnClientLegendDJsCancellation.Visible = false;
            this.btnClientLegendDJsCancellation.Click += new System.EventHandler(this.btnClientLegendDJsCancellation_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(409, 23);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(105, 20);
            this.lblForename.TabIndex = 54;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(574, 20);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename.MaxLength = 25;
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(230, 22);
            this.txtForename.TabIndex = 53;
            // 
            // btnClientConfirmCancellation
            // 
            this.btnClientConfirmCancellation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientConfirmCancellation.Location = new System.Drawing.Point(421, 654);
            this.btnClientConfirmCancellation.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientConfirmCancellation.Name = "btnClientConfirmCancellation";
            this.btnClientConfirmCancellation.Size = new System.Drawing.Size(383, 49);
            this.btnClientConfirmCancellation.TabIndex = 52;
            this.btnClientConfirmCancellation.Text = "Confirm Cancellation";
            this.btnClientConfirmCancellation.UseVisualStyleBackColor = true;
            this.btnClientConfirmCancellation.Visible = false;
            this.btnClientConfirmCancellation.Click += new System.EventHandler(this.btnConfirmCancellation_Click);
            // 
            // pnlCancelBooking2
            // 
            this.pnlCancelBooking2.Controls.Add(this.lblRefundDue);
            this.pnlCancelBooking2.Controls.Add(this.lblRefundPercentage);
            this.pnlCancelBooking2.Controls.Add(this.txtRefundPercentage);
            this.pnlCancelBooking2.Controls.Add(this.txtRefundDue);
            this.pnlCancelBooking2.Location = new System.Drawing.Point(12, 520);
            this.pnlCancelBooking2.Name = "pnlCancelBooking2";
            this.pnlCancelBooking2.Size = new System.Drawing.Size(792, 100);
            this.pnlCancelBooking2.TabIndex = 51;
            this.pnlCancelBooking2.Visible = false;
            // 
            // lblRefundDue
            // 
            this.lblRefundDue.AutoSize = true;
            this.lblRefundDue.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundDue.Location = new System.Drawing.Point(477, 39);
            this.lblRefundDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefundDue.Name = "lblRefundDue";
            this.lblRefundDue.Size = new System.Drawing.Size(129, 20);
            this.lblRefundDue.TabIndex = 50;
            this.lblRefundDue.Text = "Refund Due";
            // 
            // lblRefundPercentage
            // 
            this.lblRefundPercentage.AutoSize = true;
            this.lblRefundPercentage.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundPercentage.Location = new System.Drawing.Point(44, 39);
            this.lblRefundPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefundPercentage.Name = "lblRefundPercentage";
            this.lblRefundPercentage.Size = new System.Drawing.Size(213, 20);
            this.lblRefundPercentage.TabIndex = 49;
            this.lblRefundPercentage.Text = "Refund Percentage";
            // 
            // txtRefundPercentage
            // 
            this.txtRefundPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundPercentage.Location = new System.Drawing.Point(288, 36);
            this.txtRefundPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefundPercentage.MaxLength = 5;
            this.txtRefundPercentage.Name = "txtRefundPercentage";
            this.txtRefundPercentage.ReadOnly = true;
            this.txtRefundPercentage.Size = new System.Drawing.Size(83, 26);
            this.txtRefundPercentage.TabIndex = 47;
            // 
            // txtRefundDue
            // 
            this.txtRefundDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundDue.Location = new System.Drawing.Point(629, 36);
            this.txtRefundDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefundDue.MaxLength = 5;
            this.txtRefundDue.Name = "txtRefundDue";
            this.txtRefundDue.ReadOnly = true;
            this.txtRefundDue.Size = new System.Drawing.Size(83, 26);
            this.txtRefundDue.TabIndex = 48;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Checked = false;
            this.dtpBookingDate.CustomFormat = "dd-MMM-yy";
            this.dtpBookingDate.Enabled = false;
            this.dtpBookingDate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(574, 85);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(171, 25);
            this.dtpBookingDate.TabIndex = 46;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(411, 90);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(153, 20);
            this.lblBookingDate.TabIndex = 45;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(411, 54);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(129, 20);
            this.lblBookingID.TabIndex = 44;
            this.lblBookingID.Text = "Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(574, 50);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.MaxLength = 5;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(55, 26);
            this.txtBookingID.TabIndex = 43;
            // 
            // pnlCancelBooking
            // 
            this.pnlCancelBooking.Controls.Add(this.btnClientCancelBooking);
            this.pnlCancelBooking.Controls.Add(this.cboEndTime);
            this.pnlCancelBooking.Controls.Add(this.cboStartTime);
            this.pnlCancelBooking.Controls.Add(this.btnLegendDJsCancelBooking);
            this.pnlCancelBooking.Controls.Add(this.lblStartTime);
            this.pnlCancelBooking.Controls.Add(this.txtLocation);
            this.pnlCancelBooking.Controls.Add(this.txtDuration);
            this.pnlCancelBooking.Controls.Add(this.txtTotalCost);
            this.pnlCancelBooking.Controls.Add(this.txtEircode);
            this.pnlCancelBooking.Controls.Add(this.lblTotalCost);
            this.pnlCancelBooking.Controls.Add(this.lblEircode);
            this.pnlCancelBooking.Controls.Add(this.lblLocation);
            this.pnlCancelBooking.Controls.Add(this.lblEndTime);
            this.pnlCancelBooking.Controls.Add(this.lblDuration);
            this.pnlCancelBooking.Location = new System.Drawing.Point(12, 167);
            this.pnlCancelBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCancelBooking.Name = "pnlCancelBooking";
            this.pnlCancelBooking.Size = new System.Drawing.Size(792, 346);
            this.pnlCancelBooking.TabIndex = 42;
            this.pnlCancelBooking.Visible = false;
            // 
            // btnClientCancelBooking
            // 
            this.btnClientCancelBooking.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancelBooking.Location = new System.Drawing.Point(502, 283);
            this.btnClientCancelBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientCancelBooking.Name = "btnClientCancelBooking";
            this.btnClientCancelBooking.Size = new System.Drawing.Size(257, 49);
            this.btnClientCancelBooking.TabIndex = 46;
            this.btnClientCancelBooking.Text = "Client Cancel";
            this.btnClientCancelBooking.UseVisualStyleBackColor = true;
            this.btnClientCancelBooking.Click += new System.EventHandler(this.btnClientCancelBooking_Click);
            // 
            // cboEndTime
            // 
            this.cboEndTime.Enabled = false;
            this.cboEndTime.FormattingEnabled = true;
            this.cboEndTime.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cboEndTime.Location = new System.Drawing.Point(232, 47);
            this.cboEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboEndTime.Name = "cboEndTime";
            this.cboEndTime.Size = new System.Drawing.Size(160, 24);
            this.cboEndTime.TabIndex = 45;
            // 
            // cboStartTime
            // 
            this.cboStartTime.Enabled = false;
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cboStartTime.Location = new System.Drawing.Point(232, 14);
            this.cboStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(160, 24);
            this.cboStartTime.TabIndex = 44;
            // 
            // btnLegendDJsCancelBooking
            // 
            this.btnLegendDJsCancelBooking.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLegendDJsCancelBooking.Location = new System.Drawing.Point(36, 283);
            this.btnLegendDJsCancelBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnLegendDJsCancelBooking.Name = "btnLegendDJsCancelBooking";
            this.btnLegendDJsCancelBooking.Size = new System.Drawing.Size(279, 49);
            this.btnLegendDJsCancelBooking.TabIndex = 43;
            this.btnLegendDJsCancelBooking.Text = "Legend DJs Cancel";
            this.btnLegendDJsCancelBooking.UseVisualStyleBackColor = true;
            this.btnLegendDJsCancelBooking.Click += new System.EventHandler(this.btnLegendDJsCancelBooking_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(32, 20);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(129, 20);
            this.lblStartTime.TabIndex = 11;
            this.lblStartTime.Text = "Start Time";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(232, 116);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.MaxLength = 255;
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(527, 67);
            this.txtLocation.TabIndex = 1;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(232, 81);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.MaxLength = 20;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(83, 25);
            this.txtDuration.TabIndex = 2;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(232, 225);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.MaxLength = 50;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(83, 25);
            this.txtTotalCost.TabIndex = 6;
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(232, 191);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(111, 25);
            this.txtEircode.TabIndex = 2;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(32, 233);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(129, 20);
            this.lblTotalCost.TabIndex = 16;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(32, 198);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(93, 20);
            this.lblEircode.TabIndex = 17;
            this.lblEircode.Text = "Eircode";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(32, 124);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(105, 20);
            this.lblLocation.TabIndex = 18;
            this.lblLocation.Text = "Location";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(32, 53);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(105, 20);
            this.lblEndTime.TabIndex = 21;
            this.lblEndTime.Text = "End Time";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(32, 86);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(177, 20);
            this.lblDuration.TabIndex = 19;
            this.lblDuration.Text = "Duration (hrs)";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(44, 142);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(129, 20);
            this.lblEventDate.TabIndex = 35;
            this.lblEventDate.Text = "Event Date";
            // 
            // txtDJID
            // 
            this.txtDJID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJID.Location = new System.Drawing.Point(243, 54);
            this.txtDJID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJID.MaxLength = 5;
            this.txtDJID.Name = "txtDJID";
            this.txtDJID.ReadOnly = true;
            this.txtDJID.Size = new System.Drawing.Size(83, 26);
            this.txtDJID.TabIndex = 34;
            // 
            // lblDJID
            // 
            this.lblDJID.AutoSize = true;
            this.lblDJID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJID.Location = new System.Drawing.Point(44, 62);
            this.lblDJID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJID.Name = "lblDJID";
            this.lblDJID.Size = new System.Drawing.Size(69, 20);
            this.lblDJID.TabIndex = 33;
            this.lblDJID.Text = "DJ ID";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(44, 96);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(129, 20);
            this.lblServiceID.TabIndex = 32;
            this.lblServiceID.Text = "Service ID";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.Location = new System.Drawing.Point(243, 89);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.MaxLength = 5;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(83, 26);
            this.txtServiceID.TabIndex = 31;
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(243, 21);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.MaxLength = 5;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(83, 26);
            this.txtClientID.TabIndex = 27;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(44, 28);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(117, 20);
            this.lblClientID.TabIndex = 26;
            this.lblClientID.Text = "Client ID";
            // 
            // grpCancelBookingMatchingClients
            // 
            this.grpCancelBookingMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpCancelBookingMatchingClients.Controls.Add(this.grdCancelBookingMatchingClients);
            this.grpCancelBookingMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCancelBookingMatchingClients.Location = new System.Drawing.Point(76, 87);
            this.grpCancelBookingMatchingClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBookingMatchingClients.Name = "grpCancelBookingMatchingClients";
            this.grpCancelBookingMatchingClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCancelBookingMatchingClients.Size = new System.Drawing.Size(644, 497);
            this.grpCancelBookingMatchingClients.TabIndex = 56;
            this.grpCancelBookingMatchingClients.TabStop = false;
            this.grpCancelBookingMatchingClients.Text = "Matching Clients";
            this.grpCancelBookingMatchingClients.Visible = false;
            // 
            // grdCancelBookingMatchingClients
            // 
            this.grdCancelBookingMatchingClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdCancelBookingMatchingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCancelBookingMatchingClients.Location = new System.Drawing.Point(7, 25);
            this.grdCancelBookingMatchingClients.Margin = new System.Windows.Forms.Padding(4);
            this.grdCancelBookingMatchingClients.Name = "grdCancelBookingMatchingClients";
            this.grdCancelBookingMatchingClients.ReadOnly = true;
            this.grdCancelBookingMatchingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCancelBookingMatchingClients.Size = new System.Drawing.Size(630, 460);
            this.grdCancelBookingMatchingClients.TabIndex = 0;
            this.grdCancelBookingMatchingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCancelBookingMatchingClients_CellDoubleClick);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(410, 42);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(180, 38);
            this.btnFindClient.TabIndex = 55;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(72, 9);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(177, 20);
            this.lblEnterName.TabIndex = 54;
            this.lblEnterName.Text = "Enter Surname:";
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnterSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(280, 9);
            this.txtEnterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(453, 24);
            this.txtEnterSurname.TabIndex = 53;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged);
            // 
            // btnCancelBookingClientPrintInvoice
            // 
            this.btnCancelBookingClientPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBookingClientPrintInvoice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelBookingClientPrintInvoice.Location = new System.Drawing.Point(2152, 749);
            this.btnCancelBookingClientPrintInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelBookingClientPrintInvoice.Name = "btnCancelBookingClientPrintInvoice";
            this.btnCancelBookingClientPrintInvoice.Size = new System.Drawing.Size(100, 100);
            this.btnCancelBookingClientPrintInvoice.TabIndex = 59;
            this.btnCancelBookingClientPrintInvoice.Text = "Print Invoice";
            this.btnCancelBookingClientPrintInvoice.UseVisualStyleBackColor = true;
            this.btnCancelBookingClientPrintInvoice.Visible = false;
            this.btnCancelBookingClientPrintInvoice.Click += new System.EventHandler(this.btnWithdrawClientPrintInvoice_Click);
            // 
            // btnCancelBookingLegendDJsPrintInvoice
            // 
            this.btnCancelBookingLegendDJsPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBookingLegendDJsPrintInvoice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelBookingLegendDJsPrintInvoice.Location = new System.Drawing.Point(1747, 749);
            this.btnCancelBookingLegendDJsPrintInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelBookingLegendDJsPrintInvoice.Name = "btnCancelBookingLegendDJsPrintInvoice";
            this.btnCancelBookingLegendDJsPrintInvoice.Size = new System.Drawing.Size(100, 100);
            this.btnCancelBookingLegendDJsPrintInvoice.TabIndex = 60;
            this.btnCancelBookingLegendDJsPrintInvoice.Text = "Print Invoice";
            this.btnCancelBookingLegendDJsPrintInvoice.UseVisualStyleBackColor = true;
            this.btnCancelBookingLegendDJsPrintInvoice.Visible = false;
            this.btnCancelBookingLegendDJsPrintInvoice.Click += new System.EventHandler(this.btnCancelBookingLegendDJsPrintInvoice_Click);
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.The_Venue_inside;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2473, 947);
            this.Controls.Add(this.btnCancelBookingLegendDJsPrintInvoice);
            this.Controls.Add(this.btnCancelBookingClientPrintInvoice);
            this.Controls.Add(this.grpCancelBookingActiveBookings);
            this.Controls.Add(this.grpCancelBooking);
            this.Controls.Add(this.grpCancelBookingMatchingClients);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterSurname);
            this.Controls.Add(this.btnMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.grpCancelBookingActiveBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBookingActiveBookings)).EndInit();
            this.grpCancelBooking.ResumeLayout(false);
            this.grpCancelBooking.PerformLayout();
            this.pnlCancelBooking2.ResumeLayout(false);
            this.pnlCancelBooking2.PerformLayout();
            this.pnlCancelBooking.ResumeLayout(false);
            this.pnlCancelBooking.PerformLayout();
            this.grpCancelBookingMatchingClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBookingMatchingClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpCancelBookingActiveBookings;
        private System.Windows.Forms.DataGridView grdCancelBookingActiveBookings;
        private System.Windows.Forms.GroupBox grpCancelBooking;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Panel pnlCancelBooking;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.Button btnLegendDJsCancelBooking;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtDJID;
        private System.Windows.Forms.Label lblDJID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.GroupBox grpCancelBookingMatchingClients;
        private System.Windows.Forms.DataGridView grdCancelBookingMatchingClients;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.Button btnClientCancelBooking;
        private System.Windows.Forms.TextBox txtRefundPercentage;
        private System.Windows.Forms.TextBox txtRefundDue;
        private System.Windows.Forms.Label lblRefundDue;
        private System.Windows.Forms.Label lblRefundPercentage;
        private System.Windows.Forms.Panel pnlCancelBooking2;
        private System.Windows.Forms.Button btnClientConfirmCancellation;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnClientLegendDJsCancellation;
        private System.Windows.Forms.Button btnCancelBookingClientPrintInvoice;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnCancelBookingLegendDJsPrintInvoice;
    }
}