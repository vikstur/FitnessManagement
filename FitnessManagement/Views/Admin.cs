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
    public partial class Admin : UserControl
    {
        private UserServices _userServices;
        public Admin()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("AdminSubscriptions");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("CreateSubscriptionType");
        }
    }
}
