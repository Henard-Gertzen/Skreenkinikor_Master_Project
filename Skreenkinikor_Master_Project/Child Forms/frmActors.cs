using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;

namespace Skreenkinikor_Master_Project
{
    public partial class frmActors : Form
    {
        private List<Actor_Info> actors = new List<Actor_Info>();

        public frmActors()
        {
            InitializeComponent();
        }

        private void frmActors_Load(object sender, EventArgs e)
        {
            // Initialize DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = actors;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string firstName = txtBxName.Text.Trim();
            string lastName = txtBxSurname.Text.Trim();

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                actors.Add(new Actor { FirstName = firstName, LastName = lastName });
                RefreshGrid();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please enter both first name and last name.");
            }
        }
    }
}



     
        

       
        
    
    

