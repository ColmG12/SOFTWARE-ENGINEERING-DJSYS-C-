namespace DJSys
{
    partial class frmAddDJ
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
            this.dtpDJDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddDJ = new System.Windows.Forms.Button();
            this.lblDJSurname = new System.Windows.Forms.Label();
            this.lblDJDateOfBirth = new System.Windows.Forms.Label();
            this.lblDJContactNo = new System.Windows.Forms.Label();
            this.lblDJEmail = new System.Windows.Forms.Label();
            this.lblDJStreet = new System.Windows.Forms.Label();
            this.lblDJTown = new System.Windows.Forms.Label();
            this.lblDJCity = new System.Windows.Forms.Label();
            this.lblDJCounty = new System.Windows.Forms.Label();
            this.txtDJID = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblDJEircode = new System.Windows.Forms.Label();
            this.lblDJForename = new System.Windows.Forms.Label();
            this.txtDJCity = new System.Windows.Forms.TextBox();
            this.txtDJTown = new System.Windows.Forms.TextBox();
            this.txtDJStreet = new System.Windows.Forms.TextBox();
            this.txtDJEmail = new System.Windows.Forms.TextBox();
            this.txtDJContactNo = new System.Windows.Forms.TextBox();
            this.txtDJSurname = new System.Windows.Forms.TextBox();
            this.txtDJForename = new System.Windows.Forms.TextBox();
            this.lblDJID = new System.Windows.Forms.Label();
            this.txtDJEircode = new System.Windows.Forms.TextBox();
            this.grpAddDJ = new System.Windows.Forms.GroupBox();
            this.lblHourlyRateRequired = new System.Windows.Forms.Label();
            this.lblEircodeRequired = new System.Windows.Forms.Label();
            this.lblCountyRequired = new System.Windows.Forms.Label();
            this.lblTownRequired = new System.Windows.Forms.Label();
            this.lblStreetRequired = new System.Windows.Forms.Label();
            this.lblEmailRequired = new System.Windows.Forms.Label();
            this.lblContactRequired = new System.Windows.Forms.Label();
            this.lblDateRequired = new System.Windows.Forms.Label();
            this.lblSurnameRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.cboDJCounty = new System.Windows.Forms.ComboBox();
            this.txtDJHourlyRate = new System.Windows.Forms.TextBox();
            this.lblDJHourlyRate = new System.Windows.Forms.Label();
            this.grpAddDJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDJDateOfBirth
            // 
            this.dtpDJDateOfBirth.Checked = false;
            this.dtpDJDateOfBirth.CustomFormat = "dd-MMM-yy";
            this.dtpDJDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDJDateOfBirth.Location = new System.Drawing.Point(281, 135);
            this.dtpDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDJDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDJDateOfBirth.Name = "dtpDJDateOfBirth";
            this.dtpDJDateOfBirth.Size = new System.Drawing.Size(143, 27);
            this.dtpDJDateOfBirth.TabIndex = 2;
            // 
            // btnAddDJ
            // 
            this.btnAddDJ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDJ.Location = new System.Drawing.Point(321, 528);
            this.btnAddDJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDJ.Name = "btnAddDJ";
            this.btnAddDJ.Size = new System.Drawing.Size(200, 57);
            this.btnAddDJ.TabIndex = 22;
            this.btnAddDJ.Text = "Add DJ";
            this.btnAddDJ.UseVisualStyleBackColor = true;
            this.btnAddDJ.Click += new System.EventHandler(this.btnAddDJ_Click);
            // 
            // lblDJSurname
            // 
            this.lblDJSurname.AutoSize = true;
            this.lblDJSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJSurname.Location = new System.Drawing.Point(49, 102);
            this.lblDJSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJSurname.Name = "lblDJSurname";
            this.lblDJSurname.Size = new System.Drawing.Size(93, 20);
            this.lblDJSurname.TabIndex = 21;
            this.lblDJSurname.Text = "Surname";
            // 
            // lblDJDateOfBirth
            // 
            this.lblDJDateOfBirth.AutoSize = true;
            this.lblDJDateOfBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJDateOfBirth.Location = new System.Drawing.Point(49, 142);
            this.lblDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJDateOfBirth.Name = "lblDJDateOfBirth";
            this.lblDJDateOfBirth.Size = new System.Drawing.Size(165, 20);
            this.lblDJDateOfBirth.TabIndex = 20;
            this.lblDJDateOfBirth.Text = "Date Of Birth";
            // 
            // lblDJContactNo
            // 
            this.lblDJContactNo.AutoSize = true;
            this.lblDJContactNo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJContactNo.Location = new System.Drawing.Point(49, 174);
            this.lblDJContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJContactNo.Name = "lblDJContactNo";
            this.lblDJContactNo.Size = new System.Drawing.Size(141, 20);
            this.lblDJContactNo.TabIndex = 19;
            this.lblDJContactNo.Text = "Contact No.";
            // 
            // lblDJEmail
            // 
            this.lblDJEmail.AutoSize = true;
            this.lblDJEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEmail.Location = new System.Drawing.Point(49, 209);
            this.lblDJEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEmail.Name = "lblDJEmail";
            this.lblDJEmail.Size = new System.Drawing.Size(69, 20);
            this.lblDJEmail.TabIndex = 18;
            this.lblDJEmail.Text = "Email";
            // 
            // lblDJStreet
            // 
            this.lblDJStreet.AutoSize = true;
            this.lblDJStreet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJStreet.Location = new System.Drawing.Point(49, 245);
            this.lblDJStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJStreet.Name = "lblDJStreet";
            this.lblDJStreet.Size = new System.Drawing.Size(81, 20);
            this.lblDJStreet.TabIndex = 17;
            this.lblDJStreet.Text = "Street";
            // 
            // lblDJTown
            // 
            this.lblDJTown.AutoSize = true;
            this.lblDJTown.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJTown.Location = new System.Drawing.Point(49, 281);
            this.lblDJTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJTown.Name = "lblDJTown";
            this.lblDJTown.Size = new System.Drawing.Size(57, 20);
            this.lblDJTown.TabIndex = 16;
            this.lblDJTown.Text = "Town";
            // 
            // lblDJCity
            // 
            this.lblDJCity.AutoSize = true;
            this.lblDJCity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCity.Location = new System.Drawing.Point(49, 316);
            this.lblDJCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCity.Name = "lblDJCity";
            this.lblDJCity.Size = new System.Drawing.Size(57, 20);
            this.lblDJCity.TabIndex = 15;
            this.lblDJCity.Text = "City";
            // 
            // lblDJCounty
            // 
            this.lblDJCounty.AutoSize = true;
            this.lblDJCounty.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCounty.Location = new System.Drawing.Point(49, 352);
            this.lblDJCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCounty.Name = "lblDJCounty";
            this.lblDJCounty.Size = new System.Drawing.Size(81, 20);
            this.lblDJCounty.TabIndex = 14;
            this.lblDJCounty.Text = "County";
            // 
            // txtDJID
            // 
            this.txtDJID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJID.Location = new System.Drawing.Point(923, 150);
            this.txtDJID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJID.MaxLength = 5;
            this.txtDJID.Name = "txtDJID";
            this.txtDJID.ReadOnly = true;
            this.txtDJID.Size = new System.Drawing.Size(45, 26);
            this.txtDJID.TabIndex = 29;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(515, 851);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 28;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblDJEircode
            // 
            this.lblDJEircode.AutoSize = true;
            this.lblDJEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEircode.Location = new System.Drawing.Point(49, 388);
            this.lblDJEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEircode.Name = "lblDJEircode";
            this.lblDJEircode.Size = new System.Drawing.Size(93, 20);
            this.lblDJEircode.TabIndex = 13;
            this.lblDJEircode.Text = "Eircode";
            // 
            // lblDJForename
            // 
            this.lblDJForename.AutoSize = true;
            this.lblDJForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJForename.Location = new System.Drawing.Point(49, 66);
            this.lblDJForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJForename.Name = "lblDJForename";
            this.lblDJForename.Size = new System.Drawing.Size(105, 20);
            this.lblDJForename.TabIndex = 11;
            this.lblDJForename.Text = "Forename";
            // 
            // txtDJCity
            // 
            this.txtDJCity.Location = new System.Drawing.Point(281, 314);
            this.txtDJCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJCity.MaxLength = 50;
            this.txtDJCity.Name = "txtDJCity";
            this.txtDJCity.Size = new System.Drawing.Size(453, 27);
            this.txtDJCity.TabIndex = 7;
            // 
            // txtDJTown
            // 
            this.txtDJTown.Location = new System.Drawing.Point(281, 278);
            this.txtDJTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJTown.MaxLength = 50;
            this.txtDJTown.Name = "txtDJTown";
            this.txtDJTown.Size = new System.Drawing.Size(453, 27);
            this.txtDJTown.TabIndex = 6;
            // 
            // txtDJStreet
            // 
            this.txtDJStreet.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJStreet.Location = new System.Drawing.Point(281, 242);
            this.txtDJStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJStreet.MaxLength = 50;
            this.txtDJStreet.Name = "txtDJStreet";
            this.txtDJStreet.Size = new System.Drawing.Size(453, 27);
            this.txtDJStreet.TabIndex = 5;
            // 
            // txtDJEmail
            // 
            this.txtDJEmail.Location = new System.Drawing.Point(281, 207);
            this.txtDJEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEmail.MaxLength = 255;
            this.txtDJEmail.Name = "txtDJEmail";
            this.txtDJEmail.Size = new System.Drawing.Size(489, 27);
            this.txtDJEmail.TabIndex = 4;
            // 
            // txtDJContactNo
            // 
            this.txtDJContactNo.Location = new System.Drawing.Point(281, 171);
            this.txtDJContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJContactNo.MaxLength = 20;
            this.txtDJContactNo.Name = "txtDJContactNo";
            this.txtDJContactNo.Size = new System.Drawing.Size(239, 27);
            this.txtDJContactNo.TabIndex = 3;
            // 
            // txtDJSurname
            // 
            this.txtDJSurname.Location = new System.Drawing.Point(281, 100);
            this.txtDJSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJSurname.MaxLength = 35;
            this.txtDJSurname.Name = "txtDJSurname";
            this.txtDJSurname.Size = new System.Drawing.Size(453, 27);
            this.txtDJSurname.TabIndex = 1;
            // 
            // txtDJForename
            // 
            this.txtDJForename.Location = new System.Drawing.Point(281, 64);
            this.txtDJForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJForename.MaxLength = 35;
            this.txtDJForename.Name = "txtDJForename";
            this.txtDJForename.Size = new System.Drawing.Size(453, 27);
            this.txtDJForename.TabIndex = 0;
            // 
            // lblDJID
            // 
            this.lblDJID.AutoSize = true;
            this.lblDJID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJID.Location = new System.Drawing.Point(691, 154);
            this.lblDJID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJID.Name = "lblDJID";
            this.lblDJID.Size = new System.Drawing.Size(69, 20);
            this.lblDJID.TabIndex = 30;
            this.lblDJID.Text = "DJ ID";
            // 
            // txtDJEircode
            // 
            this.txtDJEircode.Location = new System.Drawing.Point(281, 385);
            this.txtDJEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEircode.MaxLength = 7;
            this.txtDJEircode.Name = "txtDJEircode";
            this.txtDJEircode.Size = new System.Drawing.Size(101, 27);
            this.txtDJEircode.TabIndex = 9;
            // 
            // grpAddDJ
            // 
            this.grpAddDJ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAddDJ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpAddDJ.Controls.Add(this.lblHourlyRateRequired);
            this.grpAddDJ.Controls.Add(this.lblEircodeRequired);
            this.grpAddDJ.Controls.Add(this.lblCountyRequired);
            this.grpAddDJ.Controls.Add(this.lblTownRequired);
            this.grpAddDJ.Controls.Add(this.lblStreetRequired);
            this.grpAddDJ.Controls.Add(this.lblEmailRequired);
            this.grpAddDJ.Controls.Add(this.lblContactRequired);
            this.grpAddDJ.Controls.Add(this.lblDateRequired);
            this.grpAddDJ.Controls.Add(this.lblSurnameRequired);
            this.grpAddDJ.Controls.Add(this.label1);
            this.grpAddDJ.Controls.Add(this.lblRequiredFields);
            this.grpAddDJ.Controls.Add(this.cboDJCounty);
            this.grpAddDJ.Controls.Add(this.txtDJHourlyRate);
            this.grpAddDJ.Controls.Add(this.lblDJHourlyRate);
            this.grpAddDJ.Controls.Add(this.dtpDJDateOfBirth);
            this.grpAddDJ.Controls.Add(this.btnAddDJ);
            this.grpAddDJ.Controls.Add(this.lblDJSurname);
            this.grpAddDJ.Controls.Add(this.lblDJDateOfBirth);
            this.grpAddDJ.Controls.Add(this.lblDJContactNo);
            this.grpAddDJ.Controls.Add(this.lblDJEmail);
            this.grpAddDJ.Controls.Add(this.lblDJStreet);
            this.grpAddDJ.Controls.Add(this.lblDJTown);
            this.grpAddDJ.Controls.Add(this.lblDJCity);
            this.grpAddDJ.Controls.Add(this.lblDJCounty);
            this.grpAddDJ.Controls.Add(this.lblDJEircode);
            this.grpAddDJ.Controls.Add(this.lblDJForename);
            this.grpAddDJ.Controls.Add(this.txtDJEircode);
            this.grpAddDJ.Controls.Add(this.txtDJCity);
            this.grpAddDJ.Controls.Add(this.txtDJTown);
            this.grpAddDJ.Controls.Add(this.txtDJStreet);
            this.grpAddDJ.Controls.Add(this.txtDJEmail);
            this.grpAddDJ.Controls.Add(this.txtDJContactNo);
            this.grpAddDJ.Controls.Add(this.txtDJSurname);
            this.grpAddDJ.Controls.Add(this.txtDJForename);
            this.grpAddDJ.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddDJ.Location = new System.Drawing.Point(642, 219);
            this.grpAddDJ.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddDJ.Name = "grpAddDJ";
            this.grpAddDJ.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddDJ.Size = new System.Drawing.Size(812, 592);
            this.grpAddDJ.TabIndex = 27;
            this.grpAddDJ.TabStop = false;
            this.grpAddDJ.Text = "Enter DJ Details";
            // 
            // lblHourlyRateRequired
            // 
            this.lblHourlyRateRequired.AutoSize = true;
            this.lblHourlyRateRequired.Location = new System.Drawing.Point(258, 420);
            this.lblHourlyRateRequired.Name = "lblHourlyRateRequired";
            this.lblHourlyRateRequired.Size = new System.Drawing.Size(16, 19);
            this.lblHourlyRateRequired.TabIndex = 44;
            this.lblHourlyRateRequired.Text = "*";
            // 
            // lblEircodeRequired
            // 
            this.lblEircodeRequired.AutoSize = true;
            this.lblEircodeRequired.Location = new System.Drawing.Point(258, 385);
            this.lblEircodeRequired.Name = "lblEircodeRequired";
            this.lblEircodeRequired.Size = new System.Drawing.Size(16, 19);
            this.lblEircodeRequired.TabIndex = 43;
            this.lblEircodeRequired.Text = "*";
            // 
            // lblCountyRequired
            // 
            this.lblCountyRequired.AutoSize = true;
            this.lblCountyRequired.Location = new System.Drawing.Point(258, 348);
            this.lblCountyRequired.Name = "lblCountyRequired";
            this.lblCountyRequired.Size = new System.Drawing.Size(16, 19);
            this.lblCountyRequired.TabIndex = 42;
            this.lblCountyRequired.Text = "*";
            // 
            // lblTownRequired
            // 
            this.lblTownRequired.AutoSize = true;
            this.lblTownRequired.Location = new System.Drawing.Point(258, 278);
            this.lblTownRequired.Name = "lblTownRequired";
            this.lblTownRequired.Size = new System.Drawing.Size(16, 19);
            this.lblTownRequired.TabIndex = 41;
            this.lblTownRequired.Text = "*";
            // 
            // lblStreetRequired
            // 
            this.lblStreetRequired.AutoSize = true;
            this.lblStreetRequired.Location = new System.Drawing.Point(258, 242);
            this.lblStreetRequired.Name = "lblStreetRequired";
            this.lblStreetRequired.Size = new System.Drawing.Size(16, 19);
            this.lblStreetRequired.TabIndex = 40;
            this.lblStreetRequired.Text = "*";
            // 
            // lblEmailRequired
            // 
            this.lblEmailRequired.AutoSize = true;
            this.lblEmailRequired.Location = new System.Drawing.Point(258, 207);
            this.lblEmailRequired.Name = "lblEmailRequired";
            this.lblEmailRequired.Size = new System.Drawing.Size(16, 19);
            this.lblEmailRequired.TabIndex = 39;
            this.lblEmailRequired.Text = "*";
            // 
            // lblContactRequired
            // 
            this.lblContactRequired.AutoSize = true;
            this.lblContactRequired.Location = new System.Drawing.Point(258, 171);
            this.lblContactRequired.Name = "lblContactRequired";
            this.lblContactRequired.Size = new System.Drawing.Size(16, 19);
            this.lblContactRequired.TabIndex = 38;
            this.lblContactRequired.Text = "*";
            // 
            // lblDateRequired
            // 
            this.lblDateRequired.AutoSize = true;
            this.lblDateRequired.Location = new System.Drawing.Point(258, 135);
            this.lblDateRequired.Name = "lblDateRequired";
            this.lblDateRequired.Size = new System.Drawing.Size(16, 19);
            this.lblDateRequired.TabIndex = 37;
            this.lblDateRequired.Text = "*";
            // 
            // lblSurnameRequired
            // 
            this.lblSurnameRequired.AutoSize = true;
            this.lblSurnameRequired.Location = new System.Drawing.Point(258, 100);
            this.lblSurnameRequired.Name = "lblSurnameRequired";
            this.lblSurnameRequired.Size = new System.Drawing.Size(16, 19);
            this.lblSurnameRequired.TabIndex = 36;
            this.lblSurnameRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Location = new System.Drawing.Point(597, 0);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(215, 19);
            this.lblRequiredFields.TabIndex = 33;
            this.lblRequiredFields.Text = "* denotes required fields";
            // 
            // cboDJCounty
            // 
            this.cboDJCounty.FormattingEnabled = true;
            this.cboDJCounty.Location = new System.Drawing.Point(281, 348);
            this.cboDJCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDJCounty.Name = "cboDJCounty";
            this.cboDJCounty.Size = new System.Drawing.Size(132, 26);
            this.cboDJCounty.TabIndex = 8;
            this.cboDJCounty.SelectedIndexChanged += new System.EventHandler(this.cboDJCounty_SelectedIndexChanged_1);
            // 
            // txtDJHourlyRate
            // 
            this.txtDJHourlyRate.Location = new System.Drawing.Point(281, 420);
            this.txtDJHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJHourlyRate.MaxLength = 6;
            this.txtDJHourlyRate.Name = "txtDJHourlyRate";
            this.txtDJHourlyRate.Size = new System.Drawing.Size(73, 27);
            this.txtDJHourlyRate.TabIndex = 10;
            // 
            // lblDJHourlyRate
            // 
            this.lblDJHourlyRate.AutoSize = true;
            this.lblDJHourlyRate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJHourlyRate.Location = new System.Drawing.Point(49, 427);
            this.lblDJHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJHourlyRate.Name = "lblDJHourlyRate";
            this.lblDJHourlyRate.Size = new System.Drawing.Size(141, 20);
            this.lblDJHourlyRate.TabIndex = 26;
            this.lblDJHourlyRate.Text = "Hourly Rate";
            // 
            // frmAddDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.SarahJaneParty;
            this.ClientSize = new System.Drawing.Size(1884, 958);
            this.Controls.Add(this.txtDJID);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblDJID);
            this.Controls.Add(this.grpAddDJ);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddDJ";
            this.Text = "Add DJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddDJ_Load);
            this.grpAddDJ.ResumeLayout(false);
            this.grpAddDJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDJDateOfBirth;
        private System.Windows.Forms.Button btnAddDJ;
        private System.Windows.Forms.Label lblDJSurname;
        private System.Windows.Forms.Label lblDJDateOfBirth;
        private System.Windows.Forms.Label lblDJContactNo;
        private System.Windows.Forms.Label lblDJEmail;
        private System.Windows.Forms.Label lblDJStreet;
        private System.Windows.Forms.Label lblDJTown;
        private System.Windows.Forms.Label lblDJCity;
        private System.Windows.Forms.Label lblDJCounty;
        private System.Windows.Forms.TextBox txtDJID;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblDJEircode;
        private System.Windows.Forms.Label lblDJForename;
        private System.Windows.Forms.TextBox txtDJCity;
        private System.Windows.Forms.TextBox txtDJTown;
        private System.Windows.Forms.TextBox txtDJStreet;
        private System.Windows.Forms.TextBox txtDJEmail;
        private System.Windows.Forms.TextBox txtDJContactNo;
        private System.Windows.Forms.TextBox txtDJSurname;
        private System.Windows.Forms.TextBox txtDJForename;
        private System.Windows.Forms.Label lblDJID;
        private System.Windows.Forms.TextBox txtDJEircode;
        private System.Windows.Forms.GroupBox grpAddDJ;
        private System.Windows.Forms.Label lblDJHourlyRate;
        private System.Windows.Forms.TextBox txtDJHourlyRate;
        private System.Windows.Forms.ComboBox cboDJCounty;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblHourlyRateRequired;
        private System.Windows.Forms.Label lblEircodeRequired;
        private System.Windows.Forms.Label lblCountyRequired;
        private System.Windows.Forms.Label lblTownRequired;
        private System.Windows.Forms.Label lblStreetRequired;
        private System.Windows.Forms.Label lblEmailRequired;
        private System.Windows.Forms.Label lblContactRequired;
        private System.Windows.Forms.Label lblDateRequired;
        private System.Windows.Forms.Label lblSurnameRequired;
        private System.Windows.Forms.Label label1;
    }
}