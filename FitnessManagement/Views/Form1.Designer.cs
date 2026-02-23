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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 717);
            Controls.Add(loginControl1);
            Controls.Add(registerControl1);
            Controls.Add(homeControl1);
            Controls.Add(aboutrGym1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AboutRGym aboutrGym1;
        private HomeControl homeControl1;
        private LoginControl loginControl1;
        private RegisterControl registerControl1;
    }
}