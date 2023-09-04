using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreenkinikor_Master_Project
{
    public partial class frmTicket_Sale : Form
    {
        private List<string> SelectedTickets = new List<string>();
        private string connectionString = ConnectionStrings.conSkreenMainStr;

        //Saves all seats in List and disable checkboxes
        private void ConfirmTickets()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Enabled = false;

                    SelectedTickets.Add(checkBox.Name);
                }
            }
        }

        //add movie names to combobox for the selected date
        private void PopulateMovieComboBox(ComboBox comboBox, DateTime selectedDate)
        {

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
                        comboBox.Items.Clear(); 

                        while (reader.Read())
                        {                           
                            comboBox.Items.Add(reader["Movie_Name"].ToString());
                        }
                    }
                }
            }
        }

        // Function to insert selected seats into the Ticket_Info table
        private void InsertSelectedSeatsIntoDatabase(string selectedMovieName)
        {
            int selectedMovieId = GetMovieIdFromName(selectedMovieName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string combinedSeats = string.Join("#", SelectedTickets);

                    decimal ticketTotal = SelectedTickets.Count * GetSeatPriceByMovieId(selectedMovieId);

                    string insertQuery = "INSERT INTO Ticket_Info (Movie_ID, Ticket_Total, Seats, Payment_Date) " +
                                         "VALUES (@MovieID, @TicketTotal, @Seats, @PaymentDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieID", selectedMovieId);
                        cmd.Parameters.AddWithValue("@TicketTotal", ticketTotal);
                        cmd.Parameters.AddWithValue("@Seats", combinedSeats);
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tickets Booked");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int GetMovieIdFromName(string movieName)
        {
            int movieId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT Movie_ID FROM Movie_Info WHERE Movie_Name = @MovieName";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieName", movieName);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int.TryParse(result.ToString(), out movieId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

        //get seat price
        private decimal GetSeatPriceByMovieId(int movieId)
        {
            decimal seatPrice = -1; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Seat_Price FROM Movie_Info WHERE Movie_ID = @MovieId";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movieId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        seatPrice = Convert.ToDecimal(result);
                    }
                }
            }

            return seatPrice;
        }

        // Function to read seats from the database and disable checkboxes for a specific movie and date
        private void DisableBookedSeats(string selectedMovieName, DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int selectedMovieId = GetMovieIdFromName(selectedMovieName);

                    string selectQuery = "SELECT Seats FROM Ticket_Info TI " +
                                         "INNER JOIN Movie_Info MI ON TI.Movie_ID = MI.Movie_ID " +
                                         "WHERE MI.Movie_Name = @MovieName " +
                                         "AND TI.Movie_ID = @MovieId";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieName", selectedMovieName);
                        cmd.Parameters.AddWithValue("@MovieId", selectedMovieId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> bookedSeats = new List<string>();

                            while (reader.Read())
                            {
                                string seats = reader["Seats"].ToString();

                                if (!string.IsNullOrEmpty(seats))
                                {
                                    bookedSeats.AddRange(seats.Split('#'));
                                }
                            }

                            // Disable checkboxes for booked seats
                            foreach (string seat in bookedSeats)
                            {
                                CheckBox checkBox = FindCheckBoxByName(seat);
                                if (checkBox != null)
                                {
                                    checkBox.Enabled = false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // Helper function to find a CheckBox by its name in the TableLayoutPanel
        private CheckBox FindCheckBoxByName(string name)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Name == name)
                {
                    return checkBox;
                }
            }
            return null; 
        }

        private string MovieShowTime(string selectedMovieName, DateTime selectedDate)
        {
            int selectedMovieId = GetMovieIdFromName(selectedMovieName);

            if (selectedMovieId != -1)
            {
                string showTime = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string selectQuery = "SELECT Schedule.Timeslot " +
                                             "FROM Movie_On_Schedule " +
                                             "INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID " +
                                             "WHERE Movie_On_Schedule.Movie_ID = @MovieId " +
                                             "AND CONVERT(DATE, Schedule.Day_Shown) = @SelectedDate";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@MovieId", selectedMovieId);
                            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                showTime = result.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                return showTime;
            }
            else
            {
                return "Showtime not available";
            }
        }


        public frmTicket_Sale()
        {
            InitializeComponent();
        }
        //Method
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
        private void frmTicket_Sale_Load(object sender, EventArgs e)
        {
            ShowUpcomingMoviesInDataGridView(dgwSchedule);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string selectedMovieName = cbbSelectMovie.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedMovieName))
            {
                ConfirmTickets();
                InsertSelectedSeatsIntoDatabase(selectedMovieName);
                UncheckAllCheckBoxes(this);
                SelectedTickets.Clear();
            }
            else
            {
                MessageBox.Show("Please select a movie from the ComboBox.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UncheckAllCheckBoxes(this);
            dateTimePicker1.Value = DateTime.Now;
            lblStartDate.Text = dateTimePicker1.Value.ToString("MMM dd, yyyy");
        }

        private void cbxSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string selectedMovieName = cbbSelectMovie.SelectedItem as string;
            EnableAllCheckBoxes(this);
            DisableBookedSeats(selectedMovieName, selectedDate);
            lblShowTimeTime.Text = MovieShowTime(selectedMovieName, selectedDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EnableAllCheckBoxes(this);
            DateTime selectedDate = dateTimePicker1.Value;

            cbbSelectMovie.Items.Clear();

            PopulateMovieComboBox(cbbSelectMovie, selectedDate);

            lblStartDate.Text = dateTimePicker1.Value.ToString("MMM dd, yyyy");

        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            SendKeys.Send("%{DOWN}");
        }
    }
}
