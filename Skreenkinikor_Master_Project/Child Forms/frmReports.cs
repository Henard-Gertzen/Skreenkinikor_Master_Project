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
        private Button btnCurrent;
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
            Active(btnWeek);
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

                chTop10.DataSource = reports.lTop10Movies;
                chTop10.Series[0].XValueMember = "Key";
                chTop10.Series[0].YValueMembers = "Value";
                chTop10.DataBind();
            }
            else
            {
                Console.WriteLine("View Not loaded!");
            }
        }
        private void Active(object activeButton)
        {
            if (activeButton != null)
            {
                Disable();
                btnCurrent = (Button)activeButton;
                btnCurrent.BackColor = Color.FromArgb(0, 100, 148);
                btnCurrent.ForeColor = Color.White;
            }
        }
        private void Disable()
        {
            dtpEnd.Enabled = false;
            dtpStart.Enabled = false;
            btnSubmit.Visible = false;

            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(19, 41, 61);
                btnCurrent.ForeColor = Color.White;
                btnCurrent.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEnd.Value = DateTime.Now;
            InitializeGraphData();
            Active(sender);
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Now;
            InitializeGraphData();
            Active(sender);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-7);
            dtpEnd.Value = DateTime.Now;
            InitializeGraphData();
            Active(sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            Active(sender);
            dtpEnd.Enabled = true;
            dtpStart.Enabled = true;
            btnSubmit.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InitializeGraphData();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            if(btnCurrent == btnCustom)
            {
                dtpStart.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustom)
            {
                dtpEnd.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStart.Value.ToString("MMM dd, yyyy");
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEnd.Value.ToString("MMM dd, yyyy");
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStart.Value.ToString("MMM dd, yyyy");
            lblEndDate.Text = dtpEnd.Value.ToString("MMM dd, yyyy");
        }
    }
}
