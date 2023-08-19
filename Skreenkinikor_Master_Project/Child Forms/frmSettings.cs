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

namespace Skreenkinikor_Master_Project
{
    public partial class frmSettings : Form
    {
        private Button btnCurrent;
        private SqlDataAdapter adapter;
        private frmMain mainInstance;
        public string firstName;
        private string conStr = "Data Source=.;Initial Catalog=LoginDB;Integrated Security=True";
        private string sqlReset = "SELECT * FROM ResetPassword";
        private string sqlLogin = "SELECT Username, Password, FirstName, LastName, IsAdmin FROM Login_Table";
        public frmSettings(frmMain mainForm)
        {
            InitializeComponent();
            mainInstance = mainForm;
        }
        //Methods
        private void Active(object activeButton)
        {
            if (activeButton != null)
            {
                Disable();
                btnCurrent = (Button)activeButton;
                btnCurrent.BackColor = Color.FromArgb(0, 100, 148);
                btnCurrent.ForeColor = Color.White;
            }
        }
        private void search(string sqlSearch)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlSearch, con))
                {
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgSettings.DataSource = dt;

                    if (dt.Columns.Count == 6)
                    {
                        dgSettings.Columns["FirstName"].HeaderText = "Name";
                        dgSettings.Columns["LastName"].HeaderText = "Surname";
                        dgSettings.Columns["IsAdmin"].HeaderText = "Admin";
                    }
                    else if (dt.Columns.Count == 2)
                    {
                        dgSettings.Columns["RequestTimestamp"].HeaderText = "Time of Request";
                    }
                }
                con.Close();
            }
        }
        private void Disable()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(19, 41, 61);
                btnCurrent.ForeColor = Color.White;
                btnCurrent.FlatAppearance.BorderColor = Color.White;
            }
        }
        public void LoadTable(string sqlTable)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlTable, con))
                {
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgSettings.DataSource = dt;

                    if (dt.Columns.Count == 5)
                    {
                        dgSettings.Columns["FirstName"].HeaderText = "Name";
                        dgSettings.Columns["LastName"].HeaderText = "Surname";
                        dgSettings.Columns["IsAdmin"].HeaderText = "Admin";
                    }
                    else if (dt.Columns.Count == 2)
                    {
                        dgSettings.Columns["RequestTimestamp"].HeaderText = "Time of Request";
                    }
                }
                con.Close();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Active(btnRequests);
            LoadTable(sqlReset);
            lblMainCotentTitle.Text = "View Requests";
            btnManaged.Visible = true;
            btnManage2.Visible = false;
            txtSearchRequest.Visible = true;
            txtSearchUsers.Visible = false;
        }


        private void btnRequests_Click(object sender, EventArgs e)
        {
            Active(sender);
            LoadTable(sqlReset);
            lblMainCotentTitle.Text = "View Requests";
            btnManaged.Visible = true;
            btnManage2.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            btnRefresh.Visible = false;
            txtSearchRequest.Visible = true;
            txtSearchUsers.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Active(sender);
            LoadTable(sqlLogin);
            lblMainCotentTitle.Text = "Modify Users";
            btnManaged.Visible = false;
            btnManage2.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = true;
            btnRefresh.Visible = true;
            txtSearchRequest.Visible = false;
            txtSearchUsers.Visible = true;
        }


        private void dgSettings_SelectionChanged(object sender, EventArgs e)
        {
            if(dgSettings.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in dgSettings.SelectedRows)
                {
                    row.Selected = false;
                }
            }
        }

        private void deleteRequest(string sqlQuery)
        {
            if (dgSettings.SelectedRows.Count != 0)
            {
               
                    DateTime pk = (DateTime)dgSettings.SelectedRows[0].Cells["RequestTimestamp"].Value;
                    string deleteCmd = "DELETE FROM ResetPassword WHERE RequestTimestamp = @RequestTimestamp";
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteCmd, con))
                        {
                            cmd.Parameters.AddWithValue("@RequestTimestamp", pk);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    LoadTable(sqlQuery);
            }
            else
            {
                MessageBox.Show("No Row Selected", "Error.NoSelection");
            }
        }

        private void deleteUser(string sqlQuery)
        {
            string checkAdmin = dgSettings.SelectedRows[0].Cells["FirstName"].Value.ToString();
            if (checkAdmin.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                    MessageBox.Show("Admin account cannot be deleted.", "Error.AdminDeletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
            }
            string user = dgSettings.SelectedRows[0].Cells["Username"].Value.ToString();
            string deleteCmd = "DELETE FROM Login_Table WHERE Username = @Username";
            //Check if user is logged in
            firstName = UserSession.FullName;
            if(firstName == dgSettings.SelectedRows[0].Cells["FirstName"].Value.ToString())
            {
                DialogResult warn = MessageBox.Show("Are you sure you want to proceed, deleting your own account will terminate your session", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(warn == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteCmd, con))
                        {
                            cmd.Parameters.AddWithValue("@Username", user);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    mainInstance.Close();
                    var login = new frmLogin();
                    this.Close();
                    login.Show();
                }
                else if(warn == DialogResult.No)
                {
                    //nothing happens
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteCmd, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", user);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                LoadTable(sqlQuery);
            }
            
        }

        private void btnManaged_MouseEnter(object sender, EventArgs e)
        {
            btnManaged.BackColor = Color.FromArgb(0, 169, 165);
        }

        private void btnManaged_MouseLeave(object sender, EventArgs e)
        {
            btnManaged.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnManaged_Click(object sender, EventArgs e)
        {
            deleteRequest(sqlReset);
        }

        private void btnManage2_MouseEnter(object sender, EventArgs e)
        {
            btnManage2.BackColor = Color.FromArgb(0, 169, 165);
        }

        private void btnManage2_MouseLeave(object sender, EventArgs e)
        {
            btnManage2.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnManage2_Click(object sender, EventArgs e)
        {
            var modify = new frmModifyUser();
            modify.modifyUsername = dgSettings.SelectedRows[0].Cells["Username"].Value.ToString();
            modify.modifyName = dgSettings.SelectedRows[0].Cells["FirstName"].Value.ToString();
            modify.modifySurname = dgSettings.SelectedRows[0].Cells["LastName"].Value.ToString();
            modify.modifyPassword = dgSettings.SelectedRows[0].Cells["Password"].Value.ToString();
            modify.modifyAdmin = Convert.ToBoolean(dgSettings.SelectedRows[0].Cells["IsAdmin"].Value);
            modify.FormClosed += Modify_FormClosed;
            modify.ShowDialog();
        }

        private void Modify_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable(sqlLogin);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(255, 87, 51);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUser(sqlLogin);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addNew = new frmAddUser();
            addNew.ShowDialog();
            addNew.FormClosed += addNew_FormClosed;
        }

        private void addNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable(sqlLogin);
        }

        private void txtSearchRequests_TextChanged(object sender, EventArgs e)
        {
            string searchRequest = "SELECT * FROM ResetPassword WHERE RequestTimestamp LIKE '%" + txtSearchRequest.Text + "%' OR Username LIKE '%" + txtSearchRequest.Text + "%'";
            search(searchRequest);
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            string searchUser = "SELECT Username, Password, FirstName, LastName, IsAdmin FROM Login_Table WHERE Username LIKE '%" + txtSearchUsers.Text + "%'" +
                                   "OR Password LIKE '%" + txtSearchUsers.Text + "%'" +
                                   "OR FirstName LIKE '%" + txtSearchUsers.Text + "%'" +
                                   "OR LastName LIKE '%" + txtSearchUsers.Text + "%'";
            search(searchUser);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(27, 152, 224);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTable(sqlLogin);
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(144, 194, 231);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(19, 41, 61);
        }
    }
}
