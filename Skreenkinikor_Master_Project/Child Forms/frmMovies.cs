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

        private void frmMovies_Load(object sender, EventArgs e)
        {
            
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
        }

        private void button3_Click(object sender, EventArgs e)
        {


            
        }
    }
}
