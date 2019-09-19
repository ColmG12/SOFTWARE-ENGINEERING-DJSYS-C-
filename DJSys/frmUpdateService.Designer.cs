namespace DJSys
{
    partial class frmUpdateService
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
            this.grpUpdateMatchingServices = new System.Windows.Forms.GroupBox();
            this.grdUpdateMatchingServices = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnFindServiceID = new System.Windows.Forms.Button();
            this.lblEnterServiceID = new System.Windows.Forms.Label();
            this.txtEnterServiceID = new System.Windows.Forms.TextBox();
            this.grpUpdateServices = new System.Windows.Forms.GroupBox();
            this.lblBaseRateRequired = new System.Windows.Forms.Label();
            this.lblDescriptionRequired = new System.Windows.Forms.Label();
            this.lblServiceIDRequired = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.txtBaseRate = new System.Windows.Forms.TextBox();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.grpUpdateMatchingServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMatchingServices)).BeginInit();
            this.grpUpdateServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateMatchingServices
            // 
            this.grpUpdateMatchingServices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpUpdateMatchingServices.Controls.Add(this.grdUpdateMatchingServices);
            this.grpUpdateMatchingServices.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateMatchingServices.Location = new System.Drawing.Point(65, 89);
            this.grpUpdateMatchingServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateMatchingServices.Name = "grpUpdateMatchingServices";
            this.grpUpdateMatchingServices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateMatchingServices.Size = new System.Drawing.Size(721, 500);
            this.grpUpdateMatchingServices.TabIndex = 37;
            this.grpUpdateMatchingServices.TabStop = false;
            this.grpUpdateMatchingServices.Text = "Matching Services";
            this.grpUpdateMatchingServices.Visible = false;
            // 
            // grdUpdateMatchingServices
            // 
            this.grdUpdateMatchingServices.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdUpdateMatchingServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateMatchingServices.Location = new System.Drawing.Point(7, 25);
            this.grdUpdateMatchingServices.Margin = new System.Windows.Forms.Padding(4);
            this.grdUpdateMatchingServices.Name = "grdUpdateMatchingServices";
            this.grdUpdateMatchingServices.ReadOnly = true;
            this.grdUpdateMatchingServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateMatchingServices.Size = new System.Drawing.Size(708, 460);
            this.grdUpdateMatchingServices.TabIndex = 0;
            this.grdUpdateMatchingServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateMatchingServices_CellDoubleClick);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(18, 615);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 36;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // btnFindServiceID
            // 
            this.btnFindServiceID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindServiceID.Location = new System.Drawing.Point(386, 43);
            this.btnFindServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindServiceID.Name = "btnFindServiceID";
            this.btnFindServiceID.Size = new System.Drawing.Size(323, 38);
            this.btnFindServiceID.TabIndex = 35;
            this.btnFindServiceID.Text = "Find Service ID";
            this.btnFindServiceID.UseVisualStyleBackColor = true;
            this.btnFindServiceID.Click += new System.EventHandler(this.btnFindServiceID_Click);
            // 
            // lblEnterServiceID
            // 
            this.lblEnterServiceID.AutoSize = true;
            this.lblEnterServiceID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterServiceID.Location = new System.Drawing.Point(61, 10);
            this.lblEnterServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterServiceID.Name = "lblEnterServiceID";
            this.lblEnterServiceID.Size = new System.Drawing.Size(213, 20);
            this.lblEnterServiceID.TabIndex = 34;
            this.lblEnterServiceID.Text = "Enter Service ID:";
            // 
            // txtEnterServiceID
            // 
            this.txtEnterServiceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnterServiceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnterServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterServiceID.Location = new System.Drawing.Point(325, 10);
            this.txtEnterServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterServiceID.MaxLength = 35;
            this.txtEnterServiceID.Name = "txtEnterServiceID";
            this.txtEnterServiceID.Size = new System.Drawing.Size(453, 24);
            this.txtEnterServiceID.TabIndex = 33;
            this.txtEnterServiceID.TextChanged += new System.EventHandler(this.txtEnterServiceID_TextChanged);
            // 
            // grpUpdateServices
            // 
            this.grpUpdateServices.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpUpdateServices.Controls.Add(this.lblBaseRateRequired);
            this.grpUpdateServices.Controls.Add(this.lblDescriptionRequired);
            this.grpUpdateServices.Controls.Add(this.lblServiceIDRequired);
            this.grpUpdateServices.Controls.Add(this.lblRequiredFields);
            this.grpUpdateServices.Controls.Add(this.txtBaseRate);
            this.grpUpdateServices.Controls.Add(this.btnUpdateService);
            this.grpUpdateServices.Controls.Add(this.lblDescription);
            this.grpUpdateServices.Controls.Add(this.lblBaseRate);
            this.grpUpdateServices.Controls.Add(this.lblServiceID);
            this.grpUpdateServices.Controls.Add(this.txtDescription);
            this.grpUpdateServices.Controls.Add(this.txtServiceID);
            this.grpUpdateServices.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateServices.Location = new System.Drawing.Point(853, 89);
            this.grpUpdateServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateServices.Name = "grpUpdateServices";
            this.grpUpdateServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateServices.Size = new System.Drawing.Size(900, 300);
            this.grpUpdateServices.TabIndex = 31;
            this.grpUpdateServices.TabStop = false;
            this.grpUpdateServices.Text = "Update Service Details";
            this.grpUpdateServices.Visible = false;
            // 
            // lblBaseRateRequired
            // 
            this.lblBaseRateRequired.AutoSize = true;
            this.lblBaseRateRequired.Location = new System.Drawing.Point(258, 142);
            this.lblBaseRateRequired.Name = "lblBaseRateRequired";
            this.lblBaseRateRequired.Size = new System.Drawing.Size(16, 19);
            this.lblBaseRateRequired.TabIndex = 43;
            this.lblBaseRateRequired.Text = "*";
            // 
            // lblDescriptionRequired
            // 
            this.lblDescriptionRequired.AutoSize = true;
            this.lblDescriptionRequired.Location = new System.Drawing.Point(258, 100);
            this.lblDescriptionRequired.Name = "lblDescriptionRequired";
            this.lblDescriptionRequired.Size = new System.Drawing.Size(16, 19);
            this.lblDescriptionRequired.TabIndex = 42;
            this.lblDescriptionRequired.Text = "*";
            // 
            // lblServiceIDRequired
            // 
            this.lblServiceIDRequired.AutoSize = true;
            this.lblServiceIDRequired.Location = new System.Drawing.Point(258, 64);
            this.lblServiceIDRequired.Name = "lblServiceIDRequired";
            this.lblServiceIDRequired.Size = new System.Drawing.Size(16, 19);
            this.lblServiceIDRequired.TabIndex = 41;
            this.lblServiceIDRequired.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Location = new System.Drawing.Point(685, 0);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(215, 19);
            this.lblRequiredFields.TabIndex = 33;
            this.lblRequiredFields.Text = "* denotes required fields";
            // 
            // txtBaseRate
            // 
            this.txtBaseRate.Location = new System.Drawing.Point(281, 142);
            this.txtBaseRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseRate.MaxLength = 6;
            this.txtBaseRate.Name = "txtBaseRate";
            this.txtBaseRate.Size = new System.Drawing.Size(73, 27);
            this.txtBaseRate.TabIndex = 2;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.Location = new System.Drawing.Point(281, 214);
            this.btnUpdateService.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(324, 57);
            this.btnUpdateService.TabIndex = 3;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
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
            this.txtDescription.Size = new System.Drawing.Size(489, 27);
            this.txtDescription.TabIndex = 1;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(281, 64);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.MaxLength = 4;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(73, 27);
            this.txtServiceID.TabIndex = 0;
            // 
            // frmUpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.DJ16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1886, 984);
            this.Controls.Add(this.grpUpdateServices);
            this.Controls.Add(this.grpUpdateMatchingServices);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnFindServiceID);
            this.Controls.Add(this.lblEnterServiceID);
            this.Controls.Add(this.txtEnterServiceID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateService";
            this.Text = "Update Service";
            this.Load += new System.EventHandler(this.frmUpdateService_Load);
            this.grpUpdateMatchingServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMatchingServices)).EndInit();
            this.grpUpdateServices.ResumeLayout(false);
            this.grpUpdateServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpUpdateMatchingServices;
        private System.Windows.Forms.DataGridView grdUpdateMatchingServices;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnFindServiceID;
        private System.Windows.Forms.Label lblEnterServiceID;
        private System.Windows.Forms.TextBox txtEnterServiceID;
        private System.Windows.Forms.GroupBox grpUpdateServices;
        private System.Windows.Forms.TextBox txtBaseRate;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblBaseRateRequired;
        private System.Windows.Forms.Label lblDescriptionRequired;
        private System.Windows.Forms.Label lblServiceIDRequired;
    }
}