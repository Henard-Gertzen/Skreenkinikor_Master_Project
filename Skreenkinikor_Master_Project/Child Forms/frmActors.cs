using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skreenkinikor_Master_Project
{
    public partial class frmActors : Form
    {

        private SqlConnection sqlConnection;

        public frmActors()
        {
            InitializeComponent();
        }

        private void frmActors_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                // Replace "YourTableName" with the name of your database table.
                string tableName = "Actor_Info";
                string insertQuery = $"INSERT INTO Actor_Info (Column1, Column2, Column3) VALUES (@Value1, @Value2, @Value3)";

                using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                {
                    // Replace @Value1, @Value2, and @Value3 with the actual parameter names.
                    sqlCommand.Parameters.AddWithValue("@Value1", txtBxName.Text);
                    sqlCommand.Parameters.AddWithValue("@Value2", txtBxSurname.Text);


                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Actor inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                // Replace "YourTableName" with the name of your database table.
                string tableName = "YourTableName";
                string deleteQuery = $"DELETE FROM {tableName} WHERE ColumnName = @ValueToDelete";

                using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                {
                    
                    sqlCommand.Parameters.AddWithValue("@ValueToDelete", txtBxName.Text);
                    sqlCommand.Parameters.AddWithValue("@ValueToDelete", txtBxSurname.Text);// Replace with the value you want to delete.

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No data matching the criteria found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                
                string tableName = "Actor_Info";
                string updateQuery = $"UPDATE Actor_Info SET Column1 = @Value1, Column2 = @Value2 WHERE Column3 = @Value3";

                using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                {
                    // Replace @Value1, @Value2, and @Value3 with the actual parameter names.
                    sqlCommand.Parameters.AddWithValue("@Value1", txtBxName.Text);
                    sqlCommand.Parameters.AddWithValue("@Value2", txtBxSurname.Text);


                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Data modified successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
    
}
