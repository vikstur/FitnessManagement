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
    public partial class Requests : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        public Requests()
        {
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
            LoadRequests();
        }
        private void LoadRequests()
        {
            var requests = _subscriptionServices.GetPendingRequests();

            listBox1.DataSource = requests;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Id";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            int requestId = (int)listBox1.SelectedValue;
            _subscriptionServices.ApproveRequest(requestId);

            MessageBox.Show("Request approved.");
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            int requestId = (int)listBox1.SelectedValue;
            _subscriptionServices.RejectRequest(requestId);

            MessageBox.Show("Request rejected.");
            LoadRequests();
        }
    }
}
