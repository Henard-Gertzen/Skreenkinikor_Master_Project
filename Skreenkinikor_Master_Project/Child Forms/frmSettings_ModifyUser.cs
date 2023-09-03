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
using System.Data.Sql;
using System.Data.SqlClient;
using Skreenkinikor_Master_Project.Classes;

namespace Skreenkinikor_Master_Project.Child_Forms
{
    public partial class frmSettings_ModifyUser : Form
    {
        public string modifyUsername, modifyName, modifySurname, modifyPassword;
        public bool modifyAdmin;
        private string conString = ConnectionStrings.conLoginStr;
        private SqlConnection conn;
        private SqlCommand cmd;

        public frmSettings_ModifyUser()
        {
            InitializeComponent();
        }
        //Methods
        private String changeUser()
        {
            try
            {
                string update = "UPDATE Login_Table SET Username = @Username, Password = @Password, IsAdmin = @IsAdmin WHERE FirstName = @FirstName";
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(update, conn))
                    {
                        if (txtChangeUser.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@Username", txtChangeUser.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Username", modifyUsername);
                        }
                        if (txtChangePassword.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@Password", txtChangePassword.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Password", modifyPassword);
                        }
                        if (cbxChangeAdmin.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@IsAdmin", true);
                        }
                        else if (cbxChangeAdmin.Checked == false)
                        {
                            cmd.Parameters.AddWithValue("@IsAdmin", false);
                        }
                        cmd.Parameters.AddWithValue("@FirstName", modifyName);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            conn.Close();
                            return "Changes have been applied successfully";
                        }
                        else
                        {
                            conn.Close();
                            return "User could not be found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
                return "Error!";
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            cbxCurrentAdmin.Enabled = false;   
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(changeUser());
            this.Close();
        }

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            lblCurrent.Text = "Currently Editing User: " + modifyName + " " + modifySurname;
            lblUsername.Text = "Current Username: " + modifyUsername;
            lblPassword.Text = "Current Password: " + modifyPassword;
            cbxCurrentAdmin.Checked = modifyAdmin;
            cbxChangeAdmin.Checked = modifyAdmin;
            if(modifyName == "Admin")
            {
                ipbDisable.Visible = true;
                cbxChangeAdmin.Enabled = false;
            }
        }
    }
}
