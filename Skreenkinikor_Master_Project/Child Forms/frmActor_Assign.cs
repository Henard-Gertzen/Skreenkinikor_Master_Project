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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Shell;


namespace Skreenkinikor_Master_Project.Child_Forms
{
    public partial class frmActor_Assign : Form
    {
        public frmActor_Assign()
        {
            InitializeComponent();
        }

        private string connectionString = ConnectionStrings.conSkreenMainStr;
        private string mName, aName;

        private void frmActor_Assign_Load(object sender, EventArgs e)
        {
            // reads the movie name and actor names into their respective comboboxes
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlActor = $"Select First_Name, Last_Name FROM Actor_Info";
                

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlActor, conn))
                    {
                        SqlDataReader datareader;
                        datareader = cmd.ExecuteReader();

                        while (datareader.Read())
                        {
                            
                            cmbActors.Items.Add(datareader.GetValue(0) + " " + datareader.GetValue(1));
                            
                        }
                    }
                }
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlMovie = $"Select Movie_Name FROM Movie_Info";
                SqlDataReader reader;

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlMovie, conn))
                    {
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            
                            cmbMovies.Items.Add(reader.GetValue(0));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
            string ActorName;
            
            aName = cmbActors.SelectedItem.ToString();
           
            // splits the name and surname of the actor
            char[] separator = new char[] { ' ' };
            string[] parts = aName.Split(separator, StringSplitOptions.None);

            // the actor name is saved into the the new variable
             ActorName = parts[0];
            mName = cmbMovies.SelectedItem.ToString();


            // initialise default values for the variables
            int mID = 0, aID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // retrieves the actor ID from the database using the actor name received from the combobox
                try
                {
                    conn.Open();
                    
                    string sqlActor = $"Select Actor_ID FROM Actor_Info WHERE First_Name = '{ActorName}'";

                    using (SqlCommand cmd = new SqlCommand(sqlActor, conn))
                    {
                        SqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            mID = (int)reader.GetValue(0);
                        }

                        Console.WriteLine("aName: " + ActorName);
                        Console.WriteLine("Actor " + mID);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // retrieves the Movie ID from the database using the Movie name received from the combobox
                try
                {
                    conn.Open();

                    string sqlMovie = $"SELECT Movie_ID FROM Movie_Info WHERE Movie_Name = '{mName}'";
                    using (SqlCommand command = new SqlCommand(sqlMovie, conn))
                    {
                        SqlDataReader dataReader;
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            aID = (int)dataReader.GetValue(0);
                        }

                        Console.WriteLine("mName: " + mName);
                        Console.WriteLine("MovieID " + aID);
                    }
                }
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // inserts the actor ID and movie ID into the database
                try
                {
                    conn.Open();

                    string sql = $"INSERT INTO Actor_On_Movie(Actor_ID,Movie_ID) VALUES ('{aID}','{mID}')";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                   {
                        using (SqlCommand cmdAdd = new SqlCommand(sql, conn))
                        {
                            /* adapter.InsertCommand = cmdAdd;
                             adapter.InsertCommand.ExecuteNonQuery();*/
                            cmdAdd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            MessageBox.Show("Added succesfully!");
        }
    }
}
