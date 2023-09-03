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
            string insertQuery = "INSERT INTO Actor_Info (First_Name, Last_Nmae, Description) VALUES (@f_name, @l_name, @description)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Param1", txtBxName.Text);
                command.Parameters.AddWithValue("@Param2", txtBxSurname.Text);
                command.Parameters.AddWithValue("@Param2", txtBxDescription.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Actor added succesfully ");
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
            connection.Open();

            // Define the DELETE command
            string deleteQuery = "DELETE FROM Actor_Info WHERE  = @ID";

            // Create a SqlCommand with parameters
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                // Set the parameter values
                command.Parameters.AddWithValue("@ID", 123); // Replace 123 with the ID you want to delete

                // Execute the DELETE command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No records deleted.");
                }
            }
        }
    }
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
        }
    }
}












