namespace SIS
{
    partial class Add_Subjects
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
            button1 = new Button();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            button1.TabIndex = 49;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(14, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 187);
            groupBox2.TabIndex = 48;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(412, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 242);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prerequisite Subject";
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 20;
            textBox4.Text = "Search...";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 52);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(188, 184);
            listBox1.TabIndex = 16;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(102, 38);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(123, 23);
            comboBox4.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 41);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 45;
            label7.Text = "Department:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "11", "12", "1", "2", "3", "4" });
            comboBox2.Location = new Point(299, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(107, 23);
            comboBox2.TabIndex = 42;
            comboBox2.TextChanged += comboBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 41);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 41;
            label4.Text = "Year Level:*";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox1.Location = new Point(102, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 73);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 39;
            label3.Text = "Units:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 12);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 38;
            label2.Text = "Subject Code:*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 36;
            label1.Text = "Subject Name:*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 35;
            // 
            // Add_Subjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Add_Subjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Subjects";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private ListBox listBox1;
        private ComboBox comboBox4;
        private Label label7;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}