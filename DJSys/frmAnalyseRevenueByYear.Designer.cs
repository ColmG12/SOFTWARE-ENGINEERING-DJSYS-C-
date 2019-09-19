namespace DJSys
{
    partial class frmAnalyseRevenueByYear
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
            this.btnPrintGraphAnalyseByYear = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.grpAnalyseByYear = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chtAnalyseByYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSelectAgain = new System.Windows.Forms.Button();
            this.grpAnalyseByYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseByYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintGraphAnalyseByYear
            // 
            this.btnPrintGraphAnalyseByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintGraphAnalyseByYear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrintGraphAnalyseByYear.Location = new System.Drawing.Point(1715, 852);
            this.btnPrintGraphAnalyseByYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintGraphAnalyseByYear.Name = "btnPrintGraphAnalyseByYear";
            this.btnPrintGraphAnalyseByYear.Size = new System.Drawing.Size(100, 100);
            this.btnPrintGraphAnalyseByYear.TabIndex = 13;
            this.btnPrintGraphAnalyseByYear.Text = "Print Graph";
            this.btnPrintGraphAnalyseByYear.UseVisualStyleBackColor = true;
            this.btnPrintGraphAnalyseByYear.Visible = false;
            this.btnPrintGraphAnalyseByYear.Click += new System.EventHandler(this.btnPrintGraph_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMain.Location = new System.Drawing.Point(13, 852);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 100);
            this.btnMain.TabIndex = 36;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // grpAnalyseByYear
            // 
            this.grpAnalyseByYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpAnalyseByYear.Controls.Add(this.cboYear);
            this.grpAnalyseByYear.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalyseByYear.Location = new System.Drawing.Point(61, 12);
            this.grpAnalyseByYear.Name = "grpAnalyseByYear";
            this.grpAnalyseByYear.Size = new System.Drawing.Size(180, 132);
            this.grpAnalyseByYear.TabIndex = 37;
            this.grpAnalyseByYear.TabStop = false;
            this.grpAnalyseByYear.Text = "Yearly Analysis";
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
            this.cboYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(160, 25);
            this.cboYear.TabIndex = 45;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // chtAnalyseByYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnalyseByYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnalyseByYear.Legends.Add(legend1);
            this.chtAnalyseByYear.Location = new System.Drawing.Point(266, 12);
            this.chtAnalyseByYear.Name = "chtAnalyseByYear";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyseByYear.Series.Add(series1);
            this.chtAnalyseByYear.Size = new System.Drawing.Size(1597, 816);
            this.chtAnalyseByYear.TabIndex = 38;
            this.chtAnalyseByYear.Text = "chart1";
            // 
            // btnSelectAgain
            // 
            this.btnSelectAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAgain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectAgain.Location = new System.Drawing.Point(897, 852);
            this.btnSelectAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAgain.Name = "btnSelectAgain";
            this.btnSelectAgain.Size = new System.Drawing.Size(100, 100);
            this.btnSelectAgain.TabIndex = 39;
            this.btnSelectAgain.Text = "Select Again";
            this.btnSelectAgain.UseVisualStyleBackColor = true;
            this.btnSelectAgain.Visible = false;
            this.btnSelectAgain.Click += new System.EventHandler(this.btnSelectAgain_Click);
            // 
            // frmAnalyseRevenueByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DJSys.Properties.Resources.MumParty2;
            this.ClientSize = new System.Drawing.Size(1875, 965);
            this.Controls.Add(this.btnSelectAgain);
            this.Controls.Add(this.chtAnalyseByYear);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpAnalyseByYear);
            this.Controls.Add(this.btnPrintGraphAnalyseByYear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnalyseRevenueByYear";
            this.Text = "Analyse Revenue By Year";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnalyseRevenueByMonth_Load);
            this.grpAnalyseByYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseByYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrintGraphAnalyseByYear;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox grpAnalyseByYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyseByYear;
        private System.Windows.Forms.Button btnSelectAgain;
    }
}