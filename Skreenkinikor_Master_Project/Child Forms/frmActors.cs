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
using System.Windows;
using Skreenkinikor_Master_Project.Classes;

namespace Skreenkinikor_Master_Project
{
    public partial class frmActors : Form
    {

        private SqlConnection connection;

        public frmActors(string connectionString)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Database connection opened.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error opening database connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database connection closed.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error closing database connection: " + ex.Message);
            }
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Actor_Info (Actor_ID,First_Name, Last_Nmae, Description) VALUES (@ID,@f_name, @l_name, @description)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Param1", txtBxID.Text);
                command.Parameters.AddWithValue("@Param2", txtBxName.Text);
                command.Parameters.AddWithValue("@Param3", txtBxSurname.Text);
                command.Parameters.AddWithValue("@Param4", txtBxDescription.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Actor added successfully! ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        class Connection
        {
            static void Main(string[] args)
            {

                string connectionString = "Data Source=.;Initial Catalog=ScreenKinikor;Integrated Security=True";

                frmActors dataConnection = new frmActors(connectionString);

                try
                {
                    dataConnection.OpenConnection();

                    // Perform database operations here

                    dataConnection.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Define the DELETE command
                string deleteQuery = "DELETE FROM Actor_Info WHERE  Actor_ID = @Param1 ,First_Name =@Param2, Last_Nmae =@Param3, Description = @Param4";

                // Create a SqlCommand with parameters
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@Param1", txtBxID.Text);
                    command.Parameters.AddWithValue("@Param2", txtBxName.Text);
                    command.Parameters.AddWithValue("@Param3", txtBxSurname.Text);
                    command.Parameters.AddWithValue("@Param4", txtBxDescription.Text);

                    // Execute the DELETE command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Actor deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No records deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()

        {

            // Create a DataTable to hold your data
            DataTable freshData = new DataTable();

          
                string query = "SELECT * FROM YourTable"; // Replace with your SQL query
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(freshData);
            
            dataGridView1.DataSource = freshData;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Define the SQL update query
                string updateQuery = "UPDATE Actor_Info SET FirstName = @NewFirstName WHERE LastName = @LastName";

                // Create a SqlCommand with the SQL query and the SqlConnection
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Set parameters for the query
                    command.Parameters.AddWithValue("@Param1", txtBxID.Text);
                    command.Parameters.AddWithValue("@Param2", txtBxName.Text);
                    command.Parameters.AddWithValue("@Param3", txtBxSurname.Text);
                    command.Parameters.AddWithValue("@Param4", txtBxDescription.Text);

                    // Execute the update query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Update successful.");
                    }
                    else
                    {
                        Console.WriteLine("No records were updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

        
    











