using FitnessManagement.Core;
using FitnessManagement.Models;
using FitnessManagement.Services;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessManagement.Views
{
    public partial class PurchaseRequest : UserControl
    {
        private UserServices _userServices;
        private SubscriptionServices _subscriptionServices;
        public PurchaseRequest()
        {
            _subscriptionServices = new SubscriptionServices();
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to buy this subscription?",
            "Confirm",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                _subscriptionServices.CreateRequest(3);
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
            }
        }

        private void PurchaseRequest_Load(object sender, EventArgs e)
        {
            var types = _subscriptionServices.GetAllSubscriptionTypes();
            comboBox1.DataSource = types;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";


            comboBox1.SelectedIndex = -1;
            ClearLabels();
        }
        private void ClearLabels()
        {
            label5.Text = "";
            label6.Text = "";
            label9.Text = "";
            label7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to buy this subscription?",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool created = _subscriptionServices.CreateRequest(2);

                if (created)
                {
                    MessageBox.Show("Request sent successfully.");
                }
                else
                {
                    MessageBox.Show("You already have a pending request for this subscription.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to buy this subscription?",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool created = _subscriptionServices.CreateRequest(1);

                if (created)
                {
                    MessageBox.Show("Request sent successfully.");
                }
                else
                {
                    MessageBox.Show("You already have a pending request for this subscription.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to buy this subscription?",
               "Confirm",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool created = _subscriptionServices.CreateRequest(2);

                if (created)
                {
                    MessageBox.Show("Request sent successfully.");
                }
                else
                {
                    MessageBox.Show("You already have a pending request for this subscription.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to buy this subscription?",
            "Confirm",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to buy this subscription?",
            "Confirm",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                _subscriptionServices.CreateRequest(4);
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is SubscriptionType selectedType)
            {
                // 1. Display Price
                label5.Text = $"{selectedType.Price:F2} BGN";

                // 2. Display Duration
                label6.Text = $"{selectedType.DurationDays} Days";

                // 3. Display Visits
                // If Visits is null in DB, it usually means "Unlimited" for Premium
                label9.Text = selectedType.Visits.HasValue
                    ? selectedType.Visits.Value.ToString()
                    : "Unlimited";

                // 4. Display Services
                // We join the names of the services into a single string
                var serviceNames = selectedType.SubscriptionTypeServices
                    .Select(sts => sts.Service.Name)
                    .ToList();

                label7.Text = string.Join(", ", serviceNames);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                DialogResult result = MessageBox.Show(
               "Are you sure you want to buy this subscription?",
               "Confirm",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {


                    int typeId = (int)comboBox1.SelectedValue;
                    bool success = _subscriptionServices.CreateRequest(typeId);

                    if (success)
                    {
                        MessageBox.Show("Request sent successfully! Waiting for approval.");
                    }
                        
                    else
                    {
                         MessageBox.Show("You already have a pending request for this type.");
                    }
                       

                }
            }
        }
    }
}
