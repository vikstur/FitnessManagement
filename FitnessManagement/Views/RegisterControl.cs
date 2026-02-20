using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Services;

namespace FitnessManagement
{
    public partial class RegisterControl : UserControl
    {
        private UserServices _userServices;

        public RegisterControl()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        public void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
            
            
          
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
           textBox2.Text == "" ||
           textBox3.Text == "" ||
           textBox4.Text == "" ||
           textBox5.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox4.Text.Trim();
            string phone = textBox5.Text.Trim();

            _userServices.CreateUser(email, firstName, lastName, password, phone);
            ClearFields();
        }
         
        
    }
}
