namespace Hospital
{
    partial class DiagnosePatient
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
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.DiagnoseTextBox = new System.Windows.Forms.RichTextBox();
            this.AddDiagnoseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLabel.Location = new System.Drawing.Point(43, 9);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(163, 32);
            this.PatientNameLabel.TabIndex = 0;
            this.PatientNameLabel.Text = "Imie nazwisko";
            // 
            // DiagnoseTextBox
            // 
            this.DiagnoseTextBox.Location = new System.Drawing.Point(12, 44);
            this.DiagnoseTextBox.Name = "DiagnoseTextBox";
            this.DiagnoseTextBox.Size = new System.Drawing.Size(219, 150);
            this.DiagnoseTextBox.TabIndex = 2;
            this.DiagnoseTextBox.Text = "";
            // 
            // AddDiagnoseButton
            // 
            this.AddDiagnoseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDiagnoseButton.Location = new System.Drawing.Point(74, 200);
            this.AddDiagnoseButton.Name = "AddDiagnoseButton";
            this.AddDiagnoseButton.Size = new System.Drawing.Size(97, 38);
            this.AddDiagnoseButton.TabIndex = 3;
            this.AddDiagnoseButton.Text = "Add diagnose";
            this.AddDiagnoseButton.UseVisualStyleBackColor = true;
            this.AddDiagnoseButton.Click += new System.EventHandler(this.AddDiagnoseButton_Click);
            // 
            // DiagnosePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 250);
            this.Controls.Add(this.AddDiagnoseButton);
            this.Controls.Add(this.DiagnoseTextBox);
            this.Controls.Add(this.PatientNameLabel);
            this.Name = "DiagnosePatient";
            this.Text = "DiagnosePatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PatientNameLabel;
        private RichTextBox richTextBox1;
        private Button AddDiagnoseButton;
        private RichTextBox DiagnoseTextBox;
    }
}