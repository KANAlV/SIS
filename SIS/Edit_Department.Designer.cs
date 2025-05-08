namespace SIS
{
    partial class Edit_Department
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox6 = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(87, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 23);
            comboBox1.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 116);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 80;
            label5.Text = "Dept Head':";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 76;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 78);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 77;
            label4.Text = "Phone:";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(275, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 79;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(57, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 78;
            // 
            // comboBox6
            // 
            comboBox6.Enabled = false;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Active", "Archived" });
            comboBox6.Location = new Point(213, 163);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(102, 23);
            comboBox6.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 167);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 74;
            label8.Text = "Active:*";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 109, 183);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(321, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 73;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 72;
            label2.Text = "Dept. Code:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(87, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 70;
            label1.Text = "Dept. Name:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(87, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 69;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(1, 109, 183);
            button3.Location = new Point(321, 163);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 82;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 184);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 83;
            label6.Text = "Last Updated:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 184);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 84;
            label7.Text = "##/##/##";
            // 
            // Edit_Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 201);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox6);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Edit_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            FormClosed += Edit_Department_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox6;
        private Label label8;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Label label6;
        private Label label7;
    }
}