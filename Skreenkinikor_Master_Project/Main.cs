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
        //Fields
        private IconButton btnCurrent;
        private Panel pnlLeft;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            pnlLeft = new Panel();
            pnlLeft.Size = new Size(9, 60);
            pnlMenu.Controls.Add(pnlLeft);
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
                lblSelected.Text = btnCurrent.Text;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnTicket_Sale_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnCon_Sale_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnActors_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Active(sender, Colors.foregroundColor1);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Active(btnHome, Colors.foregroundColor1);
            ipbSelectedIcon.IconChar = IconChar.HomeLg;
            lblSelected.Text = "Home";
        }
        //Don't touch this, this adds drag functionality to the header panel
        //Explanation: Uses native libaries of the OS to move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
