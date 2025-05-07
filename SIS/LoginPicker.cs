using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class LoginPicker : Form
    {
        public LoginPicker()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
            StudentLogin.BackColor = Color.Transparent;
            FacultyLogin.BackColor = Color.Transparent;
            panel1.BackColor = Color.FromArgb(180, 255, 255, 255);
            StudentLogin.BackColor = Color.FromArgb(180, 255, 255, 255);
            FacultyLogin.BackColor = Color.FromArgb(180, 255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            StudentLogin.Visible = true;
            StuUsername.Enabled = true;
            StuPassword.Enabled = true;
            StuLogin.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            FacultyLogin.Visible = true;
            FacUsername.Enabled = true;
            FacPassword.Enabled = true;
            FacLogin.Enabled = true;
        }

        private void FacLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void StuLogin_Click(object sender, EventArgs e)
        {

        }

        private void FacUsername_Click(object sender, EventArgs e)
        {
            if (FacUsername.Text == "Username")
            {
                FacUsername.Clear();
                FacUsername.ForeColor = Color.Black;
            }
        }

        private void FacPassword_Click(object sender, EventArgs e)
        {
            if (FacPassword.Text == "Password")
            {
                FacPassword.Clear();
                FacPassword.ForeColor = Color.Black;
            }
        }

        private void StuUsername_Click(object sender, EventArgs e)
        {
            if (StuUsername.Text == "Username")
            {
                StuUsername.Clear();
                StuUsername.ForeColor = Color.Black;
            }
        }

        private void StuPassword_Click(object sender, EventArgs e)
        {
            if (StuPassword.Text == "Password")
            {
                StuPassword.Clear();
                StuPassword.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            StudentLogin.Visible = false;
            StuUsername.Enabled = false;
            StuPassword.Enabled = false;
            StuLogin.Enabled = false;
            FacultyLogin.Visible = false;
            FacUsername.Enabled = false;
            FacPassword.Enabled = false;
            FacLogin.Enabled = false;
        }
    }
}
