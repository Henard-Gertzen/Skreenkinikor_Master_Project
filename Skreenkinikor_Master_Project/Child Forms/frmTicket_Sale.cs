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
    public partial class frmTicket_Sale : Form
    {
        private List<string> disabledCheckboxes = new List<string>();

        private void DisableCheckedCheckboxes()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Enabled = false;

                    // Store the name of the disabled checkbox
                    disabledCheckboxes.Add(checkBox.Name);
                }
            }

            // Display the names of the disabled checkboxes (for demonstration)
            MessageBox.Show("Disabled Checkboxes: " + string.Join(", ", disabledCheckboxes));
        }

        public frmTicket_Sale()
        {
            InitializeComponent();
        }

        private void frmTicket_Sale_Load(object sender, EventArgs e)
        {

        }
    }
}
