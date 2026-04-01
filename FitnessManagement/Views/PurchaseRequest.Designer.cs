namespace FitnessManagement.Views
{
    partial class PurchaseRequest
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
            button7 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.Location = new Point(0, -1);
            button7.Name = "button7";
            button7.Size = new Size(102, 48);
            button7.TabIndex = 24;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(438, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(350, 16);
            label1.Name = "label1";
            label1.Size = new Size(449, 125);
            label1.TabIndex = 26;
            label1.Text = "Nesh text ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(359, 260);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 0;
            label2.Text = "Price";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(359, 333);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 0;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(359, 415);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 27;
            label4.Text = "Services";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(438, 259);
            label5.Name = "label5";
            label5.Size = new Size(279, 23);
            label5.TabIndex = 28;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(438, 332);
            label6.Name = "label6";
            label6.Size = new Size(279, 23);
            label6.TabIndex = 29;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(438, 414);
            label7.Name = "label7";
            label7.Size = new Size(279, 23);
            label7.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(440, 548);
            button1.Name = "button1";
            button1.Size = new Size(277, 48);
            button1.TabIndex = 31;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(359, 487);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 32;
            label8.Text = "Visits";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(438, 487);
            label9.Name = "label9";
            label9.Size = new Size(279, 23);
            label9.TabIndex = 33;
            // 
            // PurchaseRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Name = "PurchaseRequest";
            Size = new Size(1106, 756);
            Load += PurchaseRequest_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button7;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}
