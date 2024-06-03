using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Admin : Form
    {
        string dbConnection;
        MySqlConnection mySqlConnection;
        private string patientName, patientSurname, illness, pesel, phoneNumber;
        DateTime date;

        

        public Admin(string dbCon)
        {
            InitializeComponent();
            dbConnection = dbCon;
            mySqlConnection = new(dbConnection);
            LoadSpecializations(IllnessComboBox);
            LoadSpecializations(DocSpecComboBox);
        }
        private void LoadSpecializations(ComboBox comboBox)
        {
            try
            {
                mySqlConnection.Open();
                string query = "SELECT ID, Specjalizacja FROM specjalizacje";
                MySqlCommand command = new(query, mySqlConnection);
                MySqlDataAdapter dataAdapter = new(command);
                DataTable table = new();
                dataAdapter.Fill(table);

                comboBox.DisplayMember = "Specjalizacja";
                comboBox.ValueMember = "ID";
                comboBox.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Load Spec: " +  ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void LoadDoctors(int specializationID)
        {
            try
            {
                if(mySqlConnection.State == ConnectionState.Closed) mySqlConnection.Open();
                string query = "SELECT ID, CONCAT('dr. ', Imie, ' ', Nazwisko) as FullName FROM lekarze WHERE ID_Specjalizacji = @ID_Specjalizacji";
                MySqlCommand command = new(query, mySqlConnection);
                command.Parameters.AddWithValue("@ID_Specjalizacji", specializationID);
                MySqlDataAdapter dataAdapter = new(command);
                DataTable table = new();
                dataAdapter.Fill(table);

                DoctorComboBox.DisplayMember = "FullName";
                DoctorComboBox.ValueMember = "ID";
                DoctorComboBox.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Load Doctors: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void IllnessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IllnessComboBox.SelectedValue != null)
            {
                int specializationID = (int)IllnessComboBox.SelectedValue;
                LoadDoctors(specializationID);
            }
        }
        private bool TestFieldEmpty(TextBox textBox)
        {
            bool integrity = !string.IsNullOrWhiteSpace(textBox.Text);  //if it is null or whitespace it's bad
            if (!integrity) MessageBox.Show(textBox.Name + " Bad ");
            return integrity;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private bool TestPeselIntegrity(TextBox textBox)
        {
            bool integrity = Regex.IsMatch(textBox.Text, @"^\d{11}$");
            if (!integrity) MessageBox.Show("PESEL bad >:(");
            return integrity;
        }

        //I don't wanna rename the buttons because the project comes to an end
        // button1 - add patient form
        // button2 - add doctor form
        // button3 ? - add medicaments form
        private void button1_Click(object sender, EventArgs e)
        {
            AddPatientPanel.Visible = true;
            AddDoctorPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDoctorPanel.Visible = true;
            AddPatientPanel.Visible = false;
        }
        private bool TestPhoneNumberIntegrity(TextBox textBox)
        {
            bool integrity = Regex.IsMatch(textBox.Text, @"^\d{9}$");
            if (!integrity) MessageBox.Show("Phone number bad >:(");
            return integrity;
        }
        private bool TestAllPatientValues()
        {
            //name and surname can't be empty
            // pesel must contain 11 digits 
            // phone number must contain 9 digits
            return TestFieldEmpty(NameTextBox) && TestFieldEmpty(SurnameTextBox) && TestFieldEmpty(LoginTextbox) &&
                TestFieldEmpty(PasswordTextBox) && TestPeselIntegrity(PeselTextBox) && TestPhoneNumberIntegrity(PhoneNumberTextBox);
        }
        private bool TestAllDoctorValues()
        {
            return TestFieldEmpty(DocNameTextBox) && TestFieldEmpty(DocSurnameTextBox) && TestFieldEmpty(DocLoginTextBox) && TestFieldEmpty(DocPasswordTextBox);
        }
        private void CleanUpPatientForm()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            PeselTextBox.Clear();
            PhoneNumberTextBox.Clear();
            LoginTextbox.Clear();
            PhoneNumberTextBox.Clear();
            PasswordTextBox.Clear();
            DatePicker.Value = DateTime.Now;
            IllnessComboBox.SelectedIndex = 0;
        }
        private void CleanUpDoctorForm()
        {
            DocNameTextBox.Clear();
            DocSurnameTextBox.Clear();
            DocLoginTextBox.Clear();
            DocPasswordTextBox.Clear();
            DocSpecComboBox.SelectedIndex = 0;
        }
        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            if (!TestAllPatientValues()) return;

            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string specializationID = IllnessComboBox.SelectedValue?.ToString();
            string doctorID = DoctorComboBox.SelectedValue?.ToString();
            string pesel = PeselTextBox.Text;
            string phone = PhoneNumberTextBox.Text;
            string date = DatePicker.Value.ToString("yyyy-MM-dd");
            string login = LoginTextbox.Text;
            string password = PasswordTextBox.Text;

           
            try
            {
                mySqlConnection.Open();
                string query = $"INSERT INTO pacjenci (Imie, Nazwisko, ID_Schorzenia, Data_Przyjecia, ID_Lekarza, nr_bliskiego, login, haslo, Pesel)" +
                    $"VALUES (\"{name}\", \"{surname}\", \"{specializationID}\", " +
                    $"\'{date}\', {doctorID}, \"{phone}\", \"{login}\", \"{password}\", \"{pesel}\")";
                MySqlCommand command = new(query, mySqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie dodano pacjenta");
                CleanUpPatientForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            if (!TestAllDoctorValues()) return;

            string name = DocNameTextBox.Text;
            string surname = DocSurnameTextBox.Text;
            string specializationID = DocSpecComboBox.SelectedValue?.ToString();
            string login = DocLoginTextBox.Text;
            string password = DocPasswordTextBox.Text;

            try
            {
                mySqlConnection.Open();
                string query = $"INSERT INTO lekarze (Imie, Nazwisko, ID_Specjalizacji, login, haslo)" +
                    $"VALUES (\"{name}\", \"{surname}\", \"{specializationID}\", " +
                   $"\"{login}\", \"{password}\")";
                MySqlCommand command = new(query, mySqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie dodano lekarza");
                CleanUpDoctorForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
