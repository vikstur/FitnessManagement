using FitnessManagement.Core;
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
    public partial class CheckVisits : UserControl
    {
        private AttendanceServices _attendanceServices;
        public CheckVisits()
        {
            _attendanceServices = new AttendanceServices();
            InitializeComponent();
        }

        private void CheckVisits_Load(object sender, EventArgs e)
        {
            
                label1.Text =
                    "Welcome to RGym " + UserSession.CurrentUser.FirstName + ", you can check your recent visits here";
            LoadAttendances();
        }
        private void LoadAttendances()
        {
            var visits = _attendanceServices.GetAttendances();

            listBox1.DataSource = null;
            listBox1.DataSource = visits;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");
        }
    }
}
