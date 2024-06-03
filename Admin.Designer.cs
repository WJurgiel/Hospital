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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AddDoctorPanel = new System.Windows.Forms.Panel();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.DocSpecComboBox = new System.Windows.Forms.ComboBox();
            this.DocPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DocLoginTextBox = new System.Windows.Forms.TextBox();
            this.DocSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DocNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddPatientPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.AddDoctorPanel.SuspendLayout();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, -2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddDoctorPanel);
            this.splitContainer1.Panel2.Controls.Add(this.AddPatientPanel);
            this.splitContainer1.Size = new System.Drawing.Size(799, 450);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 4;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.Location = new System.Drawing.Point(10, 372);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(131, 75);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AddDoctorPanel
            // 
            this.AddDoctorPanel.Controls.Add(this.AddDoctorButton);
            this.AddDoctorPanel.Controls.Add(this.DocSpecComboBox);
            this.AddDoctorPanel.Controls.Add(this.DocPasswordTextBox);
            this.AddDoctorPanel.Controls.Add(this.DocLoginTextBox);
            this.AddDoctorPanel.Controls.Add(this.DocSurnameTextBox);
            this.AddDoctorPanel.Controls.Add(this.label17);
            this.AddDoctorPanel.Controls.Add(this.label16);
            this.AddDoctorPanel.Controls.Add(this.label15);
            this.AddDoctorPanel.Controls.Add(this.label14);
            this.AddDoctorPanel.Controls.Add(this.label13);
            this.AddDoctorPanel.Controls.Add(this.DocNameTextBox);
            this.AddDoctorPanel.Controls.Add(this.label12);
            this.AddDoctorPanel.Location = new System.Drawing.Point(0, 0);
            this.AddDoctorPanel.Name = "AddDoctorPanel";
            this.AddDoctorPanel.Size = new System.Drawing.Size(652, 447);
            this.AddDoctorPanel.TabIndex = 20;
            this.AddDoctorPanel.Visible = false;
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDoctorButton.Location = new System.Drawing.Point(218, 324);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(177, 58);
            this.AddDoctorButton.TabIndex = 31;
            this.AddDoctorButton.Text = "Dodaj Lekarza";
            this.AddDoctorButton.UseVisualStyleBackColor = true;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // DocSpecComboBox
            // 
            this.DocSpecComboBox.FormattingEnabled = true;
            this.DocSpecComboBox.Location = new System.Drawing.Point(170, 190);
            this.DocSpecComboBox.Name = "DocSpecComboBox";
            this.DocSpecComboBox.Size = new System.Drawing.Size(189, 23);
            this.DocSpecComboBox.TabIndex = 30;
            // 
            // DocPasswordTextBox
            // 
            this.DocPasswordTextBox.Location = new System.Drawing.Point(104, 266);
            this.DocPasswordTextBox.Name = "DocPasswordTextBox";
            this.DocPasswordTextBox.Size = new System.Drawing.Size(189, 23);
            this.DocPasswordTextBox.TabIndex = 29;
            // 
            // DocLoginTextBox
            // 
            this.DocLoginTextBox.Location = new System.Drawing.Point(104, 227);
            this.DocLoginTextBox.Name = "DocLoginTextBox";
            this.DocLoginTextBox.Size = new System.Drawing.Size(189, 23);
            this.DocLoginTextBox.TabIndex = 28;
            // 
            // DocSurnameTextBox
            // 
            this.DocSurnameTextBox.Location = new System.Drawing.Point(141, 146);
            this.DocSurnameTextBox.Name = "DocSurnameTextBox";
            this.DocSurnameTextBox.Size = new System.Drawing.Size(189, 23);
            this.DocSurnameTextBox.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(29, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 30);
            this.label17.TabIndex = 26;
            this.label17.Text = "Hasło:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(29, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 30);
            this.label16.TabIndex = 25;
            this.label16.Text = "Login:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(29, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 30);
            this.label15.TabIndex = 24;
            this.label15.Text = "Specjalizacja:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(29, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 30);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nazwisko:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(29, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "Imię:";
            // 
            // DocNameTextBox
            // 
            this.DocNameTextBox.Location = new System.Drawing.Point(93, 108);
            this.DocNameTextBox.Name = "DocNameTextBox";
            this.DocNameTextBox.Size = new System.Drawing.Size(189, 23);
            this.DocNameTextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(29, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "Dodaj nowego lekarza";
            // 
            // AddPatientPanel
            // 
            this.AddPatientPanel.Controls.Add(this.label11);
            this.AddPatientPanel.Controls.Add(this.PasswordTextBox);
            this.AddPatientPanel.Controls.Add(this.label10);
            this.AddPatientPanel.Controls.Add(this.LoginTextbox);
            this.AddPatientPanel.Controls.Add(this.label9);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 30);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dodaj nowego pacjenta";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(104, 318);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(189, 23);
            this.PasswordTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hasło:";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(104, 289);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(189, 23);
            this.LoginTextbox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "Login:";
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPatientButton.Location = new System.Drawing.Point(210, 358);
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
            this.DoctorComboBox.Location = new System.Drawing.Point(104, 259);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(189, 23);
            this.DoctorComboBox.TabIndex = 13;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(176, 226);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 23);
            this.DatePicker.TabIndex = 12;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(280, 193);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(189, 23);
            this.PhoneNumberTextBox.TabIndex = 11;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Location = new System.Drawing.Point(196, 164);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(189, 23);
            this.PeselTextBox.TabIndex = 10;
            // 
            // IllnessComboBox
            // 
            this.IllnessComboBox.FormattingEnabled = true;
            this.IllnessComboBox.Location = new System.Drawing.Point(196, 130);
            this.IllnessComboBox.Name = "IllnessComboBox";
            this.IllnessComboBox.Size = new System.Drawing.Size(189, 23);
            this.IllnessComboBox.TabIndex = 9;
            this.IllnessComboBox.SelectedIndexChanged += new System.EventHandler(this.IllnessComboBox_SelectedIndexChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(196, 100);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(189, 23);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(196, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(189, 23);
            this.NameTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nr telefonu osoby bliskiej:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lekarz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "PESEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Przyjęcia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Schorzenie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nazwisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 64);
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
            this.AddDoctorPanel.ResumeLayout(false);
            this.AddDoctorPanel.PerformLayout();
            this.AddPatientPanel.ResumeLayout(false);
            this.AddPatientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
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
        private TextBox LoginTextbox;
        private Label label9;
        private TextBox PasswordTextBox;
        private Label label10;
        private Label label11;
        private Button LogoutButton;
        private Panel AddDoctorPanel;
        private TextBox DocPasswordTextBox;
        private TextBox DocLoginTextBox;
        private TextBox DocSurnameTextBox;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox DocNameTextBox;
        private Label label12;
        private Button AddDoctorButton;
        private ComboBox DocSpecComboBox;
    }
}