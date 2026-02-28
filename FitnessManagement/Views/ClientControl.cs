using FitnessManagement.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessManagement.Views
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                label1.Text =
                    "Welcome to RGym " + UserSession.CurrentUser.FirstName + ", you can buy a subscription from here:";
                label1.Parent = pictureBox1;
                label1.BackColor = Color.Transparent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Client");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("PurchaseRequest");
        }
    }
}
