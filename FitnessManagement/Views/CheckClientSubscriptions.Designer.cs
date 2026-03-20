namespace FitnessManagement.Views
{
    partial class CheckClientSubscriptions
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
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(326, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(494, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(326, 206);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(494, 424);
            listBox1.TabIndex = 2;
            // 
            // CheckClientSubscriptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "CheckClientSubscriptions";
            Size = new Size(1106, 756);
            Load += CheckClientSubscriptions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}
