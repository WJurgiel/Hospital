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
    public partial class DiagnosePatient : Form
    {
        private int PatientID;
        public string diagnose { get; set; }
        private string name, surname;
        Doktor doctor = null;
        public DiagnosePatient(Doktor doc, int id, string n,string s)
        {
            InitializeComponent();

            doctor = doc;
            PatientID = id;
            name = n;
            surname = s;
            PatientNameLabel.Text = $"{name} {surname}";
        }

        private void AddDiagnoseButton_Click(object sender, EventArgs e)
        {
            diagnose = DiagnoseTextBox.Text;

            doctor.UpdateDiagnose(PatientID, diagnose);
            doctor.createPatientsPanel();
            this.Close();
        }
      
    }
}
