namespace Hospital
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddPatientPanel = new System.Windows.Forms.Panel();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.IllnessComboBox = new System.Windows.Forms.ComboBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AddPatientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj Administratorze";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj nowego pacjenta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(10, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj nowego lekarza";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(10, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dodaj nowy lek";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, -2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddPatientPanel);
            this.splitContainer1.Size = new System.Drawing.Size(799, 450);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 4;
            // 
            // AddPatientPanel
            // 
            this.AddPatientPanel.Controls.Add(this.AddPatientButton);
            this.AddPatientPanel.Controls.Add(this.DoctorComboBox);
            this.AddPatientPanel.Controls.Add(this.DatePicker);
            this.AddPatientPanel.Controls.Add(this.PhoneNumberTextBox);
            this.AddPatientPanel.Controls.Add(this.PeselTextBox);
            this.AddPatientPanel.Controls.Add(this.IllnessComboBox);
            this.AddPatientPanel.Controls.Add(this.SurnameTextBox);
            this.AddPatientPanel.Controls.Add(this.NameTextBox);
            this.AddPatientPanel.Controls.Add(this.label8);
            this.AddPatientPanel.Controls.Add(this.label7);
            this.AddPatientPanel.Controls.Add(this.label6);
            this.AddPatientPanel.Controls.Add(this.label5);
            this.AddPatientPanel.Controls.Add(this.label4);
            this.AddPatientPanel.Controls.Add(this.label3);
            this.AddPatientPanel.Controls.Add(this.label2);
            this.AddPatientPanel.Location = new System.Drawing.Point(8, 6);
            this.AddPatientPanel.Name = "AddPatientPanel";
            this.AddPatientPanel.Size = new System.Drawing.Size(640, 444);
            this.AddPatientPanel.TabIndex = 0;
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPatientButton.Location = new System.Drawing.Point(210, 356);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(177, 58);
            this.AddPatientButton.TabIndex = 14;
            this.AddPatientButton.Text = "Dodaj Pacjenta";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(106, 312);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(189, 23);
            this.DoctorComboBox.TabIndex = 13;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(178, 279);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 23);
            this.DatePicker.TabIndex = 12;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(282, 246);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(189, 23);
            this.PhoneNumberTextBox.TabIndex = 11;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Location = new System.Drawing.Point(198, 217);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(189, 23);
            this.PeselTextBox.TabIndex = 10;
            // 
            // IllnessComboBox
            // 
            this.IllnessComboBox.FormattingEnabled = true;
            this.IllnessComboBox.Location = new System.Drawing.Point(198, 183);
            this.IllnessComboBox.Name = "IllnessComboBox";
            this.IllnessComboBox.Size = new System.Drawing.Size(189, 23);
            this.IllnessComboBox.TabIndex = 9;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(198, 153);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(189, 23);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(198, 117);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(189, 23);
            this.NameTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nr telefonu osoby bliskiej:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lekarz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "PESEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Przyjęcia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Schorzenie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nazwisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Imie:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AddPatientPanel.ResumeLayout(false);
            this.AddPatientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private SplitContainer splitContainer1;
        private Panel AddPatientPanel;
        private Button AddPatientButton;
        private ComboBox DoctorComboBox;
        private DateTimePicker DatePicker;
        private TextBox PhoneNumberTextBox;
        private TextBox PeselTextBox;
        private ComboBox IllnessComboBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}