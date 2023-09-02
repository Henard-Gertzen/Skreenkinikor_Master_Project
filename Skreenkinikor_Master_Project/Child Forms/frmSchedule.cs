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

        //Populate ComboBox with movie names
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

        //Insert Movie to Schedule
        private void InsertMovieOnSchedule(int movieID, int scheduleID)
        {
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

        //Displays the upcoming moveis for the next 2 weeks
        private void ShowUpcomingMoviesInDataGridView(DataGridView dataGridView)
        {
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = startDate.AddDays(14);

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
            int scheduleID = -1;

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
                        scheduleID = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Movie successfully added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return scheduleID; 
        }

        //Update the schedule to the selected movie
        private void ModifySchedule(int scheduleID, int currentMovieID, int replacementMovieID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                string updateMovieOnScheduleQuery = "UPDATE Movie_On_Schedule SET Movie_ID = @ReplacementMovieID WHERE Schedule_ID = @ScheduleID AND Movie_ID = @CurrentMovieID";

                using (SqlCommand updateMovieOnScheduleCommand = new SqlCommand(updateMovieOnScheduleQuery, connection))
                {
                    updateMovieOnScheduleCommand.Parameters.AddWithValue("@ReplacementMovieID", replacementMovieID);
                    updateMovieOnScheduleCommand.Parameters.AddWithValue("@ScheduleID", scheduleID);
                    updateMovieOnScheduleCommand.Parameters.AddWithValue("@CurrentMovieID", currentMovieID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = updateMovieOnScheduleCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Schedule modified successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching records found in Movie_On_Schedule to modify.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        //Get ID of Selected Movie
        private int GetSelectedMovieID(string selectedMovieName)
        {

            int movieID = -1;

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

        // Get the name of the movie from the selected row
        private string GetMovieName()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int movieNameIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Movie_Name")
                    {
                        movieNameIndex = column.Index;
                        break; 
                    }
                }

                if (movieNameIndex != -1)
                {
                    string movieName = selectedRow.Cells[movieNameIndex].Value.ToString();
                    return movieName;
                }
            }

            return null;
        }

        //Get the showtime
        private string GetMovieTime()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int timeIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Timeslot")
                    {
                        timeIndex = column.Index;
                        break;
                    }
                }

                if (timeIndex != -1)
                {
                    string movieTime = selectedRow.Cells[timeIndex].Value.ToString();
                    return movieTime;
                }
            }

            return null; 
        }

        //Get the date
        private string GetMovieDate()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int dateIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Day_Shown")
                    {
                        dateIndex = column.Index;
                        break; 
                    }
                }

                if (dateIndex != -1)
                {
                    DateTime movieDate = Convert.ToDateTime(selectedRow.Cells[dateIndex].Value);

                    string formattedDate = movieDate.ToString("M/d/yyyy");

                    return formattedDate;
                }
            }

            return null; 
        }

        //Get schedule ID
        private int GetScheduleID(string dayShown, string timeslot)
        {
            int scheduleID = -1; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Schedule_ID FROM Schedule WHERE Day_Shown = @DayShown AND Timeslot = @Timeslot";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DayShown", DateTime.Parse(dayShown).Date); 
                    command.Parameters.AddWithValue("@Timeslot", TimeSpan.Parse(timeslot)); 

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            scheduleID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return scheduleID;
        }

        //Delete movie from schedule
        private void DeleteSchedule(int scheduleID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Schedule WHERE Schedule_ID = @ScheduleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Schedule deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        //Delete data from movie on schedule
        private void DeleteMovieOnSchedule(int scheduleID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Movie_On_Schedule WHERE Schedule_ID = @ScheduleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Movie on Schedule deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        //Make sure no schedule conflicts
        private bool IsScheduleConflict(DateTime date, DateTime timeSlot)
        {          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Schedule WHERE Day_Shown = @DayShown AND Timeslot = @TimeSlot";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DayShown", date);
                    command.Parameters.AddWithValue("@TimeSlot", timeSlot.TimeOfDay); 

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return false; 
        }

        //Make sure no date conflicts
        private bool IsMovieScheduledForDate(int movieID, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Movie_On_Schedule " +
                               "INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID " +
                               "WHERE Movie_On_Schedule.Movie_ID = @MovieID AND Schedule.Day_Shown = @DayShown";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieID", movieID);
                    command.Parameters.AddWithValue("@DayShown", date.Date);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return false; 
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

            string selectedMovieName = string.Empty;

            if (comboBox1.SelectedItem != null)
            {
                selectedMovieName = comboBox1.SelectedItem.ToString();
            }

            if (string.IsNullOrEmpty(selectedMovieName))
            {
                MessageBox.Show("Please select a movie.");
                return; 
            }

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
                    return; 
            }

            int selectedMovieID = GetSelectedMovieID(selectedMovieName);

            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (IsMovieScheduledForDate(selectedMovieID, selectedDate))
            {
                MessageBox.Show("The selected movie is already scheduled for the chosen date.");
                return;
            }

            if (IsScheduleConflict(selectedDate, selectedTime))
            {
                MessageBox.Show("Schedule conflict! This date and time already exist in the schedule.");
                return; 
            }

            scheduleID = InsertSchedule(selectedDate, selectedTime);
            InsertMovieOnSchedule(selectedMovieID, scheduleID);
            ShowUpcomingMoviesInDataGridView(dataGridView1);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            string date = GetMovieDate();
            string time = GetMovieTime();

            int scheduleID = GetScheduleID(date, time);

            DeleteMovieOnSchedule(scheduleID);
            DeleteSchedule(scheduleID);

            ShowUpcomingMoviesInDataGridView(dataGridView1);
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            PopulateMovieComboBox();
            ShowUpcomingMoviesInDataGridView(dataGridView1);
            lblStartDate.Text = dateTimePicker1.Value.ToString("MMM dd, yyyy");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string currentMovieName = GetMovieName();
            string replacementMovieName = string.Empty;

            if (comboBox1.SelectedItem != null)
            {
                replacementMovieName = comboBox1.SelectedItem.ToString();
            }


            int currentMovieID = GetSelectedMovieID(currentMovieName);
            int replacementMovieID = GetSelectedMovieID(replacementMovieName);

            string date = GetMovieDate();
            string time = GetMovieTime();

            int scheduleID = GetScheduleID(date, time);

            if (IsMovieScheduledForDate(replacementMovieID, DateTime.Parse(date)))
            {
                MessageBox.Show("The selected movie is already scheduled for the chosen date.");
                return;
            }

            ModifySchedule(scheduleID, currentMovieID, replacementMovieID);
            ShowUpcomingMoviesInDataGridView(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
