namespace Hospital
{
    partial class Doktor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.InformationsPanelButton = new System.Windows.Forms.Button();
            this.PatientsPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PrescriptionButton = new System.Windows.Forms.Button();
            this.DiagnoseButton = new System.Windows.Forms.Button();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.PatientCountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PatientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.PatientsButton);
            this.splitContainer1.Panel1.Controls.Add(this.InformationsPanelButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PatientsPanel);
            this.splitContainer1.Panel2.Controls.Add(this.InformationPanel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Opinie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(12, 393);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(124, 45);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Location = new System.Drawing.Point(12, 63);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(124, 45);
            this.PatientsButton.TabIndex = 1;
            this.PatientsButton.Text = "Pacjenci";
            this.PatientsButton.UseVisualStyleBackColor = true;
            this.PatientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // InformationsPanelButton
            // 
            this.InformationsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationsPanelButton.Location = new System.Drawing.Point(12, 12);
            this.InformationsPanelButton.Name = "InformationsPanelButton";
            this.InformationsPanelButton.Size = new System.Drawing.Size(124, 45);
            this.InformationsPanelButton.TabIndex = 0;
            this.InformationsPanelButton.Text = "Informacje";
            this.InformationsPanelButton.UseVisualStyleBackColor = true;
            this.InformationsPanelButton.Click += new System.EventHandler(this.InformationsPanelButton_Click);
            // 
            // PatientsPanel
            // 
            this.PatientsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PatientsPanel.Controls.Add(this.label7);
            this.PatientsPanel.Controls.Add(this.button2);
            this.PatientsPanel.Controls.Add(this.PrescriptionButton);
            this.PatientsPanel.Controls.Add(this.DiagnoseButton);
            this.PatientsPanel.Controls.Add(this.PatientsGrid);
            this.PatientsPanel.Location = new System.Drawing.Point(0, 0);
            this.PatientsPanel.Name = "PatientsPanel";
            this.PatientsPanel.Size = new System.Drawing.Size(655, 450);
            this.PatientsPanel.TabIndex = 0;
            this.PatientsPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(204, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 47);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lista Pacjentów";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(396, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wypisz Pacjenta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrescriptionButton
            // 
            this.PrescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PrescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrescriptionButton.Location = new System.Drawing.Point(258, 401);
            this.PrescriptionButton.Name = "PrescriptionButton";
            this.PrescriptionButton.Size = new System.Drawing.Size(132, 29);
            this.PrescriptionButton.TabIndex = 2;
            this.PrescriptionButton.Text = "Przypisz Lek";
            this.PrescriptionButton.UseVisualStyleBackColor = false;
            this.PrescriptionButton.Click += new System.EventHandler(this.PrescriptionButton_Click);
            // 
            // DiagnoseButton
            // 
            this.DiagnoseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DiagnoseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiagnoseButton.Location = new System.Drawing.Point(120, 401);
            this.DiagnoseButton.Name = "DiagnoseButton";
            this.DiagnoseButton.Size = new System.Drawing.Size(132, 29);
            this.DiagnoseButton.TabIndex = 1;
            this.DiagnoseButton.Text = "Postaw Diagnozę";
            this.DiagnoseButton.UseVisualStyleBackColor = false;
            this.DiagnoseButton.Click += new System.EventHandler(this.DiagnoseButton_Click);
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(22, 63);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowTemplate.Height = 25;
            this.PatientsGrid.Size = new System.Drawing.Size(614, 322);
            this.PatientsGrid.TabIndex = 0;
            // 
            // InformationPanel
            // 
            this.InformationPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InformationPanel.Controls.Add(this.label3);
            this.InformationPanel.Controls.Add(this.label4);
            this.InformationPanel.Controls.Add(this.label5);
            this.InformationPanel.Controls.Add(this.label6);
            this.InformationPanel.Controls.Add(this.NameLabel);
            this.InformationPanel.Controls.Add(this.SurnameLabel);
            this.InformationPanel.Controls.Add(this.SpecializationLabel);
            this.InformationPanel.Controls.Add(this.PatientCountLabel);
            this.InformationPanel.Controls.Add(this.label8);
            this.InformationPanel.Controls.Add(this.IdLabel);
            this.InformationPanel.Location = new System.Drawing.Point(22, 138);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(617, 277);
            this.InformationPanel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imię:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nazwisko:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specjalizacja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Liczba pacjentów:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(123, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 50);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "X";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(213, 108);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(42, 50);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Y";
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.AutoSize = true;
            this.SpecializationLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationLabel.Location = new System.Drawing.Point(268, 158);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(43, 50);
            this.SpecializationLabel.TabIndex = 8;
            this.SpecializationLabel.Text = "Z";
            // 
            // PatientCountLabel
            // 
            this.PatientCountLabel.AutoSize = true;
            this.PatientCountLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientCountLabel.Location = new System.Drawing.Point(343, 208);
            this.PatientCountLabel.Name = "PatientCountLabel";
            this.PatientCountLabel.Size = new System.Drawing.Size(57, 50);
            this.PatientCountLabel.TabIndex = 9;
            this.PatientCountLabel.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 50);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nr ewidencyjny:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(304, 14);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(57, 50);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "zalogowano jako doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "WITAJ";
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PatientsPanel.ResumeLayout(false);
            this.PatientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button PatientsButton;
        private Button InformationsPanelButton;
        private Button LogoutButton;
        private Label label2;
        private Label label1;
        private Panel PatientsPanel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label SurnameLabel;
        private Label NameLabel;
        private Label PatientCountLabel;
        private Label SpecializationLabel;
        private Label label7;
        private Label IdLabel;
        private Label label8;
        private Panel InformationPanel;
        private Button button1;
        private Button DiagnoseButton;
        private DataGridView PatientsGrid;
        private Button button2;
        private Button PrescriptionButton;
    }
}