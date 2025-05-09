namespace SIS
{
    partial class Add_Faculty
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label12 = new Label();
            comboBox7 = new ComboBox();
            label13 = new Label();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Surname:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 22);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Middle Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(508, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(666, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(545, 55);
            dateTimePicker1.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2025, 5, 7, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jr.", "Sr.", "II", "III", "PhD", "EdD", "MD", "DVM", "CPA", "RN", "Esq." });
            comboBox1.Location = new Point(69, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 23);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 61);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Suffix:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 61);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "Gender:*";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox2.Location = new Point(293, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 58);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 12;
            label6.Text = "Birth Date:*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 186);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // button1
            // 
            button1.Location = new Point(666, 157);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 17;
            button1.Text = "Choose File...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(283, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 23);
            textBox5.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 113);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 113);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 13;
            label7.Text = "Phone No.:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 223);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 18;
            label9.Text = "Employment Type:*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(265, 223);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 19;
            label10.Text = "Role:*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(439, 223);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 20;
            label11.Text = "Position:*";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contractual" });
            comboBox3.Location = new Point(132, 220);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 21;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Admin", "Faculty", "Staff" });
            comboBox4.Location = new Point(304, 220);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 22;
            comboBox4.TextChanged += comboBox4_TextChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(498, 220);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(173, 23);
            comboBox5.TabIndex = 23;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(100, 256);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(173, 23);
            comboBox6.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 259);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 24;
            label12.Text = "Department:";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Active", "On Leave", "Resigned", "Suspended", "Retired", "Terminated" });
            comboBox7.Location = new Point(634, 296);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(102, 23);
            comboBox7.TabIndex = 61;
            comboBox7.Text = "Active";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(585, 300);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 60;
            label13.Text = "Status:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 109, 183);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(742, 296);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 59;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add_Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 331);
            Controls.Add(comboBox7);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(comboBox6);
            Controls.Add(label12);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Add_Faculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Faculty";
            FormClosed += Add_Faculty_FormClosed;
            Load += Add_Faculty_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label12;
        private ComboBox comboBox7;
        private Label label13;
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}