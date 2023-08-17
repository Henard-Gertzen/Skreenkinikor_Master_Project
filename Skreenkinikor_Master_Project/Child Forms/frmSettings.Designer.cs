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
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pnlcenter = new System.Windows.Forms.Panel();
            this.pnlDatagrid = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnModifyUsers = new System.Windows.Forms.Button();
            this.pnlbtnbuffer = new System.Windows.Forms.Panel();
            this.pnlcenter.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(20, 450);
            this.pnlleft.TabIndex = 0;
            // 
            // pnlright
            // 
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(780, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(20, 450);
            this.pnlright.TabIndex = 1;
            // 
            // pnlbottom
            // 
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(20, 430);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(760, 20);
            this.pnlbottom.TabIndex = 2;
            // 
            // pnltop
            // 
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(20, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(760, 20);
            this.pnltop.TabIndex = 1;
            // 
            // pnlcenter
            // 
            this.pnlcenter.Controls.Add(this.pnlButton);
            this.pnlcenter.Controls.Add(this.pnlDatagrid);
            this.pnlcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcenter.Location = new System.Drawing.Point(20, 20);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(760, 410);
            this.pnlcenter.TabIndex = 3;
            // 
            // pnlDatagrid
            // 
            this.pnlDatagrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatagrid.Location = new System.Drawing.Point(120, 0);
            this.pnlDatagrid.Name = "pnlDatagrid";
            this.pnlDatagrid.Size = new System.Drawing.Size(640, 410);
            this.pnlDatagrid.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnModifyUsers);
            this.pnlButton.Controls.Add(this.pnlbtnbuffer);
            this.pnlButton.Controls.Add(this.btnRequests);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(120, 410);
            this.pnlButton.TabIndex = 0;
            // 
            // btnRequests
            // 
            this.btnRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequests.Location = new System.Drawing.Point(0, 0);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(120, 40);
            this.btnRequests.TabIndex = 0;
            this.btnRequests.Text = "&See Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            // 
            // btnModifyUsers
            // 
            this.btnModifyUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyUsers.Location = new System.Drawing.Point(0, 60);
            this.btnModifyUsers.Name = "btnModifyUsers";
            this.btnModifyUsers.Size = new System.Drawing.Size(120, 40);
            this.btnModifyUsers.TabIndex = 1;
            this.btnModifyUsers.Text = "&Modify Users";
            this.btnModifyUsers.UseVisualStyleBackColor = true;
            // 
            // pnlbtnbuffer
            // 
            this.pnlbtnbuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbtnbuffer.Location = new System.Drawing.Point(0, 40);
            this.pnlbtnbuffer.Name = "pnlbtnbuffer";
            this.pnlbtnbuffer.Size = new System.Drawing.Size(120, 20);
            this.pnlbtnbuffer.TabIndex = 2;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlcenter);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.pnlcenter.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlcenter;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlDatagrid;
        private System.Windows.Forms.Button btnModifyUsers;
        private System.Windows.Forms.Panel pnlbtnbuffer;
        private System.Windows.Forms.Button btnRequests;
    }
}