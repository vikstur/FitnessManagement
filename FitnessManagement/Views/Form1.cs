using FitnessManagement.Models;
using FitnessManagement.Services;
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
            new SubscriptionServices().UpdateExpiredStatusesInDb();
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
                requests3.Show();
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
            else if (control == "CheckClientSubscriptions")
            {
                HideEverything();
               checkClientSubscriptions1.Show();
            }
            else if (control == "ClientSearch")
            {
                HideEverything();
                clientSearch1.Show();
            }
            else if (control == "CheckVisitsByDate")
            {
                HideEverything();
                checkVisitsByDate1.Show();
            }
            else if (control == "Admin")
            {
                HideEverything();
                admin1.Show();
            }
            else if (control == "AdminSubscriptions")
            {
                HideEverything();
                adminSubscriptions1.Show();
            }
            else if (control == "EditSubscription")
            {
                HideEverything();
                editSubscription1.Show();
            }
            else if (control == "CreateSubscriptionType")
            {
                HideEverything();
                createSubscriptionType1.Show();
            }
            else if (control == "CheckVisitsByPeriod")
            {
                HideEverything();
                checkVisitsByPeriod1.Show();
            }
            else if (control == "AdminActiveSubscriptions")
            {
                HideEverything();
                adminActiveSubscriptions1.Show();
            }
            else if (control == "UserEdit")
            {
                HideEverything();
                clientEdit1.Show();
            }
            else if (control == "UserNameEdit")
            {
                HideEverything();
                userNameEdit1.Show();
            }
            else if (control == "ChangeRole")
            {
                HideEverything();
                changeRole1.Show();
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
            requests3.Hide();
            checkSubscription1.Hide();
            employee1.Hide();
            attendances1.Hide();
            checkVisits1.Hide();
            checkClientSubscriptions1.Hide();
            clientSearch1.Hide();
            checkVisitsByDate1.Hide();
            admin1.Hide();
            adminSubscriptions1.Hide();
            editSubscription1.Hide();
            createSubscriptionType1.Hide();
            checkVisitsByPeriod1.Hide();
            adminActiveSubscriptions1.Hide();
            clientEdit1.Hide();
            userNameEdit1.Hide();
            changeRole1.Hide();
        }

        private void purchaseRequest1_Load(object sender, EventArgs e)
        {

        }
        public void TransferDataToEdit(SubscriptionType type)
        {
            this.editSubscription1.SetSubscriptionData(type);
        }
        public void TransferToEditName(string name)
        {
            this.userNameEdit1.SetTargetPerson(name);
            this.Change("UserNameEdit");
        }
        private void employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
