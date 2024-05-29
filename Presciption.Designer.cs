namespace Hospital
{
    partial class Presciption
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
            this.DrugsGrid = new System.Windows.Forms.DataGridView();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.DrugNameLabel = new System.Windows.Forms.Label();
            this.DrugProducentLabel = new System.Windows.Forms.Label();
            this.AddPrescriptionButton = new System.Windows.Forms.Button();
            this.UseDueLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SwitchCalendarButton = new System.Windows.Forms.Button();
            this.CallendarPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DrugsGrid)).BeginInit();
            this.CallendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrugsGrid
            // 
            this.DrugsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugsGrid.Location = new System.Drawing.Point(12, 46);
            this.DrugsGrid.Name = "DrugsGrid";
            this.DrugsGrid.RowTemplate.Height = 25;
            this.DrugsGrid.Size = new System.Drawing.Size(347, 340);
            this.DrugsGrid.TabIndex = 0;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLabel.Location = new System.Drawing.Point(401, 76);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(253, 47);
            this.PatientNameLabel.TabIndex = 1;
            this.PatientNameLabel.Text = "Imie i nazwisko";
            // 
            // DrugNameLabel
            // 
            this.DrugNameLabel.AutoSize = true;
            this.DrugNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrugNameLabel.Location = new System.Drawing.Point(482, 147);
            this.DrugNameLabel.Name = "DrugNameLabel";
            this.DrugNameLabel.Size = new System.Drawing.Size(71, 47);
            this.DrugNameLabel.TabIndex = 2;
            this.DrugNameLabel.Text = "Lek";
            // 
            // DrugProducentLabel
            // 
            this.DrugProducentLabel.AutoSize = true;
            this.DrugProducentLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrugProducentLabel.Location = new System.Drawing.Point(428, 194);
            this.DrugProducentLabel.Name = "DrugProducentLabel";
            this.DrugProducentLabel.Size = new System.Drawing.Size(180, 47);
            this.DrugProducentLabel.TabIndex = 3;
            this.DrugProducentLabel.Text = "Producent";
            // 
            // AddPrescriptionButton
            // 
            this.AddPrescriptionButton.Location = new System.Drawing.Point(482, 307);
            this.AddPrescriptionButton.Name = "AddPrescriptionButton";
            this.AddPrescriptionButton.Size = new System.Drawing.Size(105, 53);
            this.AddPrescriptionButton.TabIndex = 4;
            this.AddPrescriptionButton.Text = "Wypisz receptę";
            this.AddPrescriptionButton.UseVisualStyleBackColor = true;
            // 
            // UseDueLabel
            // 
            this.UseDueLabel.AutoSize = true;
            this.UseDueLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UseDueLabel.Location = new System.Drawing.Point(390, 241);
            this.UseDueLabel.Name = "UseDueLabel";
            this.UseDueLabel.Size = new System.Drawing.Size(218, 47);
            this.UseDueLabel.TabIndex = 5;
            this.UseDueLabel.Text = "Stosować do";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // SwitchCalendarButton
            // 
            this.SwitchCalendarButton.Location = new System.Drawing.Point(614, 254);
            this.SwitchCalendarButton.Name = "SwitchCalendarButton";
            this.SwitchCalendarButton.Size = new System.Drawing.Size(23, 23);
            this.SwitchCalendarButton.TabIndex = 7;
            this.SwitchCalendarButton.Text = "...";
            this.SwitchCalendarButton.UseVisualStyleBackColor = true;
            // 
            // CallendarPanel
            // 
            this.CallendarPanel.Controls.Add(this.monthCalendar1);
            this.CallendarPanel.Location = new System.Drawing.Point(33, 94);
            this.CallendarPanel.Name = "CallendarPanel";
            this.CallendarPanel.Size = new System.Drawing.Size(293, 183);
            this.CallendarPanel.TabIndex = 8;
            this.CallendarPanel.Visible = false;
            // 
            // Presciption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 398);
            this.Controls.Add(this.CallendarPanel);
            this.Controls.Add(this.SwitchCalendarButton);
            this.Controls.Add(this.UseDueLabel);
            this.Controls.Add(this.AddPrescriptionButton);
            this.Controls.Add(this.DrugProducentLabel);
            this.Controls.Add(this.DrugNameLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.DrugsGrid);
            this.Name = "Presciption";
            this.Text = "Presciption";
            ((System.ComponentModel.ISupportInitialize)(this.DrugsGrid)).EndInit();
            this.CallendarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DrugsGrid;
        private Label PatientNameLabel;
        private Label DrugNameLabel;
        private Label DrugProducentLabel;
        private Button AddPrescriptionButton;
        private Label UseDueLabel;
        private MonthCalendar monthCalendar1;
        private Button SwitchCalendarButton;
        private Panel CallendarPanel;
    }
}