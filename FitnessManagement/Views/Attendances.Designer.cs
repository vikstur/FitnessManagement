namespace FitnessManagement.Views
{
    partial class Attendances
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
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(455, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBox1.Location = new Point(315, 255);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 21);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Fitness";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBox2.Location = new Point(315, 319);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 21);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "SPA";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBox3.Location = new Point(315, 386);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(124, 21);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Swimming pool";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(550, 255);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(449, 454);
            button1.Name = "button1";
            button1.Size = new Size(173, 44);
            button1.TabIndex = 5;
            button1.Text = "Create attendance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(85, 41);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(496, 255);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 7;
            label1.Text = "Date:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 20.25F, FontStyle.Bold);
            label2.Location = new Point(349, 64);
            label2.Name = "label2";
            label2.Size = new Size(389, 40);
            label2.TabIndex = 8;
            label2.Text = "Create attendance";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Attendances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Name = "Attendances";
            Size = new Size(1106, 756);
            Load += Attendances_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}
