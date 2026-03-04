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
            aboutrGym1.Hide();
            homeControl1.Hide();
            registerControl1.Hide();
            clientControl1.Hide();

        }
        public void Change(string control)
        {
            if (control == "Home")
            {
                homeControl1.Show();
            }
            else if (control == "Client")
            {
                HideEverything();
                clientControl1.Show();
            }
            else if (control == "About")
            {
                aboutrGym1.Show();
            }
            else if (control == "Login")
            {
                loginControl1.Show();
            }
            else if (control == "Register")
            {
                registerControl1.Show();
            }
            else if (control == "PurchaseRequest")
            {
                purchaseRequest1.Show();
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
        }

        private void purchaseRequest1_Load(object sender, EventArgs e)
        {

        }
    }
}
