using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreenkinikor_Master_Project.Child_Forms
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }
        private string conStr = "Data Source=.;Initial Catalog=LoginDB;Integrated Security=True";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 87, 51);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogUser();
            this.Close();
        }

        private void LogUser()
        {
            string username = txtUser.Text;
            DateTime requestTimestamp = DateTime.Now;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string getUser = "INSERT INTO ResetPassword (RequestTimestamp, Username) VALUES (@timestamp, @username)"; ;
                using (SqlCommand cmd = new SqlCommand(getUser, con))
                {
                    cmd.Parameters.AddWithValue("@timestamp", requestTimestamp);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Request logged");
        }
    }
}
