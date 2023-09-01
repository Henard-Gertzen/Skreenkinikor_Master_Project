using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Check which radio button is selected and update the selectedTime variable.
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
                    // Handle the case where none of the radio buttons are selected.
                    MessageBox.Show("Please select a show option.");
                    break;
            }

            // Now, you can use the 'selectedTime' variable as needed.
            MessageBox.Show($"Selected Time: {selectedTime.ToString("HH:mm")}");
        }
    }
}
