namespace FitnessManagement
{
    partial class LoginControl
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 0;
            button1.Text = "RGym";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Text", 27.75F, FontStyle.Bold);
            label1.Location = new Point(493, 81);
            label1.Name = "label1";
            label1.Size = new Size(128, 53);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            label2.Location = new Point(331, 197);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            label3.Location = new Point(301, 276);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 28);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 276);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 28);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(597, 364);
            button2.Name = "button2";
            button2.Size = new Size(98, 33);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(424, 364);
            button3.Name = "button3";
            button3.Size = new Size(98, 33);
            button3.TabIndex = 7;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "LoginControl";
            Size = new Size(1106, 756);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
         public TextBox textBox1;
        public TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}
