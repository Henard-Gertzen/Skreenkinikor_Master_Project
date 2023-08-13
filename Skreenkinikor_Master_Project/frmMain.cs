using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Skreenkinikor_Master_Project
{
    public partial class frmMain : Form
    {
        //Variables
        private IconButton btnCurrent;
        private Panel pnlLeft;
        private Form childCurrent;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            pnlLeft = new Panel();
            pnlLeft.Size = new Size(9, 60);
            pnlMenu.Controls.Add(pnlLeft);
            //Remove title bar
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Color Structure
        private struct Colors
        {
            public static Color primaryBackColor1 = Color.FromArgb(9, 35, 39);
            public static Color primaryBackColor2 = Color.FromArgb(19, 41, 61);

            public static Color secondaryBackColor1 = Color.FromArgb(36, 92, 160);
            public static Color secondaryBackColor2 = Color.FromArgb(31, 67, 100);

            public static Color winBorderColor1 = Color.FromArgb(0, 100, 148);
            public static Color winBorderColor2 = Color.FromArgb(36, 123, 160);
            public static Color windBorderColor3 = Color.FromArgb(27, 152, 224);

            public static Color foregroundColor1 = Color.FromArgb(144, 194, 231);
            public static Color foregroundColor2 = Color.FromArgb(255, 87, 51);
            public static Color foregroundColor3 = Color.FromArgb(11, 83, 81);
        }
        //Methods
        private void Active(object sendedButton, Color color)
        {
            if(sendedButton != null)
            {
                DisableButton();
                //Button Modifyer if selected
                btnCurrent = (IconButton)sendedButton;
                btnCurrent.BackColor = Color.FromArgb(9, 35, 39);
                btnCurrent.ForeColor = color;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = color;
                btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                //Border
                pnlLeft.BackColor = color;
                pnlLeft.Location = new Point(0,btnCurrent.Location.Y);
                pnlLeft.Visible = true;
                pnlLeft.BringToFront();
                //Selected Child form
                ipbSelectedIcon.IconChar = btnCurrent.IconChar;
            }
        }

        private void DisableButton()
        {
            if(btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(31, 67, 100);
                btnCurrent.ForeColor = Color.White;
                btnCurrent.TextAlign = ContentAlignment.MiddleLeft;
                btnCurrent.IconColor = Color.White;
                btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChild(Form child)
        {
            if(childCurrent != null)
            {
                childCurrent.Close();
            }
            childCurrent = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlMainContainer.Controls.Add(child);
            pnlMainContainer.Tag = child;
            //Brings child form to active front and shows.
            child.BringToFront();
            child.Show();
            //Changes header text
            lblSelected.Text = btnCurrent.Text;
        }
        //Button Click events
        private void btnHome_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmHome());
        }

        private void btnTicket_Sale_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmTicket_Sale());
        }

        private void btnCon_Sale_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmSchedule());
        }

        private void btnActors_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmActors());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmStock());
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmMovies());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmReports());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
            OpenChild(new frmSettings());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Active(btnHome, Colors.foregroundColor1);
            ipbSelectedIcon.IconChar = IconChar.HomeLg;
            lblSelected.Text = "Home";
            OpenChild(new frmHome());
        }
        //Don't touch this, this adds drag functionality to the header panel
        //Explanation: Uses native libaries of the OS to move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlFullBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Colors.foregroundColor2;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Colors.secondaryBackColor2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMax.ImageAlign = ContentAlignment.TopCenter;
                btnMax.IconSize = 12;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMax.ImageAlign = ContentAlignment.TopCenter;
                btnMax.IconSize = 14;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Minimized)
            {
                WindowState=FormWindowState.Minimized;
            }
        }

        private void btnMax_MouseEnter(object sender, EventArgs e)
        {
            btnMax.BackColor = Colors.foregroundColor3;
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackColor = Colors.secondaryBackColor2;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Colors.foregroundColor3;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Colors.secondaryBackColor2;
        }

    }
}
