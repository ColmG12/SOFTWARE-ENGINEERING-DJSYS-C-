namespace DJSys
{
    partial class frmChangeBooking
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
            this.grpChangeBookingActiveDJs = new System.Windows.Forms.GroupBox();
            this.grdChangeBookingActiveDJs = new System.Windows.Forms.DataGridView();
            this.grpChangeBooking = new System.Windows.Forms.GroupBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.pnlChangeBooking = new System.Windows.Forms.Panel();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
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
            this.btnCheckAvailibility = new System.Windows.Forms.Button();
            this.grpChangeBookingMatchingClients = new System.Windows.Forms.GroupBox();
            this.grdChangeBookingMatchingClients = new System.Windows.Forms.DataGridView();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.grpChangeBookingActiveBookings = new System.Windows.Forms.GroupBox();
            this.grdChangeBookingActiveBookings = new System.Windows.Forms.DataGridView();
            this.grpChangeBookingActiveServices = new System.Windows.Forms.GroupBox();
            this.grdChangeBookingActiveServices = new System.Windows.Forms.DataGridView();
            this.grpChangeBookingActiveDJs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveDJs)).BeginInit();
            this.grpChangeBooking.SuspendLayout();
            this.pnlChangeBooking.SuspendLayout();
            this.grpChangeBookingMatchingClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingMatchingClients)).BeginInit();
            this.grpChangeBookingActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveBookings)).BeginInit();
            this.grpChangeBookingActiveServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveServices)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeBookingActiveDJs
            // 
            this.grpChangeBookingActiveDJs.AutoSize = true;
            this.grpChangeBookingActiveDJs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpChangeBookingActiveDJs.Controls.Add(this.grdChangeBookingActiveDJs);
            this.grpChangeBookingActiveDJs.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChangeBookingActiveDJs.Location = new System.Drawing.Point(766, 661);
            this.grpChangeBookingActiveDJs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveDJs.Name = "grpChangeBookingActiveDJs";
            this.grpChangeBookingActiveDJs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveDJs.Size = new System.Drawing.Size(759, 509);
            this.grpChangeBookingActiveDJs.TabIndex = 50;
            this.grpChangeBookingActiveDJs.TabStop = false;
            this.grpChangeBookingActiveDJs.Text = "Active DJs";
            this.grpChangeBookingActiveDJs.Visible = false;
            // 
            // grdChangeBookingActiveDJs
            // 
            this.grdChangeBookingActiveDJs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdChangeBookingActiveDJs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChangeBookingActiveDJs.Location = new System.Drawing.Point(7, 25);
            this.grdChangeBookingActiveDJs.Margin = new System.Windows.Forms.Padding(4);
            this.grdChangeBookingActiveDJs.Name = "grdChangeBookingActiveDJs";
            this.grdChangeBookingActiveDJs.ReadOnly = true;
            this.grdChangeBookingActiveDJs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdChangeBookingActiveDJs.Size = new System.Drawing.Size(744, 460);
            this.grdChangeBookingActiveDJs.TabIndex = 0;
            this.grdChangeBookingActiveDJs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChangeBookingActiveDJs_CellDoubleClick);
            // 
            // grpChangeBooking
            // 
            this.grpChangeBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpChangeBooking.Controls.Add(this.dtpEventDate);
            this.grpChangeBooking.Controls.Add(this.dtpBookingDate);
            this.grpChangeBooking.Controls.Add(this.lblBookingDate);
            this.grpChangeBooking.Controls.Add(this.lblBookingID);
            this.grpChangeBooking.Controls.Add(this.txtBookingID);
            this.grpChangeBooking.Controls.Add(this.pnlChangeBooking);
            this.grpChangeBooking.Controls.Add(this.lblEventDate);
            this.grpChangeBooking.Controls.Add(this.txtDJID);
            this.grpChangeBooking.Controls.Add(this.lblDJID);
            this.grpChangeBooking.Controls.Add(this.lblServiceID);
            this.grpChangeBooking.Controls.Add(this.txtServiceID);
            this.grpChangeBooking.Controls.Add(this.txtClientID);
            this.grpChangeBooking.Controls.Add(this.lblClientID);
            this.grpChangeBooking.Controls.Add(this.btnCheckAvailibility);
            this.grpChangeBooking.Location = new System.Drawing.Point(1578, 30);
            this.grpChangeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpChangeBooking.Name = "grpChangeBooking";
            this.grpChangeBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpChangeBooking.Size = new System.Drawing.Size(812, 598);
            this.grpChangeBooking.TabIndex = 46;
            this.grpChangeBooking.TabStop = false;
            this.grpChangeBooking.Text = "Booking Details";
            this.grpChangeBooking.Visible = false;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CalendarFont = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.CustomFormat = "dd-MMM-yy";
            this.dtpEventDate.Enabled = false;
            this.dtpEventDate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(243, 142);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEventDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(171, 25);
            this.dtpEventDate.TabIndex = 47;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Checked = false;
            this.dtpBookingDate.CustomFormat = "dd-MMM-yy";
            this.dtpBookingDate.Enabled = false;
            this.dtpBookingDate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(541, 58);
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
            this.lblBookingDate.Location = new System.Drawing.Point(378, 63);
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
            this.lblBookingID.Location = new System.Drawing.Point(378, 27);
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
            this.txtBookingID.Location = new System.Drawing.Point(541, 23);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.MaxLength = 5;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(55, 26);
            this.txtBookingID.TabIndex = 43;
            // 
            // pnlChangeBooking
            // 
            this.pnlChangeBooking.Controls.Add(this.cboEndTime);
            this.pnlChangeBooking.Controls.Add(this.cboStartTime);
            this.pnlChangeBooking.Controls.Add(this.btnConfirmBooking);
            this.pnlChangeBooking.Controls.Add(this.lblStartTime);
            this.pnlChangeBooking.Controls.Add(this.txtLocation);
            this.pnlChangeBooking.Controls.Add(this.txtDuration);
            this.pnlChangeBooking.Controls.Add(this.txtTotalCost);
            this.pnlChangeBooking.Controls.Add(this.txtEircode);
            this.pnlChangeBooking.Controls.Add(this.lblTotalCost);
            this.pnlChangeBooking.Controls.Add(this.lblEircode);
            this.pnlChangeBooking.Controls.Add(this.lblLocation);
            this.pnlChangeBooking.Controls.Add(this.lblEndTime);
            this.pnlChangeBooking.Controls.Add(this.lblDuration);
            this.pnlChangeBooking.Location = new System.Drawing.Point(12, 255);
            this.pnlChangeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChangeBooking.Name = "pnlChangeBooking";
            this.pnlChangeBooking.Size = new System.Drawing.Size(792, 336);
            this.pnlChangeBooking.TabIndex = 42;
            this.pnlChangeBooking.Visible = false;
            // 
            // cboEndTime
            // 
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
            this.cboEndTime.SelectedIndexChanged += new System.EventHandler(this.cboEndTime_SelectedIndexChanged);
            // 
            // cboStartTime
            // 
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
            this.cboStartTime.SelectedIndexChanged += new System.EventHandler(this.cboStartTime_SelectedIndexChanged);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBooking.Location = new System.Drawing.Point(265, 283);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(257, 49);
            this.btnConfirmBooking.TabIndex = 43;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click_1);
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
            // btnCheckAvailibility
            // 
            this.btnCheckAvailibility.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailibility.Location = new System.Drawing.Point(257, 198);
            this.btnCheckAvailibility.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckAvailibility.Name = "btnCheckAvailibility";
            this.btnCheckAvailibility.Size = new System.Drawing.Size(299, 49);
            this.btnCheckAvailibility.TabIndex = 22;
            this.btnCheckAvailibility.Text = "Check Availibility";
            this.btnCheckAvailibility.UseVisualStyleBackColor = true;
            this.btnCheckAvailibility.Click += new System.EventHandler(this.btnCheckAvailibility_Click);
            // 
            // grpChangeBookingMatchingClients
            // 
            this.grpChangeBookingMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpChangeBookingMatchingClients.Controls.Add(this.grdChangeBookingMatchingClients);
            this.grpChangeBookingMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChangeBookingMatchingClients.Location = new System.Drawing.Point(76, 87);
            this.grpChangeBookingMatchingClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingMatchingClients.Name = "grpChangeBookingMatchingClients";
            this.grpChangeBookingMatchingClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingMatchingClients.Size = new System.Drawing.Size(644, 497);
            this.grpChangeBookingMatchingClients.TabIndex = 45;
            this.grpChangeBookingMatchingClients.TabStop = false;
            this.grpChangeBookingMatchingClients.Text = "Matching Clients";
            this.grpChangeBookingMatchingClients.Visible = false;
            // 
            // grdChangeBookingMatchingClients
            // 
            this.grdChangeBookingMatchingClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdChangeBookingMatchingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChangeBookingMatchingClients.Location = new System.Drawing.Point(7, 25);
            this.grdChangeBookingMatchingClients.Margin = new System.Windows.Forms.Padding(4);
            this.grdChangeBookingMatchingClients.Name = "grdChangeBookingMatchingClients";
            this.grdChangeBookingMatchingClients.ReadOnly = true;
            this.grdChangeBookingMatchingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdChangeBookingMatchingClients.Size = new System.Drawing.Size(630, 460);
            this.grdChangeBookingMatchingClients.TabIndex = 0;
            this.grdChangeBookingMatchingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChangeBookingMatchingClients_CellDoubleClick);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(410, 42);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(180, 38);
            this.btnFindClient.TabIndex = 44;
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
            this.lblEnterName.TabIndex = 43;
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
            this.txtEnterSurname.TabIndex = 42;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 1193);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 51;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // grpChangeBookingActiveBookings
            // 
            this.grpChangeBookingActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpChangeBookingActiveBookings.Controls.Add(this.grdChangeBookingActiveBookings);
            this.grpChangeBookingActiveBookings.Location = new System.Drawing.Point(766, 87);
            this.grpChangeBookingActiveBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveBookings.Name = "grpChangeBookingActiveBookings";
            this.grpChangeBookingActiveBookings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveBookings.Size = new System.Drawing.Size(759, 497);
            this.grpChangeBookingActiveBookings.TabIndex = 52;
            this.grpChangeBookingActiveBookings.TabStop = false;
            this.grpChangeBookingActiveBookings.Text = "Active Bookings";
            this.grpChangeBookingActiveBookings.Visible = false;
            // 
            // grdChangeBookingActiveBookings
            // 
            this.grdChangeBookingActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdChangeBookingActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChangeBookingActiveBookings.Location = new System.Drawing.Point(7, 21);
            this.grdChangeBookingActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdChangeBookingActiveBookings.Name = "grdChangeBookingActiveBookings";
            this.grdChangeBookingActiveBookings.ReadOnly = true;
            this.grdChangeBookingActiveBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdChangeBookingActiveBookings.Size = new System.Drawing.Size(744, 460);
            this.grdChangeBookingActiveBookings.TabIndex = 1;
            this.grdChangeBookingActiveBookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChangeBookingActiveBookings_CellDoubleClick);
            // 
            // grpChangeBookingActiveServices
            // 
            this.grpChangeBookingActiveServices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpChangeBookingActiveServices.Controls.Add(this.grdChangeBookingActiveServices);
            this.grpChangeBookingActiveServices.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChangeBookingActiveServices.Location = new System.Drawing.Point(76, 661);
            this.grpChangeBookingActiveServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveServices.Name = "grpChangeBookingActiveServices";
            this.grpChangeBookingActiveServices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangeBookingActiveServices.Size = new System.Drawing.Size(644, 497);
            this.grpChangeBookingActiveServices.TabIndex = 53;
            this.grpChangeBookingActiveServices.TabStop = false;
            this.grpChangeBookingActiveServices.Text = "Active Services";
            this.grpChangeBookingActiveServices.Visible = false;
            // 
            // grdChangeBookingActiveServices
            // 
            this.grdChangeBookingActiveServices.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdChangeBookingActiveServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChangeBookingActiveServices.Location = new System.Drawing.Point(7, 25);
            this.grdChangeBookingActiveServices.Margin = new System.Windows.Forms.Padding(4);
            this.grdChangeBookingActiveServices.Name = "grdChangeBookingActiveServices";
            this.grdChangeBookingActiveServices.ReadOnly = true;
            this.grdChangeBookingActiveServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdChangeBookingActiveServices.Size = new System.Drawing.Size(630, 460);
            this.grdChangeBookingActiveServices.TabIndex = 0;
            this.grdChangeBookingActiveServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChangeBookingActiveServices_CellDoubleClick);
            // 
            // frmChangeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.The_Swan_inside;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2565, 1153);
            this.Controls.Add(this.grpChangeBookingActiveServices);
            this.Controls.Add(this.grpChangeBookingActiveBookings);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpChangeBookingActiveDJs);
            this.Controls.Add(this.grpChangeBooking);
            this.Controls.Add(this.grpChangeBookingMatchingClients);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterSurname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangeBooking";
            this.Text = "Change Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChangeBooking_Load);
            this.grpChangeBookingActiveDJs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveDJs)).EndInit();
            this.grpChangeBooking.ResumeLayout(false);
            this.grpChangeBooking.PerformLayout();
            this.pnlChangeBooking.ResumeLayout(false);
            this.pnlChangeBooking.PerformLayout();
            this.grpChangeBookingMatchingClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingMatchingClients)).EndInit();
            this.grpChangeBookingActiveBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveBookings)).EndInit();
            this.grpChangeBookingActiveServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeBookingActiveServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChangeBookingActiveDJs;
        private System.Windows.Forms.DataGridView grdChangeBookingActiveDJs;
        private System.Windows.Forms.GroupBox grpChangeBooking;
        private System.Windows.Forms.Panel pnlChangeBooking;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.Button btnConfirmBooking;
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
        private System.Windows.Forms.Button btnCheckAvailibility;
        private System.Windows.Forms.GroupBox grpChangeBookingMatchingClients;
        private System.Windows.Forms.DataGridView grdChangeBookingMatchingClients;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpChangeBookingActiveBookings;
        private System.Windows.Forms.DataGridView grdChangeBookingActiveBookings;
        private System.Windows.Forms.GroupBox grpChangeBookingActiveServices;
        private System.Windows.Forms.DataGridView grdChangeBookingActiveServices;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
    }
}