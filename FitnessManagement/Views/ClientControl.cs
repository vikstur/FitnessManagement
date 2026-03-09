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
    public partial class ClientControl : UserControl
    {
        private UserServices _userServices;
        public ClientControl()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                label1.Text =
                    "Welcome to RGym " + UserSession.CurrentUser.FirstName + ", you can buy a subscription from here:";
                label1.Parent = pictureBox1;
                label1.BackColor = Color.Transparent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("PurchaseRequest");
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("CheckSubscriptions");
        }
    }
}
