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
    public partial class frmSchedule : Form
    {
        private DateTime selectedTime;
        private string connectionString = ConnectionStrings.conSkreenMainStr;

        //add data to combobox
        private void PopulateMovieComboBox()
        {
            comboBox1.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Movie_Name FROM Movie_Info";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Movie_Name"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void InsertMovieOnSchedule(int movieID, int scheduleID)
        {
            // Create a SqlConnection and a SqlCommand.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Movie_On_Schedule (Movie_ID, Schedule_ID) VALUES (@MovieID, @ScheduleID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieID", movieID);
                    command.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        //insert data to schedule
        private int InsertSchedule(DateTime date, DateTime timeSlot)
        {
            // Initialize the scheduleID to -1 in case of an error.
            int scheduleID = -1;

            // Create a SqlConnection and a SqlCommand.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Schedule (Day_Shown, Timeslot) OUTPUT INSERTED.Schedule_ID VALUES (@DayShown, @TimeSlot)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DayShown", date);
                    command.Parameters.AddWithValue("@TimeSlot", timeSlot);

                    try
                    {
                        connection.Open();
                        // ExecuteScalar to get the inserted Schedule_ID.
                        scheduleID = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Schedule successfully added. Schedule ID: " + scheduleID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return scheduleID; // Return the Schedule_ID.
        }


        //get the selected movie id
        private int GetSelectedMovieID(string selectedMovieName)
        {

            int movieID = -1; // Initialize with an invalid ID in case the movie is not found.

            // Create a SqlConnection and a SqlCommand.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Movie_ID FROM Movie_Info WHERE Movie_Name = @MovieName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieName", selectedMovieName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            movieID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return movieID;
        }

        public frmSchedule()
        {
            InitializeComponent();
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dateTimePicker1.Value.ToString("MMM dd, yyyy");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int scheduleID;

            switch (true)
            {
                case var _ when rdoFirstShow.Checked:
                    selectedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                    break;
                case var _ when rdoSecondSHow.Checked:
                    selectedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
                    break;
                case var _ when rdoThirdShow.Checked:
                    selectedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
                    break;
                case var _ when rdoFourthShow.Checked:
                    selectedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);
                    break;
                default:
                    MessageBox.Show("Please select a show option.");
                    break;
            }

            // Now, you can use the 'selectedTime' variable as needed.
            MessageBox.Show($"Selected Time: {selectedTime.ToString("HH:mm")}");

            string selectedMovieName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;

            if (!string.IsNullOrEmpty(selectedMovieName))
            {
                int selectedMovieID = GetSelectedMovieID(selectedMovieName);
                scheduleID = InsertSchedule(dateTimePicker1.Value.Date, selectedTime);
                InsertMovieOnSchedule(selectedMovieID, scheduleID);
            }
            else
            {
                MessageBox.Show("Please select a movie.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rdoFirstShow.Checked = false;
            rdoSecondSHow.Checked = false;
            rdoThirdShow.Checked = false;
            rdoFourthShow.Checked = false;

            dateTimePicker1.Value = DateTime.Now;
            lblStartDate.Text = dateTimePicker1.Value.ToString("MMM dd, yyyy");
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            PopulateMovieComboBox();
        }
    }
}
