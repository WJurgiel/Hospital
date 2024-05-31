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
        private int AssignedDoctorID;
        private string name, surname, pesel, phoneNumber, diagnose, doctorName, doctorSurname;
        private int prescriptionCount;
        private DataTable prescriptionsTable;

        private List<Button> ratingButtons = new();
        private bool ratingButtonClicked = false;
        private int ratingNote = 0;
        private string ratingComment;
        private bool ratingAnonymous;
        private bool hasAlreadyRated;

        public Patient(string dbCon, int patientID)
        {
            InitializeComponent();

            dbConnection = dbCon;
            mySqlConnection = new(dbCon);

            PatientID = patientID;


            CommentTextBox.ReadOnly = true;

            CreateInformationsPanel();
            PopulateRatingButtonList();
            CheckIfHasAlreadyVoted();
        }

    

        private void CreateInformationsPanel()
        {
            mySqlConnection.Open();
            string query = $"SELECT p.Imie, p.ID_Lekarza, p.Nazwisko, p.Pesel, p.Diagnoza, p.nr_bliskiego, d.Imie as Imie_Doktora, d.Nazwisko as Nazwisko_Doktora FROM pacjenci as p JOIN lekarze as d ON p.ID_Lekarza = d.ID WHERE p.ID = {PatientID}";
            MySqlCommand command = new(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                AssignedDoctorID = reader.GetInt32("ID_Lekarza");
                name = reader.GetString("Imie");
                surname = reader.GetString("Nazwisko");
                pesel = reader.GetString("Pesel");
                phoneNumber = reader.GetString("nr_bliskiego");
                diagnose = reader.GetString("Diagnoza");
                doctorName = reader.GetString("Imie_Doktora");
                doctorSurname = reader.GetString("Nazwisko_Doktora");

            }
            reader.Close();
            mySqlConnection.Close();

            PatientNameLabel.Text = name;
            PatientSurnameLabel.Text = surname;
            PatientPeselLabel.Text = pesel;
            PatientDiagnoseLabel.Text = diagnose;
            PatientRelativeNumberLabel.Text = phoneNumber;
            PatientDoctorAsignedLabel.Text = $"{doctorName} {doctorSurname}";
        }

        private void CheckIfHasAlreadyVoted()
        {
            mySqlConnection.Open();
            string query = $"SELECT SUM(ID_Pacjenta) AS voting FROM opinie WHERE ID_Pacjenta = {PatientID}";
            MySqlCommand command = new(query, mySqlConnection);
            object voting = command.ExecuteScalar();
            int votingTimes;
            if (voting != null && !Convert.IsDBNull(voting)) votingTimes = Convert.ToInt32(voting);
            else
            {
                votingTimes = 0;
            }
            hasAlreadyRated = votingTimes > 0;
            mySqlConnection.Close();
        }

        private void PopulateRatingButtonList()
        {
            if(ratingButtons.Count == 0)
            {
                ratingButtons.Add(Rating_1_Button);
                ratingButtons.Add(Rating_2_Button);
                ratingButtons.Add(Rating_3_Button);
                ratingButtons.Add(Rating_4_Button);
                ratingButtons.Add(Rating_5_Button);
            }
        }
        private void ResetRatingButtonsColors()
        {
            foreach (Button b in ratingButtons)
            {
                b.BackColor = SystemColors.ControlLight;
            }
        }
        private void UnlockCommentBox()
        {
            if (ratingButtonClicked)
            {
                CommentTextBox.ReadOnly = false;
            }
        }



        private void CreateYourPrescriptionsPanel()
        {
            mySqlConnection.Open();
            string query = $"SELECT l.Nazwa AS Lek, l.Producent, r.Stosowanie, r.NR_recepty FROM leki as l JOIN recepty as r ON r.ID_Leku = l.ID WHERE r.ID_Pacjenta = {PatientID}";
            MySqlDataAdapter dataAdapter = new(query, mySqlConnection);

            if (prescriptionsTable == null) prescriptionsTable = new();
            else prescriptionsTable.Clear();

            dataAdapter.Fill(prescriptionsTable);
            YourPrescriptionsGrid.DataSource = prescriptionsTable;
            
            mySqlConnection.Close();
        }
        private void CountYourPrescriptions()
        {
            mySqlConnection.Open();
            string query = $"SELECT COUNT(ID) as liczbaRecept FROM recepty WHERE ID_Pacjenta = {PatientID}";
            MySqlCommand command = new(query, mySqlConnection);

            object count = command.ExecuteScalar();

            if (count != null)
            {
                prescriptionCount = Convert.ToInt32(count);
                PrescriptionsCountLabel.Text = $"Liczba recept: {prescriptionCount}";
            }
            else
            {
                MessageBox.Show("Nie można policzyć recept");
                return;
            }
            mySqlConnection.Close();
        }
        private void InformationsPanelButton_Click(object sender, EventArgs e)
        {
            YourPrescriptionsPanel.Visible = false;
            RatingPanel.Visible = false;
            ThanksForOpinionPanel.Visible = false;
        }

        private void PrescriptionsButton_Click(object sender, EventArgs e)
        {
            YourPrescriptionsPanel.Visible = true;
            RatingPanel.Visible = false;
            ThanksForOpinionPanel.Visible = false;
            CreateYourPrescriptionsPanel();
            CountYourPrescriptions();
        }
        private void ReviewButton_Click(object sender, EventArgs e)
        {
            CheckIfHasAlreadyVoted();

            YourPrescriptionsPanel.Visible = false;

            if (!hasAlreadyRated) RatingPanel.Visible = true;
            else ThanksForOpinionPanel.Visible = true;

        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
        private void Rating_1_Button_Click(object sender, EventArgs e)
        {
            ResetRatingButtonsColors();
            Rating_1_Button.BackColor = Color.Red;
            if (!ratingButtonClicked) ratingButtonClicked = true;
            if (CommentTextBox.ReadOnly == true) UnlockCommentBox();
            ratingNote = 1;
        }

        private void Rating_2_Button_Click(object sender, EventArgs e)
        {
            ResetRatingButtonsColors();
            Rating_2_Button.BackColor = Color.OrangeRed;
            if (!ratingButtonClicked) ratingButtonClicked = true;
            if (CommentTextBox.ReadOnly == true) UnlockCommentBox();
            ratingNote = 2;
        }

        private void Rating_3_Button_Click(object sender, EventArgs e)
        {
            ResetRatingButtonsColors();
            Rating_3_Button.BackColor = Color.YellowGreen;
            if (!ratingButtonClicked) ratingButtonClicked = true;
            if (CommentTextBox.ReadOnly == true) UnlockCommentBox();
            ratingNote = 3;
        }

        private void Rating_4_Button_Click(object sender, EventArgs e)
        {
            ResetRatingButtonsColors();
            Rating_4_Button.BackColor = Color.GreenYellow;
            if (!ratingButtonClicked) ratingButtonClicked = true;
            if (CommentTextBox.ReadOnly == true) UnlockCommentBox();
            ratingNote = 4;
        }

        private void Rating_5_Button_Click(object sender, EventArgs e)
        {
            ResetRatingButtonsColors();
            Rating_5_Button.BackColor = Color.Yellow;
            if (!ratingButtonClicked) ratingButtonClicked = true;
            if (CommentTextBox.ReadOnly == true) UnlockCommentBox();
            ratingNote = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">Wybierz ocenę,\n>napisz komentarz,\n>zaznacz anonimowość(Lekarz nie zobaczy twoich danych)");
        }
        private void SendOpinionButton_Click(object sender, EventArgs e)
        {
            if (ratingNote == 0)
            {
                MessageBox.Show("Proszę wpierw wybrać ocenę");
                return;
            }
            if (AnonymousRB.Checked) ratingAnonymous = true;
            if (NotAnonymousRB.Checked) ratingAnonymous = false;
            int anonymousInt = (ratingAnonymous) ? 1 : 0;

            ratingComment = CommentTextBox.Text;

            mySqlConnection.Open();
            string query = $"INSERT INTO opinie (ID_Lekarza, Ocena, ID_Pacjenta, komentarz, Anonimowe)" +
                $" VALUES({AssignedDoctorID},{ratingNote}, {PatientID}, @Komentarz, {anonymousInt})";
            MySqlCommand command = new(query, mySqlConnection);
            command.Parameters.AddWithValue("@Komentarz", ratingComment);
            command.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Dziękujemy za twoją opinię! :)");

            RatingPanel.Visible = false;
            ThanksForOpinionPanel.Visible = true;
        }
    }
}
