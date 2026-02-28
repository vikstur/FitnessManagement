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
        public PurchaseRequest()
        {
            InitializeComponent();
        }

        private void PurchaseRequest_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox4;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox5;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox6;
            label6.BackColor = Color.Transparent;
           
        }
    }
}
