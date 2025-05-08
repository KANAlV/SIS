namespace SIS
{
    partial class Edit_Faculty
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
            openFileDialog1 = new OpenFileDialog();
            comboBox7 = new ComboBox();
            label13 = new Label();
            comboBox6 = new ComboBox();
            label12 = new Label();
            comboBox5 = new ComboBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button3 = new Button();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox7
            // 
            comboBox7.Enabled = false;
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Active", "On Leave", "Resigned", "Suspended", "Retired", "Terminated" });
            comboBox7.Location = new Point(625, 297);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(102, 23);
            comboBox7.TabIndex = 73;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(576, 301);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 72;
            label13.Text = "Status:";
            // 
            // comboBox6
            // 
            comboBox6.Enabled = false;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(91, 257);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(173, 23);
            comboBox6.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 260);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 69;
            label12.Text = "Department:";
            // 
            // comboBox5
            // 
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(489, 221);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(173, 23);
            comboBox5.TabIndex = 68;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(666, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 109, 183);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(733, 297);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 71;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Admin", "Faculty", "Staff" });
            comboBox4.Location = new Point(295, 221);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 67;
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contractual" });
            comboBox3.Location = new Point(123, 221);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 66;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(430, 224);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 65;
            label11.Text = "Position:*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(256, 224);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 64;
            label10.Text = "Role:*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 224);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 63;
            label9.Text = "Employment Type:*";
            // 
            // button1
            // 
            button1.Enabled = false;
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
            textBox5.Enabled = false;
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
            textBox4.Enabled = false;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 58);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 12;
            label6.Text = "Birth Date:*";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(69, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 3;
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
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox2.Location = new Point(293, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 61);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Suffix:";
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
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jr.", "Sr.", "II", "III", "PhD", "EdD", "MD", "DVM", "CPA", "RN", "Esq." });
            comboBox1.Location = new Point(69, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 23);
            comboBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(281, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(545, 55);
            dateTimePicker1.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2025, 5, 7, 0, 0, 0, 0);
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(508, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 5;
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
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 186);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
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
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(1, 109, 183);
            button3.Location = new Point(733, 297);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 74;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseHover += button3_MouseHover;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(76, 316);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 86;
            label14.Text = "##/##/##";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1, 316);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 85;
            label15.Text = "Last Updated:";
            // 
            // Edit_Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 331);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(button3);
            Controls.Add(comboBox7);
            Controls.Add(label13);
            Controls.Add(comboBox6);
            Controls.Add(label12);
            Controls.Add(comboBox5);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Edit_Faculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculty";
            FormClosed += Edit_Faculty_FormClosed;
            Load += Edit_Faculty_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox7;
        private Label label13;
        private ComboBox comboBox6;
        private Label label12;
        private ComboBox comboBox5;
        private PictureBox pictureBox1;
        private Button button2;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button1;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Label label1;
        private Button button3;
        private Label label14;
        private Label label15;
    }
}