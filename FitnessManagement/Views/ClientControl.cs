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
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
