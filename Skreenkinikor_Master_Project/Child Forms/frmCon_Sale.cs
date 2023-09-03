using Skreenkinikor_Master_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreenkinikor_Master_Project
{
    public partial class frmCon_Sale : Form
    {
        public frmCon_Sale()
        {
            InitializeComponent();

        }

        private string connectionString = ConnectionStrings.conSkreenMainStr;
        private string item;
        private int amount;
        private string tempItem;
        private int tempAmount;
        private LinkedList list = new LinkedList();


        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCon_Sale_Load(object sender, EventArgs e)
        {
            // loads the the confectionary items into the datagrid when the form loads

            lblAmount.Visible = false;
            nudAmount.Visible = false;
            btnAdd.Visible = false;
            lblDelete.Visible = false;
            lbItems.Visible = false;
            lblEdit.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            displayDB();
           


        }

        private void displayDB()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // displays the confectionary items and their prices in the datagrid when the form loads
                    string sql = "SELECT Confectionary_Name, Confectionary_Price FROM Confectionary_Item Where Confectionary_Stock > 0";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            using (DataSet ds = new DataSet())
                            {


                                dataAdapter.SelectCommand = command;
                                dataAdapter.Fill(ds, "Confectionary_Item");



                                dgvConItems.DataSource = ds;
                                dgvConItems.DataMember = "Confectionary_Item";

                                dgvConItems.Columns["Confectionary_Name"].HeaderText = "Item";
                                dgvConItems.Columns["Confectionary_Price"].HeaderText = "Price";
                            }
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            lblAmount.Visible = true;
            nudAmount.Visible = true;
            btnAdd.Visible = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            // the text in the textbox filters the datagrid according to what is typed
                            // The collation allows for case-insensitivity in the sql query.
                            string sql = "SELECT Confectionary_Name, Confectionary_Price FROM Confectionary_Item Where Confectionary_Stock > 0 AND Confectionary_Name COLLATE Latin1_General_CI_AS LIKE '%" + txtSearch.Text + "%'";

                            using (SqlCommand command = new SqlCommand(sql, conn))
                            {
                                dataAdapter.SelectCommand = command;
                                dataAdapter.Fill(ds, "Confectionary_Item");

                                dgvConItems.DataSource = ds;
                                dgvConItems.DataMember = "Confectionary_Item";
                            }
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        

       

        private void dgvConItems_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvConItems.Rows.Count)
            {
                // the name of the item clicked is saved into the item variable
                item = dgvConItems.Rows[e.RowIndex].Cells["Confectionary_Name"].Value.ToString();
            }
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // receives the amount the user wants to order
            amount = (int)nudAmount.Value;

            lbItems.Visible = true;
            lblDelete.Visible = true;
            lblEdit.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            int available = 0;

            // sql statement that retrieves the available stock for the selected item

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = $"SELECT Confectionary_Stock FROM Confectionary_Item WHERE Confectionary_Name = '{item}'";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    available = (int)command.ExecuteScalar();
                }
            }

            // checks to see that the amount requested does not exceed the available stock
            if (amount > available)
            {
                MessageBox.Show("The amount you have requested exceeds that for which we have stock, stock available: " + available.ToString());
                return;
            }



            // calls the method to add the item and the amount to the linked list
            list.AddItem(item, amount);

            // adds the selected item and quantity to the listbox
            lbItems.Items.Add(item + " x " + amount.ToString());


            //list.ShowListInMessageBox();
        }

        private void btnProceed_Click_2(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        string sql = "UPDATE Confectionary_Item SET Confectionary_Stock = Confectionary_Stock - @Amount WHERE Confectionary_Name = @Item";
                        using (SqlCommand command = new SqlCommand(sql, conn))
                        {
                            // adds parameters to the command
                            command.Parameters.Add("@Amount", SqlDbType.Int);
                            command.Parameters.Add("@Item", SqlDbType.VarChar);

                            var current = list.Head;
                            while (current != null)
                            {
                                /*command.Parameters.AddWithValue("@Amount", current.Amount);
                                command.Parameters.AddWithValue("@Item", current.Item);
                                command.ExecuteNonQuery();*/

                                // Sets the parameter values
                                command.Parameters["@Amount"].Value = current.Amount;
                                command.Parameters["@Item"].Value = current.Item;

                                //update statement is executed
                                command.ExecuteNonQuery();

                                // moves to the next node
                                current = current.Next;

                            }
                        }
                    }

                    list.Head = null;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                displayDB();
                lbItems.Items.Clear();

            }

            MessageBox.Show("Thank you for your purchase!");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            tempItem = lbItems.SelectedItem.ToString();

            try
            {
                //splits the selected item into their respective parts (item and amount)

                var parts = tempItem.Split(new[] { " x " }, StringSplitOptions.None);
                var item = parts[0];
                var ampount = int.Parse(parts[1]);

                // remove function is called
                list.RemoveItem(item);


                lbItems.Items.Clear();


                // loop through the linkedlist and displays its contents
                var current = list.Head;
                while (current != null)
                {
                    lbItems.Items.Add(current.Item + " x " + current.Amount.ToString());
                    current = current.Next;
                }

            }
            catch
            {
                MessageBox.Show("Please select an item!");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // receive the selected item from the listbox
            tempItem = lbItems.SelectedItem.ToString();




            // try catch to ensure the user selects an item to edit
            try
            {
                // splits the selected item into their respective parts (item and amount)

                var parts = tempItem.Split(new[] { " x " }, StringSplitOptions.None);
                var item = parts[0];
                var ampount = int.Parse(parts[1]);

                // new value to be inserted into the list
                tempAmount = (int)nudAmount.Value;

                // edit method is called
                list.editAmount(item, tempAmount);

                // listbox is cleared in order to display the updated list
                lbItems.Items.Clear();

                // loop through the linkedlist and displays its contents
                var current = list.Head;


                while (current != null)
                {
                    lbItems.Items.Add(current.Item + " x " + current.Amount.ToString());
                    current = current.Next;
                }
            }
            catch
            {
                MessageBox.Show("Please select an item");
            }
        }
    }
}
