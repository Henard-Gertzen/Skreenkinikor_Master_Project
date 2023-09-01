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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 40);
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
            this.panel1.Controls.Add(this.rdoFourthShow);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rdoFirstShow);
            this.panel1.Controls.Add(this.rdoThirdShow);
            this.panel1.Controls.Add(this.rdoSeccondSHow);
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 70);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 106);
            this.panel2.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(713, 386);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 52);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}