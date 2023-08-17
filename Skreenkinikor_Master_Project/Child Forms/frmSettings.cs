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
    public partial class frmSettings : Form
    {
        private Button btnCurrent;
        private SqlDataAdapter adapter;
        private string conStr = "Data Source=.;Initial Catalog=LoginDB;Integrated Security=True";
        private string sqlQuery;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Active(btnRequests);
            sqlQuery = "SELECT * FROM ResetPassword";
            LoadTable(sqlQuery);
        }


        private void btnRequests_Click(object sender, EventArgs e)
        {
            Active(sender);
            sqlQuery = "SELECT * FROM ResetPassword";
            LoadTable(sqlQuery);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Active(sender);
            sqlQuery = "SELECT * FROM Login_Table";
            LoadTable(sqlQuery);
        }

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
        private void Disable()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(232, 241, 242);
                btnCurrent.ForeColor = Color.Black;
            }
        }
        private void LoadTable(string sqlTable)
        {
            using(SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(sqlTable, con))
                {
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgSettings.DataSource = dt;

                    if(dt.Columns.Count == 6)
                    {
                        dgSettings.Columns["Id"].HeaderText = "User";
                        dgSettings.Columns["FirstName"].HeaderText = "Name";
                        dgSettings.Columns["LastName"].HeaderText = "Surname";
                        dgSettings.Columns["IsAdmin"].HeaderText = "Admin";
                    }
                    else if(dt.Columns.Count == 2)
                    {
                        dgSettings.Columns["RequestTimestamp"].HeaderText = "Time of Request";
                    }
                }
                con.Close();
            }
        }
    }
}
