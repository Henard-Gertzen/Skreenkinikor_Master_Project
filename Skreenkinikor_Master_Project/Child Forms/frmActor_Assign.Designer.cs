namespace Skreenkinikor_Master_Project.Child_Forms
{
    partial class frmActor_Assign
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.cmbActors = new System.Windows.Forms.ComboBox();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(114, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "&Assign";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.ForeColor = System.Drawing.Color.White;
            this.lblActor.Location = new System.Drawing.Point(9, 37);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(37, 13);
            this.lblActor.TabIndex = 18;
            this.lblActor.Text = "Actors";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.ForeColor = System.Drawing.Color.White;
            this.lblMovies.Location = new System.Drawing.Point(177, 37);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(41, 13);
            this.lblMovies.TabIndex = 19;
            this.lblMovies.Text = "Movies";
            // 
            // cmbActors
            // 
            this.cmbActors.FormattingEnabled = true;
            this.cmbActors.Location = new System.Drawing.Point(12, 53);
            this.cmbActors.Name = "cmbActors";
            this.cmbActors.Size = new System.Drawing.Size(121, 21);
            this.cmbActors.TabIndex = 20;
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(180, 53);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(121, 21);
            this.cmbMovies.TabIndex = 21;
            // 
            // frmActor_Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(312, 182);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.cmbActors);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActor_Assign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActor_Assign";
            this.Load += new System.EventHandler(this.frmActor_Assign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.ComboBox cmbActors;
        private System.Windows.Forms.ComboBox cmbMovies;
    }
}