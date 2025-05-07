using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;

namespace SIS
{
    public partial class Add_Faculty : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        Form Fac;
        public Add_Faculty(Form Fac)
        {
            InitializeComponent();
            this.Fac = Fac;
            string query = @"SELECT code FROM department";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string courseCode = reader["code"].ToString();
                                comboBox4.Items.Add(courseCode);
                            }
                        }
                    }
                }
            }
        }

        private void Add_Faculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Fac.Visible = true;
        }

        private void Add_Faculty_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            switch (comboBox4.Text)
            {
                case "Admin":
                    comboBox5.Items.Add("Academic Affairs Officer");
                    comboBox5.Items.Add("Admissions Officer");
                    comboBox5.Items.Add("Assistant Registrar");
                    comboBox5.Items.Add("Curriculum Coordinator");
                    comboBox5.Items.Add("Database Administrator");
                    comboBox5.Items.Add("Dean");
                    comboBox5.Items.Add("Department Chair");
                    comboBox5.Items.Add("Enrollment Officer");
                    comboBox5.Items.Add("Finance / Billing Staff");
                    comboBox5.Items.Add("Program Coordinator");
                    comboBox5.Items.Add("Records Clerk");
                    comboBox5.Items.Add("Registrar");
                    comboBox5.Items.Add("Scheduling Officer");
                    comboBox5.Items.Add("System Administrator");
                    break;
                case "Faculty":
                    comboBox5.Items.Add("Academic Adviser");
                    comboBox5.Items.Add("Instructor");
                    comboBox5.Items.Add("Lecturer");
                    comboBox5.Items.Add("Professor");
                    break;
                case "Staff":
                    comboBox5.Items.Add("Guidance Counselor");
                    comboBox5.Items.Add("IT Support Staff");
                    comboBox5.Items.Add("Librarian");
                    comboBox5.Items.Add("School Nurse");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
