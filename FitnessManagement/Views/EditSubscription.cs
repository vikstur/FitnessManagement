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
    public partial class EditSubscription : UserControl
    {
        private SubscriptionType _currentType;
        private SubscriptionServices _subscriptionServices;
        public EditSubscription()
        {
            _currentType = new SubscriptionType();
            _subscriptionServices = new SubscriptionServices();
            InitializeComponent();

        }

        public void SetSubscriptionData(SubscriptionType type)
        {
       
            _currentType = type;
            textBox1.Text = type.Price.ToString("F2");
            textBox2.Text = type.DurationDays.ToString();
            textBox4.Text = type.Visits?.ToString() ?? "";

            var serviceNames = type.SubscriptionTypeServices
                .Select(sts => sts.Service.Name);
            textBox3.Text = string.Join(", ", serviceNames);


        }
        private void EditSubscription_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newPrice = decimal.Parse(textBox1.Text);
                int newDuration = int.Parse(textBox2.Text);
                int? newVisits = string.IsNullOrWhiteSpace(textBox4.Text) ? (int?)null : int.Parse(textBox4.Text);

                List<string> newServices = textBox3.Text
                    .Split(',')
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToList();

                _subscriptionServices.UpdateSubscriptionType(_currentType.Id, newPrice, newDuration, newVisits, newServices);

                MessageBox.Show("Changes saved successfully!");

                Form1 mainForm = (Form1)this.FindForm();
                mainForm.Change("AdminSubscriptions");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Please ensure numeric fields are filled correctly. " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("AdminSubscriptions");
        }

        private void EditSubscription_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
