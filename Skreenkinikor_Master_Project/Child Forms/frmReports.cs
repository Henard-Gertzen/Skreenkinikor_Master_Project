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
            btnWeek.Select();

            reports = new Reports_Class();

            InitializeGraphData();
        }

        private void InitializeGraphData()
        {
            var reloadData = reports.LoadMovieData(dtpStart.Value, dtpEnd.Value);
            if (reloadData == true)
            {
                chTotal.DataSource = reports.lTotalMovies;
                chTotal.Series[0].XValueMember = "Date";
                chTotal.Series[0].YValueMembers = "TotalAmount";
                chTotal.DataBind();
            }
            else
            {
                Console.WriteLine("View Not loaded!");
            }
        }
    }
}
