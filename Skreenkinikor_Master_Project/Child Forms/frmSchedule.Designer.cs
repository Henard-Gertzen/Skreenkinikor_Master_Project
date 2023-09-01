namespace Skreenkinikor_Master_Project
{
    partial class frmSchedule
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdoFirstShow = new System.Windows.Forms.RadioButton();
            this.rdoSeccondSHow = new System.Windows.Forms.RadioButton();
            this.rdoThirdShow = new System.Windows.Forms.RadioButton();
            this.rdoFourthShow = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // rdoFirstShow
            // 
            this.rdoFirstShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFirstShow.AutoSize = true;
            this.rdoFirstShow.Location = new System.Drawing.Point(10, 11);
            this.rdoFirstShow.Name = "rdoFirstShow";
            this.rdoFirstShow.Size = new System.Drawing.Size(57, 23);
            this.rdoFirstShow.TabIndex = 1;
            this.rdoFirstShow.TabStop = true;
            this.rdoFirstShow.Text = "First Slot";
            this.rdoFirstShow.UseVisualStyleBackColor = true;
            // 
            // rdoSeccondSHow
            // 
            this.rdoSeccondSHow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSeccondSHow.AutoSize = true;
            this.rdoSeccondSHow.Location = new System.Drawing.Point(73, 11);
            this.rdoSeccondSHow.Name = "rdoSeccondSHow";
            this.rdoSeccondSHow.Size = new System.Drawing.Size(81, 23);
            this.rdoSeccondSHow.TabIndex = 2;
            this.rdoSeccondSHow.TabStop = true;
            this.rdoSeccondSHow.Text = "Seccond Slot";
            this.rdoSeccondSHow.UseVisualStyleBackColor = true;
            // 
            // rdoThirdShow
            // 
            this.rdoThirdShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoThirdShow.AutoSize = true;
            this.rdoThirdShow.Location = new System.Drawing.Point(160, 11);
            this.rdoThirdShow.Name = "rdoThirdShow";
            this.rdoThirdShow.Size = new System.Drawing.Size(62, 23);
            this.rdoThirdShow.TabIndex = 3;
            this.rdoThirdShow.TabStop = true;
            this.rdoThirdShow.Text = "Third Slot";
            this.rdoThirdShow.UseVisualStyleBackColor = true;
            // 
            // rdoFourthShow
            // 
            this.rdoFourthShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFourthShow.AutoSize = true;
            this.rdoFourthShow.Location = new System.Drawing.Point(228, 11);
            this.rdoFourthShow.Name = "rdoFourthShow";
            this.rdoFourthShow.Size = new System.Drawing.Size(68, 23);
            this.rdoFourthShow.TabIndex = 4;
            this.rdoFourthShow.TabStop = true;
            this.rdoFourthShow.Text = "Fourth Slot";
            this.rdoFourthShow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.rdoFourthShow);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rdoFirstShow);
            this.panel1.Controls.Add(this.rdoThirdShow);
            this.panel1.Controls.Add(this.rdoSeccondSHow);
            this.panel1.Location = new System.Drawing.Point(17, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 102);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(195, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 166);
            this.panel2.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(124, 14);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 52);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(43, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 52);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(237, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 149);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.btnConfirm);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Location = new System.Drawing.Point(20, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 83);
            this.panel4.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 13);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Select Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Finalise Schedule";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdoFirstShow;
        private System.Windows.Forms.RadioButton rdoSeccondSHow;
        private System.Windows.Forms.RadioButton rdoThirdShow;
        private System.Windows.Forms.RadioButton rdoFourthShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}