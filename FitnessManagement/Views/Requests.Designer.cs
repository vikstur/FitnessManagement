namespace FitnessManagement.Views
{
    partial class Requests
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(76, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(955, 664);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(829, 655);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 1;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(932, 655);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 2;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(76, 36);
            button3.TabIndex = 3;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Requests";
            Size = new Size(1106, 756);
            Load += Requests_Load;
            VisibleChanged += Requests_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
