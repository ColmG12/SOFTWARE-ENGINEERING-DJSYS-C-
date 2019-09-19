namespace DJSys
{
    partial class frmShowDJSchedule
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
            this.grpDJScheduleMatchingDJs = new System.Windows.Forms.GroupBox();
            this.grdDJScheduleMatchingDJs = new System.Windows.Forms.DataGridView();
            this.txtDJID = new System.Windows.Forms.TextBox();
            this.lblDJID = new System.Windows.Forms.Label();
            this.txtDJHourlyRate = new System.Windows.Forms.TextBox();
            this.lblDJHourlyRate = new System.Windows.Forms.Label();
            this.dtpDJDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDJSurname = new System.Windows.Forms.Label();
            this.lblDJDateOfBirth = new System.Windows.Forms.Label();
            this.lblDJContactNo = new System.Windows.Forms.Label();
            this.lblDJEmail = new System.Windows.Forms.Label();
            this.grpDJScheduleDJActiveBookings = new System.Windows.Forms.GroupBox();
            this.grdDJScheduleDJActiveBookings = new System.Windows.Forms.DataGridView();
            this.btnFindDJ = new System.Windows.Forms.Button();
            this.lblEnterSurname = new System.Windows.Forms.Label();
            this.lblDJStreet = new System.Windows.Forms.Label();
            this.lblDJTown = new System.Windows.Forms.Label();
            this.lblDJCity = new System.Windows.Forms.Label();
            this.lblDJCounty = new System.Windows.Forms.Label();
            this.lblDJForename = new System.Windows.Forms.Label();
            this.lblDJEircode = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtDJEircode = new System.Windows.Forms.TextBox();
            this.txtDJCounty = new System.Windows.Forms.TextBox();
            this.txtDJCity = new System.Windows.Forms.TextBox();
            this.txtDJTown = new System.Windows.Forms.TextBox();
            this.txtDJStreet = new System.Windows.Forms.TextBox();
            this.txtDJEmail = new System.Windows.Forms.TextBox();
            this.txtDJSurname = new System.Windows.Forms.TextBox();
            this.txtDJForename = new System.Windows.Forms.TextBox();
            this.btnCheckActiveBookings = new System.Windows.Forms.Button();
            this.txtEnterSurname = new System.Windows.Forms.TextBox();
            this.txtDJContactNo = new System.Windows.Forms.TextBox();
            this.grpDJScheduleDJ = new System.Windows.Forms.GroupBox();
            this.grpDJScheduleMatchingDJs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDJScheduleMatchingDJs)).BeginInit();
            this.grpDJScheduleDJActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDJScheduleDJActiveBookings)).BeginInit();
            this.grpDJScheduleDJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDJScheduleMatchingDJs
            // 
            this.grpDJScheduleMatchingDJs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpDJScheduleMatchingDJs.Controls.Add(this.grdDJScheduleMatchingDJs);
            this.grpDJScheduleMatchingDJs.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDJScheduleMatchingDJs.Location = new System.Drawing.Point(64, 110);
            this.grpDJScheduleMatchingDJs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDJScheduleMatchingDJs.Name = "grpDJScheduleMatchingDJs";
            this.grpDJScheduleMatchingDJs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDJScheduleMatchingDJs.Size = new System.Drawing.Size(721, 522);
            this.grpDJScheduleMatchingDJs.TabIndex = 45;
            this.grpDJScheduleMatchingDJs.TabStop = false;
            this.grpDJScheduleMatchingDJs.Text = "Matching DJs";
            this.grpDJScheduleMatchingDJs.Visible = false;
            // 
            // grdDJScheduleMatchingDJs
            // 
            this.grdDJScheduleMatchingDJs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdDJScheduleMatchingDJs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDJScheduleMatchingDJs.Location = new System.Drawing.Point(7, 25);
            this.grdDJScheduleMatchingDJs.Margin = new System.Windows.Forms.Padding(4);
            this.grdDJScheduleMatchingDJs.Name = "grdDJScheduleMatchingDJs";
            this.grdDJScheduleMatchingDJs.ReadOnly = true;
            this.grdDJScheduleMatchingDJs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDJScheduleMatchingDJs.Size = new System.Drawing.Size(708, 490);
            this.grdDJScheduleMatchingDJs.TabIndex = 0;
            this.grdDJScheduleMatchingDJs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDJScheduleMatchingDJs_CellDoubleClick);
            // 
            // txtDJID
            // 
            this.txtDJID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJID.Location = new System.Drawing.Point(280, 33);
            this.txtDJID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJID.MaxLength = 5;
            this.txtDJID.Name = "txtDJID";
            this.txtDJID.ReadOnly = true;
            this.txtDJID.Size = new System.Drawing.Size(55, 26);
            this.txtDJID.TabIndex = 50;
            // 
            // lblDJID
            // 
            this.lblDJID.AutoSize = true;
            this.lblDJID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJID.Location = new System.Drawing.Point(48, 36);
            this.lblDJID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJID.Name = "lblDJID";
            this.lblDJID.Size = new System.Drawing.Size(69, 20);
            this.lblDJID.TabIndex = 49;
            this.lblDJID.Text = "DJ ID";
            // 
            // txtDJHourlyRate
            // 
            this.txtDJHourlyRate.Location = new System.Drawing.Point(280, 423);
            this.txtDJHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJHourlyRate.MaxLength = 6;
            this.txtDJHourlyRate.Name = "txtDJHourlyRate";
            this.txtDJHourlyRate.ReadOnly = true;
            this.txtDJHourlyRate.Size = new System.Drawing.Size(73, 22);
            this.txtDJHourlyRate.TabIndex = 37;
            // 
            // lblDJHourlyRate
            // 
            this.lblDJHourlyRate.AutoSize = true;
            this.lblDJHourlyRate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJHourlyRate.Location = new System.Drawing.Point(48, 431);
            this.lblDJHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJHourlyRate.Name = "lblDJHourlyRate";
            this.lblDJHourlyRate.Size = new System.Drawing.Size(141, 20);
            this.lblDJHourlyRate.TabIndex = 48;
            this.lblDJHourlyRate.Text = "Hourly Rate";
            // 
            // dtpDJDateOfBirth
            // 
            this.dtpDJDateOfBirth.CustomFormat = "dd-MMM-yy";
            this.dtpDJDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDJDateOfBirth.Location = new System.Drawing.Point(280, 139);
            this.dtpDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDJDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDJDateOfBirth.Name = "dtpDJDateOfBirth";
            this.dtpDJDateOfBirth.Size = new System.Drawing.Size(143, 22);
            this.dtpDJDateOfBirth.TabIndex = 29;
            this.dtpDJDateOfBirth.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // lblDJSurname
            // 
            this.lblDJSurname.AutoSize = true;
            this.lblDJSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJSurname.Location = new System.Drawing.Point(48, 106);
            this.lblDJSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJSurname.Name = "lblDJSurname";
            this.lblDJSurname.Size = new System.Drawing.Size(93, 20);
            this.lblDJSurname.TabIndex = 47;
            this.lblDJSurname.Text = "Surname";
            // 
            // lblDJDateOfBirth
            // 
            this.lblDJDateOfBirth.AutoSize = true;
            this.lblDJDateOfBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJDateOfBirth.Location = new System.Drawing.Point(48, 145);
            this.lblDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJDateOfBirth.Name = "lblDJDateOfBirth";
            this.lblDJDateOfBirth.Size = new System.Drawing.Size(165, 20);
            this.lblDJDateOfBirth.TabIndex = 46;
            this.lblDJDateOfBirth.Text = "Date Of Birth";
            // 
            // lblDJContactNo
            // 
            this.lblDJContactNo.AutoSize = true;
            this.lblDJContactNo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJContactNo.Location = new System.Drawing.Point(48, 177);
            this.lblDJContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJContactNo.Name = "lblDJContactNo";
            this.lblDJContactNo.Size = new System.Drawing.Size(141, 20);
            this.lblDJContactNo.TabIndex = 45;
            this.lblDJContactNo.Text = "Contact No.";
            // 
            // lblDJEmail
            // 
            this.lblDJEmail.AutoSize = true;
            this.lblDJEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEmail.Location = new System.Drawing.Point(48, 213);
            this.lblDJEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEmail.Name = "lblDJEmail";
            this.lblDJEmail.Size = new System.Drawing.Size(69, 20);
            this.lblDJEmail.TabIndex = 44;
            this.lblDJEmail.Text = "Email";
            // 
            // grpDJScheduleDJActiveBookings
            // 
            this.grpDJScheduleDJActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpDJScheduleDJActiveBookings.Controls.Add(this.grdDJScheduleDJActiveBookings);
            this.grpDJScheduleDJActiveBookings.Location = new System.Drawing.Point(64, 658);
            this.grpDJScheduleDJActiveBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDJScheduleDJActiveBookings.Name = "grpDJScheduleDJActiveBookings";
            this.grpDJScheduleDJActiveBookings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDJScheduleDJActiveBookings.Size = new System.Drawing.Size(1600, 500);
            this.grpDJScheduleDJActiveBookings.TabIndex = 44;
            this.grpDJScheduleDJActiveBookings.TabStop = false;
            this.grpDJScheduleDJActiveBookings.Text = "Active Bookings";
            this.grpDJScheduleDJActiveBookings.Visible = false;
            // 
            // grdDJScheduleDJActiveBookings
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.grdDJScheduleDJActiveBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDJScheduleDJActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdDJScheduleDJActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDJScheduleDJActiveBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDJScheduleDJActiveBookings.Location = new System.Drawing.Point(7, 21);
            this.grdDJScheduleDJActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdDJScheduleDJActiveBookings.Name = "grdDJScheduleDJActiveBookings";
            this.grdDJScheduleDJActiveBookings.Size = new System.Drawing.Size(1580, 460);
            this.grdDJScheduleDJActiveBookings.TabIndex = 1;
            // 
            // btnFindDJ
            // 
            this.btnFindDJ.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDJ.Location = new System.Drawing.Point(393, 64);
            this.btnFindDJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindDJ.Name = "btnFindDJ";
            this.btnFindDJ.Size = new System.Drawing.Size(180, 38);
            this.btnFindDJ.TabIndex = 43;
            this.btnFindDJ.Text = "Find DJ";
            this.btnFindDJ.UseVisualStyleBackColor = true;
            this.btnFindDJ.Click += new System.EventHandler(this.btnFindDJ_Click);
            // 
            // lblEnterSurname
            // 
            this.lblEnterSurname.AutoSize = true;
            this.lblEnterSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSurname.Location = new System.Drawing.Point(60, 31);
            this.lblEnterSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterSurname.Name = "lblEnterSurname";
            this.lblEnterSurname.Size = new System.Drawing.Size(177, 20);
            this.lblEnterSurname.TabIndex = 42;
            this.lblEnterSurname.Text = "Enter Surname:";
            // 
            // lblDJStreet
            // 
            this.lblDJStreet.AutoSize = true;
            this.lblDJStreet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJStreet.Location = new System.Drawing.Point(48, 249);
            this.lblDJStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJStreet.Name = "lblDJStreet";
            this.lblDJStreet.Size = new System.Drawing.Size(81, 20);
            this.lblDJStreet.TabIndex = 43;
            this.lblDJStreet.Text = "Street";
            // 
            // lblDJTown
            // 
            this.lblDJTown.AutoSize = true;
            this.lblDJTown.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJTown.Location = new System.Drawing.Point(48, 284);
            this.lblDJTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJTown.Name = "lblDJTown";
            this.lblDJTown.Size = new System.Drawing.Size(57, 20);
            this.lblDJTown.TabIndex = 42;
            this.lblDJTown.Text = "Town";
            // 
            // lblDJCity
            // 
            this.lblDJCity.AutoSize = true;
            this.lblDJCity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCity.Location = new System.Drawing.Point(48, 320);
            this.lblDJCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCity.Name = "lblDJCity";
            this.lblDJCity.Size = new System.Drawing.Size(57, 20);
            this.lblDJCity.TabIndex = 41;
            this.lblDJCity.Text = "City";
            // 
            // lblDJCounty
            // 
            this.lblDJCounty.AutoSize = true;
            this.lblDJCounty.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCounty.Location = new System.Drawing.Point(48, 356);
            this.lblDJCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCounty.Name = "lblDJCounty";
            this.lblDJCounty.Size = new System.Drawing.Size(81, 20);
            this.lblDJCounty.TabIndex = 40;
            this.lblDJCounty.Text = "County";
            // 
            // lblDJForename
            // 
            this.lblDJForename.AutoSize = true;
            this.lblDJForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJForename.Location = new System.Drawing.Point(48, 70);
            this.lblDJForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJForename.Name = "lblDJForename";
            this.lblDJForename.Size = new System.Drawing.Size(105, 20);
            this.lblDJForename.TabIndex = 38;
            this.lblDJForename.Text = "Forename";
            // 
            // lblDJEircode
            // 
            this.lblDJEircode.AutoSize = true;
            this.lblDJEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEircode.Location = new System.Drawing.Point(48, 391);
            this.lblDJEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEircode.Name = "lblDJEircode";
            this.lblDJEircode.Size = new System.Drawing.Size(93, 20);
            this.lblDJEircode.TabIndex = 39;
            this.lblDJEircode.Text = "Eircode";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(64, 1175);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 47;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtDJEircode
            // 
            this.txtDJEircode.Location = new System.Drawing.Point(280, 389);
            this.txtDJEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEircode.MaxLength = 7;
            this.txtDJEircode.Name = "txtDJEircode";
            this.txtDJEircode.ReadOnly = true;
            this.txtDJEircode.Size = new System.Drawing.Size(101, 22);
            this.txtDJEircode.TabIndex = 36;
            // 
            // txtDJCounty
            // 
            this.txtDJCounty.Location = new System.Drawing.Point(280, 353);
            this.txtDJCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJCounty.MaxLength = 15;
            this.txtDJCounty.Name = "txtDJCounty";
            this.txtDJCounty.ReadOnly = true;
            this.txtDJCounty.Size = new System.Drawing.Size(132, 22);
            this.txtDJCounty.TabIndex = 35;
            // 
            // txtDJCity
            // 
            this.txtDJCity.Location = new System.Drawing.Point(280, 318);
            this.txtDJCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJCity.MaxLength = 50;
            this.txtDJCity.Name = "txtDJCity";
            this.txtDJCity.ReadOnly = true;
            this.txtDJCity.Size = new System.Drawing.Size(453, 22);
            this.txtDJCity.TabIndex = 34;
            // 
            // txtDJTown
            // 
            this.txtDJTown.Location = new System.Drawing.Point(280, 282);
            this.txtDJTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJTown.MaxLength = 50;
            this.txtDJTown.Name = "txtDJTown";
            this.txtDJTown.ReadOnly = true;
            this.txtDJTown.Size = new System.Drawing.Size(453, 22);
            this.txtDJTown.TabIndex = 33;
            // 
            // txtDJStreet
            // 
            this.txtDJStreet.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJStreet.Location = new System.Drawing.Point(280, 246);
            this.txtDJStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJStreet.MaxLength = 50;
            this.txtDJStreet.Name = "txtDJStreet";
            this.txtDJStreet.ReadOnly = true;
            this.txtDJStreet.Size = new System.Drawing.Size(453, 27);
            this.txtDJStreet.TabIndex = 32;
            // 
            // txtDJEmail
            // 
            this.txtDJEmail.Location = new System.Drawing.Point(280, 210);
            this.txtDJEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEmail.MaxLength = 255;
            this.txtDJEmail.Name = "txtDJEmail";
            this.txtDJEmail.ReadOnly = true;
            this.txtDJEmail.Size = new System.Drawing.Size(489, 22);
            this.txtDJEmail.TabIndex = 31;
            // 
            // txtDJSurname
            // 
            this.txtDJSurname.Location = new System.Drawing.Point(280, 103);
            this.txtDJSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJSurname.MaxLength = 35;
            this.txtDJSurname.Name = "txtDJSurname";
            this.txtDJSurname.ReadOnly = true;
            this.txtDJSurname.Size = new System.Drawing.Size(453, 22);
            this.txtDJSurname.TabIndex = 28;
            // 
            // txtDJForename
            // 
            this.txtDJForename.Location = new System.Drawing.Point(280, 68);
            this.txtDJForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJForename.MaxLength = 35;
            this.txtDJForename.Name = "txtDJForename";
            this.txtDJForename.ReadOnly = true;
            this.txtDJForename.Size = new System.Drawing.Size(453, 22);
            this.txtDJForename.TabIndex = 27;
            // 
            // btnCheckActiveBookings
            // 
            this.btnCheckActiveBookings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckActiveBookings.Location = new System.Drawing.Point(280, 471);
            this.btnCheckActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckActiveBookings.Name = "btnCheckActiveBookings";
            this.btnCheckActiveBookings.Size = new System.Drawing.Size(416, 43);
            this.btnCheckActiveBookings.TabIndex = 22;
            this.btnCheckActiveBookings.Text = "Check Active Bookings";
            this.btnCheckActiveBookings.UseVisualStyleBackColor = true;
            this.btnCheckActiveBookings.Click += new System.EventHandler(this.btnCheckActiveBookings_Click);
            // 
            // txtEnterSurname
            // 
            this.txtEnterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSurname.Location = new System.Drawing.Point(268, 31);
            this.txtEnterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterSurname.MaxLength = 35;
            this.txtEnterSurname.Name = "txtEnterSurname";
            this.txtEnterSurname.Size = new System.Drawing.Size(453, 24);
            this.txtEnterSurname.TabIndex = 41;
            this.txtEnterSurname.TextChanged += new System.EventHandler(this.txtEnterSurname_TextChanged);
            // 
            // txtDJContactNo
            // 
            this.txtDJContactNo.Location = new System.Drawing.Point(280, 175);
            this.txtDJContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJContactNo.MaxLength = 20;
            this.txtDJContactNo.Name = "txtDJContactNo";
            this.txtDJContactNo.ReadOnly = true;
            this.txtDJContactNo.Size = new System.Drawing.Size(239, 22);
            this.txtDJContactNo.TabIndex = 30;
            // 
            // grpDJScheduleDJ
            // 
            this.grpDJScheduleDJ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpDJScheduleDJ.Controls.Add(this.txtDJID);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJID);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJHourlyRate);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJHourlyRate);
            this.grpDJScheduleDJ.Controls.Add(this.dtpDJDateOfBirth);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJSurname);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJDateOfBirth);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJContactNo);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJEmail);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJStreet);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJTown);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJCity);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJCounty);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJEircode);
            this.grpDJScheduleDJ.Controls.Add(this.lblDJForename);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJEircode);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJCounty);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJCity);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJTown);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJStreet);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJEmail);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJContactNo);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJSurname);
            this.grpDJScheduleDJ.Controls.Add(this.txtDJForename);
            this.grpDJScheduleDJ.Controls.Add(this.btnCheckActiveBookings);
            this.grpDJScheduleDJ.Location = new System.Drawing.Point(852, 110);
            this.grpDJScheduleDJ.Margin = new System.Windows.Forms.Padding(4);
            this.grpDJScheduleDJ.Name = "grpDJScheduleDJ";
            this.grpDJScheduleDJ.Padding = new System.Windows.Forms.Padding(4);
            this.grpDJScheduleDJ.Size = new System.Drawing.Size(812, 522);
            this.grpDJScheduleDJ.TabIndex = 46;
            this.grpDJScheduleDJ.TabStop = false;
            this.grpDJScheduleDJ.Text = "DJ Details";
            this.grpDJScheduleDJ.Visible = false;
            // 
            // frmShowDJSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.SarahJaneParty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1723, 1055);
            this.Controls.Add(this.grpDJScheduleMatchingDJs);
            this.Controls.Add(this.grpDJScheduleDJActiveBookings);
            this.Controls.Add(this.btnFindDJ);
            this.Controls.Add(this.lblEnterSurname);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.txtEnterSurname);
            this.Controls.Add(this.grpDJScheduleDJ);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShowDJSchedule";
            this.Text = "Show DJ Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowDJSchedule_Load);
            this.grpDJScheduleMatchingDJs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDJScheduleMatchingDJs)).EndInit();
            this.grpDJScheduleDJActiveBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDJScheduleDJActiveBookings)).EndInit();
            this.grpDJScheduleDJ.ResumeLayout(false);
            this.grpDJScheduleDJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDJScheduleMatchingDJs;
        private System.Windows.Forms.DataGridView grdDJScheduleMatchingDJs;
        private System.Windows.Forms.TextBox txtDJID;
        private System.Windows.Forms.Label lblDJID;
        private System.Windows.Forms.TextBox txtDJHourlyRate;
        private System.Windows.Forms.Label lblDJHourlyRate;
        private System.Windows.Forms.DateTimePicker dtpDJDateOfBirth;
        private System.Windows.Forms.Label lblDJSurname;
        private System.Windows.Forms.Label lblDJDateOfBirth;
        private System.Windows.Forms.Label lblDJContactNo;
        private System.Windows.Forms.Label lblDJEmail;
        private System.Windows.Forms.GroupBox grpDJScheduleDJActiveBookings;
        private System.Windows.Forms.DataGridView grdDJScheduleDJActiveBookings;
        private System.Windows.Forms.Button btnFindDJ;
        private System.Windows.Forms.Label lblEnterSurname;
        private System.Windows.Forms.Label lblDJStreet;
        private System.Windows.Forms.Label lblDJTown;
        private System.Windows.Forms.Label lblDJCity;
        private System.Windows.Forms.Label lblDJCounty;
        private System.Windows.Forms.Label lblDJForename;
        private System.Windows.Forms.Label lblDJEircode;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtDJEircode;
        private System.Windows.Forms.TextBox txtDJCounty;
        private System.Windows.Forms.TextBox txtDJCity;
        private System.Windows.Forms.TextBox txtDJTown;
        private System.Windows.Forms.TextBox txtDJStreet;
        private System.Windows.Forms.TextBox txtDJEmail;
        private System.Windows.Forms.TextBox txtDJSurname;
        private System.Windows.Forms.TextBox txtDJForename;
        private System.Windows.Forms.Button btnCheckActiveBookings;
        private System.Windows.Forms.TextBox txtEnterSurname;
        private System.Windows.Forms.TextBox txtDJContactNo;
        private System.Windows.Forms.GroupBox grpDJScheduleDJ;
    }
}