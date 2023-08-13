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

namespace Skreenkinikor_Master_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Variables
        private string conStr = "Data Source=.;Initial Catalog=LoginDB;Integrated Security=True";

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
            btnClose.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(11, 83, 81);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(19, 41, 61); 
        }
        //Initiate login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateLogin(txtUser.Text, txtPass.Text) == true)
            {
                string user = txtUser.Text;
                var openMain = new frmMain();
                openMain.bIsAdmin = checkIfAdmin(user);
                openMain.sUserModel = userModel(user);

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
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string checkDetails = "SELECT * FROM Login_Table WHERE Username = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(checkDetails, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    bool isValid = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

                    return isValid;
                }
            }
        }
        //Check if user is admin
        private bool checkIfAdmin(string user)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string checkAdmin = "SELECT * FROM Login_Table WHERE Username = @user";
                using (SqlCommand cmd = new SqlCommand(checkAdmin, con))
                {
                    cmd.Parameters.AddWithValue("@user", user);

                    object isAdminObj = cmd.ExecuteScalar();

                    if (isAdminObj != null && isAdminObj != DBNull.Value)
                    {
                        int isAdminInt = Convert.ToInt32(isAdminObj);
                        return isAdminInt == 1;
                    }

                    return false;
                }
            }
        }

        private string userModel(string user)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string getUser = "SELECT * FROM Login_Table WHERE Username = @user";
                using (SqlCommand cmd = new SqlCommand(getUser, con))
                {
                    cmd.Parameters.AddWithValue("@user", user);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader.GetString(3);
                            string lastName = reader.GetString(4);
                            return firstName + " " +lastName;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
