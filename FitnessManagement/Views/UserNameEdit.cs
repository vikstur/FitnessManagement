using FitnessManagement.Models;
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
    public partial class UserNameEdit : UserControl
    {
        private UserServices _userServices;
        private string OldFullName;
        public UserNameEdit()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("UserEdit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newFirst = textBox1.Text.Trim();
            string newLast = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(newFirst) || string.IsNullOrEmpty(newLast))
            {
                MessageBox.Show("Please enter both a first and last name.", "Input Missing");
                return;
            }

            string message = $"Are you sure you want to change the name of '{OldFullName}' to '{newFirst} {newLast}'?";
            DialogResult result = MessageBox.Show(message, "Confirm Name Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _userServices.UpdatePersonName(OldFullName, newFirst, newLast);

                if (success)
                {
                    MessageBox.Show("Name updated successfully!", "Success");
                    Form1 mainForm = (Form1)this.FindForm();
                    mainForm.Change("UserEdit");
                }
                else
                {
                    MessageBox.Show("Could not find the person in the database. They may have been deleted.", "Error");
                }
            }
        }
        public void SetTargetPerson(string fullName)
        {
            OldFullName = fullName;
            textBox1.Clear();
            textBox2.Clear(); 

            string[] names = fullName.Split(' ');
            if (names.Length >= 2)
            {
                textBox1.Text = names[0];
                textBox2.Text = names[1];
            }
        }
        private void UserNameEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
