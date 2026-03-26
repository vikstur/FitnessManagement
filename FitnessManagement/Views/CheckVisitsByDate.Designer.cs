namespace FitnessManagement.Views
{
    partial class CheckVisitsByDate
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(85, 41);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(191, 141);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold);
            label1.Location = new Point(191, 58);
            label1.Name = "label1";
            label1.Size = new Size(753, 62);
            label1.TabIndex = 2;
            label1.Text = "check the visits for specific date here";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(481, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(452, 499);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(25, 141);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 4;
            label2.Text = "Choose date:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(191, 325);
            button2.Name = "button2";
            button2.Size = new Size(220, 38);
            button2.TabIndex = 5;
            button2.Text = "Check visits";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CheckVisitsByDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Name = "CheckVisitsByDate";
            Size = new Size(1106, 756);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Button button2;
    }
}
