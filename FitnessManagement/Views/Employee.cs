using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Services;

namespace FitnessManagement.Views
{
    public partial class Employee : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        private AttendanceServices _attendanceServices;
        public Employee()
        {
            _attendanceServices = new AttendanceServices();
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Attendance");
        }
    }
}
