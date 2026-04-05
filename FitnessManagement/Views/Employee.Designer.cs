namespace FitnessManagement.Views
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1106, 756);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(91, 42);
            button1.TabIndex = 1;
            button1.Text = "Rgym";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(275, 0);
            button2.Name = "button2";
            button2.Size = new Size(150, 44);
            button2.TabIndex = 2;
            button2.Text = "Attendances";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(447, 0);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 3;
            button3.Text = "Requsets";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(616, 0);
            button4.Name = "button4";
            button4.Size = new Size(150, 45);
            button4.TabIndex = 4;
            button4.Text = "Check client subscriptions";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold);
            label1.Location = new Point(368, 205);
            label1.Name = "label1";
            label1.Size = new Size(380, 204);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button5.Location = new Point(100, 0);
            button5.Name = "button5";
            button5.Size = new Size(150, 44);
            button5.TabIndex = 6;
            button5.Text = "Client search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button6.Location = new Point(789, 0);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 7;
            button6.Text = "Check visits by date";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button7.Location = new Point(1020, 0);
            button7.Name = "button7";
            button7.Size = new Size(86, 26);
            button7.TabIndex = 8;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Employee";
            Size = new Size(1106, 756);
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
