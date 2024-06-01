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
        }
        private void LoadSpecialization()
        {

        }
        private void AddPatientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
