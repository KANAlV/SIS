using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                                comboBox6.Items.Add(courseCode);
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
            comboBox5.Items.Clear();
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
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (string.IsNullOrWhiteSpace(comboBox2.Text)) { Cont = false; Debug.WriteLine("cb2"); }
            if (string.IsNullOrWhiteSpace(comboBox3.Text)) { Cont = false; Debug.WriteLine("cb3"); }
            if (string.IsNullOrWhiteSpace(comboBox4.Text)) { Cont = false; Debug.WriteLine("cb4"); }
            if (string.IsNullOrWhiteSpace(comboBox7.Text)) { Cont = false; Debug.WriteLine("cb4"); }
            if (Cont == true)
            {
                string insertQuery = @"INSERT INTO faculty
                (teacher_code, surname, firstname, middle_name, suffix, date_of_birth, gender, phone, email, employment_type, role, position, department, status, photo)
                VALUES (
                    @TC, @SN, @FN,
                    @MN, @SUF, @DoB,
                    @Gen, @Phn, @email,
                    @ET, @Rol, @Pos,
                    @Dept, @Stat, @Phot
                )";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    string teachCode = (textBox2.Text[0].ToString() + textBox3.Text[0].ToString() + textBox1.Text[0].ToString());

                    switch (comboBox2.Text)
                    {
                        case "Male":
                            command.Parameters.AddWithValue("@Gen", "M");
                            break;
                        case "Female":
                            command.Parameters.AddWithValue("@Gen", "F");
                            break;
                        case "Other":
                            command.Parameters.AddWithValue("@Gen", "O");
                            break;
                    }

                    command.Parameters.AddWithValue("@TC", teachCode);
                    command.Parameters.AddWithValue("@SN", textBox1.Text);
                    command.Parameters.AddWithValue("@FN", textBox2.Text);
                    command.Parameters.AddWithValue("@MN", textBox3.Text);
                    command.Parameters.AddWithValue("@SUF", comboBox1.Text);
                    command.Parameters.Add("@DoB", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command.Parameters.AddWithValue("@Phn", textBox4.Text);
                    command.Parameters.AddWithValue("@email", textBox5.Text);
                    command.Parameters.AddWithValue("@ET", comboBox3.Text);
                    command.Parameters.AddWithValue("@Rol", comboBox4.Text);
                    command.Parameters.AddWithValue("@Pos", comboBox5.Text);
                    command.Parameters.AddWithValue("@Dept", comboBox6.Text);
                    command.Parameters.AddWithValue("@Stat", comboBox7.Text);

                    byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
                    command.Parameters.AddWithValue("@Phot", imageBytes);
                    

                    try
                    {
                        connection.Open();
                        int rowsInserted = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsInserted} row(s) inserted.");
                        Console.WriteLine($"{rowsInserted} row(s) inserted.");
                        Debug.WriteLine($"{rowsInserted} row(s) inserted.");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
