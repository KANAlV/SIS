namespace SIS
{
    partial class Add_Course
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label7 = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Course Name:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 15);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Course Code:*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 44);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Program Type:*";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Undergraduate", "Graduate", "Diploma", "Foundation", "Doctorate" });
            comboBox1.Location = new Point(102, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 44);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Year Level:*";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "11", "12", "1", "2", "3", "4" });
            comboBox2.Location = new Point(299, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(107, 23);
            comboBox2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 44);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 12;
            label6.Text = "Semester Offered:*";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1st", "2nd", "3rd", "1st, 2nd", "All" });
            comboBox3.Location = new Point(524, 41);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(88, 23);
            comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(102, 70);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(90, 23);
            comboBox4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 73);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 14;
            label7.Text = "Department:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 52);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(188, 154);
            listBox1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(412, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 216);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subjects";
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 20;
            textBox4.Text = "Search...";
            textBox4.Click += textBox4_Click;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(14, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 187);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 158);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 109, 183);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(537, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 73);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 21;
            label5.Text = "Course Fee:*";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 20;
            // 
            // Add_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            Name = "Add_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Course";
            FormClosed += Add_Course_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label7;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
    }
}