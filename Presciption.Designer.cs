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
            this.MedicamentsGrid = new System.Windows.Forms.DataGridView();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.DrugNameLabel = new System.Windows.Forms.Label();
            this.DrugProducerLabel = new System.Windows.Forms.Label();
            this.AddPrescriptionButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SwitchCalendarButton = new System.Windows.Forms.Button();
            this.IllnessTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DueDataLabel = new System.Windows.Forms.Label();
            this.PrescribedGrid = new System.Windows.Forms.DataGridView();
            this.DeletePrescriptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescribedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicamentsGrid
            // 
            this.MedicamentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicamentsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MedicamentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicamentsGrid.Location = new System.Drawing.Point(3, 45);
            this.MedicamentsGrid.MultiSelect = false;
            this.MedicamentsGrid.Name = "MedicamentsGrid";
            this.MedicamentsGrid.RowHeadersWidth = 51;
            this.MedicamentsGrid.RowTemplate.Height = 25;
            this.MedicamentsGrid.Size = new System.Drawing.Size(235, 208);
            this.MedicamentsGrid.TabIndex = 0;
            this.MedicamentsGrid.SelectionChanged += new System.EventHandler(this.MedicamentsGrid_SelectionChanged);
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLabel.Location = new System.Drawing.Point(0, 0);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(758, 47);
            this.PatientNameLabel.TabIndex = 1;
            this.PatientNameLabel.Text = "Imie i nazwisko";
            this.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugNameLabel
            // 
            this.DrugNameLabel.AutoSize = true;
            this.DrugNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrugNameLabel.Location = new System.Drawing.Point(292, 106);
            this.DrugNameLabel.Name = "DrugNameLabel";
            this.DrugNameLabel.Size = new System.Drawing.Size(35, 20);
            this.DrugNameLabel.TabIndex = 2;
            this.DrugNameLabel.Text = "Lek";
            // 
            // DrugProducerLabel
            // 
            this.DrugProducerLabel.AutoSize = true;
            this.DrugProducerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrugProducerLabel.Location = new System.Drawing.Point(292, 136);
            this.DrugProducerLabel.Name = "DrugProducerLabel";
            this.DrugProducerLabel.Size = new System.Drawing.Size(82, 20);
            this.DrugProducerLabel.TabIndex = 3;
            this.DrugProducerLabel.Text = "Producent";
            // 
            // AddPrescriptionButton
            // 
            this.AddPrescriptionButton.Location = new System.Drawing.Point(309, 215);
            this.AddPrescriptionButton.Name = "AddPrescriptionButton";
            this.AddPrescriptionButton.Size = new System.Drawing.Size(104, 30);
            this.AddPrescriptionButton.TabIndex = 4;
            this.AddPrescriptionButton.Text = "Dodaj receptę";
            this.AddPrescriptionButton.UseVisualStyleBackColor = true;
            this.AddPrescriptionButton.Click += new System.EventHandler(this.AddPrescriptionButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(292, 166);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 20);
            this.label.TabIndex = 5;
            this.label.Text = "do:";
            // 
            // SwitchCalendarButton
            // 
            this.SwitchCalendarButton.Location = new System.Drawing.Point(263, 164);
            this.SwitchCalendarButton.Name = "SwitchCalendarButton";
            this.SwitchCalendarButton.Size = new System.Drawing.Size(23, 23);
            this.SwitchCalendarButton.TabIndex = 7;
            this.SwitchCalendarButton.Text = "🗓";
            this.SwitchCalendarButton.UseVisualStyleBackColor = true;
            this.SwitchCalendarButton.Click += new System.EventHandler(this.SwitchCalendarButton_Click);
            // 
            // IllnessTypeLabel
            // 
            this.IllnessTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IllnessTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IllnessTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.IllnessTypeLabel.Name = "IllnessTypeLabel";
            this.IllnessTypeLabel.Size = new System.Drawing.Size(241, 260);
            this.IllnessTypeLabel.TabIndex = 8;
            this.IllnessTypeLabel.Text = "Leki na problemy X";
            this.IllnessTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MedicamentsGrid);
            this.panel1.Controls.Add(this.IllnessTypeLabel);
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 260);
            this.panel1.TabIndex = 9;
            // 
            // DueDataLabel
            // 
            this.DueDataLabel.AutoSize = true;
            this.DueDataLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DueDataLabel.Location = new System.Drawing.Point(327, 166);
            this.DueDataLabel.Name = "DueDataLabel";
            this.DueDataLabel.Size = new System.Drawing.Size(0, 21);
            this.DueDataLabel.TabIndex = 10;
            // 
            // PrescribedGrid
            // 
            this.PrescribedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrescribedGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrescribedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescribedGrid.Location = new System.Drawing.Point(447, 95);
            this.PrescribedGrid.MultiSelect = false;
            this.PrescribedGrid.Name = "PrescribedGrid";
            this.PrescribedGrid.RowHeadersWidth = 51;
            this.PrescribedGrid.RowTemplate.Height = 25;
            this.PrescribedGrid.Size = new System.Drawing.Size(299, 208);
            this.PrescribedGrid.TabIndex = 9;
            // 
            // DeletePrescriptionButton
            // 
            this.DeletePrescriptionButton.Location = new System.Drawing.Point(309, 251);
            this.DeletePrescriptionButton.Name = "DeletePrescriptionButton";
            this.DeletePrescriptionButton.Size = new System.Drawing.Size(104, 30);
            this.DeletePrescriptionButton.TabIndex = 11;
            this.DeletePrescriptionButton.Text = "Usuń receptę";
            this.DeletePrescriptionButton.UseVisualStyleBackColor = true;
            this.DeletePrescriptionButton.Click += new System.EventHandler(this.DeletePrescriptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(516, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Przypisane leki";
            // 
            // Presciption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(758, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletePrescriptionButton);
            this.Controls.Add(this.PrescribedGrid);
            this.Controls.Add(this.DueDataLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SwitchCalendarButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AddPrescriptionButton);
            this.Controls.Add(this.DrugProducerLabel);
            this.Controls.Add(this.DrugNameLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Presciption";
            this.Text = "Presciption";
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrescribedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView MedicamentsGrid;
        private Label PatientNameLabel;
        private Label DrugNameLabel;
        private Label DrugProducerLabel;
        private Button AddPrescriptionButton;
        private Label label;
        private Button SwitchCalendarButton;
        private Label IllnessTypeLabel;
        private Panel panel1;
        private Label DueDataLabel;
        private DataGridView PrescribedGrid;
        private Button DeletePrescriptionButton;
        private Label label1;
    }
}