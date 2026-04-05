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
    public partial class CheckVisitsByPeriod : UserControl
    {
        private VisitsServices _visitsServices;
        public CheckVisitsByPeriod()
        {
            _visitsServices = new VisitsServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Admin");
        }

        private void CheckVisitsByPeriod_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fromDate = monthCalendar1.SelectionStart;
            DateTime toDate = monthCalendar2.SelectionStart;

            // 2. Validation: Make sure 'From' isn't after 'To'
            if (fromDate > toDate)
            {
                MessageBox.Show("The 'From' date cannot be later than the 'To' date.");
                return;
            }

            // 3. Fetch the data
            var results = _visitsServices.GetVisitsByPeriod(fromDate, toDate);

            // 4. Display in ListBox
            listBox1.Items.Clear();

            if (results.Count == 0)
            {
                listBox1.Items.Add("No visits found for this period.");
                return;
            }

            foreach (var visit in results)
            {
                string displayText = $"{visit.CheckInTime:dd/MM/yyyy HH:mm} - {visit.ClientName} ({visit.SubscriptionType})";
                listBox1.Items.Add(displayText);
            }
        }
    }
}
