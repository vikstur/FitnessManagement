namespace FitnessManagement.Views
{
    partial class CheckVisitsByPeriod
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
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(85, 41);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(529, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(452, 479);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(109, 151);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(109, 360);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "To:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(221, 151);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(221, 360);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(221, 607);
            button2.Name = "button2";
            button2.Size = new Size(220, 43);
            button2.TabIndex = 6;
            button2.Text = "Check visits";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Stencil", 24F, FontStyle.Bold);
            label3.Location = new Point(293, 39);
            label3.Name = "label3";
            label3.Size = new Size(525, 65);
            label3.TabIndex = 7;
            label3.Text = "Check visits by period";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckVisitsByPeriod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "CheckVisitsByPeriod";
            Size = new Size(1106, 756);
            Load += CheckVisitsByPeriod_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Button button2;
        private Label label3;
    }
}
