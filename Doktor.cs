using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Properties;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Hospital
{
    
    public partial class Doktor : Form
    {
        private string dbConnection;
        private MySqlConnection mySqlConnection;
        public int DoctorID { get; set; }
        private int DoctorSpecializationID { get; set; }

        private DataTable patientsTable;
        private DataTable opinionsTable;
        private Presciption prescriptionForm;

        private double opinionScore;
        public Doktor(string dbCon, int doctorID, int specializationID)
        {
            InitializeComponent();
            //class fields
            DoctorID = doctorID;
            DoctorSpecializationID = specializationID;
            //database connection;  
            dbConnection = dbCon;
            mySqlConnection = new(dbConnection);

            //others
            PatientsPanel.Visible = false;
            patientsTable = null;

            CreateInformationsPanel();
            createPatientsPanel();
            CreateOpinionsPanel();
        }
        void CreateInformationsPanel()
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
            string querry = $"SELECT p.ID, p.Imie, p.Nazwisko, p.Diagnoza, p.Data_Przyjecia FROM pacjenci as p WHERE p.ID_Lekarza = {DoctorID}";
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
        public void CreateOpinionsPanel()
        {
            mySqlConnection.Open();
            string query = $"SELECT " +
                $"CASE WHEN o.Anonimowe = 1 THEN 'Anonimowy' ELSE p.Imie END AS Imie, " +
                $"CASE WHEN o.Anonimowe = 1 THEN ' ' ELSE p.Nazwisko END AS Nazwisko," +
                $" o.Ocena, o.komentarz FROM pacjenci as p JOIN opinie as o ON o.ID_Lekarza = {DoctorID} WHERE o.ID_Pacjenta = p.ID";
            MySqlDataAdapter dataAdapter = new(query, mySqlConnection);

            if (opinionsTable == null) opinionsTable= new();
            else opinionsTable.Clear();

            dataAdapter.Fill(opinionsTable);
            OpinionsGrid.DataSource = opinionsTable;
            mySqlConnection.Close();

        }
        private void CalculateAverageScore()
        {
            mySqlConnection.Open();
            string query = $"SELECT AVG(Ocena) AS Average FROM opinie WHERE ID_Lekarza = {DoctorID}";
            MySqlCommand command = new(query, mySqlConnection);
            object average = command.ExecuteScalar();
            if (average != null)
            {
                opinionScore = Convert.ToDouble(average);
                AverageGradeLabel.Text = opinionScore.ToString();
            }
            else
            {
                MessageBox.Show("Nie można obliczyć średniej");
                return;
            }
            mySqlConnection.Close();
        }
        private void UpdateScorePictureBox()
        {
            if (opinionScore < 2) ScorePictureBox.Image = Resources.EmojiShocked;
            else if (opinionScore < 4) ScorePictureBox.Image = Resources.EmojiSad;
            else ScorePictureBox.Image = Resources.EmojiNice;
        }
        public void UpdateDiagnose(int PatientID, string newDiagnose)
        {
            mySqlConnection.Open();
            try
            {
                string querry = $"UPDATE pacjenci SET Diagnoza = @Diagnoza WHERE ID = @ID";
                MySqlCommand command = new(querry, mySqlConnection);
                command.Parameters.AddWithValue("@Diagnoza", newDiagnose);
                command.Parameters.AddWithValue("@ID", PatientID);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Coś się zepsuło w procesie, PatientID = {PatientID}, newDiagnose: {newDiagnose}");
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
            OpinionsPanel.Visible = false;
        }
        private void ShowOpinionsButton_Click(object sender, EventArgs e)
        {

            OpinionsPanel.Visible = true;
            PatientsPanel.Visible = false;
            CreateOpinionsPanel();
            CalculateAverageScore();
            UpdateScorePictureBox();
        }

        private void InformationsPanelButton_Click(object sender, EventArgs e)
        {
            PatientsPanel.Visible = false;
            OpinionsPanel.Visible = false;
        }
        public void OnDiagnoseUpdated(int patientId, string newDiagnose)
        {
            UpdateDiagnose(patientId, newDiagnose);
            createPatientsPanel();
            DiagnoseButton.Text = "działa:P";
        }
        private void DiagnoseButton_Click(object sender, EventArgs e)
        {
          
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
                int selectedRowIndex = PatientsGrid.SelectedRows[0].Index;
                int patientId = Convert.ToInt32(PatientsGrid.Rows[selectedRowIndex].Cells["ID"].Value);
                string name = (PatientsGrid.Rows[selectedRowIndex].Cells["Imie"]).Value.ToString();
                string surname = PatientsGrid.Rows[selectedRowIndex].Cells["Nazwisko"].Value.ToString();

                prescriptionForm = new(dbConnection, patientId, DoctorID, DoctorSpecializationID, name, surname);
                
                if (prescriptionForm.ShowDialog() == DialogResult.OK)
                {
                    
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
