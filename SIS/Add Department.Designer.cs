namespace SIS
{
    partial class Add_Department
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
            comboBox6 = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Active", "Archived" });
            comboBox6.Location = new Point(215, 166);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(102, 23);
            comboBox6.TabIndex = 58;
            comboBox6.Text = "Active";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 170);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 57;
            label8.Text = "Active:*";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 109, 183);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(323, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 55;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 43;
            label2.Text = "Dept. Code:*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 23);
            textBox2.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 41;
            label1.Text = "Dept. Name:*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 23);
            comboBox1.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 119);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 67;
            label5.Text = "Dept Head':";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 81);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 63;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 81);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 64;
            label4.Text = "Phone:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 66;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(59, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 65;
            // 
            // Add_Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 201);
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
            Name = "Add_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Department";
            FormClosed += Add_Department_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox6;
        private Label label8;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}