using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Skreenkinikor_Master_Project.Classes;

namespace Skreenkinikor_Master_Project
{
    public partial class frmActors : Form
    {
        //Variables
        private string connectionString = ConnectionStrings.conSkreenMainStr;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        public frmActors()
        {
            InitializeComponent();
            LoadTable();
        }
        //Method
        public void LoadTable()
        {
            try
            {
                string load = @"SELECT First_Name, Last_Name, Description FROM Actor_Info";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(load, con))
                    {
                        DataTable dt = new DataTable();
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        dgwActor.DataSource = dt;

                        dgwActor.Columns["First_Name"].HeaderText = "Name";
                        dgwActor.Columns["Last_Name"].HeaderText = "Surname";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
            }
        }
        private int GetActorID()
        {
            string query = "SELECT Actor_ID FROM Actor_Info WHERE First_Name = @First AND Last_Name = @Last AND Description = @Desc";
            int id = -1;
            string getName = dgwActor.SelectedRows[0].Cells["First_Name"].Value.ToString();
            string getSurname = dgwActor.SelectedRows[0].Cells["Last_Name"].Value.ToString();
            string getDesc = dgwActor.SelectedRows[0].Cells["Description"].Value.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@First", getName);
                    cmd.Parameters.AddWithValue("@Last", getSurname);
                    cmd.Parameters.AddWithValue("@Desc", getDesc);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }
            return id;
        }
        private void cancelMod()
        {
            txtBxDescription.Enabled = true;
            txtBxName.Enabled = true;
            txtBxSurname.Enabled = true;
            btnAddNew.Enabled = true;
            btnDelete.Enabled = true;
            btnModify.Enabled = true;
            btnRefresh.Enabled = true;
            dgwActor.Enabled = true;

            txtModDesc.Visible = false;
            txtModName.Visible = false;
            txtModSur.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void modActor()
        {
            txtBxDescription.Enabled = false;
            txtBxName.Enabled = false;
            txtBxSurname.Enabled = false;
            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnRefresh.Enabled = false;
            dgwActor.Enabled = false;

            txtModDesc.Visible = true;
            txtModName.Visible = true;
            txtModSur.Visible = true;
            btnSubmit.Visible = true;
            btnCancel.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }
        private void clearBox()
        {
            txtBxDescription.Clear();
            txtBxName.Clear();
            txtBxSurname.Clear();
        }
        //Objects
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteCmd = "DELETE FROM Actor_Info WHERE Actor_ID = @ID";
                string deleteSql = "DELETE FROM Actor_On_Movie WHERE Actor_ID = @ID";

                DialogResult warn = MessageBox.Show("Are you sure you want to remove this actor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteCmd, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", GetActorID());
                            cmd.ExecuteNonQuery();
                        }
                        using(SqlCommand cmd = new SqlCommand(deleteSql, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", GetActorID());
                            cmd.ExecuteNonQuery();
                        }
                        LoadTable();
                        clearBox();
                    }
                }
                else if (warn == DialogResult.No)
                {
                    //nothing happens
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                modActor();
                string getName = dgwActor.SelectedRows[0].Cells["First_Name"].Value.ToString();
                string getSurname = dgwActor.SelectedRows[0].Cells["Last_Name"].Value.ToString();
                string getDesc = dgwActor.SelectedRows[0].Cells["Description"].Value.ToString();

                txtBxDescription.Text = getDesc;
                txtBxName.Text = getName;
                txtBxSurname.Text = getSurname;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadTable();
            clearBox();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelMod();
            clearBox();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string update = $"UPDATE Actor_Info SET First_Name = @Name, Last_Name = @Surname, Description = @Desc WHERE Actor_ID = @ID";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(update, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", GetActorID());

                        if (txtModName.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@Name", txtModName.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Name", dgwActor.SelectedRows[0].Cells["First_Name"].Value.ToString());
                        }
                        if (txtModSur.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@Surname", txtModSur.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Surname", dgwActor.SelectedRows[0].Cells["Last_Name"].Value.ToString());
                        }
                        if (txtModDesc.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@Desc", txtModDesc.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Desc", dgwActor.SelectedRows[0].Cells["Description"].Value.ToString());
                        }

                        cmd.ExecuteNonQuery();
                        LoadTable();
                        cancelMod();
                        clearBox();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occurred: " + ex);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlAdd = "INSERT INTO Actor_Info(First_Name, Last_Name, Description) VALUES (@First, @Last, @Desc)";
                    con.Open();
                    using (cmd = new SqlCommand(sqlAdd, con))
                    {
                        if (txtBxDescription.Text != "" && txtBxSurname.Text != "" && txtBxName.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@First", txtBxName.Text);
                            cmd.Parameters.AddWithValue("@Last", txtBxSurname.Text);
                            cmd.Parameters.AddWithValue("@Desc", txtBxDescription.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Actor has been added!");
                            LoadTable();
                            clearBox();
                        }
                        else
                        {
                            MessageBox.Show("Please fill in Name, Surname and Description");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}