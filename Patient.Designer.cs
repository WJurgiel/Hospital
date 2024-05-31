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
            this.ThanksForOpinionPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RatingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Rating_5_Button = new System.Windows.Forms.Button();
            this.SendOpinionButton = new System.Windows.Forms.Button();
            this.AnonymousRB = new System.Windows.Forms.RadioButton();
            this.NotAnonymousRB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Rating_4_Button = new System.Windows.Forms.Button();
            this.Rating_3_Button = new System.Windows.Forms.Button();
            this.Rating_2_Button = new System.Windows.Forms.Button();
            this.Rating_1_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.RichTextBox();
            this.YourPrescriptionsPanel = new System.Windows.Forms.Panel();
            this.PrescriptionsCountLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.YourPrescriptionsGrid = new System.Windows.Forms.DataGridView();
            this.PatientPeselLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.ThanksForOpinionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RatingPanel.SuspendLayout();
            this.YourPrescriptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourPrescriptionsGrid)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.ThanksForOpinionPanel);
            this.splitContainer1.Panel2.Controls.Add(this.RatingPanel);
            this.splitContainer1.Panel2.Controls.Add(this.YourPrescriptionsPanel);
            this.splitContainer1.Panel2.Controls.Add(this.PatientPeselLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
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
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
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
            this.PrescriptionsButton.Click += new System.EventHandler(this.PrescriptionsButton_Click);
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
            this.InformationsPanelButton.Click += new System.EventHandler(this.InformationsPanelButton_Click);
            // 
            // ThanksForOpinionPanel
            // 
            this.ThanksForOpinionPanel.BackColor = System.Drawing.Color.Aqua;
            this.ThanksForOpinionPanel.Controls.Add(this.pictureBox1);
            this.ThanksForOpinionPanel.Controls.Add(this.label14);
            this.ThanksForOpinionPanel.Location = new System.Drawing.Point(0, 0);
            this.ThanksForOpinionPanel.Name = "ThanksForOpinionPanel";
            this.ThanksForOpinionPanel.Size = new System.Drawing.Size(649, 450);
            this.ThanksForOpinionPanel.TabIndex = 15;
            this.ThanksForOpinionPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital.Properties.Resources.happy;
            this.pictureBox1.Location = new System.Drawing.Point(221, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(649, 450);
            this.label14.TabIndex = 0;
            this.label14.Text = "Dziękujemy za twój głos!";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingPanel
            // 
            this.RatingPanel.BackColor = System.Drawing.Color.Aqua;
            this.RatingPanel.Controls.Add(this.button1);
            this.RatingPanel.Controls.Add(this.Rating_5_Button);
            this.RatingPanel.Controls.Add(this.SendOpinionButton);
            this.RatingPanel.Controls.Add(this.AnonymousRB);
            this.RatingPanel.Controls.Add(this.NotAnonymousRB);
            this.RatingPanel.Controls.Add(this.label13);
            this.RatingPanel.Controls.Add(this.label12);
            this.RatingPanel.Controls.Add(this.Rating_4_Button);
            this.RatingPanel.Controls.Add(this.Rating_3_Button);
            this.RatingPanel.Controls.Add(this.Rating_2_Button);
            this.RatingPanel.Controls.Add(this.Rating_1_Button);
            this.RatingPanel.Controls.Add(this.label11);
            this.RatingPanel.Controls.Add(this.label8);
            this.RatingPanel.Controls.Add(this.CommentTextBox);
            this.RatingPanel.Location = new System.Drawing.Point(0, 0);
            this.RatingPanel.Name = "RatingPanel";
            this.RatingPanel.Size = new System.Drawing.Size(649, 450);
            this.RatingPanel.TabIndex = 10;
            this.RatingPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rating_5_Button
            // 
            this.Rating_5_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Rating_5_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating_5_Button.Location = new System.Drawing.Point(448, 101);
            this.Rating_5_Button.Name = "Rating_5_Button";
            this.Rating_5_Button.Size = new System.Drawing.Size(75, 58);
            this.Rating_5_Button.TabIndex = 13;
            this.Rating_5_Button.Text = "5";
            this.Rating_5_Button.UseVisualStyleBackColor = false;
            this.Rating_5_Button.Click += new System.EventHandler(this.Rating_5_Button_Click);
            // 
            // SendOpinionButton
            // 
            this.SendOpinionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendOpinionButton.Location = new System.Drawing.Point(433, 393);
            this.SendOpinionButton.Name = "SendOpinionButton";
            this.SendOpinionButton.Size = new System.Drawing.Size(151, 46);
            this.SendOpinionButton.TabIndex = 12;
            this.SendOpinionButton.Text = "Wyślij opinię";
            this.SendOpinionButton.UseVisualStyleBackColor = true;
            this.SendOpinionButton.Click += new System.EventHandler(this.SendOpinionButton_Click);
            // 
            // AnonymousRB
            // 
            this.AnonymousRB.AutoSize = true;
            this.AnonymousRB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnonymousRB.Location = new System.Drawing.Point(191, 405);
            this.AnonymousRB.Name = "AnonymousRB";
            this.AnonymousRB.Size = new System.Drawing.Size(41, 19);
            this.AnonymousRB.TabIndex = 11;
            this.AnonymousRB.TabStop = true;
            this.AnonymousRB.Text = "Tak";
            this.AnonymousRB.UseVisualStyleBackColor = true;
            // 
            // NotAnonymousRB
            // 
            this.NotAnonymousRB.AutoSize = true;
            this.NotAnonymousRB.Checked = true;
            this.NotAnonymousRB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotAnonymousRB.Location = new System.Drawing.Point(143, 405);
            this.NotAnonymousRB.Name = "NotAnonymousRB";
            this.NotAnonymousRB.Size = new System.Drawing.Size(42, 19);
            this.NotAnonymousRB.TabIndex = 10;
            this.NotAnonymousRB.TabStop = true;
            this.NotAnonymousRB.Text = "Nie";
            this.NotAnonymousRB.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Opinia anonimowa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Komentarz (opcjonalnie)";
            // 
            // Rating_4_Button
            // 
            this.Rating_4_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating_4_Button.Location = new System.Drawing.Point(367, 101);
            this.Rating_4_Button.Name = "Rating_4_Button";
            this.Rating_4_Button.Size = new System.Drawing.Size(75, 58);
            this.Rating_4_Button.TabIndex = 7;
            this.Rating_4_Button.Text = "4";
            this.Rating_4_Button.UseVisualStyleBackColor = true;
            this.Rating_4_Button.Click += new System.EventHandler(this.Rating_4_Button_Click);
            // 
            // Rating_3_Button
            // 
            this.Rating_3_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating_3_Button.Location = new System.Drawing.Point(286, 101);
            this.Rating_3_Button.Name = "Rating_3_Button";
            this.Rating_3_Button.Size = new System.Drawing.Size(75, 58);
            this.Rating_3_Button.TabIndex = 6;
            this.Rating_3_Button.Text = "3";
            this.Rating_3_Button.UseVisualStyleBackColor = true;
            this.Rating_3_Button.Click += new System.EventHandler(this.Rating_3_Button_Click);
            // 
            // Rating_2_Button
            // 
            this.Rating_2_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating_2_Button.Location = new System.Drawing.Point(205, 101);
            this.Rating_2_Button.Name = "Rating_2_Button";
            this.Rating_2_Button.Size = new System.Drawing.Size(75, 58);
            this.Rating_2_Button.TabIndex = 5;
            this.Rating_2_Button.Text = "2";
            this.Rating_2_Button.UseVisualStyleBackColor = true;
            this.Rating_2_Button.Click += new System.EventHandler(this.Rating_2_Button_Click);
            // 
            // Rating_1_Button
            // 
            this.Rating_1_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating_1_Button.Location = new System.Drawing.Point(124, 101);
            this.Rating_1_Button.Name = "Rating_1_Button";
            this.Rating_1_Button.Size = new System.Drawing.Size(75, 58);
            this.Rating_1_Button.TabIndex = 4;
            this.Rating_1_Button.Text = "1";
            this.Rating_1_Button.UseVisualStyleBackColor = true;
            this.Rating_1_Button.Click += new System.EventHandler(this.Rating_1_Button_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(649, 45);
            this.label11.TabIndex = 2;
            this.label11.Text = "dr. AB CD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(649, 45);
            this.label8.TabIndex = 1;
            this.label8.Text = "Wystaw opinię o:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(50, 182);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.ReadOnly = true;
            this.CommentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentTextBox.Size = new System.Drawing.Size(534, 205);
            this.CommentTextBox.TabIndex = 0;
            this.CommentTextBox.Text = "";
            // 
            // YourPrescriptionsPanel
            // 
            this.YourPrescriptionsPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.YourPrescriptionsPanel.Controls.Add(this.PrescriptionsCountLabel);
            this.YourPrescriptionsPanel.Controls.Add(this.label10);
            this.YourPrescriptionsPanel.Controls.Add(this.YourPrescriptionsGrid);
            this.YourPrescriptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.YourPrescriptionsPanel.Name = "YourPrescriptionsPanel";
            this.YourPrescriptionsPanel.Size = new System.Drawing.Size(651, 447);
            this.YourPrescriptionsPanel.TabIndex = 19;
            this.YourPrescriptionsPanel.Visible = false;
            // 
            // PrescriptionsCountLabel
            // 
            this.PrescriptionsCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrescriptionsCountLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrescriptionsCountLabel.Location = new System.Drawing.Point(0, 45);
            this.PrescriptionsCountLabel.Name = "PrescriptionsCountLabel";
            this.PrescriptionsCountLabel.Size = new System.Drawing.Size(651, 45);
            this.PrescriptionsCountLabel.TabIndex = 9;
            this.PrescriptionsCountLabel.Text = "Liczba recept: X";
            this.PrescriptionsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(651, 45);
            this.label10.TabIndex = 8;
            this.label10.Text = "Twoje recepty";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YourPrescriptionsGrid
            // 
            this.YourPrescriptionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YourPrescriptionsGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.YourPrescriptionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YourPrescriptionsGrid.Location = new System.Drawing.Point(16, 122);
            this.YourPrescriptionsGrid.Name = "YourPrescriptionsGrid";
            this.YourPrescriptionsGrid.RowTemplate.Height = 25;
            this.YourPrescriptionsGrid.Size = new System.Drawing.Size(624, 316);
            this.YourPrescriptionsGrid.TabIndex = 2;
            // 
            // PatientPeselLabel
            // 
            this.PatientPeselLabel.AutoSize = true;
            this.PatientPeselLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientPeselLabel.Location = new System.Drawing.Point(96, 227);
            this.PatientPeselLabel.Name = "PatientPeselLabel";
            this.PatientPeselLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientPeselLabel.TabIndex = 20;
            this.PatientPeselLabel.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 45);
            this.label9.TabIndex = 19;
            this.label9.Text = "Pesel:";
            // 
            // PatientDoctorAsignedLabel
            // 
            this.PatientDoctorAsignedLabel.AutoSize = true;
            this.PatientDoctorAsignedLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDoctorAsignedLabel.Location = new System.Drawing.Point(249, 362);
            this.PatientDoctorAsignedLabel.Name = "PatientDoctorAsignedLabel";
            this.PatientDoctorAsignedLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientDoctorAsignedLabel.TabIndex = 18;
            this.PatientDoctorAsignedLabel.Text = "--";
            // 
            // PatientDiagnoseLabel
            // 
            this.PatientDiagnoseLabel.AutoSize = true;
            this.PatientDiagnoseLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDiagnoseLabel.Location = new System.Drawing.Point(158, 317);
            this.PatientDiagnoseLabel.Name = "PatientDiagnoseLabel";
            this.PatientDiagnoseLabel.Size = new System.Drawing.Size(46, 45);
            this.PatientDiagnoseLabel.TabIndex = 17;
            this.PatientDiagnoseLabel.Text = "--";
            // 
            // PatientRelativeNumberLabel
            // 
            this.PatientRelativeNumberLabel.AutoSize = true;
            this.PatientRelativeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientRelativeNumberLabel.Location = new System.Drawing.Point(277, 272);
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
            this.label7.Location = new System.Drawing.Point(3, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 45);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lekarz opiekun:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diagnoza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 272);
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
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zalogowano jako pacjent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Witaj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Patient";
            this.Text = "Patient";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ThanksForOpinionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RatingPanel.ResumeLayout(false);
            this.RatingPanel.PerformLayout();
            this.YourPrescriptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YourPrescriptionsGrid)).EndInit();
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
        private Panel YourPrescriptionsPanel;
        private DataGridView YourPrescriptionsGrid;
        private Label PatientPeselLabel;
        private Label label9;
        private Label label10;
        private Label PrescriptionsCountLabel;
        private Panel RatingPanel;
        private Button SendOpinionButton;
        private RadioButton AnonymousRB;
        private RadioButton NotAnonymousRB;
        private Label label13;
        private Label label12;
        private Button Rating_4_Button;
        private Button Rating_3_Button;
        private Button Rating_2_Button;
        private Button Rating_1_Button;
        private Label label11;
        private Label label8;
        private RichTextBox CommentTextBox;
        private Button Rating_5_Button;
        private Button button1;
        private Panel ThanksForOpinionPanel;
        private Label label14;
        private PictureBox pictureBox1;
    }
}