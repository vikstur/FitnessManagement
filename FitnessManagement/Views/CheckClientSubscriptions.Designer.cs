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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
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
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(546, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(279, 209);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(546, 382);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 51);
            label1.Name = "label1";
            label1.Size = new Size(546, 90);
            label1.TabIndex = 3;
            label1.Text = "Ckeck client subscriptions";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CheckClientSubscriptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
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
        private Label label1;
    }
}
