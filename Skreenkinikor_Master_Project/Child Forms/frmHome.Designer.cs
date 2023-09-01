namespace Skreenkinikor_Master_Project
{
    partial class frmHome
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
            this.pnlTop1 = new System.Windows.Forms.Panel();
            this.pnlRight1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop1
            // 
            this.pnlTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop1.Location = new System.Drawing.Point(18, 0);
            this.pnlTop1.Name = "pnlTop1";
            this.pnlTop1.Size = new System.Drawing.Size(650, 18);
            this.pnlTop1.TabIndex = 26;
            // 
            // pnlRight1
            // 
            this.pnlRight1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight1.Location = new System.Drawing.Point(668, 0);
            this.pnlRight1.Name = "pnlRight1";
            this.pnlRight1.Size = new System.Drawing.Size(18, 644);
            this.pnlRight1.TabIndex = 30;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(18, 644);
            this.pnlLeft.TabIndex = 25;
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblDate);
            this.pnlMid.Controls.Add(this.lblTime);
            this.pnlMid.Controls.Add(this.pbLogo);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(18, 18);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(650, 626);
            this.pnlMid.TabIndex = 31;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Skreenkinikor_Master_Project.Properties.Resources.SK_Logo;
            this.pbLogo.Location = new System.Drawing.Point(82, 96);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(500, 285);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Historic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(219, 420);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(204, 65);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "99:99:99";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(211, 485);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(223, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "99 September 9999";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(686, 644);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlTop1);
            this.Controls.Add(this.pnlRight1);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop1;
        private System.Windows.Forms.Panel pnlRight1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblDate;
    }
}