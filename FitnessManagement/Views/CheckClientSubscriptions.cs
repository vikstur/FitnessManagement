using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Services;
using FitnessManagement.Models;

namespace FitnessManagement.Views
{
    public partial class CheckClientSubscriptions : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        private UserServices _userServices;
        public CheckClientSubscriptions()
        {
            _userServices = new UserServices();
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Employee");
        }

        private void CheckClientSubscriptions_Load(object sender, EventArgs e)
        {
            var users = _userServices.GetAllClients();

            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "FullName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            User selectedUser = (User)comboBox1.SelectedItem;

            var subs = _subscriptionServices.GetUserSubscriptions(selectedUser.Id);

            listBox1.DataSource = null;

            if (subs.Count == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("This user does not have a subscription.");
                return;
            }

            listBox1.DataSource = subs;
        }
    }
}
