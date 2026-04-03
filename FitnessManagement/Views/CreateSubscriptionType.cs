using FitnessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitnessManagement.Views
{
    public partial class CreateSubscriptionType : UserControl
    {
        private SubscriptionServices _subscriptionServices;
        public CreateSubscriptionType()
        {
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Admin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string subName = textBox4.Text;
                decimal price = decimal.Parse(textBox1.Text);
                int duration = int.Parse(textBox2.Text);
                int? visits = string.IsNullOrWhiteSpace(textBox3.Text) ? (int?)null : int.Parse(textBox3.Text);

                List<string> selectedServices = new List<string>();

                if (checkBox1.Checked) selectedServices.Add("Fitness");
                if (checkBox2.Checked) selectedServices.Add("SPA");
                if (checkBox3.Checked) selectedServices.Add("Pool");

                if (selectedServices.Count == 0)
                {
                    MessageBox.Show("Please select at least one service!");
                    return;
                }

                _subscriptionServices.CreateNewSubscriptionType(subName, duration, price, visits, selectedServices);

                MessageBox.Show($"Subscription '{subName}' created successfully!");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Please check that price and duration are numbers. " + ex.Message);
            }
        }
        private void ClearFields()
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
