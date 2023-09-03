namespace Skreenkinikor_Master_Project
{
    partial class frmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridDisplayStock = new System.Windows.Forms.DataGridView();
            this.lblConfirmDeleteStock = new System.Windows.Forms.Label();
            this.btnStockCancelRemoval = new System.Windows.Forms.Button();
            this.btnConfirmItemRemoval = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnModifyStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtSearchStock = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridDisplayType = new System.Windows.Forms.DataGridView();
            this.btnCancelTypeRemoval = new System.Windows.Forms.Button();
            this.lblConfirmDeleteType = new System.Windows.Forms.Label();
            this.btnConfirmTypeRemoval = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModifyType = new System.Windows.Forms.Button();
            this.btnRemoveType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.panelType = new System.Windows.Forms.Panel();
            this.grpTypeChange = new System.Windows.Forms.GroupBox();
            this.btnConfirmType = new System.Windows.Forms.Button();
            this.btnCancelType = new System.Windows.Forms.Button();
            this.btnFinalConfirmation = new System.Windows.Forms.Button();
            this.txtTypeDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemStock = new System.Windows.Forms.TextBox();
            this.cmboItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnFinalConfirmationItem = new System.Windows.Forms.Button();
            this.panelItem = new System.Windows.Forms.Panel();
            this.grpItemChange = new System.Windows.Forms.GroupBox();
            this.errorProviderItem = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.tabControlStock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayStock)).BeginInit();
            this.gbTools.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelType.SuspendLayout();
            this.grpTypeChange.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.grpItemChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelMain.Controls.Add(this.tabControlStock);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(682, 671);
            this.panelMain.TabIndex = 1;
            // 
            // tabControlStock
            // 
            this.tabControlStock.Controls.Add(this.tabPage1);
            this.tabControlStock.Controls.Add(this.tabPage2);
            this.tabControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStock.Location = new System.Drawing.Point(0, 0);
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.Size = new System.Drawing.Size(682, 671);
            this.tabControlStock.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.tabPage1.Controls.Add(this.gridDisplayStock);
            this.tabPage1.Controls.Add(this.lblConfirmDeleteStock);
            this.tabPage1.Controls.Add(this.btnStockCancelRemoval);
            this.tabPage1.Controls.Add(this.btnConfirmItemRemoval);
            this.tabPage1.Controls.Add(this.gbTools);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Item Stock";
            // 
            // gridDisplayStock
            // 
            this.gridDisplayStock.AllowUserToAddRows = false;
            this.gridDisplayStock.AllowUserToDeleteRows = false;
            this.gridDisplayStock.AllowUserToResizeColumns = false;
            this.gridDisplayStock.AllowUserToResizeRows = false;
            this.gridDisplayStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDisplayStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.gridDisplayStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDisplayStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDisplayStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDisplayStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDisplayStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDisplayStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDisplayStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDisplayStock.EnableHeadersVisualStyles = false;
            this.gridDisplayStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.gridDisplayStock.Location = new System.Drawing.Point(1, 0);
            this.gridDisplayStock.Name = "gridDisplayStock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDisplayStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDisplayStock.RowHeadersVisible = false;
            this.gridDisplayStock.RowTemplate.Height = 35;
            this.gridDisplayStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDisplayStock.Size = new System.Drawing.Size(677, 399);
            this.gridDisplayStock.TabIndex = 13;
            this.gridDisplayStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridDisplayStock_DataBindingComplete);
            this.gridDisplayStock.SelectionChanged += new System.EventHandler(this.gridDisplayStock_SelectionChanged);
            // 
            // lblConfirmDeleteStock
            // 
            this.lblConfirmDeleteStock.AutoSize = true;
            this.lblConfirmDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.lblConfirmDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmDeleteStock.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblConfirmDeleteStock.Location = new System.Drawing.Point(182, 539);
            this.lblConfirmDeleteStock.Name = "lblConfirmDeleteStock";
            this.lblConfirmDeleteStock.Size = new System.Drawing.Size(133, 17);
            this.lblConfirmDeleteStock.TabIndex = 12;
            this.lblConfirmDeleteStock.Text = "[confirmationtext]";
            // 
            // btnStockCancelRemoval
            // 
            this.btnStockCancelRemoval.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStockCancelRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnStockCancelRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockCancelRemoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockCancelRemoval.ForeColor = System.Drawing.Color.White;
            this.btnStockCancelRemoval.Location = new System.Drawing.Point(347, 594);
            this.btnStockCancelRemoval.Name = "btnStockCancelRemoval";
            this.btnStockCancelRemoval.Size = new System.Drawing.Size(324, 48);
            this.btnStockCancelRemoval.TabIndex = 6;
            this.btnStockCancelRemoval.Text = "CANCEL ITEM REMOVAL";
            this.btnStockCancelRemoval.UseVisualStyleBackColor = false;
            this.btnStockCancelRemoval.Click += new System.EventHandler(this.btnStockCancelRemoval_Click);
            // 
            // btnConfirmItemRemoval
            // 
            this.btnConfirmItemRemoval.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmItemRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnConfirmItemRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmItemRemoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmItemRemoval.ForeColor = System.Drawing.Color.White;
            this.btnConfirmItemRemoval.Location = new System.Drawing.Point(3, 594);
            this.btnConfirmItemRemoval.Name = "btnConfirmItemRemoval";
            this.btnConfirmItemRemoval.Size = new System.Drawing.Size(324, 48);
            this.btnConfirmItemRemoval.TabIndex = 5;
            this.btnConfirmItemRemoval.Text = "CONFIRM ITEM REMOVAL";
            this.btnConfirmItemRemoval.UseVisualStyleBackColor = false;
            this.btnConfirmItemRemoval.Click += new System.EventHandler(this.btnConfirmItemRemoval_Click);
            // 
            // gbTools
            // 
            this.gbTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTools.Controls.Add(this.btnModifyStock);
            this.gbTools.Controls.Add(this.btnRemoveStock);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Controls.Add(this.btnAddStock);
            this.gbTools.Controls.Add(this.txtSearchStock);
            this.gbTools.ForeColor = System.Drawing.Color.White;
            this.gbTools.Location = new System.Drawing.Point(109, 407);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(475, 122);
            this.gbTools.TabIndex = 7;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // btnModifyStock
            // 
            this.btnModifyStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnModifyStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyStock.Location = new System.Drawing.Point(152, 33);
            this.btnModifyStock.Name = "btnModifyStock";
            this.btnModifyStock.Size = new System.Drawing.Size(75, 69);
            this.btnModifyStock.TabIndex = 3;
            this.btnModifyStock.Text = "Modify Item";
            this.btnModifyStock.UseVisualStyleBackColor = false;
            this.btnModifyStock.Click += new System.EventHandler(this.btnModifyStock_Click);
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStock.Location = new System.Drawing.Point(79, 33);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(75, 69);
            this.btnRemoveStock.TabIndex = 2;
            this.btnRemoveStock.Text = "Remove";
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by Name/Type:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(6, 33);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 69);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Add Item";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // txtSearchStock
            // 
            this.txtSearchStock.Location = new System.Drawing.Point(281, 58);
            this.txtSearchStock.Name = "txtSearchStock";
            this.txtSearchStock.Size = new System.Drawing.Size(188, 20);
            this.txtSearchStock.TabIndex = 4;
            this.txtSearchStock.TextChanged += new System.EventHandler(this.txtSearchStock_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.tabPage2.Controls.Add(this.gridDisplayType);
            this.tabPage2.Controls.Add(this.btnCancelTypeRemoval);
            this.tabPage2.Controls.Add(this.lblConfirmDeleteType);
            this.tabPage2.Controls.Add(this.btnConfirmTypeRemoval);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Item Types";
            // 
            // gridDisplayType
            // 
            this.gridDisplayType.AllowUserToAddRows = false;
            this.gridDisplayType.AllowUserToDeleteRows = false;
            this.gridDisplayType.AllowUserToResizeColumns = false;
            this.gridDisplayType.AllowUserToResizeRows = false;
            this.gridDisplayType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDisplayType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.gridDisplayType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDisplayType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDisplayType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDisplayType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDisplayType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDisplayType.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridDisplayType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDisplayType.EnableHeadersVisualStyles = false;
            this.gridDisplayType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.gridDisplayType.Location = new System.Drawing.Point(1, 0);
            this.gridDisplayType.Name = "gridDisplayType";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDisplayType.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDisplayType.RowHeadersVisible = false;
            this.gridDisplayType.RowTemplate.Height = 35;
            this.gridDisplayType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDisplayType.Size = new System.Drawing.Size(677, 399);
            this.gridDisplayType.TabIndex = 14;
            this.gridDisplayType.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridDisplayType_DataBindingComplete);
            this.gridDisplayType.SelectionChanged += new System.EventHandler(this.gridDisplayType_SelectionChanged);
            // 
            // btnCancelTypeRemoval
            // 
            this.btnCancelTypeRemoval.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelTypeRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnCancelTypeRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTypeRemoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTypeRemoval.ForeColor = System.Drawing.Color.White;
            this.btnCancelTypeRemoval.Location = new System.Drawing.Point(347, 594);
            this.btnCancelTypeRemoval.Name = "btnCancelTypeRemoval";
            this.btnCancelTypeRemoval.Size = new System.Drawing.Size(324, 48);
            this.btnCancelTypeRemoval.TabIndex = 6;
            this.btnCancelTypeRemoval.Text = "CANCEL TYPE REMOVAL";
            this.btnCancelTypeRemoval.UseVisualStyleBackColor = false;
            this.btnCancelTypeRemoval.Click += new System.EventHandler(this.btnCancelTypeRemoval_Click);
            // 
            // lblConfirmDeleteType
            // 
            this.lblConfirmDeleteType.AutoSize = true;
            this.lblConfirmDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmDeleteType.ForeColor = System.Drawing.Color.White;
            this.lblConfirmDeleteType.Location = new System.Drawing.Point(182, 539);
            this.lblConfirmDeleteType.Name = "lblConfirmDeleteType";
            this.lblConfirmDeleteType.Size = new System.Drawing.Size(138, 17);
            this.lblConfirmDeleteType.TabIndex = 11;
            this.lblConfirmDeleteType.Text = "[confirmationText]";
            // 
            // btnConfirmTypeRemoval
            // 
            this.btnConfirmTypeRemoval.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmTypeRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnConfirmTypeRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTypeRemoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmTypeRemoval.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTypeRemoval.Location = new System.Drawing.Point(3, 594);
            this.btnConfirmTypeRemoval.Name = "btnConfirmTypeRemoval";
            this.btnConfirmTypeRemoval.Size = new System.Drawing.Size(324, 48);
            this.btnConfirmTypeRemoval.TabIndex = 5;
            this.btnConfirmTypeRemoval.Text = "CONFIRM TYPE REMOVAL";
            this.btnConfirmTypeRemoval.UseVisualStyleBackColor = false;
            this.btnConfirmTypeRemoval.Click += new System.EventHandler(this.btnConfirmTypeRemoval_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnModifyType);
            this.groupBox1.Controls.Add(this.btnRemoveType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.txtSearchType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(109, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btnModifyType
            // 
            this.btnModifyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnModifyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyType.Location = new System.Drawing.Point(152, 33);
            this.btnModifyType.Name = "btnModifyType";
            this.btnModifyType.Size = new System.Drawing.Size(75, 69);
            this.btnModifyType.TabIndex = 3;
            this.btnModifyType.Text = "Modify Type";
            this.btnModifyType.UseVisualStyleBackColor = false;
            this.btnModifyType.Click += new System.EventHandler(this.btnModifyType_Click);
            // 
            // btnRemoveType
            // 
            this.btnRemoveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnRemoveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveType.Location = new System.Drawing.Point(79, 33);
            this.btnRemoveType.Name = "btnRemoveType";
            this.btnRemoveType.Size = new System.Drawing.Size(75, 69);
            this.btnRemoveType.TabIndex = 2;
            this.btnRemoveType.Text = "Remove";
            this.btnRemoveType.UseVisualStyleBackColor = false;
            this.btnRemoveType.Click += new System.EventHandler(this.btnRemoveType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by Type Name:";
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Location = new System.Drawing.Point(6, 33);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 69);
            this.btnAddType.TabIndex = 1;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(281, 58);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(188, 20);
            this.txtSearchType.TabIndex = 4;
            this.txtSearchType.TextChanged += new System.EventHandler(this.txtSearchType_TextChanged);
            // 
            // panelType
            // 
            this.panelType.Controls.Add(this.grpTypeChange);
            this.panelType.Location = new System.Drawing.Point(0, 0);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(682, 671);
            this.panelType.TabIndex = 2;
            // 
            // grpTypeChange
            // 
            this.grpTypeChange.Controls.Add(this.btnConfirmType);
            this.grpTypeChange.Controls.Add(this.btnCancelType);
            this.grpTypeChange.Controls.Add(this.btnFinalConfirmation);
            this.grpTypeChange.Controls.Add(this.txtTypeDescription);
            this.grpTypeChange.Controls.Add(this.label7);
            this.grpTypeChange.Controls.Add(this.label8);
            this.grpTypeChange.Controls.Add(this.txtTypeName);
            this.grpTypeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpTypeChange.ForeColor = System.Drawing.Color.White;
            this.grpTypeChange.Location = new System.Drawing.Point(117, 78);
            this.grpTypeChange.Name = "grpTypeChange";
            this.grpTypeChange.Size = new System.Drawing.Size(447, 518);
            this.grpTypeChange.TabIndex = 9;
            this.grpTypeChange.TabStop = false;
            this.grpTypeChange.Text = "[text]";
            // 
            // btnConfirmType
            // 
            this.btnConfirmType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmType.ForeColor = System.Drawing.Color.White;
            this.btnConfirmType.Location = new System.Drawing.Point(86, 297);
            this.btnConfirmType.Name = "btnConfirmType";
            this.btnConfirmType.Size = new System.Drawing.Size(139, 46);
            this.btnConfirmType.TabIndex = 2;
            this.btnConfirmType.Text = "Confirm Changes";
            this.btnConfirmType.UseVisualStyleBackColor = true;
            this.btnConfirmType.Click += new System.EventHandler(this.btnConfirmType_Click);
            // 
            // btnCancelType
            // 
            this.btnCancelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelType.ForeColor = System.Drawing.Color.White;
            this.btnCancelType.Location = new System.Drawing.Point(225, 297);
            this.btnCancelType.Name = "btnCancelType";
            this.btnCancelType.Size = new System.Drawing.Size(139, 46);
            this.btnCancelType.TabIndex = 3;
            this.btnCancelType.Text = "Cancel Editing";
            this.btnCancelType.UseVisualStyleBackColor = true;
            this.btnCancelType.Click += new System.EventHandler(this.btnCancelType_Click);
            // 
            // btnFinalConfirmation
            // 
            this.btnFinalConfirmation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinalConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnFinalConfirmation.Location = new System.Drawing.Point(159, 343);
            this.btnFinalConfirmation.Name = "btnFinalConfirmation";
            this.btnFinalConfirmation.Size = new System.Drawing.Size(132, 73);
            this.btnFinalConfirmation.TabIndex = 4;
            this.btnFinalConfirmation.Text = "FINAL CONFIRMATION AND FINISH";
            this.btnFinalConfirmation.UseVisualStyleBackColor = true;
            this.btnFinalConfirmation.Visible = false;
            this.btnFinalConfirmation.Click += new System.EventHandler(this.btnFinalConfirmation_Click);
            // 
            // txtTypeDescription
            // 
            this.txtTypeDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTypeDescription.Location = new System.Drawing.Point(184, 152);
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(208, 96);
            this.txtTypeDescription.TabIndex = 1;
            this.txtTypeDescription.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Confectionary Type Name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Confectionary Type Description";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTypeName.Location = new System.Drawing.Point(184, 104);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(208, 22);
            this.txtTypeName.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItemName.Location = new System.Drawing.Point(250, 84);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(119, 22);
            this.txtItemName.TabIndex = 0;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItemPrice.Location = new System.Drawing.Point(250, 134);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(119, 22);
            this.txtItemPrice.TabIndex = 1;
            // 
            // txtItemStock
            // 
            this.txtItemStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItemStock.Location = new System.Drawing.Point(250, 183);
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(119, 22);
            this.txtItemStock.TabIndex = 2;
            // 
            // cmboItemType
            // 
            this.cmboItemType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmboItemType.FormattingEnabled = true;
            this.cmboItemType.Location = new System.Drawing.Point(250, 230);
            this.cmboItemType.MaxDropDownItems = 20;
            this.cmboItemType.Name = "cmboItemType";
            this.cmboItemType.Size = new System.Drawing.Size(121, 24);
            this.cmboItemType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(163, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Item Stock";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(163, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item Type";
            // 
            // btnConfirmItem
            // 
            this.btnConfirmItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmItem.ForeColor = System.Drawing.Color.White;
            this.btnConfirmItem.Location = new System.Drawing.Point(133, 344);
            this.btnConfirmItem.Name = "btnConfirmItem";
            this.btnConfirmItem.Size = new System.Drawing.Size(139, 46);
            this.btnConfirmItem.TabIndex = 8;
            this.btnConfirmItem.Text = "Confirm Changes";
            this.btnConfirmItem.UseVisualStyleBackColor = true;
            this.btnConfirmItem.Click += new System.EventHandler(this.btnConfirmItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Location = new System.Drawing.Point(272, 344);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(139, 46);
            this.btnCancelItem.TabIndex = 9;
            this.btnCancelItem.Text = "Cancel Changes";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnFinalConfirmationItem
            // 
            this.btnFinalConfirmationItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinalConfirmationItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalConfirmationItem.ForeColor = System.Drawing.Color.White;
            this.btnFinalConfirmationItem.Location = new System.Drawing.Point(170, 390);
            this.btnFinalConfirmationItem.Name = "btnFinalConfirmationItem";
            this.btnFinalConfirmationItem.Size = new System.Drawing.Size(208, 89);
            this.btnFinalConfirmationItem.TabIndex = 10;
            this.btnFinalConfirmationItem.Text = ">FINISH FINAL CONFIRMATION<";
            this.btnFinalConfirmationItem.UseVisualStyleBackColor = true;
            this.btnFinalConfirmationItem.Visible = false;
            this.btnFinalConfirmationItem.Click += new System.EventHandler(this.btnFinalConfirmationItem_Click);
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.grpItemChange);
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(682, 671);
            this.panelItem.TabIndex = 1;
            // 
            // grpItemChange
            // 
            this.grpItemChange.Controls.Add(this.txtItemName);
            this.grpItemChange.Controls.Add(this.btnConfirmItem);
            this.grpItemChange.Controls.Add(this.cmboItemType);
            this.grpItemChange.Controls.Add(this.btnFinalConfirmationItem);
            this.grpItemChange.Controls.Add(this.label6);
            this.grpItemChange.Controls.Add(this.label5);
            this.grpItemChange.Controls.Add(this.txtItemStock);
            this.grpItemChange.Controls.Add(this.txtItemPrice);
            this.grpItemChange.Controls.Add(this.label3);
            this.grpItemChange.Controls.Add(this.label4);
            this.grpItemChange.Controls.Add(this.btnCancelItem);
            this.grpItemChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItemChange.ForeColor = System.Drawing.Color.White;
            this.grpItemChange.Location = new System.Drawing.Point(65, 46);
            this.grpItemChange.Name = "grpItemChange";
            this.grpItemChange.Size = new System.Drawing.Size(552, 558);
            this.grpItemChange.TabIndex = 12;
            this.grpItemChange.TabStop = false;
            this.grpItemChange.Text = "groupBox3";
            // 
            // errorProviderItem
            // 
            this.errorProviderItem.ContainerControl = this;
            // 
            // errorProviderType
            // 
            this.errorProviderType.ContainerControl = this;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(682, 671);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControlStock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayStock)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplayType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.grpTypeChange.ResumeLayout(false);
            this.grpTypeChange.PerformLayout();
            this.panelItem.ResumeLayout(false);
            this.grpItemChange.ResumeLayout(false);
            this.grpItemChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblConfirmDeleteStock;
        private System.Windows.Forms.Button btnStockCancelRemoval;
        private System.Windows.Forms.Button btnConfirmItemRemoval;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button btnModifyStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtSearchStock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelTypeRemoval;
        private System.Windows.Forms.Label lblConfirmDeleteType;
        private System.Windows.Forms.Button btnConfirmTypeRemoval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifyType;
        private System.Windows.Forms.Button btnRemoveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtSearchType;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnFinalConfirmation;
        private System.Windows.Forms.Button btnCancelType;
        private System.Windows.Forms.Button btnConfirmType;
        private System.Windows.Forms.RichTextBox txtTypeDescription;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Button btnFinalConfirmationItem;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnConfirmItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboItemType;
        private System.Windows.Forms.TextBox txtItemStock;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ErrorProvider errorProviderItem;
        private System.Windows.Forms.DataGridView gridDisplayStock;
        private System.Windows.Forms.DataGridView gridDisplayType;
        private System.Windows.Forms.GroupBox grpTypeChange;
        private System.Windows.Forms.GroupBox grpItemChange;
        private System.Windows.Forms.ErrorProvider errorProviderType;
    }
}