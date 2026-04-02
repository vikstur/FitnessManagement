using FitnessManagement;
using FitnessManagement.Models;
using FitnessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FitnessManagement.Views
{
    public partial class AdminSubscriptions : UserControl
    {

        private SubscriptionServices _subscriptionServices;
        public AdminSubscriptions()
        {

            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Admin");
        }

        private void AdminSubscriptions_Load(object sender, EventArgs e)
        {
            var types = _subscriptionServices.GetAllSubscriptionTypes();
            comboBox1.DataSource = types;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";


            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is SubscriptionType selected)
            {
                Form1 mainForm = (Form1)this.FindForm();
                mainForm.TransferDataToEdit(selected);
                mainForm.Change("EditSubscription");
            }
            else
            {
                MessageBox.Show("Please select a subscription!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is SubscriptionType selected)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete the subscription '{selected.Name}' permanently?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = _subscriptionServices.DeleteSubscriptionType(selected.Id);

                    if (isDeleted)
                    {
                        MessageBox.Show("Subscription deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete this subscription because it is currently in use by clients.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a subscription to delete.");
            }
        }

        private void AdminSubscriptions_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
