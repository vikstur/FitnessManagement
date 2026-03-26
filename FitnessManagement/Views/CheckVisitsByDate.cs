using FitnessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessManagement.Views
{
    public partial class CheckVisitsByDate : UserControl
    {
        private VisitsServices _visitServices;
        public CheckVisitsByDate()
        {
            _visitServices = new VisitsServices();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            var visits = _visitServices.GetVisitsByDate(selectedDate);

            listBox1.Items.Clear();

            foreach (var visit in visits)
            {
                listBox1.Items.Add(visit);
            }

            if (visits.Count == 0)
            {
                listBox1.Items.Add("No visits found for this date.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Employee");
        }
    }
}
