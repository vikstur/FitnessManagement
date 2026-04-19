using FitnessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FitnessManagement.Models;

namespace FitnessManagement.Views
{
    public partial class ChangeRole : UserControl
    {
        private UserServices _userServices;
        public ChangeRole()
        {
            _userServices = new UserServices();
            InitializeComponent();
        }

        private void ChangeRole_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = _userServices.GetAllUsers();
            listBox1.DisplayMember = "FullNameWithRole";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is User selectedUser)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

                if (selectedUser.Role == "Client") { checkBox1.Checked = true; checkBox1.Visible = false; }
                else if (selectedUser.Role == "Employee") { checkBox2.Checked = true; checkBox2.Visible = false; }
                else if (selectedUser.Role == "Admin") { checkBox3.Checked = true; checkBox3.Visible = false; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem is User selectedUser)) return;

            string newRole = "";
            if (checkBox1.Checked && checkBox1.Visible) newRole = "Client";
            else if (checkBox2.Checked && checkBox2.Visible) newRole = "Employee";
            else if (checkBox3.Checked && checkBox3.Visible) newRole = "Admin";

            if (string.IsNullOrEmpty(newRole))
            {
                MessageBox.Show("Please select a new role.");
                return;
            }

            string msg = $"Are you sure you want to change {selectedUser.FirstName}'s role from {selectedUser.Role} to {newRole}?";
            DialogResult result = MessageBox.Show(msg, "Confirm Role Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool success = _userServices.UpdateUserRole(selectedUser.Id, newRole);

                if (success)
                {
                    MessageBox.Show("Role updated successfully!");
                    listBox1.DataSource = null;
                    listBox1.DataSource = _userServices.GetAllUsers();
                    listBox1.DisplayMember = "FullNameWithRole";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox2.Checked = false; checkBox3.Checked = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox1.Checked = false; checkBox3.Checked = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { checkBox1.Checked = false; checkBox2.Checked = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.Change("UserEdit");
        }
    }
}



