namespace FitnessManagement.Views
{
    partial class ChangeRole
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(81, 41);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox1.Location = new Point(341, 511);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 25);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Client";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox2.Location = new Point(472, 511);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(110, 25);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Employee";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox3.Location = new Point(619, 511);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(110, 25);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Admin";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(341, 158);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 329);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(418, 576);
            button2.Name = "button2";
            button2.Size = new Size(230, 47);
            button2.TabIndex = 5;
            button2.Text = "Save changes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangeRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "ChangeRole";
            Size = new Size(1106, 756);
            Load += ChangeRole_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ListBox listBox1;
        private Button button2;
    }
}
