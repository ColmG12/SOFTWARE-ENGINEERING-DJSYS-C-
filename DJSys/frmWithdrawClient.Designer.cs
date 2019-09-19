namespace DJSys
{
    partial class frmWithdrawClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lblEnterSurname = new System.Windows.Forms.Label();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.grpWithdrawClientActiveBookings = new System.Windows.Forms.GroupBox();
            this.txtOriginalTotalCost = new System.Windows.Forms.TextBox();
            this.txtTotalRefundDue = new System.Windows.Forms.TextBox();
            this.txtTotalCostSum = new System.Windows.Forms.TextBox();
            this.lblTotalRefundDue = new System.Windows.Forms.Label();
            this.lblTotalCostSum = new System.Windows.Forms.Label();
            this.grdWithdrawClientActiveBookings = new System.Windows.Forms.DataGridView();
            this.btnWithdrawClientPrintInvoice = new System.Windows.Forms.Button();
            this.grpWithdrawMatchingClients = new System.Windows.Forms.GroupBox();
            this.grdWithdrawMatchingClients = new System.Windows.Forms.DataGridView();
            this.grpWithdrawClient = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCheckActiveBookings = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnLegendDJsNoBookingsWithdrawClient = new System.Windows.Forms.Button();
            this.btnClientNoBookingsWithdrawClient = new System.Windows.Forms.Button();
            this.btnLegendDJsWithBookingsWithdrawClient = new System.Windows.Forms.Button();
            this.btnClientWithBookingsWithdrawClient = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnTotalRefundDue = new System.Windows.Forms.Button();
            this.btnTotalRefundDueLegendDJs = new System.Windows.Forms.Button();
            this.btnWithdrawClientPrintInvoiceLegendDJs = new System.Windows.Forms.Button();
            this.grpWithdrawClientActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWithdrawClientActiveBookings)).BeginInit();
            this.grpWithdrawMatchingClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWithdrawMatchingClients)).BeginInit();
            this.grpWithdrawClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.AutoSize = true;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(47, 938);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(106, 81);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(293, 39);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(135, 31);
            this.btnFindClient.TabIndex = 8;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // lblEnterSurname
            // 
            this.lblEnterSurname.AutoSize = true;
            this.lblEnterSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSurname.Location = new System.Drawing.Point(44, 12);
            this.lblEnterSurname.Name = "lblEnterSurname";
            this.lblEnterSurname.Size = new System.Drawing.Size(148, 16);
            this.lblEnterSurname.TabIndex = 7;
            this.lblEnterSurname.Text = "Enter Surname:";
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(200, 12);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(341, 21);
            this.txtEnterSurname.TabIndex = 6;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged);
            // 
            // grpWithdrawClientActiveBookings
            // 
            this.grpWithdrawClientActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpWithdrawClientActiveBookings.Controls.Add(this.txtOriginalTotalCost);
            this.grpWithdrawClientActiveBookings.Controls.Add(this.txtTotalRefundDue);
            this.grpWithdrawClientActiveBookings.Controls.Add(this.txtTotalCostSum);
            this.grpWithdrawClientActiveBookings.Controls.Add(this.lblTotalRefundDue);
            this.grpWithdrawClientActiveBookings.Controls.Add(this.lblTotalCostSum);
            this.grpWithdrawClientActiveBookings.Controls.Add(this.grdWithdrawClientActiveBookings);
            this.grpWithdrawClientActiveBookings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpWithdrawClientActiveBookings.Location = new System.Drawing.Point(47, 505);
            this.grpWithdrawClientActiveBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWithdrawClientActiveBookings.Name = "grpWithdrawClientActiveBookings";
            this.grpWithdrawClientActiveBookings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWithdrawClientActiveBookings.Size = new System.Drawing.Size(1670, 416);
            this.grpWithdrawClientActiveBookings.TabIndex = 30;
            this.grpWithdrawClientActiveBookings.TabStop = false;
            this.grpWithdrawClientActiveBookings.Text = "Active Bookings";
            this.grpWithdrawClientActiveBookings.Visible = false;
            // 
            // txtOriginalTotalCost
            // 
            this.txtOriginalTotalCost.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalTotalCost.Location = new System.Drawing.Point(591, 394);
            this.txtOriginalTotalCost.MaxLength = 50;
            this.txtOriginalTotalCost.Name = "txtOriginalTotalCost";
            this.txtOriginalTotalCost.Size = new System.Drawing.Size(63, 22);
            this.txtOriginalTotalCost.TabIndex = 41;
            this.txtOriginalTotalCost.Visible = false;
            // 
            // txtTotalRefundDue
            // 
            this.txtTotalRefundDue.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRefundDue.Location = new System.Drawing.Point(1165, 394);
            this.txtTotalRefundDue.MaxLength = 50;
            this.txtTotalRefundDue.Name = "txtTotalRefundDue";
            this.txtTotalRefundDue.Size = new System.Drawing.Size(63, 22);
            this.txtTotalRefundDue.TabIndex = 40;
            // 
            // txtTotalCostSum
            // 
            this.txtTotalCostSum.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCostSum.Location = new System.Drawing.Point(860, 394);
            this.txtTotalCostSum.MaxLength = 50;
            this.txtTotalCostSum.Name = "txtTotalCostSum";
            this.txtTotalCostSum.Size = new System.Drawing.Size(63, 22);
            this.txtTotalCostSum.TabIndex = 39;
            // 
            // lblTotalRefundDue
            // 
            this.lblTotalRefundDue.AutoSize = true;
            this.lblTotalRefundDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefundDue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRefundDue.Location = new System.Drawing.Point(1058, 397);
            this.lblTotalRefundDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRefundDue.Name = "lblTotalRefundDue";
            this.lblTotalRefundDue.Size = new System.Drawing.Size(108, 13);
            this.lblTotalRefundDue.TabIndex = 3;
            this.lblTotalRefundDue.Text = "Total Refund Due";
            // 
            // lblTotalCostSum
            // 
            this.lblTotalCostSum.AutoSize = true;
            this.lblTotalCostSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostSum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalCostSum.Location = new System.Drawing.Point(766, 397);
            this.lblTotalCostSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCostSum.Name = "lblTotalCostSum";
            this.lblTotalCostSum.Size = new System.Drawing.Size(93, 13);
            this.lblTotalCostSum.TabIndex = 2;
            this.lblTotalCostSum.Text = "Total Cost Sum";
            // 
            // grdWithdrawClientActiveBookings
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.grdWithdrawClientActiveBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdWithdrawClientActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdWithdrawClientActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdWithdrawClientActiveBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdWithdrawClientActiveBookings.Location = new System.Drawing.Point(5, 17);
            this.grdWithdrawClientActiveBookings.Name = "grdWithdrawClientActiveBookings";
            this.grdWithdrawClientActiveBookings.ReadOnly = true;
            this.grdWithdrawClientActiveBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdWithdrawClientActiveBookings.Size = new System.Drawing.Size(1659, 374);
            this.grdWithdrawClientActiveBookings.TabIndex = 1;
            // 
            // btnWithdrawClientPrintInvoice
            // 
            this.btnWithdrawClientPrintInvoice.AutoSize = true;
            this.btnWithdrawClientPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawClientPrintInvoice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnWithdrawClientPrintInvoice.Location = new System.Drawing.Point(1172, 938);
            this.btnWithdrawClientPrintInvoice.Name = "btnWithdrawClientPrintInvoice";
            this.btnWithdrawClientPrintInvoice.Size = new System.Drawing.Size(118, 81);
            this.btnWithdrawClientPrintInvoice.TabIndex = 30;
            this.btnWithdrawClientPrintInvoice.Text = "Print Invoice";
            this.btnWithdrawClientPrintInvoice.UseVisualStyleBackColor = true;
            this.btnWithdrawClientPrintInvoice.Visible = false;
            this.btnWithdrawClientPrintInvoice.Click += new System.EventHandler(this.btnWithdrawClientPrintInvoice_Click);
            // 
            // grpWithdrawMatchingClients
            // 
            this.grpWithdrawMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpWithdrawMatchingClients.Controls.Add(this.grdWithdrawMatchingClients);
            this.grpWithdrawMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWithdrawMatchingClients.Location = new System.Drawing.Point(47, 76);
            this.grpWithdrawMatchingClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWithdrawMatchingClients.Name = "grpWithdrawMatchingClients";
            this.grpWithdrawMatchingClients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWithdrawMatchingClients.Size = new System.Drawing.Size(541, 406);
            this.grpWithdrawMatchingClients.TabIndex = 32;
            this.grpWithdrawMatchingClients.TabStop = false;
            this.grpWithdrawMatchingClients.Text = "Matching Clients";
            this.grpWithdrawMatchingClients.Visible = false;
            // 
            // grdWithdrawMatchingClients
            // 
            this.grdWithdrawMatchingClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdWithdrawMatchingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWithdrawMatchingClients.Location = new System.Drawing.Point(5, 20);
            this.grdWithdrawMatchingClients.Name = "grdWithdrawMatchingClients";
            this.grdWithdrawMatchingClients.ReadOnly = true;
            this.grdWithdrawMatchingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdWithdrawMatchingClients.Size = new System.Drawing.Size(531, 374);
            this.grdWithdrawMatchingClients.TabIndex = 0;
            this.grdWithdrawMatchingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdWithdrawMatchingClients_CellDoubleClick);
            // 
            // grpWithdrawClient
            // 
            this.grpWithdrawClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpWithdrawClient.Controls.Add(this.dtpDateOfBirth);
            this.grpWithdrawClient.Controls.Add(this.txtClientID);
            this.grpWithdrawClient.Controls.Add(this.label13);
            this.grpWithdrawClient.Controls.Add(this.btnCheckActiveBookings);
            this.grpWithdrawClient.Controls.Add(this.label14);
            this.grpWithdrawClient.Controls.Add(this.label15);
            this.grpWithdrawClient.Controls.Add(this.label16);
            this.grpWithdrawClient.Controls.Add(this.label17);
            this.grpWithdrawClient.Controls.Add(this.label18);
            this.grpWithdrawClient.Controls.Add(this.label19);
            this.grpWithdrawClient.Controls.Add(this.label20);
            this.grpWithdrawClient.Controls.Add(this.label21);
            this.grpWithdrawClient.Controls.Add(this.label22);
            this.grpWithdrawClient.Controls.Add(this.label23);
            this.grpWithdrawClient.Controls.Add(this.txtEircode);
            this.grpWithdrawClient.Controls.Add(this.txtCounty);
            this.grpWithdrawClient.Controls.Add(this.txtCity);
            this.grpWithdrawClient.Controls.Add(this.txtTown);
            this.grpWithdrawClient.Controls.Add(this.txtStreet);
            this.grpWithdrawClient.Controls.Add(this.txtSurname);
            this.grpWithdrawClient.Controls.Add(this.txtContactNo);
            this.grpWithdrawClient.Controls.Add(this.txtEmail);
            this.grpWithdrawClient.Controls.Add(this.txtForename);
            this.grpWithdrawClient.Location = new System.Drawing.Point(638, 76);
            this.grpWithdrawClient.Name = "grpWithdrawClient";
            this.grpWithdrawClient.Size = new System.Drawing.Size(609, 404);
            this.grpWithdrawClient.TabIndex = 33;
            this.grpWithdrawClient.TabStop = false;
            this.grpWithdrawClient.Text = "Client Details";
            this.grpWithdrawClient.Visible = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Checked = false;
            this.dtpDateOfBirth.CustomFormat = "dd-MMM-yy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(172, 105);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(108, 22);
            this.dtpDateOfBirth.TabIndex = 30;
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(172, 25);
            this.txtClientID.MaxLength = 5;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(42, 22);
            this.txtClientID.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Client ID";
            // 
            // btnCheckActiveBookings
            // 
            this.btnCheckActiveBookings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckActiveBookings.Location = new System.Drawing.Point(172, 348);
            this.btnCheckActiveBookings.Name = "btnCheckActiveBookings";
            this.btnCheckActiveBookings.Size = new System.Drawing.Size(312, 46);
            this.btnCheckActiveBookings.TabIndex = 22;
            this.btnCheckActiveBookings.Text = "Check Active Bookings";
            this.btnCheckActiveBookings.UseVisualStyleBackColor = true;
            this.btnCheckActiveBookings.Click += new System.EventHandler(this.btnCheckActiveBookings_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Surname";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Date Of Birth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Contact No.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Street";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(37, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Town";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(37, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "City";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(37, 263);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "County";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 16);
            this.label22.TabIndex = 13;
            this.label22.Text = "Eircode";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(37, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 16);
            this.label23.TabIndex = 11;
            this.label23.Text = "Forename";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(172, 286);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(77, 22);
            this.txtEircode.TabIndex = 9;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(172, 260);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(100, 22);
            this.txtCounty.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(172, 234);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(341, 22);
            this.txtCity.TabIndex = 7;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(172, 208);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(341, 22);
            this.txtTown.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(172, 182);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(341, 22);
            this.txtStreet.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(172, 78);
            this.txtSurname.MaxLength = 35;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(341, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(172, 130);
            this.txtContactNo.MaxLength = 20;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(180, 22);
            this.txtContactNo.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 156);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(407, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(172, 52);
            this.txtForename.MaxLength = 35;
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(341, 22);
            this.txtForename.TabIndex = 0;
            // 
            // btnLegendDJsNoBookingsWithdrawClient
            // 
            this.btnLegendDJsNoBookingsWithdrawClient.AutoSize = true;
            this.btnLegendDJsNoBookingsWithdrawClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLegendDJsNoBookingsWithdrawClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLegendDJsNoBookingsWithdrawClient.Location = new System.Drawing.Point(239, 971);
            this.btnLegendDJsNoBookingsWithdrawClient.Name = "btnLegendDJsNoBookingsWithdrawClient";
            this.btnLegendDJsNoBookingsWithdrawClient.Size = new System.Drawing.Size(337, 38);
            this.btnLegendDJsNoBookingsWithdrawClient.TabIndex = 36;
            this.btnLegendDJsNoBookingsWithdrawClient.Text = "Legend DJs choice to deregister";
            this.btnLegendDJsNoBookingsWithdrawClient.UseVisualStyleBackColor = true;
            this.btnLegendDJsNoBookingsWithdrawClient.Visible = false;
            this.btnLegendDJsNoBookingsWithdrawClient.Click += new System.EventHandler(this.btnLegendDJsNoBookingsWithdrawClient_Click);
            // 
            // btnClientNoBookingsWithdrawClient
            // 
            this.btnClientNoBookingsWithdrawClient.AutoSize = true;
            this.btnClientNoBookingsWithdrawClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientNoBookingsWithdrawClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClientNoBookingsWithdrawClient.Location = new System.Drawing.Point(743, 971);
            this.btnClientNoBookingsWithdrawClient.Name = "btnClientNoBookingsWithdrawClient";
            this.btnClientNoBookingsWithdrawClient.Size = new System.Drawing.Size(337, 38);
            this.btnClientNoBookingsWithdrawClient.TabIndex = 36;
            this.btnClientNoBookingsWithdrawClient.Text = "Client choice to deregister";
            this.btnClientNoBookingsWithdrawClient.UseVisualStyleBackColor = true;
            this.btnClientNoBookingsWithdrawClient.Visible = false;
            this.btnClientNoBookingsWithdrawClient.Click += new System.EventHandler(this.btnClientNoBookingsWithdrawClient_Click);
            // 
            // btnLegendDJsWithBookingsWithdrawClient
            // 
            this.btnLegendDJsWithBookingsWithdrawClient.AutoSize = true;
            this.btnLegendDJsWithBookingsWithdrawClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLegendDJsWithBookingsWithdrawClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLegendDJsWithBookingsWithdrawClient.Location = new System.Drawing.Point(239, 1014);
            this.btnLegendDJsWithBookingsWithdrawClient.Name = "btnLegendDJsWithBookingsWithdrawClient";
            this.btnLegendDJsWithBookingsWithdrawClient.Size = new System.Drawing.Size(337, 38);
            this.btnLegendDJsWithBookingsWithdrawClient.TabIndex = 37;
            this.btnLegendDJsWithBookingsWithdrawClient.Text = "Legend DJs choice to deregister";
            this.btnLegendDJsWithBookingsWithdrawClient.UseVisualStyleBackColor = true;
            this.btnLegendDJsWithBookingsWithdrawClient.Visible = false;
            this.btnLegendDJsWithBookingsWithdrawClient.Click += new System.EventHandler(this.btnLegendDJsWithBookingsWithdrawClient_Click);
            // 
            // btnClientWithBookingsWithdrawClient
            // 
            this.btnClientWithBookingsWithdrawClient.AutoSize = true;
            this.btnClientWithBookingsWithdrawClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientWithBookingsWithdrawClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClientWithBookingsWithdrawClient.Location = new System.Drawing.Point(743, 1014);
            this.btnClientWithBookingsWithdrawClient.Name = "btnClientWithBookingsWithdrawClient";
            this.btnClientWithBookingsWithdrawClient.Size = new System.Drawing.Size(337, 38);
            this.btnClientWithBookingsWithdrawClient.TabIndex = 38;
            this.btnClientWithBookingsWithdrawClient.Text = "Client choice to deregister";
            this.btnClientWithBookingsWithdrawClient.UseVisualStyleBackColor = true;
            this.btnClientWithBookingsWithdrawClient.Visible = false;
            this.btnClientWithBookingsWithdrawClient.Click += new System.EventHandler(this.btnClientWithBookingsWithdrawClient_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectAll.Location = new System.Drawing.Point(592, 926);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(135, 38);
            this.btnSelectAll.TabIndex = 37;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Visible = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnTotalRefundDue
            // 
            this.btnTotalRefundDue.AutoSize = true;
            this.btnTotalRefundDue.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRefundDue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTotalRefundDue.Location = new System.Drawing.Point(743, 926);
            this.btnTotalRefundDue.Name = "btnTotalRefundDue";
            this.btnTotalRefundDue.Size = new System.Drawing.Size(337, 38);
            this.btnTotalRefundDue.TabIndex = 38;
            this.btnTotalRefundDue.Text = "Calculate Refund Due";
            this.btnTotalRefundDue.UseVisualStyleBackColor = true;
            this.btnTotalRefundDue.Visible = false;
            this.btnTotalRefundDue.Click += new System.EventHandler(this.btnTotalRefundDue_Click);
            // 
            // btnTotalRefundDueLegendDJs
            // 
            this.btnTotalRefundDueLegendDJs.AutoSize = true;
            this.btnTotalRefundDueLegendDJs.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRefundDueLegendDJs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTotalRefundDueLegendDJs.Location = new System.Drawing.Point(239, 926);
            this.btnTotalRefundDueLegendDJs.Name = "btnTotalRefundDueLegendDJs";
            this.btnTotalRefundDueLegendDJs.Size = new System.Drawing.Size(337, 38);
            this.btnTotalRefundDueLegendDJs.TabIndex = 40;
            this.btnTotalRefundDueLegendDJs.Text = "Calculate Refund Due";
            this.btnTotalRefundDueLegendDJs.UseVisualStyleBackColor = true;
            this.btnTotalRefundDueLegendDJs.Visible = false;
            this.btnTotalRefundDueLegendDJs.Click += new System.EventHandler(this.btnTotalRefundDueLegendDJs_Click);
            // 
            // btnWithdrawClientPrintInvoiceLegendDJs
            // 
            this.btnWithdrawClientPrintInvoiceLegendDJs.AutoSize = true;
            this.btnWithdrawClientPrintInvoiceLegendDJs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawClientPrintInvoiceLegendDJs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnWithdrawClientPrintInvoiceLegendDJs.Location = new System.Drawing.Point(147, 938);
            this.btnWithdrawClientPrintInvoiceLegendDJs.Name = "btnWithdrawClientPrintInvoiceLegendDJs";
            this.btnWithdrawClientPrintInvoiceLegendDJs.Size = new System.Drawing.Size(118, 81);
            this.btnWithdrawClientPrintInvoiceLegendDJs.TabIndex = 41;
            this.btnWithdrawClientPrintInvoiceLegendDJs.Text = "Print Invoice";
            this.btnWithdrawClientPrintInvoiceLegendDJs.UseVisualStyleBackColor = true;
            this.btnWithdrawClientPrintInvoiceLegendDJs.Visible = false;
            this.btnWithdrawClientPrintInvoiceLegendDJs.Click += new System.EventHandler(this.btnWithdrawClientPrintInvoiceLegendDJs_Click);
            // 
            // frmWithdrawClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.ColmAndMum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 874);
            this.Controls.Add(this.btnWithdrawClientPrintInvoiceLegendDJs);
            this.Controls.Add(this.btnTotalRefundDueLegendDJs);
            this.Controls.Add(this.btnClientWithBookingsWithdrawClient);
            this.Controls.Add(this.btnTotalRefundDue);
            this.Controls.Add(this.btnLegendDJsWithBookingsWithdrawClient);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnClientNoBookingsWithdrawClient);
            this.Controls.Add(this.btnLegendDJsNoBookingsWithdrawClient);
            this.Controls.Add(this.btnWithdrawClientPrintInvoice);
            this.Controls.Add(this.grpWithdrawClient);
            this.Controls.Add(this.grpWithdrawMatchingClients);
            this.Controls.Add(this.grpWithdrawClientActiveBookings);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterSurname);
            this.Controls.Add(this.txtEnterSurname);
            this.Name = "frmWithdrawClient";
            this.Text = "Withdraw Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWithdrawClient_Load);
            this.grpWithdrawClientActiveBookings.ResumeLayout(false);
            this.grpWithdrawClientActiveBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWithdrawClientActiveBookings)).EndInit();
            this.grpWithdrawMatchingClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWithdrawMatchingClients)).EndInit();
            this.grpWithdrawClient.ResumeLayout(false);
            this.grpWithdrawClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label lblEnterSurname;
        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.GroupBox grpWithdrawClientActiveBookings;
        private System.Windows.Forms.Button btnWithdrawClientPrintInvoice;
        private System.Windows.Forms.GroupBox grpWithdrawMatchingClients;
        private System.Windows.Forms.DataGridView grdWithdrawMatchingClients;
        private System.Windows.Forms.GroupBox grpWithdrawClient;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCheckActiveBookings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.DataGridView grdWithdrawClientActiveBookings;
        private System.Windows.Forms.Button btnLegendDJsNoBookingsWithdrawClient;
        private System.Windows.Forms.Button btnClientNoBookingsWithdrawClient;
        private System.Windows.Forms.Button btnLegendDJsWithBookingsWithdrawClient;
        private System.Windows.Forms.Button btnClientWithBookingsWithdrawClient;
        private System.Windows.Forms.Label lblTotalRefundDue;
        private System.Windows.Forms.Label lblTotalCostSum;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnTotalRefundDue;
        private System.Windows.Forms.TextBox txtTotalRefundDue;
        private System.Windows.Forms.TextBox txtTotalCostSum;
        private System.Windows.Forms.TextBox txtOriginalTotalCost;
        private System.Windows.Forms.Button btnTotalRefundDueLegendDJs;
        private System.Windows.Forms.Button btnWithdrawClientPrintInvoiceLegendDJs;
    }
}