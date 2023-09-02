using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Skreenkinikor_Master_Project.Child_Forms;
using Skreenkinikor_Master_Project.Classes;
using System.Runtime.InteropServices;

namespace Skreenkinikor_Master_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Variables
        private string conStr = ConnectionStrings.conLoginStr;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 87, 51);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(0, 100, 148);
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(0, 100, 148); 
        }
        //Initiate login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateLogin(txtUser.Text, txtPass.Text) == true)
            {
                string user = txtUser.Text;
                var openMain = new frmMain();
                Console.WriteLine("Check Admin Login : " + checkIfAdmin(user));
                openMain.bIsAdmin = checkIfAdmin(user);
                openMain.sUserModel = userModel(user);
                UserSession.Initialize(txtUser.Text, txtPass.Text);
                openMain.Show();
                this.Hide();
            }
            else if(ValidateLogin(txtPass.Text, txtUser.Text) == false)
            {
                lblError.Visible = true;
                txtPass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
        }
        //Validate password and user
        private bool ValidateLogin(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string checkDetails = "SELECT * FROM Login_Table WHERE Username = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(checkDetails, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        bool isValid = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                        con.Close();
                        return isValid;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
                return false;
            }
        }
        //Check if user is admin
        private bool checkIfAdmin(string user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string checkAdmin = "SELECT IsAdmin FROM Login_Table WHERE Username = @user"; ;
                    using (SqlCommand cmd = new SqlCommand(checkAdmin, con))
                    {
                        cmd.Parameters.AddWithValue("@user", user);

                        object isAdminObj = cmd.ExecuteScalar();

                        if (isAdminObj != null && isAdminObj != DBNull.Value)
                        {
                            bool isAdmin = Convert.ToBoolean(isAdminObj);
                            return isAdmin;
                        }

                        con.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
                return false;
            }
        }

        private string userModel(string user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string getUser = "SELECT * FROM Login_Table WHERE Username = @user";
                    using (SqlCommand cmd = new SqlCommand(getUser, con))
                    {
                        cmd.Parameters.AddWithValue("@user", user);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader.GetString(3);
                                UserSession.logFullName(firstName);
                                string lastName = reader.GetString(4);
                                return firstName + " " + lastName;
                            }
                        }
                    }
                    con.Close();
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
                return String.Empty;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var request = new frmResetPassword();
            this.Hide();
            request.ShowDialog();
        }
        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        //Don't touch
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
