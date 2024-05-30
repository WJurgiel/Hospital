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

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                WarningText.Text = "Pola nie mog¹ byæ puste!";
                WarningText.Visible = true;
            }
            else
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new("select * from lekarze", mySqlConnection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("Login")) && password.Equals(reader.GetString("Haslo")))
                    {
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
                    else
                    {
                        WarningText.Text = "Username or password incorrect!";
                        WarningText.Visible = true;
                    }
                }
                mySqlConnection.Close();
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }
        //do usuniecia 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //do usuniecia
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProcessLogin();
                this.Text = "Enter";
            }

        }
    }
}