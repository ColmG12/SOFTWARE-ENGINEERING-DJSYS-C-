namespace DJSys
{
    partial class frmLogService
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
            this.grpLogService = new System.Windows.Forms.GroupBox();
            this.lblBaseRateRequired = new System.Windows.Forms.Label();
            this.lblDescriptionRequired = new System.Windows.Forms.Label();
            this.lblServiceIDRequired = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.txtBaseRate = new System.Windows.Forms.TextBox();
            this.btnLogService = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.grpLogService.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(494, 352);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 105);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // grpLogService
            // 
            this.grpLogService.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpLogService.Controls.Add(this.lblBaseRateRequired);
            this.grpLogService.Controls.Add(this.lblDescriptionRequired);
            this.grpLogService.Controls.Add(this.lblServiceIDRequired);
            this.grpLogService.Controls.Add(this.lblRequiredFields);
            this.grpLogService.Controls.Add(this.txtBaseRate);
            this.grpLogService.Controls.Add(this.btnLogService);
            this.grpLogService.Controls.Add(this.lblDescription);
            this.grpLogService.Controls.Add(this.lblBaseRate);
            this.grpLogService.Controls.Add(this.lblServiceID);
            this.grpLogService.Controls.Add(this.txtDescription);
            this.grpLogService.Controls.Add(this.txtServiceID);
            this.grpLogService.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogService.Location = new System.Drawing.Point(624, 24);
            this.grpLogService.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogService.Name = "grpLogService";
            this.grpLogService.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogService.Size = new System.Drawing.Size(900, 300);
            this.grpLogService.TabIndex = 2;
            this.grpLogService.TabStop = false;
            this.grpLogService.Text = "Enter Service Details";
            // 
            // lblBaseRateRequired
            // 
            this.lblBaseRateRequired.AutoSize = true;
            this.lblBaseRateRequired.Location = new System.Drawing.Point(258, 142);
            this.lblBaseRateRequired.Name = "lblBaseRateRequired";
            this.lblBaseRateRequired.Size = new System.Drawing.Size(16, 19);
            this.lblBaseRateRequired.TabIndex = 40;
            this.lblBaseRateRequired.Text = "*";
            // 
            // lblDescriptionRequired
            // 
            this.lblDescriptionRequired.AutoSize = true;
            this.lblDescriptionRequired.Location = new System.Drawing.Point(258, 100);
            this.lblDescriptionRequired.Name = "lblDescriptionRequired";
            this.lblDescriptionRequired.Size = new System.Drawing.Size(16, 19);
            this.lblDescriptionRequired.TabIndex = 39;
            this.lblDescriptionRequired.Text = "*";
            // 
            // lblServiceIDRequired
            // 
            this.lblServiceIDRequired.AutoSize = true;
            this.lblServiceIDRequired.Location = new System.Drawing.Point(258, 64);
            this.lblServiceIDRequired.Name = "lblServiceIDRequired";
            this.lblServiceIDRequired.Size = new System.Drawing.Size(16, 19);
            this.lblServiceIDRequired.TabIndex = 38;
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
            // btnLogService
            // 
            this.btnLogService.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogService.Location = new System.Drawing.Point(281, 214);
            this.btnLogService.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogService.Name = "btnLogService";
            this.btnLogService.Size = new System.Drawing.Size(200, 57);
            this.btnLogService.TabIndex = 3;
            this.btnLogService.Text = "Log Service";
            this.btnLogService.UseVisualStyleBackColor = true;
            this.btnLogService.Click += new System.EventHandler(this.btnLogService_Click);
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
            // frmLogService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.DJ8;
            this.ClientSize = new System.Drawing.Size(1887, 945);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpLogService);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogService";
            this.Text = "Log Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogService_Load);
            this.grpLogService.ResumeLayout(false);
            this.grpLogService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpLogService;
        private System.Windows.Forms.Button btnLogService;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtBaseRate;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblBaseRateRequired;
        private System.Windows.Forms.Label lblDescriptionRequired;
        private System.Windows.Forms.Label lblServiceIDRequired;
    }
}