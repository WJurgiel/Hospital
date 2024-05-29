﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Hospital
{
    
    public partial class Doktor : Form
    {
        private string dbConnection;
        private MySqlConnection mySqlConnection;
        public int DoctorID { get; set; }
        private DataTable patientsTable;
        
        public Doktor(string dbCon, int doctorID)
        {
            InitializeComponent();
            //class fields
            DoctorID = doctorID;
            //database connection;  
            dbConnection = dbCon;
            mySqlConnection = new(dbConnection);

            //others
            PatientsPanel.Visible = false;
            patientsTable = null;

            createInformationsPanel();
            createPatientsPanel();

        }
        void createInformationsPanel()
        {
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new("SELECT * from lekarze as l JOIN specjalizacje as s ON l.ID_Specjalizacji = s.ID", mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (DoctorID.Equals(reader.GetInt32("ID")))
                {
                    IdLabel.Text = DoctorID.ToString();
                    NameLabel.Text = reader.GetString("Imie");
                    SurnameLabel.Text = reader.GetString("Nazwisko");
                    SpecializationLabel.Text = reader.GetString("Specjalizacja");

                }
            }
            mySqlConnection.Close();
        }
        public void createPatientsPanel()
        {
            mySqlConnection.Open();
            string querry = $"SELECT p.ID, p.Imie, p.Nazwisko, p.Diagnoza, p.Data_Przyjecia, l.Nazwa FROM pacjenci as p JOIN recepty as r ON p.ID = r.ID_Pacjenta JOIN leki as l ON r.ID_leku = l.ID AND p.ID_Lekarza = {DoctorID}";
            MySqlDataAdapter dataAdapter = new(querry, mySqlConnection);
           
            
            if(patientsTable == null)
            {
                patientsTable = new();
            }
            else
            {
                patientsTable.Clear();
            }
            
            dataAdapter.Fill(patientsTable);

            PatientsGrid.DataSource = patientsTable;
            mySqlConnection.Close();
        }
        public void UpdateDiagnose(int patientID, string newDiagnose)
        {
            mySqlConnection.Open();
            try
            {
                string querry = $"UPDATE pacjenci SET Diagnoza = @Diagnoza WHERE ID = @ID";
                MySqlCommand command = new(querry, mySqlConnection);
                command.Parameters.AddWithValue("@Diagnoza", newDiagnose);
                command.Parameters.AddWithValue("@ID", patientID);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Coś się zepsuło w procesie, patientID = {patientID}, newDiagnose: {newDiagnose}");
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            PatientsPanel.Visible = true;
        }

        private void InformationsPanelButton_Click(object sender, EventArgs e)
        {
            PatientsPanel.Visible = false;
        }
        public void OnDiagnoseUpdated(int patientId, string newDiagnose)
        {
            UpdateDiagnose(patientId, newDiagnose);
            createPatientsPanel();
            DiagnoseButton.Text = "działa:P";
        }
        private void DiagnoseButton_Click(object sender, EventArgs e)
        {
            /*
             * fix this
             */
            if(PatientsGrid.SelectedRows.Count == 1)
            {
                int selectedRowIndex = PatientsGrid.SelectedRows[0].Index;
                int patientId = Convert.ToInt32(PatientsGrid.Rows[selectedRowIndex].Cells["ID"].Value);
                
                string name = (PatientsGrid.Rows[selectedRowIndex].Cells["Imie"]).Value.ToString();
                string surname = PatientsGrid.Rows[selectedRowIndex].Cells["Nazwisko"].Value.ToString();

                
                DiagnosePatient diagnoseForm = new(this, patientId, name,surname);

                if (diagnoseForm.ShowDialog() == DialogResult.OK)
                {

                    
                 }
            }
            else
            {
                MessageBox.Show("Zaznacz tylko jednego pacjenta z listy");
            }
            
        }

        private void PrescriptionButton_Click(object sender, EventArgs e)
        {
            if (PatientsGrid.SelectedRows.Count == 1)
            {
                Presciption prescriptionForm = new();
                if(prescriptionForm.ShowDialog() == DialogResult.OK)
                {
                    //string newDiagnose = prescriptionForm.
                }

            }
            else
            {
                MessageBox.Show("Zaznacz tylko jednego pacjenta z listy");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PatientsGrid.SelectedRows.Count == 1)
            {
                DeletePatient deleteForm = new();
                deleteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Zaznacz tylko jednego pacjenta z listy");
            }

        }
    }
}