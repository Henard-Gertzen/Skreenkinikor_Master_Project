using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Shell;


namespace Skreenkinikor_Master_Project.Child_Forms
{
    public partial class frmActor_Assign : Form
    {
        private string con = ConnectionStrings.conSkreenMainStr;
        SqlCommand cmd;
        private string fName, lName;

        public frmActor_Assign()
        {
            InitializeComponent();
        }
        //Methods
        private int GetActorId(string fName, string lName)
        {
            try
            {
                string update = $"SELECT Actor_ID FROM Actor_Info WHERE First_Name = @First AND Last_Name = @Last";
                int id = -1;
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@First", fName);
                        cmd.Parameters.AddWithValue("@Last", lName);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            id = Convert.ToInt32(result);
                        }
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has ocurred: " + ex);
            }
            return -1;
        }
        private int GetMovieId()
        {
            try
            {
                string update = $"SELECT Movie_ID FROM Movie_Info WHERE Movie_Name = @Name";
                int id = -1;
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", cmbMovies.SelectedItem.ToString());

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            id = Convert.ToInt32(result);
                        }
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has ocurred: " + ex);
            }
            return -1;
        }
        private bool checkDupe(int aID, int mID)
        {
            string check = @"SELECT *
                            FROM Actor_On_Movie
                            WHERE Actor_ID = @ActorID AND Movie_ID = @MovieID";
            bool bCheck = false;

            using(SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@ActorID", aID);
                    cmd.Parameters.AddWithValue("@MovieID", mID);

                   object result = cmd.ExecuteScalar();
                   if(result != null && result != DBNull.Value)
                   {
                        return bCheck = true;
                   }
                }
            }
            return bCheck;
        }
        private void AddActorToMovie(string fName, string lName)
        {
          try
          {
            if (cmbActors.SelectedItem != null && cmbMovies.SelectedItem != null)
            {
                int actorID = GetActorId(fName, lName);
                int movieID = GetMovieId();
                if(!checkDupe(actorID, movieID))
                {
                    if (actorID != -1 && movieID != -1)
                    {
                            using (SqlConnection conn = new SqlConnection(con))
                            {
                                string sqlAdd = "INSERT INTO Actor_On_Movie(Actor_ID, Movie_ID) VALUES (@aID, @mID)";
                                conn.Open();
                                using (cmd = new SqlCommand(sqlAdd, conn))
                                {
                                    cmd.Parameters.AddWithValue("@aID", actorID);
                                    cmd.Parameters.AddWithValue("@mID", movieID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Actor has been added!");
                                }
                            }
                    }
                    else
                    {
                       MessageBox.Show("Please select valid actor and movie.");
                    }    
                }
                else
                {
                    MessageBox.Show("Actor already added to this movie!");
                }
            }
            else
            {
                MessageBox.Show("Please select an actor and movie.");
            }
          }
          catch (Exception ex)
          {
             MessageBox.Show("Error has ocurred: " + ex);
          }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] values = cmbActors.SelectedItem.ToString().Split(' ');
            fName = values[0].Trim();
            lName = values[1].Trim();
            AddActorToMovie(fName, lName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 87, 51);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        //Don't touch this, this adds drag functionality to the header panel
        //Explanation: Uses native libaries of the OS to move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmActor_Assign_Load(object sender, EventArgs e)
        {
            // reads the movie name and actor names into their respective comboboxes
            using (SqlConnection conn = new SqlConnection(con))
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

            using (SqlConnection conn = new SqlConnection(con))
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
    }
}