﻿namespace SIS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button9 = new Button();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(275, 235);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(267, 207);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Faculty";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(93, 136);
            button10.Name = "button10";
            button10.Size = new Size(79, 59);
            button10.TabIndex = 11;
            button10.Text = "Subjects";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 71);
            button8.Name = "button8";
            button8.Size = new Size(79, 59);
            button8.TabIndex = 10;
            button8.Text = "Faculty";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(178, 71);
            button7.Name = "button7";
            button7.Size = new Size(79, 59);
            button7.TabIndex = 9;
            button7.Text = "Department";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(8, 6);
            button5.Name = "button5";
            button5.Size = new Size(79, 59);
            button5.TabIndex = 4;
            button5.Text = "Student";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 136);
            button3.Name = "button3";
            button3.Size = new Size(79, 59);
            button3.TabIndex = 2;
            button3.Text = "Sections";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(8, 136);
            button2.Name = "button2";
            button2.Size = new Size(79, 59);
            button2.TabIndex = 1;
            button2.Text = "Courses";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 71);
            button1.Name = "button1";
            button1.Size = new Size(79, 59);
            button1.TabIndex = 0;
            button1.Text = "Enrollment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 6);
            button4.Name = "button4";
            button4.Size = new Size(79, 59);
            button4.TabIndex = 3;
            button4.Text = "Student Attendance";
            button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(178, 6);
            button9.Name = "button9";
            button9.Size = new Size(79, 59);
            button9.TabIndex = 8;
            button9.Text = "Diciplinary Records";
            button9.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 109, 183);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 40);
            panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 246);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information System";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button9;
        private Button button4;
        private Panel panel1;
    }
}
