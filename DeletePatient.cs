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
    public partial class DeletePatient : Form
    {
        string dbConnection;
        MySqlConnection mySqlConnection;
        int PatientID;

       private Doktor Doctor;
        public DeletePatient(string dbCon, int patientID, Doktor doc)
        {
            InitializeComponent();
            dbConnection = dbCon;
            mySqlConnection = new(dbConnection);

            PatientID = patientID;
            Doctor = doc;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            if (NoRadioButton.Checked == true) return;
            string query = $"DELETE FROM pacjenci WHERE ID = {PatientID}";
            MySqlCommand command = new(query, mySqlConnection);
            command.ExecuteNonQuery();

            Doctor.createPatientsPanel();
            mySqlConnection.Close();

            this.Close();
        }
    }
}
