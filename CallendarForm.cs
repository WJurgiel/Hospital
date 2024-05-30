using Google.Protobuf;
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
    public partial class CallendarForm : Form
    {
        public DateTime selectedDate { get; set; }

        private Label DueDate;
        public CallendarForm(Label dueDate)
        {
            InitializeComponent();
            DueDate = dueDate;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
            if(selectedDate > DateTime.Now)
            {
                string dateString = selectedDate.ToShortDateString();
                DateTime parsedDate = DateTime.ParseExact(dateString, "dd.MM.yyyy", null);
                string formattedDate = parsedDate.ToString("yyyy-MM-dd");

                DueDate.Text = formattedDate;
            }
           

        }
    }
}
