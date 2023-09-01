using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreenkinikor_Master_Project
{
    public partial class frmCon_Sale : Form
    {
        public frmCon_Sale()
        {
            InitializeComponent();
        }

        private string connectionString = ConnectionStrings.conSkreenMainStr;
        private string item;
        private int amount;

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCon_Sale_Load(object sender, EventArgs e)
        {
            // loads the the confectionary items into the datagrid when the form loads

            lblAmount.Visible = false;
            nudAmount.Visible = false;
            btnAdd.Visible = false;
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                   
                    string sql = "SELECT Confectionary_Name, Confectionary_Price FROM Confectionary_Item Where Confectionary_Stock > 0";
                    using (SqlCommand command = new SqlCommand(sql,conn))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            using (DataSet ds = new DataSet())
                            {


                                dataAdapter.SelectCommand = command;
                                dataAdapter.Fill(ds, "Confectionary_Item");

                               

                                dgvConItems.DataSource = ds;
                                dgvConItems.DataMember = "Confectionary_Item";

                                dgvConItems.Columns["Confectionary_Name"].HeaderText = "Item";
                                dgvConItems.Columns["Confectionary_Price"].HeaderText = "Price";
                            }
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
                
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            amount = (int)nudAmount.Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            
            btnAdd.Visible = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            // the text in the textbox filters the datagrid according to what is typed
                            // The collation allows for case-insensitivity in the sql query.
                            string sql = "SELECT Confectionary_Name, Confectionary_Price FROM Confectionary_Item Where Confectionary_Stock > 0 AND Confectionary_Name COLLATE Latin1_General_CI_AS LIKE '%" + txtSearch.Text + "%'";

                            using (SqlCommand command = new SqlCommand(sql,conn))
                            {
                                dataAdapter.SelectCommand= command;
                                dataAdapter.Fill(ds, "Confectionary_Item");

                                dgvConItems.DataSource= ds;
                                dgvConItems.DataMember = "Confectionary_Item";
                            }
                        }
                    }
                }
                catch(SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void dgvConItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            // the name of the item clicked is saved into the item variable

            item = dgvConItems.Rows[e.RowIndex].Cells["Confectionary_Name"].Value.ToString();
                            
            lblAmount.Visible = true;
            nudAmount.Visible = true;


        }
    }
}
