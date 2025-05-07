namespace SIS
{
    partial class LoginPicker
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            FacultyLogin = new Panel();
            FacPassword = new TextBox();
            FacUsername = new TextBox();
            FacLogin = new Button();
            label3 = new Label();
            panel6 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            StuLogin = new Button();
            StuUsername = new TextBox();
            StuPassword = new TextBox();
            StudentLogin = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            FacultyLogin.SuspendLayout();
            StudentLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(551, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 450);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 109, 183);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(37, 185);
            button2.Name = "button2";
            button2.Size = new Size(175, 35);
            button2.TabIndex = 4;
            button2.Text = "Faculty";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(254, 242, 1);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(37, 144);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 3;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 115);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 2;
            label2.Text = "Please select your account type.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 85);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome! STI'ers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources._301984799_571766621409327_8915003716152042908_n;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(89, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 70);
            panel2.TabIndex = 0;
            // 
            // FacultyLogin
            // 
            FacultyLogin.Controls.Add(FacPassword);
            FacultyLogin.Controls.Add(FacUsername);
            FacultyLogin.Controls.Add(FacLogin);
            FacultyLogin.Controls.Add(label3);
            FacultyLogin.Controls.Add(panel6);
            FacultyLogin.Location = new Point(551, 0);
            FacultyLogin.Name = "FacultyLogin";
            FacultyLogin.Size = new Size(249, 450);
            FacultyLogin.TabIndex = 7;
            FacultyLogin.Visible = false;
            // 
            // FacPassword
            // 
            FacPassword.Enabled = false;
            FacPassword.ForeColor = SystemColors.ScrollBar;
            FacPassword.Location = new Point(37, 161);
            FacPassword.Name = "FacPassword";
            FacPassword.Size = new Size(175, 23);
            FacPassword.TabIndex = 6;
            FacPassword.Text = "Password";
            FacPassword.Click += FacPassword_Click;
            // 
            // FacUsername
            // 
            FacUsername.Enabled = false;
            FacUsername.ForeColor = SystemColors.ScrollBar;
            FacUsername.Location = new Point(37, 132);
            FacUsername.Name = "FacUsername";
            FacUsername.Size = new Size(175, 23);
            FacUsername.TabIndex = 5;
            FacUsername.Text = "Username";
            FacUsername.Click += FacUsername_Click;
            // 
            // FacLogin
            // 
            FacLogin.BackColor = Color.FromArgb(1, 109, 183);
            FacLogin.Enabled = false;
            FacLogin.FlatStyle = FlatStyle.Flat;
            FacLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FacLogin.ForeColor = Color.White;
            FacLogin.Location = new Point(37, 369);
            FacLogin.Name = "FacLogin";
            FacLogin.Size = new Size(175, 35);
            FacLogin.TabIndex = 4;
            FacLogin.Text = "Login";
            FacLogin.UseVisualStyleBackColor = false;
            FacLogin.Click += FacLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 85);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 1;
            label3.Text = "Faculty Login";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources._301984799_571766621409327_8915003716152042908_n;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(89, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(70, 70);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources._301984799_571766621409327_8915003716152042908_n;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(89, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(70, 70);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 85);
            label4.Name = "label4";
            label4.Size = new Size(152, 30);
            label4.TabIndex = 1;
            label4.Text = "Student Login";
            // 
            // StuLogin
            // 
            StuLogin.BackColor = Color.FromArgb(1, 109, 183);
            StuLogin.Enabled = false;
            StuLogin.FlatStyle = FlatStyle.Flat;
            StuLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StuLogin.ForeColor = Color.White;
            StuLogin.Location = new Point(37, 369);
            StuLogin.Name = "StuLogin";
            StuLogin.Size = new Size(175, 35);
            StuLogin.TabIndex = 4;
            StuLogin.Text = "Login";
            StuLogin.UseVisualStyleBackColor = false;
            StuLogin.Click += StuLogin_Click;
            // 
            // StuUsername
            // 
            StuUsername.Enabled = false;
            StuUsername.ForeColor = SystemColors.ScrollBar;
            StuUsername.Location = new Point(37, 132);
            StuUsername.Name = "StuUsername";
            StuUsername.Size = new Size(175, 23);
            StuUsername.TabIndex = 5;
            StuUsername.Text = "Username";
            StuUsername.Click += StuUsername_Click;
            // 
            // StuPassword
            // 
            StuPassword.Enabled = false;
            StuPassword.ForeColor = SystemColors.ScrollBar;
            StuPassword.Location = new Point(37, 161);
            StuPassword.Name = "StuPassword";
            StuPassword.Size = new Size(175, 23);
            StuPassword.TabIndex = 6;
            StuPassword.Text = "Password";
            StuPassword.Click += StuPassword_Click;
            // 
            // StudentLogin
            // 
            StudentLogin.Controls.Add(StuPassword);
            StudentLogin.Controls.Add(StuUsername);
            StudentLogin.Controls.Add(StuLogin);
            StudentLogin.Controls.Add(label4);
            StudentLogin.Controls.Add(panel4);
            StudentLogin.Location = new Point(551, 0);
            StudentLogin.Name = "StudentLogin";
            StudentLogin.Size = new Size(249, 450);
            StudentLogin.TabIndex = 5;
            StudentLogin.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(1, 109, 183);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(558, 7);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(31, 34);
            button3.TabIndex = 7;
            button3.Text = "<";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // LoginPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_05_04_234610;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(FacultyLogin);
            Controls.Add(StudentLogin);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginPicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            FacultyLogin.ResumeLayout(false);
            FacultyLogin.PerformLayout();
            StudentLogin.ResumeLayout(false);
            StudentLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Panel FacultyLogin;
        private TextBox FacPassword;
        private TextBox FacUsername;
        private Button FacLogin;
        private Label label3;
        private Panel panel6;
        private Panel panel4;
        private Label label4;
        private Button StuLogin;
        private TextBox StuUsername;
        private TextBox StuPassword;
        private Panel StudentLogin;
        private Button button3;
    }
}