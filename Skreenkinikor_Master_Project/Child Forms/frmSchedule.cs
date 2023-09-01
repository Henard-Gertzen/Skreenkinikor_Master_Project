using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        private void ShowUpcomingMoviesInDataGridView(DataGridView dataGridView)
        {
            // Calculate the date range for the next seven days.
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = startDate.AddDays(7);

            // Create a SqlConnection and a SqlCommand.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Movie_Info.Movie_Name, Schedule.Timeslot, Schedule.Day_Shown " +
                               "FROM Movie_Info " +
                               "INNER JOIN Movie_On_Schedule ON Movie_Info.Movie_ID = Movie_On_Schedule.Movie_ID " +
                               "INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID " +
                               "WHERE Schedule.Day_Shown BETWEEN @StartDate AND @EndDate " +
                               "ORDER BY Schedule.Day_Shown, Schedule.Timeslot";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView.
                        dataGridView.DataSource = dt;
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

                        MessageBox.Show("Movie successfully added");
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

        // Function to get the name of the movie from the selected row
        private string GetMovieName()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Find the column index by name (case-sensitive)
                int movieNameIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Movie_Name")
                    {
                        movieNameIndex = column.Index;
                        break; // Exit the loop once the column is found
                    }
                }

                if (movieNameIndex != -1)
                {
                    // Retrieve the movie name from the selected row
                    string movieName = selectedRow.Cells[movieNameIndex].Value.ToString();
                    return movieName;
                }
            }

            return null; // Return null if no row is selected or if the column is not found
        }

        private string GetMovieTime()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Find the column index by name (case-sensitive)
                int timeIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Timeslot")
                    {
                        timeIndex = column.Index;
                        break; // Exit the loop once the column is found
                    }
                }

                if (timeIndex != -1)
                {
                    // Retrieve the movie time from the selected row
                    string movieTime = selectedRow.Cells[timeIndex].Value.ToString();
                    return movieTime;
                }
            }

            return null; // Return null if no row is selected or if the column is not found
        }

        private string GetMovieDate()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Find the column index by name (case-sensitive)
                int dateIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Day_Shown")
                    {
                        dateIndex = column.Index;
                        break; // Exit the loop once the column is found
                    }
                }

                if (dateIndex != -1)
                {
                    // Retrieve the movie date from the selected row
                    DateTime movieDate = Convert.ToDateTime(selectedRow.Cells[dateIndex].Value);

                    // Format the date to display only the date portion (e.g., 9/2/2023)
                    string formattedDate = movieDate.ToString("M/d/yyyy");

                    return formattedDate;
                }
            }

            return null; // Return null if no row is selected or if the column is not found
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

            string selectedMovieName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;

            if (!string.IsNullOrEmpty(selectedMovieName))
            {
                int selectedMovieID = GetSelectedMovieID(selectedMovieName);
                scheduleID = InsertSchedule(dateTimePicker1.Value.Date, selectedTime);
                InsertMovieOnSchedule(selectedMovieID, scheduleID);
                ShowUpcomingMoviesInDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Please select a movie.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string name = GetMovieName();
            string date = GetMovieDate();
            string time = GetMovieTime();
            MessageBox.Show(date + " <date:time> " +time);
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            PopulateMovieComboBox();
            ShowUpcomingMoviesInDataGridView(dataGridView1);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
