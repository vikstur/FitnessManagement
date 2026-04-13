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
    public partial class AdminSubscriptionsCheck : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        public AdminSubscriptionsCheck()
        {
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Admin");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var expiredList = _subscriptionServices.GetAllExpiredSubscriptions();

            if (expiredList.Count == 0)
            {
                listBox1.Items.Add("No expired subscriptions found.");
            }
            else
            {
                foreach (var info in expiredList)
                {
                    listBox1.Items.Add(info);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var activeList = _subscriptionServices.GetAllActiveSubscriptions();

            if (activeList.Count == 0)
            {
                listBox1.Items.Add("No active subscriptions found.");
                return;
            }

            foreach (var subInfo in activeList)
            {
                listBox1.Items.Add(subInfo);
            }
        }

        private void AdminActiveSubscriptions_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var activeList = _subscriptionServices.GetAllActiveSubscriptions();

            if (activeList.Count == 0)
            {
                listBox1.Items.Add("No active subscriptions found.");
                return;
            }

            foreach (var subInfo in activeList)
            {
                listBox1.Items.Add(subInfo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a subscription from the list first.", "Selection Missing");
                return;
            }

            string selectedInfo = listBox1.SelectedItem.ToString();
            if (selectedInfo.Contains("No active subscriptions")) return;
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to CANCEL this subscription?\n\n{selectedInfo}",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool success = _subscriptionServices.CancelSubscriptionByInfo(selectedInfo);

                if (success)
                {
                    MessageBox.Show("Subscription has been canceled successfully.");
                    listBox1.Items.Clear();

                    var activeList = _subscriptionServices.GetAllActiveSubscriptions();

                    if (activeList.Count == 0)
                    {
                        listBox1.Items.Add("No active subscriptions found.");
                        return;
                    }

                    foreach (var subInfo in activeList)
                    {
                        listBox1.Items.Add(subInfo);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Could not find or cancel this subscription.");
                }
            }
        }
    }
}
