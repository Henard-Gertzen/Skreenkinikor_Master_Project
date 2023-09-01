using Skreenkinikor_Master_Project.Classes;
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
    public partial class frmReports : Form
    {
        //Variables
        private Reports_Class reports;
        //Constructor
        public frmReports()
        {
            InitializeComponent();
            //Default time
            dtpStart.Value = DateTime.Today.AddDays(-7);
            dtpEnd.Value = DateTime.Now;
            reports = new Reports_Class();
        }

        private void InitializeGraphData()
        {
            var reloadData = reports.LoadMovieData();
        }
    }
}
