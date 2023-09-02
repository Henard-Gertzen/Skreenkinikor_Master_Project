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
    public partial class frmSettings_AddUser : Form
    {
        //Variables
        private string conString = ConnectionStrings.conLoginStr;
        private SqlConnection conn;
        private SqlCommand cmd;
        public frmSettings_AddUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Methods
        public bool Required(TextBox txt)
        {
            return !string.IsNullOrWhiteSpace(txt.Text);
        }
        public void validationCheck()
        {
            if (Required(txtUser) == false)
            {
                txtUser.BackColor = Color.FromArgb(255, 190, 170);
                lblRequired.Visible = true;
            }
            else if (Required(txtPass) == false)
            {
                txtPass.BackColor = Color.FromArgb(255, 190, 170);
                lblRequired.Visible = true;
            }
            else if (Required(txtName) == false)
            {
                txtName.BackColor = Color.FromArgb(255, 190, 170);
                lblRequired.Visible = true;
            }
            else if (Required(txtSurname) == false)
            {
                txtSurname.BackColor = Color.FromArgb(255, 190, 170);
                lblRequired.Visible = true;
            }
            else
            {
                if (checkIfUserExists(txtUser.Text))
                {
                    MessageBox.Show("Username is taken!", "Error.UserTaken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.BackColor = Color.FromArgb(255, 190, 170);
                    return;
                }
                DialogResult dialog = MessageBox.Show("You are about to add a new user named "
                                                        + txtName.Text + " " + txtSurname.Text + " do you wish to continue?",
                                                        "New User",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning,
                                                        MessageBoxDefaultButton.Button2
                                                        );
               if(dialog == DialogResult.Yes)
               {
                    addNewUser();
                    MessageBox.Show("New User " + txtName.Text + " " + txtSurname.Text + " has been added!");
                    this.Close();
               }
               else if (dialog == DialogResult.No)
               {
                    //Nothing happens
               }

            }
        }

        private bool checkIfUserExists(string user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Login_Table WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
            }
        }

        private void addNewUser()
        {
            try
            {
                string add = "INSERT INTO Login_Table(Username, Password, FirstName, LastName, IsAdmin) VALUES (@Username, @Password, @FirstName, @LastName, @IsAdmin)";
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand(add, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@IsAdmin", cbxAdmin.Checked);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 87, 51);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            txtPass.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            validationCheck();
        }

        //Don't touch
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
