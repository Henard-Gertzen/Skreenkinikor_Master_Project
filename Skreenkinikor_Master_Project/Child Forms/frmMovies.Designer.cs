namespace Skreenkinikor_Master_Project
{
    partial class frmMovies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMoviePrice = new System.Windows.Forms.TextBox();
            this.txtMovieDesc = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeColumns = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.dgvMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMovies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovies.EnableHeadersVisualStyles = false;
            this.dgvMovies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Name = "dgvMovies";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 35;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(686, 366);
            this.dgvMovies.TabIndex = 7;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellClick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.txtMoviePrice);
            this.pnlEdit.Controls.Add(this.txtMovieDesc);
            this.pnlEdit.Controls.Add(this.txtMovieName);
            this.pnlEdit.Location = new System.Drawing.Point(197, 428);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(280, 127);
            this.pnlEdit.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seat Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(17, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Movie Name:";
            // 
            // txtMoviePrice
            // 
            this.txtMoviePrice.Location = new System.Drawing.Point(142, 87);
            this.txtMoviePrice.Name = "txtMoviePrice";
            this.txtMoviePrice.Size = new System.Drawing.Size(100, 20);
            this.txtMoviePrice.TabIndex = 2;
            // 
            // txtMovieDesc
            // 
            this.txtMovieDesc.Location = new System.Drawing.Point(142, 47);
            this.txtMovieDesc.Name = "txtMovieDesc";
            this.txtMovieDesc.Size = new System.Drawing.Size(100, 20);
            this.txtMovieDesc.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(142, 10);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(100, 20);
            this.txtMovieName.TabIndex = 0;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.Location = new System.Drawing.Point(12, 372);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(123, 50);
            this.btnAddMovie.TabIndex = 12;
            this.btnAddMovie.Text = "&Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEditMovie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMovie.ForeColor = System.Drawing.Color.White;
            this.btnEditMovie.Location = new System.Drawing.Point(271, 372);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(123, 50);
            this.btnEditMovie.TabIndex = 13;
            this.btnEditMovie.Text = "&Edit Movie";
            this.btnEditMovie.UseVisualStyleBackColor = false;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnRemoveMovie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMovie.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMovie.Location = new System.Drawing.Point(551, 372);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(123, 50);
            this.btnRemoveMovie.TabIndex = 14;
            this.btnRemoveMovie.Text = "&Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = false;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click_1);
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(686, 644);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.dgvMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovies";
            this.Text = "frmMovies";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox txtMoviePrice;
        private System.Windows.Forms.TextBox txtMovieDesc;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
    }
}