namespace Hospital
{
    partial class Patient
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
            this.ReviewButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.PrescriptionsButton = new System.Windows.Forms.Button();
            this.InformationsPanelButton = new System.Windows.Forms.Button();
            this.PatientDoctorAsignedLabel = new System.Windows.Forms.Label();
            this.PatientDiagnoseLabel = new System.Windows.Forms.Label();
            this.PatientRelativeNumberLabel = new System.Windows.Forms.Label();
            this.PatientSurnameLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ReviewButton);
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.PrescriptionsButton);
            this.splitContainer1.Panel1.Controls.Add(this.InformationsPanelButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.PatientDoctorAsignedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PatientDiagnoseLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PatientRelativeNumberLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PatientSurnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PatientNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // ReviewButton
            // 
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Location = new System.Drawing.Point(12, 114);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(124, 45);
            this.ReviewButton.TabIndex = 6;
            this.ReviewButton.Text = "Wystaw opinię";
            this.ReviewButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(12, 393);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(124, 45);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // PrescriptionsButton
            // 
            this.PrescriptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrescriptionsButton.Location = new System.Drawing.Point(12, 63);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(124, 45);
            this.PrescriptionsButton.TabIndex = 4;
            this.PrescriptionsButton.Text = "Twoje recepty";
            this.PrescriptionsButton.UseVisualStyleBackColor = true;
            // 
            // InformationsPanelButton
            // 
            this.InformationsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationsPanelButton.Location = new System.Drawing.Point(12, 12);
            this.InformationsPanelButton.Name = "InformationsPanelButton";
            this.InformationsPanelButton.Size = new System.Drawing.Size(124, 45);
            this.InformationsPanelButton.TabIndex = 1;
            this.InformationsPanelButton.Text = "Twoje dane";
            this.InformationsPanelButton.UseVisualStyleBackColor = true;
            // 
            // PatientDoctorAsignedLabel
            // 
            this.PatientDoctorAsignedLabel.AutoSize = true;
            this.PatientDoctorAsignedLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDoctorAsignedLabel.Location = new System.Drawing.Point(249, 317);
            this.PatientDoctorAsignedLabel.Name = "PatientDoctorAsignedLabel";
            this.PatientDoctorAsignedLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientDoctorAsignedLabel.TabIndex = 18;
            this.PatientDoctorAsignedLabel.Text = "--";
            // 
            // PatientDiagnoseLabel
            // 
            this.PatientDiagnoseLabel.AutoSize = true;
            this.PatientDiagnoseLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDiagnoseLabel.Location = new System.Drawing.Point(166, 272);
            this.PatientDiagnoseLabel.Name = "PatientDiagnoseLabel";
            this.PatientDiagnoseLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientDiagnoseLabel.TabIndex = 17;
            this.PatientDiagnoseLabel.Text = "--";
            // 
            // PatientRelativeNumberLabel
            // 
            this.PatientRelativeNumberLabel.AutoSize = true;
            this.PatientRelativeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientRelativeNumberLabel.Location = new System.Drawing.Point(284, 227);
            this.PatientRelativeNumberLabel.Name = "PatientRelativeNumberLabel";
            this.PatientRelativeNumberLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientRelativeNumberLabel.TabIndex = 16;
            this.PatientRelativeNumberLabel.Text = "--";
            // 
            // PatientSurnameLabel
            // 
            this.PatientSurnameLabel.AutoSize = true;
            this.PatientSurnameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSurnameLabel.Location = new System.Drawing.Point(168, 182);
            this.PatientSurnameLabel.Name = "PatientSurnameLabel";
            this.PatientSurnameLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientSurnameLabel.TabIndex = 15;
            this.PatientSurnameLabel.Text = "--";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLabel.Location = new System.Drawing.Point(96, 137);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientNameLabel.TabIndex = 14;
            this.PatientNameLabel.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 45);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lekarz opiekun:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diagnoza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nr. Bliskiej osoby:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(144, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zalogowano jako pacjent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Witaj";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button InformationsPanelButton;
        private Button ReviewButton;
        private Button LogoutButton;
        private Button PrescriptionsButton;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label PatientNameLabel;
        private Label PatientDoctorAsignedLabel;
        private Label PatientDiagnoseLabel;
        private Label PatientRelativeNumberLabel;
        private Label PatientSurnameLabel;
    }
}