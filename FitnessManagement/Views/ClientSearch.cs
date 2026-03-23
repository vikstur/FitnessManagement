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
    public partial class ClientSearch : UserControl
    {
        private UserServices _userServices;
        public ClientSearch()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void ClientSearch_Load(object sender, EventArgs e)
        {
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            UserServices userService = new UserServices();

            var clients = userService.SearchClients(textBox1.Text);

            listBox1.DataSource = null;
            listBox1.DataSource = clients;
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Employee");
        }
    }
}
