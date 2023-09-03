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
        private string mName, Description;
        private decimal Price;
        private string delMovie;
        private string MovieName, MovieDesc,tempName;
        private decimal MoviePrice;

        

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

                                // change the colum headings to more appropriate text
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

      

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            mName = txtMovieName.Text;
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

                        string sql = $"INSERT INTO Movie_Info VALUES ('{mName}','{Description}','{Price}')";
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
            txtMovieDesc.Clear();
            txtMoviePrice.Clear();
            txtMovieName.Clear();
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            // makes sure a movie is selected
            if (MovieName == "")
            {
                MessageBox.Show("Please select a movie to Edit");
                return;
            }

            //SQL injection to update the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    MovieName = txtMovieName.Text;
                    MovieDesc = txtMovieDesc.Text;
                    MoviePrice = decimal.Parse(txtMoviePrice.Text);

                    conn.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        string sql = "UPDATE Movie_Info SET Movie_Name = @Name, Movie_Description = @Desc, Seat_Price = @Price WHERE Movie_Name = @Temp";
                        using (SqlCommand command = new SqlCommand(sql, conn))
                        {
                            // adds parameters to the command                                                                      
                            command.Parameters.AddWithValue("@Name", MovieName);
                            command.Parameters.AddWithValue("@Desc", MovieDesc);
                            command.Parameters.AddWithValue("@Price", MoviePrice);
                            command.Parameters.AddWithValue("@Temp", tempName);
                            command.ExecuteNonQuery();

                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                displayDB();
                MessageBox.Show("Movie updated");


            }
        }

        private void btnRemoveMovie_Click_1(object sender, EventArgs e)
        {
            if (delMovie == "")
            {
                MessageBox.Show("Please select a movie to delete");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                // SQL injection to delete the selected movie
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

            txtMovieDesc.Clear();
            txtMoviePrice.Clear();
            txtMovieName.Clear();
        }

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // adds the values of the selected datagrid into variables
            delMovie = dgvMovies.Rows[e.RowIndex].Cells["Movie_Name"].Value.ToString();
            MovieName = dgvMovies.Rows[e.RowIndex].Cells["Movie_Name"].Value.ToString();
            MovieDesc = dgvMovies.Rows[e.RowIndex].Cells["Movie_Description"].Value.ToString();
            tempName = dgvMovies.Rows[e.RowIndex].Cells["Movie_Name"].Value.ToString();
            MoviePrice = (decimal)dgvMovies.Rows[e.RowIndex].Cells["Seat_Price"].Value;

            // the textboxes are populated with the values
            txtMovieName.Text = MovieName;
            txtMovieDesc.Text = MovieDesc;
            txtMoviePrice.Text = MoviePrice.ToString();
        }

       

        
    }
}
