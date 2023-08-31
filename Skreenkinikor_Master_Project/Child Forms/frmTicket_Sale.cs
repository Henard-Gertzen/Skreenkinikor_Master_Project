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

            // Display the names of seats
            MessageBox.Show("Selected Checkboxes: " + string.Join(", ", SelectedTickets));
        }

        //Read List into database
        private void InsertSelectedSeatsIntoDatabase()
        {
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string seat in SelectedTickets)
                {
                    string insertQuery = "INSERT INTO Ticket_Info (Seats) VALUES (@Seats)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Seats", seat);
                        cmd.ExecuteNonQuery();
                    }
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
        // Function to read seats from the database and disable checkboxes
        private void DisableBookedSeats()
        {
            string connectionString = Classes.ConnectionStrings.conSkreenMainStr;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Seats FROM Ticket_Info";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookedSeat = reader["Seats"].ToString();

                            Control[] controls = tableLayoutPanel1.Controls.Find(bookedSeat, true);
                            if (controls.Length > 0 && controls[0] is CheckBox checkBox)
                            {
                                checkBox.Enabled = false;
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
            ConfirmTickets();
            InsertSelectedSeatsIntoDatabase();
            UncheckAllCheckBoxes(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UncheckAllCheckBoxes(this);
        }

        private void cbxSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableBookedSeats();
        }
    }
}
