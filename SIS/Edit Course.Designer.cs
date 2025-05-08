namespace SIS
{
    partial class Edit_Course
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
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label9 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox6 = new ComboBox();
            label8 = new Label();
            label14 = new Label();
            label15 = new Label();
            button3 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 158);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(14, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 187);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 20;
            textBox4.Text = "Search...";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(412, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 245);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prerequisite Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 228);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 90;
            label5.Text = "##";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 227);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 89;
            label9.Text = "Total Units:";
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 52);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(188, 169);
            listBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 109, 183);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(537, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(102, 70);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(79, 23);
            comboBox4.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 73);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 32;
            label7.Text = "Department:";
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1st", "2nd", "3rd", "1st, 2nd", "All" });
            comboBox3.Location = new Point(299, 70);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(103, 23);
            comboBox3.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 73);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 30;
            label6.Text = "Semester Offered:*";
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "11", "12", "1", "2", "3", "4" });
            comboBox2.Location = new Point(299, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(103, 23);
            comboBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 41);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 27;
            label4.Text = "Year Level:*";
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Undergraduate", "Graduate", "Diploma", "Foundation", "Doctorate" });
            comboBox1.Location = new Point(102, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 41);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 25;
            label3.Text = "Program Type:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 12);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 24;
            label2.Text = "Course Code:*";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(484, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 22;
            label1.Text = "Course Name:*";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(102, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 21;
            // 
            // comboBox6
            // 
            comboBox6.Enabled = false;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Active", "Archived" });
            comboBox6.Location = new Point(429, 289);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(102, 23);
            comboBox6.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 293);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 38;
            label8.Text = "Active:*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(77, 306);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 88;
            label14.Text = "##/##/##";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(2, 306);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 87;
            label15.Text = "Last Updated:";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(1, 109, 183);
            button3.Location = new Point(537, 288);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 91;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Edit_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(button3);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(comboBox6);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Edit_Course";
            Text = "Edit_Course";
            FormClosed += Edit_Course_FormClosed;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private ComboBox comboBox4;
        private Label label7;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox6;
        private Label label8;
        private Label label14;
        private Label label15;
        private Label label5;
        private Label label9;
        private Button button3;
    }
}