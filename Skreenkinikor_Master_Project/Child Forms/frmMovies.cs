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
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        private string connectionString = ConnectionStrings.conSkreenMainStr;
        private string Name, Description;
        private decimal Price;
        private string delMovie;

        private void frmMovies_Load(object sender, EventArgs e)
        {
            displayDB();
        }
        private void displayDB()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // displays the Movie, description and price
                    string sql = "SELECT Movie_Name, Movie_Description, Seat_Price FROM Movie_Info";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            using (DataSet ds = new DataSet())
                            {


                                dataAdapter.SelectCommand = command;
                                dataAdapter.Fill(ds, "Movie_Info");



                                dgvMovies.DataSource = ds;
                                dgvMovies.DataMember = "Movie_Info";

                                dgvMovies.Columns["Movie_name"].HeaderText = "Movie";
                                dgvMovies.Columns["Movie_Description"].HeaderText = "Description";
                                dgvMovies.Columns["Seat_Price"].HeaderText = "Price";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            Name = txtMovieName.Text;
            Description = txtMovieDesc.Text;

            // tryparse to ensure that only a decimal value is added in the textbox
            if (decimal.TryParse(txtMoviePrice.Text, out Price))
            {
                // sql statement to inject the new movie data into the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string sql = $"INSERT INTO Movie_Info VALUES ('{Name}','{Description}','{Price}')";
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            using (SqlCommand command = new SqlCommand(sql, conn))
                            {
                                adapter.InsertCommand = command;
                                adapter.InsertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (SqlException ex) 
                    { 
                        MessageBox.Show(ex.Message); 
                    }

                    MessageBox.Show("Movie added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid price for seating!");
            }
            displayDB();
        }

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delMovie = dgvMovies.Rows[e.RowIndex].Cells["Movie_Name"].Value.ToString();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = $"DELETE FROM Movie_Info WHERE Movie_Name = '{delMovie}'";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.DeleteCommand = command;
                            adapter.DeleteCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            MessageBox.Show("Movie deleted");
            displayDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            
        }
    }
}
