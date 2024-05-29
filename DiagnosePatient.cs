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
        public string diagnose { get; set; }
        public bool buttonClicked;
        private string name, surname;
        public DiagnosePatient(string n,string s)
        {
            InitializeComponent();
            buttonClicked = false;
            name = n;
            surname = s;
            PatientNameLabel.Text = $"{name} {surname}";
        }

        private void AddDiagnoseButton_Click(object sender, EventArgs e)
        {
            Diagnose();
            buttonClicked = true;
            Console.WriteLine(buttonClicked);
        }
        public void ResetButtonClicked()
        {
            buttonClicked = false;
        }
        public void Diagnose()
        {
            diagnose = DiagnoseTextBox.Text;
        }
    }
}
