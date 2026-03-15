namespace FitnessManagement.Views
{
    partial class CheckVisits
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(233, 147);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(676, 499);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label1.Location = new Point(342, 35);
            label1.Name = "label1";
            label1.Size = new Size(437, 88);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(87, 39);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheckVisits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "CheckVisits";
            Size = new Size(1106, 756);
            Load += CheckVisits_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
    }
}
