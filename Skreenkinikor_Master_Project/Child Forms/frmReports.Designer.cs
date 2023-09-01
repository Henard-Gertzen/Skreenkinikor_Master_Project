namespace Skreenkinikor_Master_Project
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.chTop10 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTop3 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop1 = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom1 = new System.Windows.Forms.Panel();
            this.pnlTop2 = new System.Windows.Forms.Panel();
            this.pnlRight1 = new System.Windows.Forms.Panel();
            this.pnlLeft1 = new System.Windows.Forms.Panel();
            this.chTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTop10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(0, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(99, 29);
            this.btnMonth.TabIndex = 15;
            this.btnMonth.Text = "&This Month";
            this.btnMonth.UseVisualStyleBackColor = false;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnPrevMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMonth.ForeColor = System.Drawing.Color.White;
            this.btnPrevMonth.Location = new System.Drawing.Point(99, 0);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(99, 29);
            this.btnPrevMonth.TabIndex = 14;
            this.btnPrevMonth.Text = "&Last 30 days";
            this.btnPrevMonth.UseVisualStyleBackColor = false;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWeek.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(198, 0);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(99, 29);
            this.btnWeek.TabIndex = 13;
            this.btnWeek.Text = "&Last 7 days";
            this.btnWeek.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel3);
            this.pnlTop.Controls.Add(this.btnSubmit);
            this.pnlTop.Controls.Add(this.btnCustom);
            this.pnlTop.Controls.Add(this.btnWeek);
            this.pnlTop.Controls.Add(this.btnPrevMonth);
            this.pnlTop.Controls.Add(this.btnMonth);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 29);
            this.pnlTop.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpEnd);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(446, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 29);
            this.panel3.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(110, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(90, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(90, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 29);
            this.panel4.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MMM dd, yyyy";
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(90, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(396, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(50, 29);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.White;
            this.btnCustom.Location = new System.Drawing.Point(297, 0);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(99, 29);
            this.btnCustom.TabIndex = 16;
            this.btnCustom.Text = "&Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlTotal);
            this.panel2.Controls.Add(this.pnlBottom);
            this.panel2.Controls.Add(this.pnlTop1);
            this.panel2.Controls.Add(this.pnlRight);
            this.panel2.Controls.Add(this.pnlLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 282);
            this.panel2.TabIndex = 19;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.chTop10);
            this.pnlTotal.Controls.Add(this.pnlTop3);
            this.pnlTotal.Controls.Add(this.pnlTop);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.Location = new System.Drawing.Point(18, 18);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(650, 246);
            this.pnlTotal.TabIndex = 21;
            // 
            // chTop10
            // 
            chartArea1.Name = "ChartArea1";
            this.chTop10.ChartAreas.Add(chartArea1);
            this.chTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chTop10.Legends.Add(legend1);
            this.chTop10.Location = new System.Drawing.Point(0, 41);
            this.chTop10.Name = "chTop10";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chTop10.Series.Add(series1);
            this.chTop10.Size = new System.Drawing.Size(650, 205);
            this.chTop10.TabIndex = 25;
            this.chTop10.Text = "chartTop10";
            title1.Name = "tHead";
            title1.Text = "Top 10 Movies";
            this.chTop10.Titles.Add(title1);
            // 
            // pnlTop3
            // 
            this.pnlTop3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop3.Location = new System.Drawing.Point(0, 29);
            this.pnlTop3.Name = "pnlTop3";
            this.pnlTop3.Size = new System.Drawing.Size(650, 12);
            this.pnlTop3.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(18, 264);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(650, 18);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlTop1
            // 
            this.pnlTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop1.Location = new System.Drawing.Point(18, 0);
            this.pnlTop1.Name = "pnlTop1";
            this.pnlTop1.Size = new System.Drawing.Size(650, 18);
            this.pnlTop1.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(668, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(18, 282);
            this.pnlRight.TabIndex = 20;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(18, 282);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBottom1
            // 
            this.pnlBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom1.Location = new System.Drawing.Point(18, 542);
            this.pnlBottom1.Name = "pnlBottom1";
            this.pnlBottom1.Size = new System.Drawing.Size(650, 18);
            this.pnlBottom1.TabIndex = 23;
            // 
            // pnlTop2
            // 
            this.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop2.Location = new System.Drawing.Point(18, 282);
            this.pnlTop2.Name = "pnlTop2";
            this.pnlTop2.Size = new System.Drawing.Size(650, 18);
            this.pnlTop2.TabIndex = 22;
            // 
            // pnlRight1
            // 
            this.pnlRight1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight1.Location = new System.Drawing.Point(668, 282);
            this.pnlRight1.Name = "pnlRight1";
            this.pnlRight1.Size = new System.Drawing.Size(18, 278);
            this.pnlRight1.TabIndex = 24;
            // 
            // pnlLeft1
            // 
            this.pnlLeft1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft1.Location = new System.Drawing.Point(0, 282);
            this.pnlLeft1.Name = "pnlLeft1";
            this.pnlLeft1.Size = new System.Drawing.Size(18, 278);
            this.pnlLeft1.TabIndex = 21;
            // 
            // chTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.chTotal.ChartAreas.Add(chartArea2);
            this.chTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chTotal.Legends.Add(legend2);
            this.chTotal.Location = new System.Drawing.Point(18, 300);
            this.chTotal.Name = "chTotal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chTotal.Series.Add(series2);
            this.chTotal.Size = new System.Drawing.Size(650, 242);
            this.chTotal.TabIndex = 19;
            this.chTotal.Text = "chartTotalMovies";
            title2.Name = "tHead";
            title2.Text = "Total Movies Scheduled";
            this.chTotal.Titles.Add(title2);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(686, 560);
            this.Controls.Add(this.chTotal);
            this.Controls.Add(this.pnlBottom1);
            this.Controls.Add(this.pnlTop2);
            this.Controls.Add(this.pnlRight1);
            this.Controls.Add(this.pnlLeft1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.pnlTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chTop10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlBottom1;
        private System.Windows.Forms.Panel pnlTop2;
        private System.Windows.Forms.Panel pnlRight1;
        private System.Windows.Forms.Panel pnlLeft1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTop10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTotal;
        private System.Windows.Forms.Panel pnlTop3;
    }
}