using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
namespace Hospital
{
    public partial class Form1 : Form
    {
        public string dbConnection = "server=127.0.0.1; user=root; database=klinika; password=";
        MySqlConnection mySqlConnection;
        Doktor doktorUI;
        Patient patientUI;
        public Form1()
        {
            InitializeComponent();
            
            mySqlConnection = new(dbConnection);
            WarningText.Visible = false;
        }
        private void ProcessLogin()
        {
            string username = usernameTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            bool loginSuccessful = false;
            
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                WarningText.Text = "Pola nie mog¹ byæ puste!";
                WarningText.Visible = true;
                return;
            }
            
            
            mySqlConnection.Open();

            //TRY LOG IN AS DOCTOR
            MySqlCommand doctorCommand = new("select * from lekarze WHERE Login = @username AND Haslo = @password", mySqlConnection);
            doctorCommand.Parameters.AddWithValue("@username", username);
            doctorCommand.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = doctorCommand.ExecuteReader();
            if (reader.Read())
            {
                loginSuccessful = true;
                WarningText.Visible = false;

                this.Hide();
                int doctorID = reader.GetInt32("ID");
                int doctorSpecialization = reader.GetInt32("ID_Specjalizacji");
                string name = reader.GetString("Imie");
                string lastName = reader.GetString("Nazwisko");

                doktorUI = new(dbConnection, doctorID, doctorSpecialization);

                doktorUI.Text = $"{name} {lastName}";
                doktorUI.Show();
                        
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            reader.Close();

            //TRY LOG IN AS PATIENT
            if (!loginSuccessful)
            {
                MySqlCommand patientCommand = new("SELECT * FROM pacjenci WHERE Login = @username AND Haslo = @password", mySqlConnection);
                patientCommand.Parameters.AddWithValue("@username", username);
                patientCommand.Parameters.AddWithValue("@password", password);

                reader = patientCommand.ExecuteReader();
                if (reader.Read())
                {
                    loginSuccessful = true;
                    WarningText.Visible = true;

                    this.Hide();
                    int patientID = reader.GetInt32("ID");
                    
                    patientUI = new(dbConnection, patientID);

                   
                    patientUI.Show();

                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";

                }
                reader.Close();
            }

            //LOGIN FAILED
            if (!loginSuccessful)
            {
                WarningText.Text = "Username or password incorrect!";
                WarningText.Visible = true;
            }
            mySqlConnection.Close();
            
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }
       
    }
}