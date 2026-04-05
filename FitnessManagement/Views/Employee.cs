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
    public partial class Employee : UserControl
    {

        private SubscriptionServices _subscriptionServices;
        private AttendanceServices _attendanceServices;
        private UserServices _userServices;
        public Employee()
        {
            _userServices = new UserServices();
            _attendanceServices = new AttendanceServices();
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Attendance");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("CheckClientSubscriptions");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Requests");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("ClientSearch");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("CheckVisitsByDate");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to log out",
         "Confirm",
         MessageBoxButtons.OKCancel,
         MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Form1 mainForm = (Form1)this.FindForm();
                _userServices.Logout();
                _userServices.LoginClear(mainForm.loginControl1);
                MessageBox.Show("Logged out successfully");

                mainForm.Change("Home");


            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                label1.Text =
                    "Welcome back to work " + UserSession.CurrentUser.FirstName;
                label1.Parent = pictureBox1;
                label1.BackColor = Color.Transparent;
            }
        }
    }
}
