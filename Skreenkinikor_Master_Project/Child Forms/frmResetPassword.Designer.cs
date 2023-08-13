namespace Skreenkinikor_Master_Project.Child_Forms
{
    partial class frmResetPassword
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlControlBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pnlUserBuffer = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlBufferU = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserText = new System.Windows.Forms.Label();
            this.pnlControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 21);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Error with Login";
            // 
            // pnlControlBar
            // 
            this.pnlControlBar.BackColor = System.Drawing.Color.White;
            this.pnlControlBar.Controls.Add(this.btnClose);
            this.pnlControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlControlBar.Name = "pnlControlBar";
            this.pnlControlBar.Size = new System.Drawing.Size(294, 22);
            this.pnlControlBar.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(272, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUser.Location = new System.Drawing.Point(50, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(222, 20);
            this.txtUser.TabIndex = 4;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
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
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.Controls.Add(this.pnlBufferU);
            this.pnlUser.Controls.Add(this.iconUser);
            this.pnlUser.Controls.Add(this.pnlUserBuffer);
            this.pnlUser.Location = new System.Drawing.Point(0, 83);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(292, 30);
            this.pnlUser.TabIndex = 11;
            // 
            // pnlBufferU
            // 
            this.pnlBufferU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBufferU.Location = new System.Drawing.Point(50, 0);
            this.pnlBufferU.Name = "pnlBufferU";
            this.pnlBufferU.Size = new System.Drawing.Size(242, 5);
            this.pnlBufferU.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(88, 133);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 36);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "&Send Request";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserText
            // 
            this.lblUserText.AutoSize = true;
            this.lblUserText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserText.ForeColor = System.Drawing.Color.White;
            this.lblUserText.Location = new System.Drawing.Point(12, 62);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(118, 18);
            this.lblUserText.TabIndex = 13;
            this.lblUserText.Text = "Enter Username:";
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(294, 181);
            this.Controls.Add(this.lblUserText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlControlBar);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResetPassword";
            this.pnlControlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlControlBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TextBox txtUser;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Panel pnlUserBuffer;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlBufferU;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserText;
    }
}