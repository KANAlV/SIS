﻿namespace SIS
{
    partial class Courses
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            course_id = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            units = new DataGridViewTextBoxColumn();
            semesters = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            programtype = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            prerequisites = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, status, code, course, units, semesters, level, programtype, department, prerequisites });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(814, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(276, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(432, 43);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Level:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(475, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 109, 183);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 70);
            panel1.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(127, 44);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 13;
            label5.Text = "Code:";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(1, 109, 183);
            button3.Location = new Point(744, 11);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 11;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(581, 43);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 10;
            label4.Text = "Prerequisites:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(664, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(1, 109, 183);
            button2.Location = new Point(779, 40);
            button2.Name = "button2";
            button2.Size = new Size(45, 23);
            button2.TabIndex = 8;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 109, 183);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(39, 33);
            button1.TabIndex = 7;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(12, 75);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(41, 28);
            button4.TabIndex = 14;
            button4.Text = "⟳";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // course_id
            // 
            course_id.HeaderText = "id";
            course_id.Name = "course_id";
            course_id.ReadOnly = true;
            course_id.Visible = false;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 80;
            // 
            // code
            // 
            code.HeaderText = "Code";
            code.Name = "code";
            code.ReadOnly = true;
            // 
            // course
            // 
            course.HeaderText = "Course";
            course.Name = "course";
            course.ReadOnly = true;
            course.Width = 150;
            // 
            // units
            // 
            units.HeaderText = "Units";
            units.Name = "units";
            units.ReadOnly = true;
            // 
            // semesters
            // 
            semesters.HeaderText = "Semesters";
            semesters.Name = "semesters";
            semesters.ReadOnly = true;
            semesters.Width = 70;
            // 
            // level
            // 
            level.HeaderText = "Level";
            level.Name = "level";
            level.ReadOnly = true;
            // 
            // programtype
            // 
            programtype.HeaderText = "Type";
            programtype.Name = "programtype";
            programtype.ReadOnly = true;
            // 
            // department
            // 
            department.HeaderText = "Department";
            department.Name = "department";
            department.ReadOnly = true;
            // 
            // prerequisites
            // 
            prerequisites.HeaderText = "Subjects";
            prerequisites.Name = "prerequisites";
            prerequisites.ReadOnly = true;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 441);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Courses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private Label label5;
        private Button button4;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn units;
        private DataGridViewTextBoxColumn semesters;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn programtype;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn prerequisites;
    }
}