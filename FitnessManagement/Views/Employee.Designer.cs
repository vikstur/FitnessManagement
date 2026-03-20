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
            // 
            // button2
            // 
            button2.Location = new Point(492, 1);
            button2.Name = "button2";
            button2.Size = new Size(150, 44);
            button2.TabIndex = 2;
            button2.Text = "Attendances";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(737, 0);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 3;
            button3.Text = "Requsets";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(956, 0);
            button4.Name = "button4";
            button4.Size = new Size(150, 45);
            button4.TabIndex = 4;
            button4.Text = "Check Client Subscriptions";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Location = new Point(368, 205);
            label1.Name = "label1";
            label1.Size = new Size(380, 204);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Employee";
            Size = new Size(1106, 756);
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
    }
}
