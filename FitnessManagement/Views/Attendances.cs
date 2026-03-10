using FitnessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Models;

namespace FitnessManagement.Views
{
    public partial class Attendances : UserControl
    {
        private AttendanceServices _attendanceServices;
        public Attendances()
        {
            _attendanceServices = new AttendanceServices();
            InitializeComponent();
        }

        private void Attendances_Load(object sender, EventArgs e)
        {
            var users = _attendanceServices.GetUsersWithActiveSubscriptions();

            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;

            User selectedUser = (User)comboBox1.SelectedItem;
            int userId = selectedUser.Id;

            bool isBasic = _attendanceServices.IsBasicSubscription(userId);

            if (isBasic)
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;

            User selectedUser = (User)comboBox1.SelectedItem;
            int userId = selectedUser.Id;

            DateTime checkIn = monthCalendar1.SelectionStart;

            if (checkBox1.Checked)
                _attendanceServices.CreateAttendance(userId, 1, checkIn);

            if (checkBox2.Checked)
                _attendanceServices.CreateAttendance(userId, 2, checkIn);

            if (checkBox3.Checked)
                _attendanceServices.CreateAttendance(userId, 3, checkIn);

            MessageBox.Show("Attendance recorded!");
        }
    }
}
