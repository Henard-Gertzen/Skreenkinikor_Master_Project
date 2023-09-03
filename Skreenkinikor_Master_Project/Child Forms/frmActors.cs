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
using Skreenkinikor_Master_Project.Classes;
using Skreenkinikor_Master_Project.Child_Forms;

namespace Skreenkinikor_Master_Project
{
    public partial class frmActors : Form
    {    
        public frmActors()
        {
            InitializeComponent();
        }
        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newfrm = new frmActor_Assign();
            newfrm.ShowDialog();
        }
    }
}

        
    











