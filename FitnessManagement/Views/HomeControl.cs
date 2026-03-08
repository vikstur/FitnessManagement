using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessManagement.Views
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Login");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("Register");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("About");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            label1.Parent = this.pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = this.pictureBox1;
            label2.BackColor = Color.Transparent;
        }
    }
}
