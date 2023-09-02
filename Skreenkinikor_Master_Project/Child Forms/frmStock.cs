﻿using FontAwesome.Sharp;
using Skreenkinikor_Master_Project.Child_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skreenkinikor_Master_Project
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        //variables
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter ad;
        DataSet ds;
        readonly string conStr = Classes.ConnectionStrings.conSkreenMainStr;

        string selectedItemStockName = null;
        string selectedItemTypeName = null;

        int modifyOrAddItem , modifyOrAddType;
        //end of variables

        ///////////custom methods////////////////

        //method repopulates datagridview
        private void populateGridStock(DataGridView grid, string sql)
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful connection to database.");
            }

            ad = new SqlDataAdapter();
            ds = new DataSet();

            com = new SqlCommand(sql, con);
            ad.SelectCommand = com;
            ad.Fill(ds, "SourceTable");

            grid.DataSource = ds;
            grid.DataMember = "SourceTable";

            con.Close();
        }
        //delete/insert commands
        private void sqlCmdMethod(string sql)
        {
            try
            {
                con = new SqlConnection(conStr);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
            con.Close();
        }
        //method to populate combobox
        public void populateCombo(ComboBox cmbo, string Sql, string thingtodisplay, string table)
        {
            try
            {
                con = new SqlConnection(conStr);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com = new SqlCommand(Sql, con);

                ad = new SqlDataAdapter();
                ad.SelectCommand = com;

                DataSet ds = new DataSet();

                ad.Fill(ds, table);

                cmbo.DataSource = ds.Tables[table];
                cmbo.DisplayMember = thingtodisplay;
                cmbo.ValueMember = thingtodisplay;
                

                con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }
        //returns int value for confectionary type assignment
        public string returnSingleDatabaseValue(string sql)
        {
            string returnValue = "";
            try
            {
                con = new SqlConnection(conStr);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                com = new SqlCommand(sql, con);
                returnValue = com.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
            return returnValue;
        }

        ////////////end of custom methods/////////////////////
        private void frmStock_Load(object sender, EventArgs e)
        {
            //populates gridview in item tab, assigns correct type to correct name
            string sqlJoinStatement = "SELECT Confectionary_Item.Confectionary_Name,Confectionary_Item.Confectionary_Price,Confectionary_Item.Confectionary_Stock, Confectionary_Item_Type.Confectionary_Type_Name from Confectionary_Item inner join Confectionary_Item_Type ON Confectionary_Item.Confectionary_Type_ID=Confectionary_Item_Type.Confectionary_Type_ID";
            populateGridStock(gridDisplayStock, sqlJoinStatement);

            //populates gridview in type tab
            populateGridStock(gridDisplayType, "SELECT Confectionary_Type_Name, Confectionary_Type_Desc FROM ScreenKinikor.dbo.Confectionary_Item_Type");

            //initial deletion button and label visibility
            btnConfirmItemRemoval.Visible = false;
            btnConfirmTypeRemoval.Visible = false;
            btnCancelTypeRemoval.Visible = false;
            btnStockCancelRemoval.Visible = false;
            lblConfirmDeleteStock.Visible = false;
            lblConfirmDeleteType.Visible = false;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            //brings panel to front, changes label text
            panelType.BringToFront();
            lblTypeDescription.Text = "Currently ADDING NEW item Type.";
        }

        private void btnRemoveType_Click(object sender, EventArgs e)
        {

            //ensures that item is selected
            if (selectedItemTypeName == null)
            {
                MessageBox.Show("Please select an item to delete.");
            }
            else
            {
                //control visibility
                btnConfirmTypeRemoval.Visible = true;
                btnCancelTypeRemoval.Visible = true;
                lblConfirmDeleteType.Visible = true;
            }

        }

        private void btnModifyType_Click(object sender, EventArgs e)
        {
            if (selectedItemTypeName == null)
            {
                MessageBox.Show("Please select an item to modify.");
            }
            else
            {
                //checks if modifying or adding new, brings panel to front and changes label text
                modifyOrAddType = 1;
                panelType.BringToFront();
                lblTypeDescription.Text = "Currently MODIFYING " + selectedItemTypeName + ", please enter the new information.";
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            //brings panel to front, changes label text
            panelItem.BringToFront();
            lblDescriptionItem.Text = "Currently ADDING NEW item.";
            populateCombo(cmboItemType, "SELECT Confectionary_Type_Name FROM ScreenKinikor.dbo.Confectionary_Item_Type", "Confectionary_Type_Name", "ScreenKinikor.dbo.Confectionary_Item_Type");
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            //ensures that item is selected
            if(selectedItemStockName == null)
            {
                MessageBox.Show("Please select an item to delete.");
            }
            else
            {
                //control visibility
                btnConfirmItemRemoval.Visible = true;
                btnStockCancelRemoval.Visible = true;
                lblConfirmDeleteStock.Visible = true;
            }
        }

        private void btnModifyStock_Click(object sender, EventArgs e)
        {
            if (selectedItemStockName == null)
            {
                MessageBox.Show("Please select an item to modify.");
            }
            else
            {
                //checks if modifying or deleting, brings panel to front and changes label text
                modifyOrAddItem = 1;
                panelItem.BringToFront();
                lblDescriptionItem.Text = "Currently MODIFYING " + selectedItemStockName + ", please enter the new information.";
                populateCombo(cmboItemType, "SELECT Confectionary_Type_Name FROM ScreenKinikor.dbo.Confectionary_Item_Type", "Confectionary_Type_Name", "ScreenKinikor.dbo.Confectionary_Item_Type");
            }
        }

        private void txtSearchStock_TextChanged(object sender, EventArgs e)
        {
            //filters stock items by name
            populateGridStock(gridDisplayStock, "SELECT Confectionary_Item.Confectionary_Name,Confectionary_Item.Confectionary_Price,Confectionary_Item.Confectionary_Stock, Confectionary_Item_Type.Confectionary_Type_Name from Confectionary_Item inner join Confectionary_Item_Type ON Confectionary_Item.Confectionary_Type_ID=Confectionary_Item_Type.Confectionary_Type_ID WHERE Confectionary_Item.Confectionary_Name LIKE '%" + txtSearchStock.Text + "%' OR Confectionary_Item_Type.Confectionary_Type_Name LIKE '%" + txtSearchStock.Text + "%'");
        }
        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            //filters stock types by name
            populateGridStock(gridDisplayType, "SELECT Confectionary_Type_Name, Confectionary_Type_Desc FROM ScreenKinikor.dbo.Confectionary_Item_Type WHERE Confectionary_Type_Name LIKE '%" + txtSearchType.Text + "%'");
        }

        private void btnConfirmItemRemoval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item "+selectedItemStockName +" successfuly removed from database.");
            btnStockCancelRemoval.Visible = false;
            lblConfirmDeleteStock.Visible = false;
            btnConfirmItemRemoval.Visible = false;
            gridDisplayStock.ClearSelection();
            

            //removes item once confirmed and repopulates
            sqlCmdMethod("DELETE FROM ScreenKinikor.dbo.Confectionary_Item WHERE Confectionary_Name = '" + selectedItemStockName + "'");
            populateGridStock(gridDisplayStock, "SELECT Confectionary_Item.Confectionary_Name,Confectionary_Item.Confectionary_Price,Confectionary_Item.Confectionary_Stock, Confectionary_Item_Type.Confectionary_Type_Name from Confectionary_Item inner join Confectionary_Item_Type ON Confectionary_Item.Confectionary_Type_ID=Confectionary_Item_Type.Confectionary_Type_ID");
            selectedItemStockName = null;
        }

        private void btnConfirmTypeRemoval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item "+selectedItemTypeName+" successfully removed from database.");

            //resets selection
            btnConfirmTypeRemoval.Visible = false;
            btnCancelTypeRemoval.Visible = false;
            lblConfirmDeleteType.Visible = false;
            gridDisplayType.ClearSelection();

            //removes item once confirmed and repopulates
            sqlCmdMethod("DELETE FROM ScreenKinikor.dbo.Confectionary_Item_Type WHERE Confectionary_Type_Name = '" + selectedItemTypeName + "'");
            populateGridStock(gridDisplayType, "SELECT Confectionary_Type_Name, Confectionary_Type_Desc FROM ScreenKinikor.dbo.Confectionary_Item_Type");
            selectedItemTypeName = null;
        }

        private void btnStockCancelRemoval_Click(object sender, EventArgs e)
        {
            //control visibility
            btnStockCancelRemoval.Visible = false;
            lblConfirmDeleteStock.Visible = false;
            btnConfirmItemRemoval.Visible = false;

            //resets grid selection and item assignment
            gridDisplayStock.ClearSelection();
            selectedItemStockName = null;
        }

        private void btnCancelTypeRemoval_Click(object sender, EventArgs e)
        {
            //control visibility
            btnConfirmTypeRemoval.Visible = false;
            btnCancelTypeRemoval.Visible = false;
            lblConfirmDeleteType.Visible = false;

            //resets grid selection and item assignment
            gridDisplayType.ClearSelection();
            selectedItemTypeName = null;
        }

        private void gridDisplayStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears initial selection in gridview
            gridDisplayStock.ClearSelection();
            selectedItemStockName = null;
        }

        private void gridDisplayType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears initial selection in gridview
            gridDisplayType.ClearSelection();
            selectedItemTypeName = null;
        }

        private void gridDisplayStock_SelectionChanged(object sender, EventArgs e)
        {
            //checks if cell if selected and inputs selected cell name value into string
            if (gridDisplayStock.SelectedCells.Count > 0)
            {
                int rowIndex = gridDisplayStock.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridDisplayStock.Rows[rowIndex];
                selectedItemStockName = (selectedRow.Cells["Confectionary_Name"].Value.ToString());

                //sets visibility if selected cell changes
                btnStockCancelRemoval.Visible = false;
                lblConfirmDeleteStock.Visible = false;
                btnConfirmItemRemoval.Visible = false;
            }
        }

        private void btnConfirmItem_Click(object sender, EventArgs e)
        {
            btnFinalConfirmationItem.Visible = true;
            btnConfirmItem.Enabled = false;
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            //cancels operation, clears textboxes
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemStock.Clear();
            panelMain.BringToFront();

            modifyOrAddItem = 2;
            btnConfirmItem.Enabled = true;
            btnFinalConfirmationItem.Visible = false;
        }

        private void btnFinalConfirmationItem_Click(object sender, EventArgs e)
        {

            int stockAmount; decimal price;
            string itemName = txtItemName.Text;

            //input numerical validation
            if (int.TryParse(txtItemStock.Text, out stockAmount) && decimal.TryParse(txtItemPrice.Text, out price))
            {
                if (modifyOrAddItem == 1)
                {
                    //RETURNS COMBOBOX VALUE AS STRING
                    DataRowView oDataRowView = cmboItemType.SelectedItem as DataRowView;
                    string ConfectionaryTypeID = string.Empty;
                    if (oDataRowView != null)
                    {
                        ConfectionaryTypeID = oDataRowView.Row["Confectionary_Type_Name"] as string;
                    }
                    string typeID = returnSingleDatabaseValue("SELECT Confectionary_Type_ID FROM ScreenKinikor.dbo.Confectionary_Item_Type WHERE Confectionary_Type_Name = '" + ConfectionaryTypeID + "' ");

                    //update method for items
                    sqlCmdMethod("UPDATE ScreenKinikor.dbo.Confectionary_Item SET Confectionary_Type_ID='" + Convert.ToInt32(typeID) + "' ,Confectionary_Name = '" + itemName + "', Confectionary_Price ='" + price + "', Confectionary_Stock='" + stockAmount + "' WHERE Confectionary_Name = '" + selectedItemStockName + "'");
                }
                else
                {
                    //RETURNS COMBOBOX VALUE AS STRING
                    DataRowView oDataRowView = cmboItemType.SelectedItem as DataRowView;
                    string ConfectionaryTypeID = string.Empty;
                    if (oDataRowView != null)
                    {
                        ConfectionaryTypeID = oDataRowView.Row["Confectionary_Type_Name"] as string;
                    }
                    string typeID = returnSingleDatabaseValue("SELECT Confectionary_Type_ID FROM ScreenKinikor.dbo.Confectionary_Item_Type WHERE Confectionary_Type_Name = '" + ConfectionaryTypeID + "' ");

                    sqlCmdMethod("INSERT INTO ScreenKinikor.dbo.Confectionary_Item(Confectionary_Type_ID,Confectionary_Name,Confectionary_Price,Confectionary_Stock) VALUES('" + Convert.ToInt32(typeID) + "','" + itemName + "','" + price + "','" + stockAmount + "')");
                }

                populateGridStock(gridDisplayStock, "SELECT Confectionary_Item.Confectionary_Name,Confectionary_Item.Confectionary_Price,Confectionary_Item.Confectionary_Stock, Confectionary_Item_Type.Confectionary_Type_Name from Confectionary_Item inner join Confectionary_Item_Type ON Confectionary_Item.Confectionary_Type_ID=Confectionary_Item_Type.Confectionary_Type_ID");
                modifyOrAddItem = 2;
                panelMain.BringToFront();
                btnFinalConfirmationItem.Visible = false;

                //clears textboxes and error provider
                txtItemName.Clear();
                txtItemPrice.Clear();
                txtItemStock.Clear();

                errorProviderItem.SetError(txtItemStock, "");
                errorProviderType.SetError(txtItemPrice, "");

                //reactives button
                btnConfirmItem.Enabled = true;
            }
            else
            {
                //sets errors if incorrect numericals
                errorProviderItem.SetError(txtItemStock,"Please enter an Integer Value");
                errorProviderType.SetError(txtItemPrice, "Please enter any numerical value");
            }
        }

        private void btnConfirmType_Click(object sender, EventArgs e)
        {
            //deactivates button and makes final confirmation visible
           btnFinalConfirmation.Visible = true;
            btnConfirmType.Enabled = false;
        }

        private void btnFinalConfirmation_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            string typeDesc = txtTypeDescription.Text;

            //if modified option selected, else do other
            if (modifyOrAddType == 1)
            {
                sqlCmdMethod("UPDATE ScreenKinikor.dbo.Confectionary_Item_Type SET Confectionary_Type_Name='"+typeName+"' ,Confectionary_Type_Desc = '" +typeDesc+"' WHERE Confectionary_Type_Name = '"+selectedItemTypeName+"'");
                MessageBox.Show("Successfully updated item: " + selectedItemTypeName);
            }
            else
            {
                sqlCmdMethod("INSERT INTO ScreenKinikor.dbo.Confectionary_Item_Type(Confectionary_Type_Name,Confectionary_Type_Desc) VALUES('"+typeName+"','"+typeDesc+"')");
                MessageBox.Show("Successfully inserted " + typeName + " into database");
            }

            //repopulates gridbox, brings panel to front and sets checker int
            populateGridStock(gridDisplayType, "SELECT Confectionary_Type_Name, Confectionary_Type_Desc FROM ScreenKinikor.dbo.Confectionary_Item_Type");
            modifyOrAddType = 2;
            panelMain.BringToFront();

            //clears textboxes
            txtTypeName.Clear();
            txtTypeDescription.Clear();

            btnFinalConfirmation.Visible = false;
            btnConfirmType.Enabled = true;

        }

        private void btnCancelType_Click(object sender, EventArgs e)
        {
            //cancels operation, clears textboxes
            txtTypeName.Clear();
            txtTypeDescription.Clear();
            panelMain.BringToFront();

            modifyOrAddType = 2;
            btnFinalConfirmation.Visible = false;
            btnConfirmType.Enabled = true;
        }

        //ignore cant remove
        private void panelItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridDisplayType_SelectionChanged(object sender, EventArgs e)
        {
            //checks if a cell is selected and inputs selected cell name value into string
            if (gridDisplayType.SelectedCells.Count > 0)
            {
                int rowIndex = gridDisplayType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridDisplayType.Rows[rowIndex];
                selectedItemTypeName = (selectedRow.Cells["Confectionary_Type_Name"].Value.ToString());

                //sets visibility if selected cell changes
                btnConfirmTypeRemoval.Visible = false;
                btnCancelTypeRemoval.Visible = false;
                lblConfirmDeleteType.Visible = false;
            }
        }
    }
}
