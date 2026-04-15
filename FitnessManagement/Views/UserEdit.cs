using FitnessManagement.Services;
using FitnessManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessManagement.Views
{
    public partial class UserEdit : UserControl
    {
        private UserServices _userServices;
        public UserEdit()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {
            var users = _userServices.GetAllUsers();
            listBox1.DataSource = users;
            listBox1.DisplayMember = "FullName";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Admin");
        }
        private void button2_Click(object sender, EventArgs e)
        {
    if (listBox1.SelectedItem is User selectedUser)
            {
                string nameToPass = selectedUser.FullName;
                Form1 mainForm = (Form1)this.FindForm();
                mainForm.TransferToEditName(nameToPass);
                mainForm.Change("UserNameEdit");
            }
            else
            {
                MessageBox.Show("Please select a user from the list first.");
            }
        }
    }
}
