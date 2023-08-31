namespace Skreenkinikor_Master_Project.Child_Forms
{
    partial class frmSettings_ModifyUser
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
            this.pnlControlBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtChangeUser = new System.Windows.Forms.TextBox();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.cbxChangeAdmin = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlCurrent = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.cbxCurrentAdmin = new System.Windows.Forms.CheckBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ipbDisable = new FontAwesome.Sharp.IconPictureBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblChangeUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBorderLeft = new System.Windows.Forms.Panel();
            this.lblChangeAdmin = new System.Windows.Forms.Label();
            this.pnlBorderRight = new System.Windows.Forms.Panel();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.ttDisable = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSufferTop = new System.Windows.Forms.Panel();
            this.pnlControlBar.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlCurrent.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbDisable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlBar
            // 
            this.pnlControlBar.BackColor = System.Drawing.Color.White;
            this.pnlControlBar.Controls.Add(this.btnClose);
            this.pnlControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlControlBar.Name = "pnlControlBar";
            this.pnlControlBar.Size = new System.Drawing.Size(340, 22);
            this.pnlControlBar.TabIndex = 11;
            this.pnlControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(318, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // txtChangeUser
            // 
            this.txtChangeUser.Location = new System.Drawing.Point(185, 13);
            this.txtChangeUser.Name = "txtChangeUser";
            this.txtChangeUser.Size = new System.Drawing.Size(100, 20);
            this.txtChangeUser.TabIndex = 12;
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Location = new System.Drawing.Point(185, 39);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(100, 20);
            this.txtChangePassword.TabIndex = 13;
            // 
            // cbxChangeAdmin
            // 
            this.cbxChangeAdmin.AutoSize = true;
            this.cbxChangeAdmin.ForeColor = System.Drawing.Color.White;
            this.cbxChangeAdmin.Location = new System.Drawing.Point(185, 65);
            this.cbxChangeAdmin.Name = "cbxChangeAdmin";
            this.cbxChangeAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbxChangeAdmin.TabIndex = 14;
            this.cbxChangeAdmin.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(93, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Modify User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 22);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(340, 38);
            this.pnlTitle.TabIndex = 16;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(19, 5);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(111, 13);
            this.lblCurrent.TabIndex = 17;
            this.lblCurrent.Text = "Currently Editing User:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(19, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 13);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Current Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(19, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 13);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Current Password:";
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlCurrent.Controls.Add(this.pnlSufferTop);
            this.pnlCurrent.Controls.Add(this.lblAdmin);
            this.pnlCurrent.Controls.Add(this.cbxCurrentAdmin);
            this.pnlCurrent.Controls.Add(this.lblCurrent);
            this.pnlCurrent.Controls.Add(this.lblPassword);
            this.pnlCurrent.Controls.Add(this.lblUsername);
            this.pnlCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrent.Location = new System.Drawing.Point(0, 60);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(340, 94);
            this.pnlCurrent.TabIndex = 20;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(39, 68);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(130, 13);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "Is Current User an Admin?";
            // 
            // cbxCurrentAdmin
            // 
            this.cbxCurrentAdmin.AutoSize = true;
            this.cbxCurrentAdmin.Checked = true;
            this.cbxCurrentAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCurrentAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbxCurrentAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbxCurrentAdmin.ForeColor = System.Drawing.Color.White;
            this.cbxCurrentAdmin.Location = new System.Drawing.Point(22, 68);
            this.cbxCurrentAdmin.Name = "cbxCurrentAdmin";
            this.cbxCurrentAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbxCurrentAdmin.TabIndex = 15;
            this.cbxCurrentAdmin.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.ipbDisable);
            this.pnlContent.Controls.Add(this.btnChange);
            this.pnlContent.Controls.Add(this.lblChangeUser);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.pnlBorderLeft);
            this.pnlContent.Controls.Add(this.txtChangeUser);
            this.pnlContent.Controls.Add(this.lblChangeAdmin);
            this.pnlContent.Controls.Add(this.pnlBorderRight);
            this.pnlContent.Controls.Add(this.cbxChangeAdmin);
            this.pnlContent.Controls.Add(this.txtChangePassword);
            this.pnlContent.Controls.Add(this.lblChangePass);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 154);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(340, 156);
            this.pnlContent.TabIndex = 21;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ipbDisable
            // 
            this.ipbDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.ipbDisable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.ipbDisable.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ipbDisable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.ipbDisable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbDisable.IconSize = 19;
            this.ipbDisable.Location = new System.Drawing.Point(198, 63);
            this.ipbDisable.Name = "ipbDisable";
            this.ipbDisable.Size = new System.Drawing.Size(19, 19);
            this.ipbDisable.TabIndex = 25;
            this.ipbDisable.TabStop = false;
            this.ttDisable.SetToolTip(this.ipbDisable, "The Admin Account\'s Admin Status cannot be changed!");
            this.ipbDisable.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(118, 91);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 40);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "&Change Info";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblChangeUser
            // 
            this.lblChangeUser.AutoSize = true;
            this.lblChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUser.ForeColor = System.Drawing.Color.White;
            this.lblChangeUser.Location = new System.Drawing.Point(68, 16);
            this.lblChangeUser.Name = "lblChangeUser";
            this.lblChangeUser.Size = new System.Drawing.Size(101, 13);
            this.lblChangeUser.TabIndex = 21;
            this.lblChangeUser.Text = "Change Username: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(15, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 15);
            this.panel1.TabIndex = 23;
            // 
            // pnlBorderLeft
            // 
            this.pnlBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderLeft.Name = "pnlBorderLeft";
            this.pnlBorderLeft.Size = new System.Drawing.Size(15, 156);
            this.pnlBorderLeft.TabIndex = 23;
            // 
            // lblChangeAdmin
            // 
            this.lblChangeAdmin.AutoSize = true;
            this.lblChangeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeAdmin.ForeColor = System.Drawing.Color.White;
            this.lblChangeAdmin.Location = new System.Drawing.Point(67, 66);
            this.lblChangeAdmin.Name = "lblChangeAdmin";
            this.lblChangeAdmin.Size = new System.Drawing.Size(117, 13);
            this.lblChangeAdmin.TabIndex = 21;
            this.lblChangeAdmin.Text = "Change Admin Access:";
            // 
            // pnlBorderRight
            // 
            this.pnlBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBorderRight.Location = new System.Drawing.Point(325, 0);
            this.pnlBorderRight.Name = "pnlBorderRight";
            this.pnlBorderRight.Size = new System.Drawing.Size(15, 156);
            this.pnlBorderRight.TabIndex = 22;
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.ForeColor = System.Drawing.Color.White;
            this.lblChangePass.Location = new System.Drawing.Point(68, 42);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(99, 13);
            this.lblChangePass.TabIndex = 21;
            this.lblChangePass.Text = "Change Password: ";
            // 
            // ttDisable
            // 
            this.ttDisable.AutoPopDelay = 5000;
            this.ttDisable.InitialDelay = 120;
            this.ttDisable.IsBalloon = true;
            this.ttDisable.ReshowDelay = 100;
            // 
            // pnlSufferTop
            // 
            this.pnlSufferTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlSufferTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSufferTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSufferTop.Name = "pnlSufferTop";
            this.pnlSufferTop.Size = new System.Drawing.Size(15, 94);
            this.pnlSufferTop.TabIndex = 24;
            // 
            // frmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(340, 310);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCurrent);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyUser";
            this.Load += new System.EventHandler(this.frmModifyUser_Load);
            this.pnlControlBar.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlCurrent.ResumeLayout(false);
            this.pnlCurrent.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbDisable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlControlBar;
        private System.Windows.Forms.TextBox txtChangeUser;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.CheckBox cbxChangeAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlCurrent;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.CheckBox cbxCurrentAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblChangeUser;
        private System.Windows.Forms.Panel pnlBorderLeft;
        private System.Windows.Forms.Panel pnlBorderRight;
        private System.Windows.Forms.Label lblChangeAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChange;
        private FontAwesome.Sharp.IconPictureBox ipbDisable;
        private System.Windows.Forms.ToolTip ttDisable;
        private System.Windows.Forms.Panel pnlSufferTop;
    }
}