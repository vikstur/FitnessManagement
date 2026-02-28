using FitnessManagement.Core;
using FitnessManagement.Models;
using FitnessManagement.Services;
using FitnessManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static FitnessManagement.Services.UserServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessManagement
{
    public partial class LoginControl : UserControl
    {
        private UserServices _userServices;
        public LoginControl()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""||textBox2.Text=="")
            {
                MessageBox.Show("Please fill all the required fields");
            }

            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            _userServices.LoginUser(email , password);
            this.Hide();
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");
        }
    }
}
