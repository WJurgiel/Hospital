using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Presciption : Form
    {
        private string dbConnection;
        private MySqlConnection mySqlConnection;
        private DataTable medicamentsTable;
        private DataTable prescribedTable;

        private int DoctorSpecializationID; //from doktor class
        private int PatientID;  // from Doktor class
        private int MedicamentID;   //from query
        private int DoctorID;   //from Doktor class
        private int PrescribedID; // from query

        private string PatientName, PatientSurname;
        private string MedicamentName, MedicamentProducer;

        public event Action PrescriptionUpdated;

        string dateString;
        public Presciption(string dbCon, int patient, int doctor, int specializationID, string name, string surname)
        {
            InitializeComponent();
            dbConnection = dbCon;
            mySqlConnection = new(dbConnection);

            DoctorSpecializationID = specializationID;
            PatientID = patient;
            DoctorID = doctor;
            PatientName = name;
            PatientSurname = surname;

            CreateMedicamentsPanel();
            SetPatientNameLabel();
            SetIllnessTypeLabel();
            CreatePrescribedPanel();

            PrescriptionUpdated += CreatePrescribedPanel;
        }
        void CreateMedicamentsPanel()
        {
            mySqlConnection.Open();
            string querry = $"SELECT l.Nazwa, l.Producent FROM leki AS l WHERE l.ID_Schorzenia = {DoctorSpecializationID}";
            MySqlDataAdapter dataAdapter = new(querry, mySqlConnection);
            if (medicamentsTable == null) medicamentsTable = new();
            else medicamentsTable.Clear();
            dataAdapter.Fill(medicamentsTable);

            MedicamentsGrid.DataSource = medicamentsTable;
            mySqlConnection.Close();
            
        }
        void CreatePrescribedPanel()
        {
            mySqlConnection.Open();
            //counter|drug name|dueDate|
            string querry = $"SELECT recepty.ID as ID_Recepty, leki.nazwa, recepty.stosowanie, recepty.NR_recepty FROM recepty JOIN leki ON recepty.ID_Leku = leki.ID WHERE recepty.ID_Pacjenta = {PatientID}";
            MySqlDataAdapter dataAdapter = new(querry, mySqlConnection);
            if (prescribedTable == null) prescribedTable = new();
            else prescribedTable.Clear();
            dataAdapter.Fill(prescribedTable);

            PrescribedGrid.DataSource = prescribedTable;
            mySqlConnection.Close();

        }
        void SetPatientNameLabel()
        {
            PatientNameLabel.Text = $"{PatientName} {PatientSurname}";
        }
        void SetIllnessTypeLabel()
        {
            mySqlConnection.Open();
            string querry = $"SELECT s.Specjalizacja FROM specjalizacje as s WHERE s.ID = {DoctorSpecializationID}";
            MySqlCommand command = new(querry, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string illness = reader.GetString("Specjalizacja");
                IllnessTypeLabel.Text = illness;
            }
            mySqlConnection.Close();
        }
       

        private void AddPrescriptionButton_Click(object sender, EventArgs e)
        {
            //Dodajemy nową recepte wiec trzeba dodać ID_Leku ID_Pacjenta ID_Lekarza i Stosowanie
            if (MedicamentsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = MedicamentsGrid.SelectedRows[0];
                var nameValue = selectedRow.Cells["Nazwa"].Value?.ToString();

                if (string.IsNullOrEmpty(nameValue))
                {
                    MessageBox.Show("Proszę wybrać lek");
                    return;
                }
                // Pobierz datę z labela
                string dateString = DueDataLabel.Text;

                DateTime parsedDate;
                if (!DateTime.TryParseExact(dateString, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    MessageBox.Show("Nieprawidłowy format daty.");
                    return;
                }

                //GET MEDICAMENT ID 
                try
                {
                    mySqlConnection.Open();
                    string idQuery = "SELECT ID FROM leki WHERE nazwa = @name";
                    MySqlCommand idCommand = new(idQuery, mySqlConnection);
                    idCommand.Parameters.AddWithValue("@name", nameValue);
                    object result = idCommand.ExecuteScalar();
                    if(result != null)
                    {
                        MedicamentID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono takiego leku");
                        return;
                    }
                    mySqlConnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              

                // CREATE NEW PRESCRIPTION
                try
                {
                    mySqlConnection.Open();
                    string query = "INSERT INTO recepty (ID_Leku, ID_Pacjenta, ID_Lekarza, Stosowanie) VALUES(@MedicamentID, @PatientID, @DoctorID, @NewStosowanie)";
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@MedicamentID", MedicamentID);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@NewStosowanie", dateString);


                    command.ExecuteNonQuery();
                    

                    mySqlConnection.Close();
                    PrescriptionUpdated?.Invoke();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                
                               
            }
            else
            {
                MessageBox.Show("Proszę wybrać lek do przypisania");
            }

        }

        private void DeletePrescriptionButton_Click(object sender, EventArgs e)
        {
            if (PrescribedGrid.SelectedRows.Count > 0)
            {
                var selectedRow = PrescribedGrid.SelectedRows[0];
                var ID = selectedRow.Cells["nr_recepty"].Value;
                try
                {
                    mySqlConnection.Open();
                    string deleteQuery = $"DELETE FROM recepty WHERE ID = {ID}";
                    MySqlCommand command = new(deleteQuery, mySqlConnection);
                    command.ExecuteNonQuery();

                    mySqlConnection.Close();
                    PrescriptionUpdated?.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: "+ ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Proszę wybrać receptę do usunięcia");
            }
        }

     

        private void MedicamentsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(MedicamentsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = MedicamentsGrid.SelectedRows[0];
                var nameValue = selectedRow.Cells["Nazwa"].Value?.ToString();
                var producerValue = selectedRow.Cells["Producent"].Value?.ToString();
                
                DrugNameLabel.Text = "Lek: " + nameValue;
                DrugProducerLabel.Text = "Prod. " + producerValue;
            }
        }

        private void SwitchCalendarButton_Click(object sender, EventArgs e)
        {
            CallendarForm callendar = new(DueDataLabel);
            callendar.ShowDialog();
        }
    }
}
