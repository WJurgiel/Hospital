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
    public partial class Patient : Form
    {
        private string dbConnection;
        private MySqlConnection mySqlConnection;
        private int PatientID { get; set; } 
        private string name, surname, phoneNumber, diagnose, doctorName, doctorSurname;

   

        public Patient(string dbCon, int patientID)
        {
            InitializeComponent();

            dbConnection = dbCon;
            mySqlConnection = new(dbCon);

            PatientID = patientID;

            CreateInformationsPanel();
        }

        private void CreateInformationsPanel()
        {
            mySqlConnection.Open();
            string query = $"SELECT p.Imie, p.Nazwisko, p.Diagnoza, p.nr_bliskiego, d.Imie as Imie_Doktora, d.Nazwisko as Nazwisko_Doktora FROM pacjenci as p JOIN lekarze as d ON p.ID_Lekarza = d.ID WHERE p.ID = {PatientID}";
            MySqlCommand command = new(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                name = reader.GetString("Imie");
                surname = reader.GetString("Nazwisko");
                phoneNumber = reader.GetString("nr_bliskiego");
                diagnose = reader.GetString("Diagnoza");
                doctorName = reader.GetString("Imie_Doktora");
                doctorSurname = reader.GetString("Nazwisko_Doktora");

            }
            reader.Close();
            mySqlConnection.Close();

            PatientNameLabel.Text = name;
            PatientSurnameLabel.Text = surname;
            PatientDiagnoseLabel.Text = diagnose;
            PatientRelativeNumberLabel.Text = phoneNumber;
            PatientDoctorAsignedLabel.Text = $"{doctorName} {doctorSurname}";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
