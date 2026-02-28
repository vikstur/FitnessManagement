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
            if (control=="Home")
            {
                homeControl1.Show();
            }
            else if (control=="Client")
            {
                clientControl1.Show();
            }
        }
       
    }
}
