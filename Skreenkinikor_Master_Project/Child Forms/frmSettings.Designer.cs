namespace Skreenkinikor_Master_Project
{
    partial class frmSettings
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
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.dgSettings = new System.Windows.Forms.DataGridView();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBuffer = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlbtnbuffer = new System.Windows.Forms.Panel();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.ipbSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlsearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSettings)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSearch)).BeginInit();
            this.pnlsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(20, 521);
            this.pnlleft.TabIndex = 0;
            // 
            // pnlright
            // 
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(666, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(20, 521);
            this.pnlright.TabIndex = 1;
            // 
            // pnltop
            // 
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(20, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(646, 20);
            this.pnltop.TabIndex = 1;
            // 
            // dgSettings
            // 
            this.dgSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgSettings.Location = new System.Drawing.Point(20, 20);
            this.dgSettings.Name = "dgSettings";
            this.dgSettings.Size = new System.Drawing.Size(646, 432);
            this.dgSettings.TabIndex = 5;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlsearch);
            this.pnlContainer.Controls.Add(this.pnlButton);
            this.pnlContainer.Controls.Add(this.pnlBuffer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(20, 452);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(646, 60);
            this.pnlContainer.TabIndex = 6;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // pnlBuffer
            // 
            this.pnlBuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuffer.Location = new System.Drawing.Point(0, 0);
            this.pnlBuffer.Name = "pnlBuffer";
            this.pnlBuffer.Size = new System.Drawing.Size(646, 16);
            this.pnlBuffer.TabIndex = 5;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnView);
            this.pnlButton.Controls.Add(this.pnlbtnbuffer);
            this.pnlButton.Controls.Add(this.btnRequests);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 16);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(278, 44);
            this.pnlButton.TabIndex = 6;
            // 
            // pnlbtnbuffer
            // 
            this.pnlbtnbuffer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlbtnbuffer.Location = new System.Drawing.Point(123, 0);
            this.pnlbtnbuffer.Name = "pnlbtnbuffer";
            this.pnlbtnbuffer.Size = new System.Drawing.Size(17, 44);
            this.pnlbtnbuffer.TabIndex = 7;
            // 
            // btnRequests
            // 
            this.btnRequests.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRequests.Location = new System.Drawing.Point(0, 0);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(123, 44);
            this.btnRequests.TabIndex = 0;
            this.btnRequests.Text = "&View Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnView.Location = new System.Drawing.Point(140, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(123, 44);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "&Modify Users";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // ipbSearch
            // 
            this.ipbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ipbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ipbSearch.IconColor = System.Drawing.Color.White;
            this.ipbSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbSearch.IconSize = 20;
            this.ipbSearch.Location = new System.Drawing.Point(0, 0);
            this.ipbSearch.Name = "ipbSearch";
            this.ipbSearch.Size = new System.Drawing.Size(26, 20);
            this.ipbSearch.TabIndex = 7;
            this.ipbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(26, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // pnlsearch
            // 
            this.pnlsearch.Controls.Add(this.txtSearch);
            this.pnlsearch.Controls.Add(this.ipbSearch);
            this.pnlsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlsearch.Location = new System.Drawing.Point(278, 16);
            this.pnlsearch.Name = "pnlsearch";
            this.pnlsearch.Size = new System.Drawing.Size(368, 20);
            this.pnlsearch.TabIndex = 8;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(686, 521);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.dgSettings);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dgSettings)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbSearch)).EndInit();
            this.pnlsearch.ResumeLayout(false);
            this.pnlsearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.DataGridView dgSettings;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBuffer;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlbtnbuffer;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Panel pnlsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox ipbSearch;
    }
}