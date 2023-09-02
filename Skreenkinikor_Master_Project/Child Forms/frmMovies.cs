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
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            pnlEdit.Visible = true;
        }
    }
}
