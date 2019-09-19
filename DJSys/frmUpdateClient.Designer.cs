namespace DJSys
{
    partial class frmUpdateClient
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
            this.components = new System.ComponentModel.Container();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.lblEnterSurame = new System.Windows.Forms.Label();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnMain = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.grpUpdateMatchingClients = new System.Windows.Forms.GroupBox();
            this.grdUpdateMatchingClients = new System.Windows.Forms.DataGridView();
            this.grpUpdateClient = new System.Windows.Forms.GroupBox();
            this.lblEircodeRequired = new System.Windows.Forms.Label();
            this.lblCountyRequired = new System.Windows.Forms.Label();
            this.lblTownRequired = new System.Windows.Forms.Label();
            this.lblStreetRequired = new System.Windows.Forms.Label();
            this.lblEmailRequired = new System.Windows.Forms.Label();
            this.lblContactRequired = new System.Windows.Forms.Label();
            this.lblDateRequired = new System.Windows.Forms.Label();
            this.lblSurnameRequired = new System.Windows.Forms.Label();
            this.lblForenameRequired = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpUpdateMatchingClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMatchingClients)).BeginInit();
            this.grpUpdateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnterSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(267, 15);
            this.txtEnterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(453, 24);
            this.txtEnterSurname.TabIndex = 0;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblEnterSurame
            // 
            this.lblEnterSurame.AutoSize = true;
            this.lblEnterSurame.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSurame.Location = new System.Drawing.Point(59, 15);
            this.lblEnterSurame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterSurame.Name = "lblEnterSurame";
            this.lblEnterSurame.Size = new System.Drawing.Size(177, 20);
            this.lblEnterSurame.TabIndex = 1;
            this.lblEnterSurame.Text = "Enter Surname:";
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(413, 48);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(180, 38);
            this.btnFindClient.TabIndex = 2;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(16, 620);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // grpUpdateMatchingClients
            // 
            this.grpUpdateMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpUpdateMatchingClients.Controls.Add(this.grdUpdateMatchingClients);
            this.grpUpdateMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateMatchingClients.Location = new System.Drawing.Point(63, 94);
            this.grpUpdateMatchingClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateMatchingClients.Name = "grpUpdateMatchingClients";
            this.grpUpdateMatchingClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateMatchingClients.Size = new System.Drawing.Size(721, 500);
            this.grpUpdateMatchingClients.TabIndex = 5;
            this.grpUpdateMatchingClients.TabStop = false;
            this.grpUpdateMatchingClients.Text = "Matching Clients";
            this.grpUpdateMatchingClients.Visible = false;
            // 
            // grdUpdateMatchingClients
            // 
            this.grdUpdateMatchingClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdUpdateMatchingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateMatchingClients.Location = new System.Drawing.Point(7, 25);
            this.grdUpdateMatchingClients.Margin = new System.Windows.Forms.Padding(4);
            this.grdUpdateMatchingClients.Name = "grdUpdateMatchingClients";
            this.grdUpdateMatchingClients.ReadOnly = true;
            this.grdUpdateMatchingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateMatchingClients.Size = new System.Drawing.Size(708, 460);
            this.grdUpdateMatchingClients.TabIndex = 0;
            this.grdUpdateMatchingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateMatchingClients_CellDoubleClick);
            // 
            // grpUpdateClient
            // 
            this.grpUpdateClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpUpdateClient.Controls.Add(this.lblEircodeRequired);
            this.grpUpdateClient.Controls.Add(this.lblCountyRequired);
            this.grpUpdateClient.Controls.Add(this.lblTownRequired);
            this.grpUpdateClient.Controls.Add(this.lblStreetRequired);
            this.grpUpdateClient.Controls.Add(this.lblEmailRequired);
            this.grpUpdateClient.Controls.Add(this.lblContactRequired);
            this.grpUpdateClient.Controls.Add(this.lblDateRequired);
            this.grpUpdateClient.Controls.Add(this.lblSurnameRequired);
            this.grpUpdateClient.Controls.Add(this.lblForenameRequired);
            this.grpUpdateClient.Controls.Add(this.lblRequiredFields);
            this.grpUpdateClient.Controls.Add(this.cboCounty);
            this.grpUpdateClient.Controls.Add(this.dtpDateOfBirth);
            this.grpUpdateClient.Controls.Add(this.txtClientID);
            this.grpUpdateClient.Controls.Add(this.label2);
            this.grpUpdateClient.Controls.Add(this.btnUpdateClient);
            this.grpUpdateClient.Controls.Add(this.label3);
            this.grpUpdateClient.Controls.Add(this.label4);
            this.grpUpdateClient.Controls.Add(this.label5);
            this.grpUpdateClient.Controls.Add(this.label6);
            this.grpUpdateClient.Controls.Add(this.label7);
            this.grpUpdateClient.Controls.Add(this.label8);
            this.grpUpdateClient.Controls.Add(this.label9);
            this.grpUpdateClient.Controls.Add(this.label10);
            this.grpUpdateClient.Controls.Add(this.label11);
            this.grpUpdateClient.Controls.Add(this.label12);
            this.grpUpdateClient.Controls.Add(this.txtEircode);
            this.grpUpdateClient.Controls.Add(this.txtCity);
            this.grpUpdateClient.Controls.Add(this.txtTown);
            this.grpUpdateClient.Controls.Add(this.txtStreet);
            this.grpUpdateClient.Controls.Add(this.txtSurname);
            this.grpUpdateClient.Controls.Add(this.txtContactNo);
            this.grpUpdateClient.Controls.Add(this.txtEmail);
            this.grpUpdateClient.Controls.Add(this.txtForename);
            this.grpUpdateClient.Location = new System.Drawing.Point(851, 94);
            this.grpUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient.Name = "grpUpdateClient";
            this.grpUpdateClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient.Size = new System.Drawing.Size(812, 497);
            this.grpUpdateClient.TabIndex = 31;
            this.grpUpdateClient.TabStop = false;
            this.grpUpdateClient.Text = "Client Details";
            this.grpUpdateClient.Visible = false;
            // 
            // lblEircodeRequired
            // 
            this.lblEircodeRequired.AutoSize = true;
            this.lblEircodeRequired.Location = new System.Drawing.Point(209, 352);
            this.lblEircodeRequired.Name = "lblEircodeRequired";
            this.lblEircodeRequired.Size = new System.Drawing.Size(13, 17);
            this.lblEircodeRequired.TabIndex = 42;
            this.lblEircodeRequired.Text = "*";
            // 
            // lblCountyRequired
            // 
            this.lblCountyRequired.AutoSize = true;
            this.lblCountyRequired.Location = new System.Drawing.Point(209, 320);
            this.lblCountyRequired.Name = "lblCountyRequired";
            this.lblCountyRequired.Size = new System.Drawing.Size(13, 17);
            this.lblCountyRequired.TabIndex = 41;
            this.lblCountyRequired.Text = "*";
            // 
            // lblTownRequired
            // 
            this.lblTownRequired.AutoSize = true;
            this.lblTownRequired.Location = new System.Drawing.Point(209, 256);
            this.lblTownRequired.Name = "lblTownRequired";
            this.lblTownRequired.Size = new System.Drawing.Size(13, 17);
            this.lblTownRequired.TabIndex = 40;
            this.lblTownRequired.Text = "*";
            // 
            // lblStreetRequired
            // 
            this.lblStreetRequired.AutoSize = true;
            this.lblStreetRequired.Location = new System.Drawing.Point(209, 224);
            this.lblStreetRequired.Name = "lblStreetRequired";
            this.lblStreetRequired.Size = new System.Drawing.Size(13, 17);
            this.lblStreetRequired.TabIndex = 39;
            this.lblStreetRequired.Text = "*";
            // 
            // lblEmailRequired
            // 
            this.lblEmailRequired.AutoSize = true;
            this.lblEmailRequired.Location = new System.Drawing.Point(209, 192);
            this.lblEmailRequired.Name = "lblEmailRequired";
            this.lblEmailRequired.Size = new System.Drawing.Size(13, 17);
            this.lblEmailRequired.TabIndex = 38;
            this.lblEmailRequired.Text = "*";
            // 
            // lblContactRequired
            // 
            this.lblContactRequired.AutoSize = true;
            this.lblContactRequired.Location = new System.Drawing.Point(209, 160);
            this.lblContactRequired.Name = "lblContactRequired";
            this.lblContactRequired.Size = new System.Drawing.Size(13, 17);
            this.lblContactRequired.TabIndex = 37;
            this.lblContactRequired.Text = "*";
            // 
            // lblDateRequired
            // 
            this.lblDateRequired.AutoSize = true;
            this.lblDateRequired.Location = new System.Drawing.Point(209, 129);
            this.lblDateRequired.Name = "lblDateRequired";
            this.lblDateRequired.Size = new System.Drawing.Size(13, 17);
            this.lblDateRequired.TabIndex = 36;
            this.lblDateRequired.Text = "*";
            // 
            // lblSurnameRequired
            // 
            this.lblSurnameRequired.AutoSize = true;
            this.lblSurnameRequired.Location = new System.Drawing.Point(209, 96);
            this.lblSurnameRequired.Name = "lblSurnameRequired";
            this.lblSurnameRequired.Size = new System.Drawing.Size(13, 17);
            this.lblSurnameRequired.TabIndex = 35;
            this.lblSurnameRequired.Text = "*";
            // 
            // lblForenameRequired
            // 
            this.lblForenameRequired.AutoSize = true;
            this.lblForenameRequired.Location = new System.Drawing.Point(209, 64);
            this.lblForenameRequired.Name = "lblForenameRequired";
            this.lblForenameRequired.Size = new System.Drawing.Size(13, 17);
            this.lblForenameRequired.TabIndex = 34;
            this.lblForenameRequired.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Location = new System.Drawing.Point(650, 0);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(162, 17);
            this.lblRequiredFields.TabIndex = 33;
            this.lblRequiredFields.Text = "* denotes required fields";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(229, 320);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(132, 24);
            this.cboCounty.TabIndex = 8;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged_1);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Checked = false;
            this.dtpDateOfBirth.CustomFormat = "dd-MMM-yy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(229, 129);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(143, 25);
            this.dtpDateOfBirth.TabIndex = 30;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Client ID";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(343, 432);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(299, 57);
            this.btnUpdateClient.TabIndex = 22;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Street";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Town";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "County";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Eircode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Forename";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(229, 352);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(101, 25);
            this.txtEircode.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(229, 288);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
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
            this.txtForename.Size = new System.Drawing.Size(453, 25);
            this.txtForename.TabIndex = 0;
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.ColmAndMum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1749, 762);
            this.Controls.Add(this.grpUpdateClient);
            this.Controls.Add(this.grpUpdateMatchingClients);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterSurame);
            this.Controls.Add(this.txtEnterSurname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateClient";
            this.Text = "Update Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpUpdateMatchingClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMatchingClients)).EndInit();
            this.grpUpdateClient.ResumeLayout(false);
            this.grpUpdateClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.Label lblEnterSurame;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnMain;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.GroupBox grpUpdateMatchingClients;
        private System.Windows.Forms.GroupBox grpUpdateClient;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.DataGridView grdUpdateMatchingClients;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblEircodeRequired;
        private System.Windows.Forms.Label lblCountyRequired;
        private System.Windows.Forms.Label lblTownRequired;
        private System.Windows.Forms.Label lblStreetRequired;
        private System.Windows.Forms.Label lblEmailRequired;
        private System.Windows.Forms.Label lblContactRequired;
        private System.Windows.Forms.Label lblDateRequired;
        private System.Windows.Forms.Label lblSurnameRequired;
        private System.Windows.Forms.Label lblForenameRequired;
    }
}