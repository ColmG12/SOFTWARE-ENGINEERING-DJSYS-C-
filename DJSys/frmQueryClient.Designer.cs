namespace DJSys
{
    partial class frmQueryClient
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
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCheckActiveBookings = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpQueryClient = new System.Windows.Forms.GroupBox();
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
            this.btnMain = new System.Windows.Forms.Button();
            this.grdQueryClients = new System.Windows.Forms.DataGridView();
            this.grpQueryClients = new System.Windows.Forms.GroupBox();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.grpQueryClientActiveBookings = new System.Windows.Forms.GroupBox();
            this.grdQueryClientActiveBookings = new System.Windows.Forms.DataGridView();
            this.lblEnterSurname = new System.Windows.Forms.Label();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.grpQueryClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryClients)).BeginInit();
            this.grpQueryClients.SuspendLayout();
            this.grpQueryClientActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryClientActiveBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd-MMM-yy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(229, 129);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(143, 25);
            this.dtpDateOfBirth.TabIndex = 30;
            this.dtpDateOfBirth.Value = new System.DateTime(2019, 4, 4, 0, 0, 0, 0);
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(229, 31);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.MaxLength = 5;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(55, 26);
            this.txtClientID.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Client ID";
            // 
            // btnCheckActiveBookings
            // 
            this.btnCheckActiveBookings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckActiveBookings.Location = new System.Drawing.Point(229, 428);
            this.btnCheckActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckActiveBookings.Name = "btnCheckActiveBookings";
            this.btnCheckActiveBookings.Size = new System.Drawing.Size(416, 57);
            this.btnCheckActiveBookings.TabIndex = 22;
            this.btnCheckActiveBookings.Text = "Check Active Bookings";
            this.btnCheckActiveBookings.UseVisualStyleBackColor = true;
            this.btnCheckActiveBookings.Click += new System.EventHandler(this.btnCheckActiveBookings_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Surname";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Date Of Birth";
            // 
            // grpQueryClient
            // 
            this.grpQueryClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpQueryClient.Controls.Add(this.dtpDateOfBirth);
            this.grpQueryClient.Controls.Add(this.txtClientID);
            this.grpQueryClient.Controls.Add(this.label13);
            this.grpQueryClient.Controls.Add(this.btnCheckActiveBookings);
            this.grpQueryClient.Controls.Add(this.label14);
            this.grpQueryClient.Controls.Add(this.label15);
            this.grpQueryClient.Controls.Add(this.label16);
            this.grpQueryClient.Controls.Add(this.label17);
            this.grpQueryClient.Controls.Add(this.label18);
            this.grpQueryClient.Controls.Add(this.label19);
            this.grpQueryClient.Controls.Add(this.label20);
            this.grpQueryClient.Controls.Add(this.label21);
            this.grpQueryClient.Controls.Add(this.label22);
            this.grpQueryClient.Controls.Add(this.label23);
            this.grpQueryClient.Controls.Add(this.txtEircode);
            this.grpQueryClient.Controls.Add(this.txtCounty);
            this.grpQueryClient.Controls.Add(this.txtCity);
            this.grpQueryClient.Controls.Add(this.txtTown);
            this.grpQueryClient.Controls.Add(this.txtStreet);
            this.grpQueryClient.Controls.Add(this.txtSurname);
            this.grpQueryClient.Controls.Add(this.txtContactNo);
            this.grpQueryClient.Controls.Add(this.txtEmail);
            this.grpQueryClient.Controls.Add(this.txtForename);
            this.grpQueryClient.Location = new System.Drawing.Point(851, 121);
            this.grpQueryClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpQueryClient.Name = "grpQueryClient";
            this.grpQueryClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpQueryClient.Size = new System.Drawing.Size(812, 497);
            this.grpQueryClient.TabIndex = 42;
            this.grpQueryClient.TabStop = false;
            this.grpQueryClient.Text = "Client Details";
            this.grpQueryClient.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 164);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Contact No.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(49, 196);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(49, 228);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Street";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(49, 260);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "Town";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(49, 292);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 15;
            this.label20.Text = "City";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(49, 324);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "County";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(49, 356);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 20);
            this.label22.TabIndex = 13;
            this.label22.Text = "Eircode";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(49, 68);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 20);
            this.label23.TabIndex = 11;
            this.label23.Text = "Forename";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(229, 352);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(101, 25);
            this.txtEircode.TabIndex = 9;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(229, 320);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(132, 25);
            this.txtCounty.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(229, 288);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(453, 25);
            this.txtCity.TabIndex = 7;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(229, 256);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(453, 25);
            this.txtTown.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(229, 224);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(453, 25);
            this.txtStreet.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(229, 96);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MaxLength = 35;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(453, 25);
            this.txtSurname.TabIndex = 4;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(229, 160);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.MaxLength = 20;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(239, 25);
            this.txtContactNo.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(229, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(541, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(229, 64);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename.MaxLength = 35;
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(453, 25);
            this.txtForename.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(63, 1182);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 38;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // grdQueryClients
            // 
            this.grdQueryClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdQueryClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryClients.Location = new System.Drawing.Point(7, 25);
            this.grdQueryClients.Margin = new System.Windows.Forms.Padding(4);
            this.grdQueryClients.Name = "grdQueryClients";
            this.grdQueryClients.ReadOnly = true;
            this.grdQueryClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQueryClients.Size = new System.Drawing.Size(708, 460);
            this.grdQueryClients.TabIndex = 0;
            this.grdQueryClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQueryClients_CellDoubleClick);
            // 
            // grpQueryClients
            // 
            this.grpQueryClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpQueryClients.Controls.Add(this.grdQueryClients);
            this.grpQueryClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQueryClients.Location = new System.Drawing.Point(63, 121);
            this.grpQueryClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryClients.Name = "grpQueryClients";
            this.grpQueryClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryClients.Size = new System.Drawing.Size(721, 500);
            this.grpQueryClients.TabIndex = 41;
            this.grpQueryClients.TabStop = false;
            this.grpQueryClients.Text = "Matching Clients";
            this.grpQueryClients.Visible = false;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(403, 77);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(180, 38);
            this.btnFindClient.TabIndex = 37;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            // 
            // grpQueryClientActiveBookings
            // 
            this.grpQueryClientActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpQueryClientActiveBookings.Controls.Add(this.grdQueryClientActiveBookings);
            this.grpQueryClientActiveBookings.Location = new System.Drawing.Point(63, 648);
            this.grpQueryClientActiveBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryClientActiveBookings.Name = "grpQueryClientActiveBookings";
            this.grpQueryClientActiveBookings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryClientActiveBookings.Size = new System.Drawing.Size(1600, 500);
            this.grpQueryClientActiveBookings.TabIndex = 40;
            this.grpQueryClientActiveBookings.TabStop = false;
            this.grpQueryClientActiveBookings.Text = "Active Bookings";
            this.grpQueryClientActiveBookings.Visible = false;
            // 
            // grdQueryClientActiveBookings
            // 
            this.grdQueryClientActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdQueryClientActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryClientActiveBookings.Location = new System.Drawing.Point(7, 21);
            this.grdQueryClientActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdQueryClientActiveBookings.Name = "grdQueryClientActiveBookings";
            this.grdQueryClientActiveBookings.ReadOnly = true;
            this.grdQueryClientActiveBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQueryClientActiveBookings.Size = new System.Drawing.Size(1580, 460);
            this.grdQueryClientActiveBookings.TabIndex = 1;
            // 
            // lblEnterSurname
            // 
            this.lblEnterSurname.AutoSize = true;
            this.lblEnterSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSurname.Location = new System.Drawing.Point(59, 42);
            this.lblEnterSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterSurname.Name = "lblEnterSurname";
            this.lblEnterSurname.Size = new System.Drawing.Size(177, 20);
            this.lblEnterSurname.TabIndex = 36;
            this.lblEnterSurname.Text = "Enter Surname:";
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(267, 42);
            this.txtEnterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(453, 24);
            this.txtEnterSurname.TabIndex = 35;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged_1);
            // 
            // frmQueryClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.ColmAndMum;
            this.ClientSize = new System.Drawing.Size(1723, 1055);
            this.Controls.Add(this.grpQueryClient);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpQueryClients);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.grpQueryClientActiveBookings);
            this.Controls.Add(this.lblEnterSurname);
            this.Controls.Add(this.txtEnterSurname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQueryClient";
            this.Text = "Query Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQueryClient_Load);
            this.grpQueryClient.ResumeLayout(false);
            this.grpQueryClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryClients)).EndInit();
            this.grpQueryClients.ResumeLayout(false);
            this.grpQueryClientActiveBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryClientActiveBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCheckActiveBookings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpQueryClient;
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
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DataGridView grdQueryClients;
        private System.Windows.Forms.GroupBox grpQueryClients;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.GroupBox grpQueryClientActiveBookings;
        private System.Windows.Forms.DataGridView grdQueryClientActiveBookings;
        private System.Windows.Forms.Label lblEnterSurname;
        private System.Windows.Forms.TextBox txtEnterSurname;
    }
}