using iTextSharp.text;
using iTextSharp.text.pdf;
using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void btnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.FromArgb(27, 152, 224);
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.BackColor = Color.FromArgb(19, 41, 61);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //Save File dialogue
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a new document
                    Document doc = new Document();
                    string pdfPath = saveFileDialog.FileName;

                    // Create a PdfWriter to write to the document
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

                    // Open the document for writing
                    doc.Open();


                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 18);
                    Paragraph title = new Paragraph("Report Generated for Skreenkinikor", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);


                    Bitmap bitmapLogo = Properties.Resources.SK_Logo;

                    Image logoImage = Image.GetInstance(bitmapLogo, System.Drawing.Imaging.ImageFormat.Png);
                    logoImage.Alignment = Element.ALIGN_CENTER;
                    doc.Add(logoImage);


                    iTextSharp.text.Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    Paragraph date = new Paragraph("Date: " + DateTime.Now.ToString("yyyy-MM-dd"), dateFont);
                    date.Alignment = Element.ALIGN_CENTER;
                    doc.Add(date);

                    string imagePath1 = "chart_image.png";
                    string imagePath2 = "chart_image2.png";

                    chTop10.SaveImage(imagePath1, ChartImageFormat.Png);
                    chTotal.SaveImage(imagePath2, ChartImageFormat.Png);

                    Image chartImage1 = Image.GetInstance(imagePath1);
                    chartImage1.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImage1);

                    Image chartImage2 = Image.GetInstance(imagePath2);
                    chartImage2.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImage2);

                    // Close the document
                    doc.Close();

                    MessageBox.Show("PDF generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
