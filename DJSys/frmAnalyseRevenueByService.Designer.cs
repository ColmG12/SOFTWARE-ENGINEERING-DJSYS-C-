namespace DJSys
{
    partial class frmAnalyseRevenueByService
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSelectAgain = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.grpAnalyseByService = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnPrintGraphAnalyseByService = new System.Windows.Forms.Button();
            this.chtAnalyseByService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpAnalyseByService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseByService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectAgain
            // 
            this.btnSelectAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAgain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectAgain.Location = new System.Drawing.Point(917, 850);
            this.btnSelectAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectAgain.Name = "btnSelectAgain";
            this.btnSelectAgain.Size = new System.Drawing.Size(100, 100);
            this.btnSelectAgain.TabIndex = 45;
            this.btnSelectAgain.Text = "Select Again";
            this.btnSelectAgain.UseVisualStyleBackColor = true;
            this.btnSelectAgain.Visible = false;
            this.btnSelectAgain.Click += new System.EventHandler(this.btnSelectAgain_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 850);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 42;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // grpAnalyseByService
            // 
            this.grpAnalyseByService.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpAnalyseByService.Controls.Add(this.cboYear);
            this.grpAnalyseByService.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalyseByService.Location = new System.Drawing.Point(49, 15);
            this.grpAnalyseByService.Name = "grpAnalyseByService";
            this.grpAnalyseByService.Size = new System.Drawing.Size(180, 132);
            this.grpAnalyseByService.TabIndex = 43;
            this.grpAnalyseByService.TabStop = false;
            this.grpAnalyseByService.Text = "Yearly Analysis (Service)";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormatString = "d";
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 17;
            this.cboYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017"});
            this.cboYear.Location = new System.Drawing.Point(7, 42);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(160, 25);
            this.cboYear.TabIndex = 45;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // btnPrintGraphAnalyseByService
            // 
            this.btnPrintGraphAnalyseByService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintGraphAnalyseByService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrintGraphAnalyseByService.Location = new System.Drawing.Point(1715, 850);
            this.btnPrintGraphAnalyseByService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintGraphAnalyseByService.Name = "btnPrintGraphAnalyseByService";
            this.btnPrintGraphAnalyseByService.Size = new System.Drawing.Size(100, 100);
            this.btnPrintGraphAnalyseByService.TabIndex = 41;
            this.btnPrintGraphAnalyseByService.Text = "Print Graph";
            this.btnPrintGraphAnalyseByService.UseVisualStyleBackColor = true;
            this.btnPrintGraphAnalyseByService.Visible = false;
            this.btnPrintGraphAnalyseByService.Click += new System.EventHandler(this.btnPrintGraphAnalyseByService_Click_1);
            // 
            // chtAnalyseByService
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnalyseByService.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnalyseByService.Legends.Add(legend1);
            this.chtAnalyseByService.Location = new System.Drawing.Point(270, 36);
            this.chtAnalyseByService.Name = "chtAnalyseByService";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyseByService.Series.Add(series1);
            this.chtAnalyseByService.Size = new System.Drawing.Size(1415, 607);
            this.chtAnalyseByService.TabIndex = 46;
            this.chtAnalyseByService.Text = "chart1";
            // 
            // frmAnalyseRevenueByService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.DJ14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1885, 967);
            this.Controls.Add(this.chtAnalyseByService);
            this.Controls.Add(this.btnSelectAgain);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpAnalyseByService);
            this.Controls.Add(this.btnPrintGraphAnalyseByService);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnalyseRevenueByService";
            this.Text = "Analyse Revenue By Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnalyseRevenueByService_Load);
            this.grpAnalyseByService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseByService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectAgain;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpAnalyseByService;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnPrintGraphAnalyseByService;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyseByService;
    }
}