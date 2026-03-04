using FitnessManagement.Services;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Core;

namespace FitnessManagement.Views
{
    public partial class PurchaseRequest : UserControl
    {
        private UserServices _userServices;
        public PurchaseRequest()
        {
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
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
            }
        }

        private void PurchaseRequest_Load(object sender, EventArgs e)
        {

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
                
                _userServices.CreateRequest(2);
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
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
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
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
                MessageBox.Show("Requested successfuly");
            }
            else
            {
                return;
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
    }
}
