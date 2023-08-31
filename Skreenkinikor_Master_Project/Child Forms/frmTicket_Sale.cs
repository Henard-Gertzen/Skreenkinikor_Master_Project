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
    public partial class frmTicket_Sale : Form
    {
        private List<string> SelectedTickets = new List<string>();

        //Saves all seats in List and disable checkboxes
        private void ConfirmTickets()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Enabled = false;

                    // Store the name of seat
                    SelectedTickets.Add(checkBox.Name);
                }
            }
        }

        // Function to insert selected seats into the Ticket_Info table
        private void InsertSelectedSeatsIntoDatabase(string selectedMovieName)
        {
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;

            // Retrieve the Movie_ID based on the selected movie name
            int selectedMovieId = GetMovieIdFromName(selectedMovieName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Combine the selected seats into a single string with '#' as the delimiter
                    string combinedSeats = string.Join("#", SelectedTickets);

                    // Calculate the Ticket_Total (number of selected seats)
                    decimal ticketTotal = SelectedTickets.Count;

                    string insertQuery = "INSERT INTO Ticket_Info (Movie_ID, Ticket_Total, Seats) VALUES (@MovieID, @TicketTotal, @Seats)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieID", selectedMovieId);
                        cmd.Parameters.AddWithValue("@TicketTotal", ticketTotal);
                        cmd.Parameters.AddWithValue("@Seats", combinedSeats);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception here or log it for debugging
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private int GetMovieIdFromName(string movieName)
        {
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;
            int movieId = -1; // Initialize to a default value or handle errors appropriately

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Movie_ID FROM Movie_Info WHERE Movie_Name = @MovieName";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MovieName", movieName);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        movieId = Convert.ToInt32(result);
                    }
                }
            }

            return movieId;
        }

        //Enable all checkboxes
        private void EnableAllCheckBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox checkBox && !checkBox.Enabled)
                {
                    checkBox.Enabled = true;
                }

                if (c.HasChildren)
                {
                    EnableAllCheckBoxes(c);
                }
            }
        }

        //Uncheck selected seats
        private void UncheckAllCheckBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }

                if (c.HasChildren)
                {
                    UncheckAllCheckBoxes(c);
                }
            }
        }
        // Function to read seats from the database and disable checkboxes for a specific movie and date
        private void DisableBookedSeats(string selectedMovieName, DateTime selectedDate)
        {
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Ticket_Info.Seats FROM Ticket_Info " +
                                     "INNER JOIN Movie_Info ON Ticket_Info.Movie_ID = Movie_Info.Movie_ID " +
                                     "INNER JOIN Movie_On_Schedule ON Movie_Info.Movie_ID = Movie_On_Schedule.Movie_ID " +
                                     "INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID " +
                                     "WHERE Ticket_Info.Seats IS NOT NULL " +
                                     "AND Movie_Info.Movie_Name = @SelectedMovieName " +
                                     "AND CONVERT(DATE, Schedule.Day_Shown) = @SelectedDate";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@SelectedMovieName", selectedMovieName);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookedSeat = reader["Seats"].ToString().Trim();

                            if (!string.IsNullOrEmpty(bookedSeat))
                            {
                                foreach (Control control in tableLayoutPanel1.Controls)
                                {
                                    if (control is CheckBox checkBox && control.Name.Trim() == bookedSeat)
                                    {
                                        checkBox.Enabled = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }




        public frmTicket_Sale()
        {
            InitializeComponent();
        }

        private void frmTicket_Sale_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string selectedMovieName = cbbSelectMovie.SelectedItem as string; // Get the selected movie name

            if (!string.IsNullOrEmpty(selectedMovieName))
            {
                ConfirmTickets();
                UncheckAllCheckBoxes(this);
                InsertSelectedSeatsIntoDatabase(selectedMovieName);
                //SelectedTickets.Clear();
            }
            else
            {
                MessageBox.Show("Please select a movie from the ComboBox.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UncheckAllCheckBoxes(this);
        }

        private void cbxSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;
            string selectedMovieName = cbbSelectMovie.SelectedItem as string;
            DisableBookedSeats(selectedMovieName, selectedDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EnableAllCheckBoxes(this);
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;

            // Clear the existing items in the ComboBox
            cbbSelectMovie.Items.Clear();

            // Query the database to retrieve movies scheduled for the selected date
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT DISTINCT Movie_Info.Movie_Name " +
                                     "FROM Movie_Info " +
                                     "INNER JOIN Movie_On_Schedule ON Movie_Info.Movie_ID = Movie_On_Schedule.Movie_ID " +
                                     "INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID " +
                                     "WHERE CONVERT(DATE, Schedule.Day_Shown) = @SelectedDate";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Add each movie name to the ComboBox
                            cbbSelectMovie.Items.Add(reader["Movie_Name"].ToString());
                        }
                    }
                }
            }
        }
    }
}
