using FitnessManagement.Core;
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
    public partial class CheckSubscription : UserControl
    {
        private UserServices _userServices;
        private SubscriptionServices _subscriptionServices;
        public CheckSubscription()
        {
            _subscriptionServices = new SubscriptionServices();
            _userServices = new UserServices();
            InitializeComponent();
            var data = _subscriptionServices.GetCurrentUserSubscriptionInfo();

            listBox1.Items.Clear();

            foreach (var item in data)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");
        }

        private void CheckSubscription_Load(object sender, EventArgs e)
        {
            var subs = _subscriptionServices.GetCurrentUserSubscriptionInfo();

            listBox1.Items.Clear();

            if (subs.Count == 0 || (subs.Count == 1 && subs[0] == "No active subscription."))
            {
                // ❌ NO subscription
                label1.Visible = false;
                label2.Visible = true;

                listBox1.Items.Clear();
                return;
            }

            // ✅ HAS subscription(s)
            label1.Visible = true;
            label2.Visible = false;

            foreach (var item in subs)
            {
                listBox1.Items.Add(item);
            }
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
