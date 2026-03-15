using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace FitnessManagement.Views
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            HideEverything();
            homeControl1.Show();

        }
        public void Change(string control)
        {
            if (control == "Home")
            {
                HideEverything();
                homeControl1.Show();
            }
            else if (control == "Client")
            {
                HideEverything();
                clientControl1.Show();
            }
            else if (control == "About")
            {
                HideEverything();
                aboutrGym1.Show();
            }
            else if (control == "Login")
            {
                HideEverything();
                loginControl1.Show();
            }
            else if (control == "Register")
            {
                HideEverything();
                registerControl1.Show();
            }
            else if (control == "PurchaseRequest")
            {
                HideEverything();
                purchaseRequest1.Show();
            }
            else if (control == "Requests")
            {
                HideEverything();
                requests2.Show();
            }
            else if (control == "CheckSubscriptions")
            {
                HideEverything();
                checkSubscription1.Show();
            }
            else if (control == "Employee")
            {
                HideEverything();
                employee1.Show();
            }
            else if (control == "Attendance")
            {
                HideEverything();
                attendances1.Show();
            }
            else if (control == "CheckVisits")
            {
                HideEverything();
                checkVisits1.Show();
            }
        }
        public void HideEverything()
        {
            aboutrGym1.Hide();
            homeControl1.Hide();
            registerControl1.Hide();
            clientControl1.Hide();
            loginControl1.Hide();
            purchaseRequest1.Hide();
            requests2.Hide();
            checkSubscription1.Hide();
            employee1.Hide();
            attendances1.Hide();
            checkVisits1.Hide();
        }

        private void purchaseRequest1_Load(object sender, EventArgs e)
        {

        }

        private void employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
