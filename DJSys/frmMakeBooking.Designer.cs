namespace DJSys
{
    partial class frmMakeBooking
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
            this.grpMakeBooking = new System.Windows.Forms.GroupBox();
            this.lblEventDateRequired = new System.Windows.Forms.Label();
            this.lblServiceIDRequired = new System.Windows.Forms.Label();
            this.lblDJIDRequired = new System.Windows.Forms.Label();
            this.lblClientIDRequired = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.pnlMakeBooking = new System.Windows.Forms.Panel();
            this.lblEircodeRequired = new System.Windows.Forms.Label();
            this.lblLocationRequired = new System.Windows.Forms.Label();
            this.lblEndTimeRequired = new System.Windows.Forms.Label();
            this.lblStartTimeRequired = new System.Windows.Forms.Label();
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
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtDJID = new System.Windows.Forms.TextBox();
            this.lblDJID = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnCheckAvailibility = new System.Windows.Forms.Button();
            this.grpMakeBookingMatchingClients = new System.Windows.Forms.GroupBox();
            this.grdMakeBookingMatchingClients = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.grpMakeBookingActiveServices = new System.Windows.Forms.GroupBox();
            this.grdMakeBookingActiveServices = new System.Windows.Forms.DataGridView();
            this.grpMakeBookingActiveDJs = new System.Windows.Forms.GroupBox();
            this.grdMakeBookingActiveDJs = new System.Windows.Forms.DataGridView();
            this.grpMakeBooking.SuspendLayout();
            this.pnlMakeBooking.SuspendLayout();
            this.grpMakeBookingMatchingClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingMatchingClients)).BeginInit();
            this.grpMakeBookingActiveServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingActiveServices)).BeginInit();
            this.grpMakeBookingActiveDJs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingActiveDJs)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMakeBooking
            // 
            this.grpMakeBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMakeBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpMakeBooking.Controls.Add(this.lblEventDateRequired);
            this.grpMakeBooking.Controls.Add(this.lblServiceIDRequired);
            this.grpMakeBooking.Controls.Add(this.lblDJIDRequired);
            this.grpMakeBooking.Controls.Add(this.lblClientIDRequired);
            this.grpMakeBooking.Controls.Add(this.lblRequiredFields);
            this.grpMakeBooking.Controls.Add(this.pnlMakeBooking);
            this.grpMakeBooking.Controls.Add(this.dtpEventDate);
            this.grpMakeBooking.Controls.Add(this.lblEventDate);
            this.grpMakeBooking.Controls.Add(this.txtDJID);
            this.grpMakeBooking.Controls.Add(this.lblDJID);
            this.grpMakeBooking.Controls.Add(this.lblServiceID);
            this.grpMakeBooking.Controls.Add(this.txtServiceID);
            this.grpMakeBooking.Controls.Add(this.txtClientID);
            this.grpMakeBooking.Controls.Add(this.lblClientID);
            this.grpMakeBooking.Controls.Add(this.btnCheckAvailibility);
            this.grpMakeBooking.Location = new System.Drawing.Point(1579, 30);
            this.grpMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpMakeBooking.Name = "grpMakeBooking";
            this.grpMakeBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpMakeBooking.Size = new System.Drawing.Size(812, 598);
            this.grpMakeBooking.TabIndex = 37;
            this.grpMakeBooking.TabStop = false;
            this.grpMakeBooking.Text = "Booking Details";
            // 
            // lblEventDateRequired
            // 
            this.lblEventDateRequired.AutoSize = true;
            this.lblEventDateRequired.Location = new System.Drawing.Point(223, 134);
            this.lblEventDateRequired.Name = "lblEventDateRequired";
            this.lblEventDateRequired.Size = new System.Drawing.Size(13, 17);
            this.lblEventDateRequired.TabIndex = 47;
            this.lblEventDateRequired.Text = "*";
            // 
            // lblServiceIDRequired
            // 
            this.lblServiceIDRequired.AutoSize = true;
            this.lblServiceIDRequired.Location = new System.Drawing.Point(223, 89);
            this.lblServiceIDRequired.Name = "lblServiceIDRequired";
            this.lblServiceIDRequired.Size = new System.Drawing.Size(13, 17);
            this.lblServiceIDRequired.TabIndex = 46;
            this.lblServiceIDRequired.Text = "*";
            // 
            // lblDJIDRequired
            // 
            this.lblDJIDRequired.AutoSize = true;
            this.lblDJIDRequired.Location = new System.Drawing.Point(223, 54);
            this.lblDJIDRequired.Name = "lblDJIDRequired";
            this.lblDJIDRequired.Size = new System.Drawing.Size(13, 17);
            this.lblDJIDRequired.TabIndex = 45;
            this.lblDJIDRequired.Text = "*";
            // 
            // lblClientIDRequired
            // 
            this.lblClientIDRequired.AutoSize = true;
            this.lblClientIDRequired.Location = new System.Drawing.Point(223, 21);
            this.lblClientIDRequired.Name = "lblClientIDRequired";
            this.lblClientIDRequired.Size = new System.Drawing.Size(13, 17);
            this.lblClientIDRequired.TabIndex = 44;
            this.lblClientIDRequired.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Location = new System.Drawing.Point(650, 0);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(162, 17);
            this.lblRequiredFields.TabIndex = 43;
            this.lblRequiredFields.Text = "* denotes required fields";
            // 
            // pnlMakeBooking
            // 
            this.pnlMakeBooking.Controls.Add(this.lblEircodeRequired);
            this.pnlMakeBooking.Controls.Add(this.lblLocationRequired);
            this.pnlMakeBooking.Controls.Add(this.lblEndTimeRequired);
            this.pnlMakeBooking.Controls.Add(this.lblStartTimeRequired);
            this.pnlMakeBooking.Controls.Add(this.cboEndTime);
            this.pnlMakeBooking.Controls.Add(this.cboStartTime);
            this.pnlMakeBooking.Controls.Add(this.btnConfirmBooking);
            this.pnlMakeBooking.Controls.Add(this.lblStartTime);
            this.pnlMakeBooking.Controls.Add(this.txtLocation);
            this.pnlMakeBooking.Controls.Add(this.txtDuration);
            this.pnlMakeBooking.Controls.Add(this.txtTotalCost);
            this.pnlMakeBooking.Controls.Add(this.txtEircode);
            this.pnlMakeBooking.Controls.Add(this.lblTotalCost);
            this.pnlMakeBooking.Controls.Add(this.lblEircode);
            this.pnlMakeBooking.Controls.Add(this.lblLocation);
            this.pnlMakeBooking.Controls.Add(this.lblEndTime);
            this.pnlMakeBooking.Controls.Add(this.lblDuration);
            this.pnlMakeBooking.Location = new System.Drawing.Point(12, 255);
            this.pnlMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMakeBooking.Name = "pnlMakeBooking";
            this.pnlMakeBooking.Size = new System.Drawing.Size(792, 336);
            this.pnlMakeBooking.TabIndex = 42;
            this.pnlMakeBooking.Visible = false;
            // 
            // lblEircodeRequired
            // 
            this.lblEircodeRequired.AutoSize = true;
            this.lblEircodeRequired.Location = new System.Drawing.Point(212, 191);
            this.lblEircodeRequired.Name = "lblEircodeRequired";
            this.lblEircodeRequired.Size = new System.Drawing.Size(13, 17);
            this.lblEircodeRequired.TabIndex = 50;
            this.lblEircodeRequired.Text = "*";
            // 
            // lblLocationRequired
            // 
            this.lblLocationRequired.AutoSize = true;
            this.lblLocationRequired.Location = new System.Drawing.Point(211, 116);
            this.lblLocationRequired.Name = "lblLocationRequired";
            this.lblLocationRequired.Size = new System.Drawing.Size(13, 17);
            this.lblLocationRequired.TabIndex = 49;
            this.lblLocationRequired.Text = "*";
            // 
            // lblEndTimeRequired
            // 
            this.lblEndTimeRequired.AutoSize = true;
            this.lblEndTimeRequired.Location = new System.Drawing.Point(212, 47);
            this.lblEndTimeRequired.Name = "lblEndTimeRequired";
            this.lblEndTimeRequired.Size = new System.Drawing.Size(13, 17);
            this.lblEndTimeRequired.TabIndex = 48;
            this.lblEndTimeRequired.Text = "*";
            // 
            // lblStartTimeRequired
            // 
            this.lblStartTimeRequired.AutoSize = true;
            this.lblStartTimeRequired.Location = new System.Drawing.Point(212, 14);
            this.lblStartTimeRequired.Name = "lblStartTimeRequired";
            this.lblStartTimeRequired.Size = new System.Drawing.Size(13, 17);
            this.lblStartTimeRequired.TabIndex = 47;
            this.lblStartTimeRequired.Text = "*";
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
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
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
            // dtpEventDate
            // 
            this.dtpEventDate.Checked = false;
            this.dtpEventDate.CustomFormat = "dd-MMM-yy";
            this.dtpEventDate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(244, 134);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEventDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(171, 25);
            this.dtpEventDate.TabIndex = 36;
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
            // grpMakeBookingMatchingClients
            // 
            this.grpMakeBookingMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpMakeBookingMatchingClients.Controls.Add(this.grdMakeBookingMatchingClients);
            this.grpMakeBookingMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeBookingMatchingClients.Location = new System.Drawing.Point(77, 130);
            this.grpMakeBookingMatchingClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingMatchingClients.Name = "grpMakeBookingMatchingClients";
            this.grpMakeBookingMatchingClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingMatchingClients.Size = new System.Drawing.Size(773, 497);
            this.grpMakeBookingMatchingClients.TabIndex = 36;
            this.grpMakeBookingMatchingClients.TabStop = false;
            this.grpMakeBookingMatchingClients.Text = "Matching Clients";
            this.grpMakeBookingMatchingClients.Visible = false;
            // 
            // grdMakeBookingMatchingClients
            // 
            this.grdMakeBookingMatchingClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdMakeBookingMatchingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMakeBookingMatchingClients.Location = new System.Drawing.Point(7, 25);
            this.grdMakeBookingMatchingClients.Margin = new System.Windows.Forms.Padding(4);
            this.grdMakeBookingMatchingClients.Name = "grdMakeBookingMatchingClients";
            this.grdMakeBookingMatchingClients.ReadOnly = true;
            this.grdMakeBookingMatchingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMakeBookingMatchingClients.Size = new System.Drawing.Size(760, 460);
            this.grdMakeBookingMatchingClients.TabIndex = 0;
            this.grdMakeBookingMatchingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMakeBookingMatchingClients_CellDoubleClick);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 1193);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 35;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(411, 85);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(180, 38);
            this.btnFindClient.TabIndex = 34;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(73, 52);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(177, 20);
            this.lblEnterName.TabIndex = 33;
            this.lblEnterName.Text = "Enter Surname:";
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnterSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(281, 52);
            this.txtEnterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(453, 24);
            this.txtEnterSurname.TabIndex = 32;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(73, 9);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(129, 20);
            this.lblBookingID.TabIndex = 39;
            this.lblBookingID.Text = "Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(305, 5);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.MaxLength = 5;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(55, 26);
            this.txtBookingID.TabIndex = 38;
            // 
            // grpMakeBookingActiveServices
            // 
            this.grpMakeBookingActiveServices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpMakeBookingActiveServices.Controls.Add(this.grdMakeBookingActiveServices);
            this.grpMakeBookingActiveServices.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeBookingActiveServices.Location = new System.Drawing.Point(915, 130);
            this.grpMakeBookingActiveServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingActiveServices.Name = "grpMakeBookingActiveServices";
            this.grpMakeBookingActiveServices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingActiveServices.Size = new System.Drawing.Size(592, 497);
            this.grpMakeBookingActiveServices.TabIndex = 40;
            this.grpMakeBookingActiveServices.TabStop = false;
            this.grpMakeBookingActiveServices.Text = "Active Services";
            this.grpMakeBookingActiveServices.Visible = false;
            // 
            // grdMakeBookingActiveServices
            // 
            this.grdMakeBookingActiveServices.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdMakeBookingActiveServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMakeBookingActiveServices.Location = new System.Drawing.Point(7, 25);
            this.grdMakeBookingActiveServices.Margin = new System.Windows.Forms.Padding(4);
            this.grdMakeBookingActiveServices.Name = "grdMakeBookingActiveServices";
            this.grdMakeBookingActiveServices.ReadOnly = true;
            this.grdMakeBookingActiveServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMakeBookingActiveServices.Size = new System.Drawing.Size(579, 460);
            this.grdMakeBookingActiveServices.TabIndex = 0;
            this.grdMakeBookingActiveServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMakeBookingActiveServices_CellDoubleClick);
            // 
            // grpMakeBookingActiveDJs
            // 
            this.grpMakeBookingActiveDJs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpMakeBookingActiveDJs.Controls.Add(this.grdMakeBookingActiveDJs);
            this.grpMakeBookingActiveDJs.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeBookingActiveDJs.Location = new System.Drawing.Point(77, 661);
            this.grpMakeBookingActiveDJs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingActiveDJs.Name = "grpMakeBookingActiveDJs";
            this.grpMakeBookingActiveDJs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakeBookingActiveDJs.Size = new System.Drawing.Size(1838, 497);
            this.grpMakeBookingActiveDJs.TabIndex = 41;
            this.grpMakeBookingActiveDJs.TabStop = false;
            this.grpMakeBookingActiveDJs.Text = "Active DJs";
            this.grpMakeBookingActiveDJs.Visible = false;
            // 
            // grdMakeBookingActiveDJs
            // 
            this.grdMakeBookingActiveDJs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdMakeBookingActiveDJs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMakeBookingActiveDJs.Location = new System.Drawing.Point(7, 25);
            this.grdMakeBookingActiveDJs.Margin = new System.Windows.Forms.Padding(4);
            this.grdMakeBookingActiveDJs.Name = "grdMakeBookingActiveDJs";
            this.grdMakeBookingActiveDJs.ReadOnly = true;
            this.grdMakeBookingActiveDJs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMakeBookingActiveDJs.Size = new System.Drawing.Size(1819, 460);
            this.grdMakeBookingActiveDJs.TabIndex = 0;
            this.grdMakeBookingActiveDJs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMakeBookingActiveDJs_CellDoubleClick);
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.DJ13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.grpMakeBookingActiveDJs);
            this.Controls.Add(this.grpMakeBookingActiveServices);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.grpMakeBooking);
            this.Controls.Add(this.grpMakeBookingMatchingClients);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterSurname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMakeBooking";
            this.Text = "Make Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpMakeBooking.ResumeLayout(false);
            this.grpMakeBooking.PerformLayout();
            this.pnlMakeBooking.ResumeLayout(false);
            this.pnlMakeBooking.PerformLayout();
            this.grpMakeBookingMatchingClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingMatchingClients)).EndInit();
            this.grpMakeBookingActiveServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingActiveServices)).EndInit();
            this.grpMakeBookingActiveDJs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMakeBookingActiveDJs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMakeBooking;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnCheckAvailibility;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox grpMakeBookingMatchingClients;
        private System.Windows.Forms.DataGridView grdMakeBookingMatchingClients;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.GroupBox grpMakeBookingActiveServices;
        private System.Windows.Forms.DataGridView grdMakeBookingActiveServices;
        private System.Windows.Forms.GroupBox grpMakeBookingActiveDJs;
        private System.Windows.Forms.DataGridView grdMakeBookingActiveDJs;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtDJID;
        private System.Windows.Forms.Label lblDJID;
        private System.Windows.Forms.Panel pnlMakeBooking;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblEventDateRequired;
        private System.Windows.Forms.Label lblServiceIDRequired;
        private System.Windows.Forms.Label lblDJIDRequired;
        private System.Windows.Forms.Label lblClientIDRequired;
        private System.Windows.Forms.Label lblEircodeRequired;
        private System.Windows.Forms.Label lblLocationRequired;
        private System.Windows.Forms.Label lblEndTimeRequired;
        private System.Windows.Forms.Label lblStartTimeRequired;
    }
}