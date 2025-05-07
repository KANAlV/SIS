namespace SIS
{
    partial class Faculty
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
            button4 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            staff_id = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            middle_int = new DataGridViewTextBoxColumn();
            suffix = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(11, 74);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(41, 27);
            button4.TabIndex = 17;
            button4.Text = "⟳";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(149, 34);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(106, 38);
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
            button3.Location = new Point(744, 5);
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
            label4.Location = new Point(604, 37);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Position:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(664, 34);
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
            button2.Location = new Point(779, 34);
            button2.Name = "button2";
            button2.Size = new Size(45, 23);
            button2.TabIndex = 8;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(425, 37);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "First Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(255, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Surname:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { staff_id, status, code, surname, firstname, middle_int, suffix, gender, Department, role, position, phone, email });
            dataGridView1.Location = new Point(11, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(814, 351);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // staff_id
            // 
            staff_id.HeaderText = "id";
            staff_id.Name = "staff_id";
            staff_id.ReadOnly = true;
            staff_id.Visible = false;
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
            code.Width = 50;
            // 
            // surname
            // 
            surname.HeaderText = "Surname";
            surname.Name = "surname";
            surname.ReadOnly = true;
            // 
            // firstname
            // 
            firstname.HeaderText = "Firstname";
            firstname.Name = "firstname";
            firstname.ReadOnly = true;
            // 
            // middle_int
            // 
            middle_int.HeaderText = "M.I.";
            middle_int.Name = "middle_int";
            middle_int.ReadOnly = true;
            middle_int.Width = 30;
            // 
            // suffix
            // 
            suffix.HeaderText = "Suffix";
            suffix.Name = "suffix";
            suffix.ReadOnly = true;
            suffix.Width = 50;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 50;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            role.ReadOnly = true;
            role.Width = 70;
            // 
            // position
            // 
            position.HeaderText = "Position";
            position.Name = "position";
            position.ReadOnly = true;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
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
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 70);
            panel1.TabIndex = 16;
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 441);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Faculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private TextBox textBox5;
        private Label label5;
        private Button button3;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private DataGridViewTextBoxColumn staff_id;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn middle_int;
        private DataGridViewTextBoxColumn suffix;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
    }
}