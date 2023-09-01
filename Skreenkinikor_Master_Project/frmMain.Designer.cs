namespace Skreenkinikor_Master_Project
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnMovies = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnActors = new FontAwesome.Sharp.IconButton();
            this.btnSchedule = new FontAwesome.Sharp.IconButton();
            this.btnCon_Sale = new FontAwesome.Sharp.IconButton();
            this.btnTicket_Sale = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlFullBar = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUserModel = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.pnlUserBottomBuffer = new System.Windows.Forms.Panel();
            this.pnlUserTopBuffer = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.ipbSelectedIcon = new FontAwesome.Sharp.IconPictureBox();
            this.pnlControlBar = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlEffect = new System.Windows.Forms.Panel();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSelectedIcon)).BeginInit();
            this.pnlControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnMovies);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnActors);
            this.pnlMenu.Controls.Add(this.btnSchedule);
            this.pnlMenu.Controls.Add(this.btnCon_Sale);
            this.pnlMenu.Controls.Add(this.btnTicket_Sale);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 722);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 620);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 560);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReports.Size = new System.Drawing.Size(220, 60);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Generate Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.White;
            this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.VideoCamera;
            this.btnMovies.IconColor = System.Drawing.Color.White;
            this.btnMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovies.IconSize = 32;
            this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.Location = new System.Drawing.Point(0, 500);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMovies.Size = new System.Drawing.Size(220, 60);
            this.btnMovies.TabIndex = 7;
            this.btnMovies.Text = "Manage Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Visible = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnStock.IconColor = System.Drawing.Color.White;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.IconSize = 32;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 440);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStock.Size = new System.Drawing.Size(220, 60);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Manage Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Visible = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnActors
            // 
            this.btnActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActors.FlatAppearance.BorderSize = 0;
            this.btnActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActors.ForeColor = System.Drawing.Color.White;
            this.btnActors.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnActors.IconColor = System.Drawing.Color.White;
            this.btnActors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActors.IconSize = 32;
            this.btnActors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActors.Location = new System.Drawing.Point(0, 380);
            this.btnActors.Name = "btnActors";
            this.btnActors.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnActors.Size = new System.Drawing.Size(220, 60);
            this.btnActors.TabIndex = 5;
            this.btnActors.Text = "Actors";
            this.btnActors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActors.UseVisualStyleBackColor = true;
            this.btnActors.Visible = false;
            this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnSchedule.IconColor = System.Drawing.Color.White;
            this.btnSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSchedule.IconSize = 32;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 320);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSchedule.Size = new System.Drawing.Size(220, 60);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Visible = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnCon_Sale
            // 
            this.btnCon_Sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCon_Sale.FlatAppearance.BorderSize = 0;
            this.btnCon_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon_Sale.ForeColor = System.Drawing.Color.White;
            this.btnCon_Sale.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btnCon_Sale.IconColor = System.Drawing.Color.White;
            this.btnCon_Sale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCon_Sale.IconSize = 32;
            this.btnCon_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon_Sale.Location = new System.Drawing.Point(0, 260);
            this.btnCon_Sale.Name = "btnCon_Sale";
            this.btnCon_Sale.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCon_Sale.Size = new System.Drawing.Size(220, 60);
            this.btnCon_Sale.TabIndex = 3;
            this.btnCon_Sale.Text = "Confectionary Sale";
            this.btnCon_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon_Sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Sale.UseVisualStyleBackColor = true;
            this.btnCon_Sale.Click += new System.EventHandler(this.btnCon_Sale_Click);
            // 
            // btnTicket_Sale
            // 
            this.btnTicket_Sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket_Sale.FlatAppearance.BorderSize = 0;
            this.btnTicket_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket_Sale.ForeColor = System.Drawing.Color.White;
            this.btnTicket_Sale.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnTicket_Sale.IconColor = System.Drawing.Color.White;
            this.btnTicket_Sale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket_Sale.IconSize = 32;
            this.btnTicket_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket_Sale.Location = new System.Drawing.Point(0, 200);
            this.btnTicket_Sale.Name = "btnTicket_Sale";
            this.btnTicket_Sale.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTicket_Sale.Size = new System.Drawing.Size(220, 60);
            this.btnTicket_Sale.TabIndex = 2;
            this.btnTicket_Sale.Text = "Ticket Sale";
            this.btnTicket_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket_Sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket_Sale.UseVisualStyleBackColor = true;
            this.btnTicket_Sale.Click += new System.EventHandler(this.btnTicket_Sale_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pnlFullBar);
            this.pnlLogo.Controls.Add(this.pbxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlFullBar
            // 
            this.pnlFullBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFullBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFullBar.Name = "pnlFullBar";
            this.pnlFullBar.Size = new System.Drawing.Size(220, 22);
            this.pnlFullBar.TabIndex = 1;
            this.pnlFullBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFullBar_MouseDown);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Skreenkinikor_Master_Project.Properties.Resources.SK_Logo;
            this.pbxLogo.Location = new System.Drawing.Point(-27, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(269, 147);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.pnlHeader.Controls.Add(this.pnlUser);
            this.pnlHeader.Controls.Add(this.lblSelected);
            this.pnlHeader.Controls.Add(this.ipbSelectedIcon);
            this.pnlHeader.Controls.Add(this.pnlControlBar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(686, 70);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUserModel);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.pnlUserBottomBuffer);
            this.pnlUser.Controls.Add(this.pnlUserTopBuffer);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUser.Location = new System.Drawing.Point(288, 22);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(398, 48);
            this.pnlUser.TabIndex = 6;
            // 
            // lblUserModel
            // 
            this.lblUserModel.AutoSize = true;
            this.lblUserModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserModel.ForeColor = System.Drawing.Color.White;
            this.lblUserModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserModel.Location = new System.Drawing.Point(311, 15);
            this.lblUserModel.Name = "lblUserModel";
            this.lblUserModel.Size = new System.Drawing.Size(65, 16);
            this.lblUserModel.TabIndex = 0;
            this.lblUserModel.Text = "Welcome";
            this.lblUserModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 16;
            this.btnLogout.Location = new System.Drawing.Point(376, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(22, 18);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // pnlUserBottomBuffer
            // 
            this.pnlUserBottomBuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.pnlUserBottomBuffer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserBottomBuffer.Location = new System.Drawing.Point(0, 33);
            this.pnlUserBottomBuffer.Name = "pnlUserBottomBuffer";
            this.pnlUserBottomBuffer.Size = new System.Drawing.Size(398, 15);
            this.pnlUserBottomBuffer.TabIndex = 1;
            // 
            // pnlUserTopBuffer
            // 
            this.pnlUserTopBuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserTopBuffer.Location = new System.Drawing.Point(0, 0);
            this.pnlUserTopBuffer.Name = "pnlUserTopBuffer";
            this.pnlUserTopBuffer.Size = new System.Drawing.Size(398, 15);
            this.pnlUserTopBuffer.TabIndex = 0;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(39, 38);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(39, 13);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "Home";
            // 
            // ipbSelectedIcon
            // 
            this.ipbSelectedIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.ipbSelectedIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.ipbSelectedIcon.IconColor = System.Drawing.Color.White;
            this.ipbSelectedIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbSelectedIcon.Location = new System.Drawing.Point(6, 29);
            this.ipbSelectedIcon.Name = "ipbSelectedIcon";
            this.ipbSelectedIcon.Size = new System.Drawing.Size(32, 32);
            this.ipbSelectedIcon.TabIndex = 0;
            this.ipbSelectedIcon.TabStop = false;
            // 
            // pnlControlBar
            // 
            this.pnlControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.pnlControlBar.Controls.Add(this.btnMin);
            this.pnlControlBar.Controls.Add(this.btnMax);
            this.pnlControlBar.Controls.Add(this.btnClose);
            this.pnlControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlControlBar.Name = "pnlControlBar";
            this.pnlControlBar.Size = new System.Drawing.Size(686, 22);
            this.pnlControlBar.TabIndex = 5;
            this.pnlControlBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControlBar_Paint);
            this.pnlControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMin.IconSize = 16;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(620, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMax.IconSize = 14;
            this.btnMax.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMax.Location = new System.Drawing.Point(642, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 22);
            this.btnMax.TabIndex = 3;
            this.btnMax.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            this.btnMax.MouseEnter += new System.EventHandler(this.btnMax_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(664, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // pnlEffect
            // 
            this.pnlEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.pnlEffect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEffect.Location = new System.Drawing.Point(220, 70);
            this.pnlEffect.Name = "pnlEffect";
            this.pnlEffect.Size = new System.Drawing.Size(686, 8);
            this.pnlEffect.TabIndex = 2;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMainContainer.Location = new System.Drawing.Point(220, 78);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(686, 644);
            this.pnlMainContainer.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 722);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlEffect);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSelectedIcon)).EndInit();
            this.pnlControlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnMovies;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnActors;
        private FontAwesome.Sharp.IconButton btnSchedule;
        private FontAwesome.Sharp.IconButton btnCon_Sale;
        private FontAwesome.Sharp.IconButton btnTicket_Sale;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconPictureBox ipbSelectedIcon;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Panel pnlEffect;
        private System.Windows.Forms.Panel pnlMainContainer;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlFullBar;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUserModel;
        private System.Windows.Forms.Panel pnlUserBottomBuffer;
        private System.Windows.Forms.Panel pnlUserTopBuffer;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel pnlControlBar;
    }
}

