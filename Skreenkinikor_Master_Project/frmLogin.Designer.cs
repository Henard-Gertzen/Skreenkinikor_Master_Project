﻿namespace Skreenkinikor_Master_Project
{
    partial class frmLogin
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlBufferP = new System.Windows.Forms.Panel();
            this.iconPass = new FontAwesome.Sharp.IconPictureBox();
            this.pnlPassBuffer = new System.Windows.Forms.Panel();
            this.pnlBuffer = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlBufferU = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pnlUserBuffer = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::Skreenkinikor_Master_Project.Properties.Resources.SK_Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(292, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 180);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Padding = new System.Windows.Forms.Padding(33, 0, 21, 30);
            this.lblLogin.Size = new System.Drawing.Size(289, 74);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Welcome to Skreenkinikor\r\nPlease Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlPass);
            this.pnlContent.Controls.Add(this.pnlBuffer);
            this.pnlContent.Controls.Add(this.pnlUser);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 254);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(292, 94);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlPass
            // 
            this.pnlPass.Controls.Add(this.txtPass);
            this.pnlPass.Controls.Add(this.pnlBufferP);
            this.pnlPass.Controls.Add(this.iconPass);
            this.pnlPass.Controls.Add(this.pnlPassBuffer);
            this.pnlPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPass.Location = new System.Drawing.Point(0, 60);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(292, 30);
            this.pnlPass.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPass.Location = new System.Drawing.Point(50, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pnlBufferP
            // 
            this.pnlBufferP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBufferP.Location = new System.Drawing.Point(50, 0);
            this.pnlBufferP.Name = "pnlBufferP";
            this.pnlBufferP.Size = new System.Drawing.Size(242, 5);
            this.pnlBufferP.TabIndex = 4;
            // 
            // iconPass
            // 
            this.iconPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPass.IconColor = System.Drawing.Color.White;
            this.iconPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPass.IconSize = 30;
            this.iconPass.Location = new System.Drawing.Point(20, 0);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(30, 30);
            this.iconPass.TabIndex = 0;
            this.iconPass.TabStop = false;
            // 
            // pnlPassBuffer
            // 
            this.pnlPassBuffer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPassBuffer.Location = new System.Drawing.Point(0, 0);
            this.pnlPassBuffer.Name = "pnlPassBuffer";
            this.pnlPassBuffer.Size = new System.Drawing.Size(20, 30);
            this.pnlPassBuffer.TabIndex = 4;
            // 
            // pnlBuffer
            // 
            this.pnlBuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuffer.Location = new System.Drawing.Point(0, 30);
            this.pnlBuffer.Name = "pnlBuffer";
            this.pnlBuffer.Size = new System.Drawing.Size(292, 30);
            this.pnlBuffer.TabIndex = 1;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.Controls.Add(this.pnlBufferU);
            this.pnlUser.Controls.Add(this.iconUser);
            this.pnlUser.Controls.Add(this.pnlUserBuffer);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(292, 30);
            this.pnlUser.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUser.Location = new System.Drawing.Point(50, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(222, 20);
            this.txtUser.TabIndex = 4;
            // 
            // pnlBufferU
            // 
            this.pnlBufferU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBufferU.Location = new System.Drawing.Point(50, 0);
            this.pnlBufferU.Name = "pnlBufferU";
            this.pnlBufferU.Size = new System.Drawing.Size(242, 5);
            this.pnlBufferU.TabIndex = 5;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.White;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconUser.IconSize = 30;
            this.iconUser.Location = new System.Drawing.Point(20, 0);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(30, 30);
            this.iconUser.TabIndex = 0;
            this.iconUser.TabStop = false;
            // 
            // pnlUserBuffer
            // 
            this.pnlUserBuffer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserBuffer.Location = new System.Drawing.Point(0, 0);
            this.pnlUserBuffer.Name = "pnlUserBuffer";
            this.pnlUserBuffer.Size = new System.Drawing.Size(20, 30);
            this.pnlUserBuffer.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(63, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 58);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.lblError.Location = new System.Drawing.Point(1, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(178, 15);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "*Username/Password Incorrect!";
            this.lblError.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMin.IconSize = 16;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(248, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.TabIndex = 7;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(270, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlPass;
        private FontAwesome.Sharp.IconPictureBox iconPass;
        private System.Windows.Forms.Panel pnlBuffer;
        private System.Windows.Forms.Panel pnlUser;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlBufferP;
        private System.Windows.Forms.Panel pnlPassBuffer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlBufferU;
        private System.Windows.Forms.Panel pnlUserBuffer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}