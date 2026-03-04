using FitnessManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessManagement.Services
{
    public partial class Employee : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        public Employee()
        {
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
            LoadRequests();
        }
        private void LoadRequests()
        {
            var requests = _subscriptionServices.GetPendingRequests();

            listBox1.DataSource = requests;
            listBox1.DisplayMember = "Id";
            listBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            var request = (PurchaseRequest)listBox1.SelectedItem;

            _subscriptionServices.ApproveRequest(request.Id);

            MessageBox.Show("Request approved.");
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            var request = (PurchaseRequest)listBox1.SelectedItem;

           _subscriptionServices.RejectRequest(request.Id);

            MessageBox.Show("Request rejected.");
            LoadRequests();
        }
    }
}
