namespace FitnessManagement.Views
{
    partial class AdminSubscriptionsCheck
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
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(82, 39);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(253, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(576, 529);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(253, 668);
            button2.Name = "button2";
            button2.Size = new Size(124, 44);
            button2.TabIndex = 2;
            button2.Text = "Active subscriptions";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(562, 668);
            button3.Name = "button3";
            button3.Size = new Size(124, 44);
            button3.TabIndex = 3;
            button3.Text = "Expired subscriptions";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(705, 668);
            button4.Name = "button4";
            button4.Size = new Size(124, 44);
            button4.TabIndex = 4;
            button4.Text = "Cancel subscription";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button5.Location = new Point(404, 668);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 5;
            button5.Text = "Most used";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold);
            label1.Location = new Point(319, 46);
            label1.Name = "label1";
            label1.Size = new Size(440, 46);
            label1.TabIndex = 6;
            label1.Text = "Subscriptions information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminSubscriptionsCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "AdminSubscriptionsCheck";
            Size = new Size(1106, 756);
            Load += AdminActiveSubscriptions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
