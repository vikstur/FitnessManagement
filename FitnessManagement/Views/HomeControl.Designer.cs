namespace FitnessManagement.Views
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(358, 82);
            label1.Name = "label1";
            label1.Size = new Size(388, 61);
            label1.TabIndex = 0;
            label1.Text = "Welcome to RGym";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1106, 756);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(8, 8);
            button1.Name = "button1";
            button1.Size = new Size(185, 42);
            button1.TabIndex = 2;
            button1.Text = "About RGym";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(925, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1017, 8);
            button3.Name = "button3";
            button3.Size = new Size(75, 26);
            button3.TabIndex = 4;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(358, 170);
            label2.Name = "label2";
            label2.Size = new Size(388, 189);
            label2.TabIndex = 5;
            label2.Text = "Working time 8:00-22:00\r\n\r\nFor more information, please login\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "HomeControl";
            Size = new Size(1106, 756);
            Load += HomeControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
