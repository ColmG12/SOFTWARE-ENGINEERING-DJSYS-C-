namespace DJSys
{
    partial class frmQueryService
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
            this.btnMain = new System.Windows.Forms.Button();
            this.grpQueryMachingServices = new System.Windows.Forms.GroupBox();
            this.grdQueryMatchingServices = new System.Windows.Forms.DataGridView();
            this.btnFindService = new System.Windows.Forms.Button();
            this.lblEnterServiceID = new System.Windows.Forms.Label();
            this.txtEnterServiceID = new System.Windows.Forms.TextBox();
            this.grpQueryServices = new System.Windows.Forms.GroupBox();
            this.btnCheckActiveBookings = new System.Windows.Forms.Button();
            this.txtBaseRate = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.grpQueryServicesActiveBookings = new System.Windows.Forms.GroupBox();
            this.grdQueryServicesActiveBookings = new System.Windows.Forms.DataGridView();
            this.grpQueryMachingServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryMatchingServices)).BeginInit();
            this.grpQueryServices.SuspendLayout();
            this.grpQueryServicesActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryServicesActiveBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 1175);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 105);
            this.btnMain.TabIndex = 49;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // grpQueryMachingServices
            // 
            this.grpQueryMachingServices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpQueryMachingServices.Controls.Add(this.grdQueryMatchingServices);
            this.grpQueryMachingServices.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQueryMachingServices.Location = new System.Drawing.Point(75, 98);
            this.grpQueryMachingServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryMachingServices.Name = "grpQueryMachingServices";
            this.grpQueryMachingServices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryMachingServices.Size = new System.Drawing.Size(721, 500);
            this.grpQueryMachingServices.TabIndex = 83;
            this.grpQueryMachingServices.TabStop = false;
            this.grpQueryMachingServices.Text = "Matching Services";
            this.grpQueryMachingServices.Visible = false;
            // 
            // grdQueryMatchingServices
            // 
            this.grdQueryMatchingServices.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdQueryMatchingServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryMatchingServices.Location = new System.Drawing.Point(7, 25);
            this.grdQueryMatchingServices.Margin = new System.Windows.Forms.Padding(4);
            this.grdQueryMatchingServices.Name = "grdQueryMatchingServices";
            this.grdQueryMatchingServices.ReadOnly = true;
            this.grdQueryMatchingServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQueryMatchingServices.Size = new System.Drawing.Size(708, 460);
            this.grdQueryMatchingServices.TabIndex = 0;
            this.grdQueryMatchingServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQueryServices_CellDoubleClick);
            // 
            // btnFindService
            // 
            this.btnFindService.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindService.Location = new System.Drawing.Point(337, 55);
            this.btnFindService.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindService.Name = "btnFindService";
            this.btnFindService.Size = new System.Drawing.Size(323, 38);
            this.btnFindService.TabIndex = 82;
            this.btnFindService.Text = "Find Service";
            this.btnFindService.UseVisualStyleBackColor = true;
            this.btnFindService.Click += new System.EventHandler(this.btnFindService_Click);
            // 
            // lblEnterServiceID
            // 
            this.lblEnterServiceID.AutoSize = true;
            this.lblEnterServiceID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterServiceID.Location = new System.Drawing.Point(71, 20);
            this.lblEnterServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterServiceID.Name = "lblEnterServiceID";
            this.lblEnterServiceID.Size = new System.Drawing.Size(177, 20);
            this.lblEnterServiceID.TabIndex = 81;
            this.lblEnterServiceID.Text = "Enter Service:";
            // 
            // txtEnterServiceID
            // 
            this.txtEnterServiceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnterServiceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnterServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterServiceID.Location = new System.Drawing.Point(279, 20);
            this.txtEnterServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterServiceID.MaxLength = 35;
            this.txtEnterServiceID.Name = "txtEnterServiceID";
            this.txtEnterServiceID.Size = new System.Drawing.Size(453, 24);
            this.txtEnterServiceID.TabIndex = 80;
            this.txtEnterServiceID.TextChanged += new System.EventHandler(this.txtEnterServiceID_TextChanged);
            // 
            // grpQueryServices
            // 
            this.grpQueryServices.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpQueryServices.Controls.Add(this.btnCheckActiveBookings);
            this.grpQueryServices.Controls.Add(this.txtBaseRate);
            this.grpQueryServices.Controls.Add(this.lblDescription);
            this.grpQueryServices.Controls.Add(this.lblBaseRate);
            this.grpQueryServices.Controls.Add(this.lblServiceID);
            this.grpQueryServices.Controls.Add(this.txtDescription);
            this.grpQueryServices.Controls.Add(this.txtServiceID);
            this.grpQueryServices.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQueryServices.Location = new System.Drawing.Point(835, 98);
            this.grpQueryServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpQueryServices.Name = "grpQueryServices";
            this.grpQueryServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpQueryServices.Size = new System.Drawing.Size(900, 300);
            this.grpQueryServices.TabIndex = 84;
            this.grpQueryServices.TabStop = false;
            this.grpQueryServices.Text = "Service Details";
            this.grpQueryServices.Visible = false;
            // 
            // btnCheckActiveBookings
            // 
            this.btnCheckActiveBookings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckActiveBookings.Location = new System.Drawing.Point(281, 220);
            this.btnCheckActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckActiveBookings.Name = "btnCheckActiveBookings";
            this.btnCheckActiveBookings.Size = new System.Drawing.Size(416, 57);
            this.btnCheckActiveBookings.TabIndex = 23;
            this.btnCheckActiveBookings.Text = "Check Active Bookings";
            this.btnCheckActiveBookings.UseVisualStyleBackColor = true;
            this.btnCheckActiveBookings.Click += new System.EventHandler(this.btnCheckActiveBookings_Click);
            // 
            // txtBaseRate
            // 
            this.txtBaseRate.Location = new System.Drawing.Point(281, 142);
            this.txtBaseRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseRate.MaxLength = 6;
            this.txtBaseRate.Name = "txtBaseRate";
            this.txtBaseRate.ReadOnly = true;
            this.txtBaseRate.Size = new System.Drawing.Size(73, 27);
            this.txtBaseRate.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(49, 102);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 20);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description";
            // 
            // lblBaseRate
            // 
            this.lblBaseRate.AutoSize = true;
            this.lblBaseRate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseRate.Location = new System.Drawing.Point(49, 142);
            this.lblBaseRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseRate.Name = "lblBaseRate";
            this.lblBaseRate.Size = new System.Drawing.Size(165, 20);
            this.lblBaseRate.TabIndex = 20;
            this.lblBaseRate.Text = "Base Rate (€)";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(49, 66);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(129, 20);
            this.lblServiceID.TabIndex = 11;
            this.lblServiceID.Text = "Service ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(281, 100);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(489, 27);
            this.txtDescription.TabIndex = 1;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(281, 64);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.MaxLength = 4;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(73, 27);
            this.txtServiceID.TabIndex = 0;
            // 
            // grpQueryServicesActiveBookings
            // 
            this.grpQueryServicesActiveBookings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpQueryServicesActiveBookings.Controls.Add(this.grdQueryServicesActiveBookings);
            this.grpQueryServicesActiveBookings.Location = new System.Drawing.Point(75, 626);
            this.grpQueryServicesActiveBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryServicesActiveBookings.Name = "grpQueryServicesActiveBookings";
            this.grpQueryServicesActiveBookings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQueryServicesActiveBookings.Size = new System.Drawing.Size(1660, 500);
            this.grpQueryServicesActiveBookings.TabIndex = 85;
            this.grpQueryServicesActiveBookings.TabStop = false;
            this.grpQueryServicesActiveBookings.Text = "Active Bookings";
            this.grpQueryServicesActiveBookings.Visible = false;
            // 
            // grdQueryServicesActiveBookings
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.grdQueryServicesActiveBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdQueryServicesActiveBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdQueryServicesActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryServicesActiveBookings.Location = new System.Drawing.Point(7, 21);
            this.grdQueryServicesActiveBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdQueryServicesActiveBookings.Name = "grdQueryServicesActiveBookings";
            this.grdQueryServicesActiveBookings.ReadOnly = true;
            this.grdQueryServicesActiveBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQueryServicesActiveBookings.Size = new System.Drawing.Size(1645, 460);
            this.grdQueryServicesActiveBookings.TabIndex = 1;
            // 
            // frmQueryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.DJ15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1844, 1055);
            this.Controls.Add(this.grpQueryServicesActiveBookings);
            this.Controls.Add(this.grpQueryServices);
            this.Controls.Add(this.grpQueryMachingServices);
            this.Controls.Add(this.btnFindService);
            this.Controls.Add(this.lblEnterServiceID);
            this.Controls.Add(this.txtEnterServiceID);
            this.Controls.Add(this.btnMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQueryService";
            this.Text = "Query Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQueryService_Load);
            this.grpQueryMachingServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryMatchingServices)).EndInit();
            this.grpQueryServices.ResumeLayout(false);
            this.grpQueryServices.PerformLayout();
            this.grpQueryServicesActiveBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryServicesActiveBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpQueryMachingServices;
        private System.Windows.Forms.DataGridView grdQueryMatchingServices;
        private System.Windows.Forms.Button btnFindService;
        private System.Windows.Forms.Label lblEnterServiceID;
        private System.Windows.Forms.TextBox txtEnterServiceID;
        private System.Windows.Forms.GroupBox grpQueryServices;
        private System.Windows.Forms.TextBox txtBaseRate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Button btnCheckActiveBookings;
        private System.Windows.Forms.GroupBox grpQueryServicesActiveBookings;
        private System.Windows.Forms.DataGridView grdQueryServicesActiveBookings;
    }
}