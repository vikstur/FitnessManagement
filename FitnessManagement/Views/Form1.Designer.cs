namespace FitnessManagement.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            aboutrGym1 = new AboutRGym();
            homeControl1 = new HomeControl();
            loginControl1 = new LoginControl();
            registerControl1 = new RegisterControl();
            clientControl1 = new ClientControl();
            purchaseRequest1 = new PurchaseRequest();
            requests2 = new Requests();
            checkSubscription1 = new CheckSubscription();
            employee1 = new Employee();
            attendances1 = new Attendances();
            checkVisits1 = new CheckVisits();
            checkClientSubscriptions1 = new CheckClientSubscriptions();
            clientSearch1 = new ClientSearch();
            checkVisitsByDate1 = new CheckVisitsByDate();
            SuspendLayout();
            // 
            // aboutrGym1
            // 
            aboutrGym1.Location = new Point(0, 0);
            aboutrGym1.Name = "aboutrGym1";
            aboutrGym1.Size = new Size(1106, 756);
            aboutrGym1.TabIndex = 0;
            // 
            // homeControl1
            // 
            homeControl1.Location = new Point(0, 0);
            homeControl1.Name = "homeControl1";
            homeControl1.Size = new Size(1106, 756);
            homeControl1.TabIndex = 1;
            // 
            // loginControl1
            // 
            loginControl1.Location = new Point(0, 0);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(1106, 756);
            loginControl1.TabIndex = 2;
            // 
            // registerControl1
            // 
            registerControl1.Location = new Point(0, 0);
            registerControl1.Name = "registerControl1";
            registerControl1.Size = new Size(1106, 756);
            registerControl1.TabIndex = 3;
            // 
            // clientControl1
            // 
            clientControl1.Location = new Point(0, 0);
            clientControl1.Name = "clientControl1";
            clientControl1.Size = new Size(1106, 756);
            clientControl1.TabIndex = 4;
            // 
            // purchaseRequest1
            // 
            purchaseRequest1.Location = new Point(0, 0);
            purchaseRequest1.Name = "purchaseRequest1";
            purchaseRequest1.Size = new Size(1106, 756);
            purchaseRequest1.TabIndex = 5;
            purchaseRequest1.Load += purchaseRequest1_Load;
            // 
            // requests2
            // 
            requests2.Location = new Point(0, 0);
            requests2.Name = "requests2";
            requests2.Size = new Size(1106, 756);
            requests2.TabIndex = 6;
            // 
            // checkSubscription1
            // 
            checkSubscription1.Location = new Point(0, 0);
            checkSubscription1.Name = "checkSubscription1";
            checkSubscription1.Size = new Size(1106, 756);
            checkSubscription1.TabIndex = 7;
            // 
            // employee1
            // 
            employee1.Location = new Point(0, 0);
            employee1.Name = "employee1";
            employee1.Size = new Size(1106, 756);
            employee1.TabIndex = 8;
            employee1.Load += employee1_Load;
            // 
            // attendances1
            // 
            attendances1.Location = new Point(0, 0);
            attendances1.Name = "attendances1";
            attendances1.Size = new Size(1106, 756);
            attendances1.TabIndex = 10;
            // 
            // checkVisits1
            // 
            checkVisits1.Location = new Point(0, 0);
            checkVisits1.Name = "checkVisits1";
            checkVisits1.Size = new Size(1106, 756);
            checkVisits1.TabIndex = 11;
            // 
            // checkClientSubscriptions1
            // 
            checkClientSubscriptions1.Location = new Point(0, 0);
            checkClientSubscriptions1.Name = "checkClientSubscriptions1";
            checkClientSubscriptions1.Size = new Size(1106, 756);
            checkClientSubscriptions1.TabIndex = 12;
            // 
            // clientSearch1
            // 
            clientSearch1.Location = new Point(0, 0);
            clientSearch1.Name = "clientSearch1";
            clientSearch1.Size = new Size(1106, 756);
            clientSearch1.TabIndex = 13;
            // 
            // checkVisitsByDate1
            // 
            checkVisitsByDate1.Location = new Point(0, 0);
            checkVisitsByDate1.Name = "checkVisitsByDate1";
            checkVisitsByDate1.Size = new Size(1106, 756);
            checkVisitsByDate1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 755);
            Controls.Add(checkVisitsByDate1);
            Controls.Add(clientSearch1);
            Controls.Add(checkClientSubscriptions1);
            Controls.Add(homeControl1);
            Controls.Add(checkVisits1);
            Controls.Add(attendances1);
            Controls.Add(employee1);
            Controls.Add(checkSubscription1);
            Controls.Add(requests2);
            Controls.Add(purchaseRequest1);
            Controls.Add(registerControl1);
            Controls.Add(loginControl1);
            Controls.Add(aboutrGym1);
            Controls.Add(clientControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AboutRGym aboutrGym1;
        private HomeControl homeControl1;
        public LoginControl loginControl1;
        private RegisterControl registerControl1;
        private ClientControl clientControl1;
        private PurchaseRequest purchaseRequest1;
        private Requests requests1;
        private Requests requests2;
        private CheckSubscription checkSubscription1;
        private Employee employee1;
        private Attendances attendances1;
        private CheckVisits checkVisits1;
        private CheckClientSubscriptions checkClientSubscriptions1;
        private ClientSearch clientSearch1;
        private CheckVisitsByDate checkVisitsByDate1;
    }
}