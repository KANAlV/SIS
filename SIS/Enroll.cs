using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Mysqlx.Notice.Warning.Types;

namespace SIS
{
    public partial class Enroll : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        Form Prev;
        string stu_no;
        long newStudentId;
        public Enroll(Form Prev)
        {
            InitializeComponent();
            this.Prev = Prev;
            setTermField();
        }
        private void setTermField()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1950; i--)
            {
                int x = i + 1;
                comboBox5.Items.Add($"{i} - {x}");
                comboBox5.SelectedIndex = 0;
            }
        }
        private void setCourse(string level)
        {
            comboBox7.Items.Clear();
            string query = "SELECT course_code FROM course WHERE level = @level AND status = 'Active'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@level", Int32.Parse(level));
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string courseCode = reader["course_code"].ToString();
                                comboBox7.Items.Add(courseCode);
                            }
                        }
                    }
                }
            }
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCourse(comboBox8.Text);
        }

        private void Enroll_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(comboBox3.Text)) { Cont = false; Debug.WriteLine("cb3"); }//Guardin Req
            if (string.IsNullOrWhiteSpace(textBox6.Text)) { Cont = false; Debug.WriteLine("tb6"); }
            if (string.IsNullOrWhiteSpace(textBox7.Text)) { Cont = false; Debug.WriteLine("tb7"); }
            if (string.IsNullOrWhiteSpace(comboBox5.Text)) { Cont = false; Debug.WriteLine("cb5"); }//Enrollment
            if (string.IsNullOrWhiteSpace(comboBox6.Text)) { Cont = false; Debug.WriteLine("cb6"); }
            if (string.IsNullOrWhiteSpace(comboBox7.Text)) { Cont = false; Debug.WriteLine("cb7"); }
            if (string.IsNullOrWhiteSpace(comboBox8.Text)) { Cont = false; Debug.WriteLine("cb8"); }
            if (string.IsNullOrEmpty(textBox10.Text) || textBox10.Text == "Use only if formerly enrolled") // Stu Info Req
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
                if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
                if (Cont == true)
                {
                    insertGuardian();//guardian first
                    insertStudent();//student second
                    insertEnrollment();//enrollment last
                }
            }
            else
            {
                if (Cont == true)
                {
                    insertEnrollment();//enrollment last
                }
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

        private void textBox10_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "Use only if formerly enrolled")
            {
                textBox10.ForeColor = Color.Black;
                textBox10.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox10.Text) ||textBox10.Text != "Use only if formerly enrolled")
            {
                string query = $@"SELECT * FROM students WHERE student_id = {Int32.Parse(textBox10.Text)};";

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
                                    string Sur = reader["last_name"].ToString();
                                    string Fn = reader["first_name"].ToString();
                                    string Mi = reader["middle_name"].ToString();
                                    string Sfx = reader["suffix"].ToString();
                                    string Gen = reader["gender"].ToString();
                                    string email = reader["email"].ToString();
                                    string phn = reader["phone"].ToString();
                                    string stat = reader["status"].ToString();
                                    object photoObj = reader["photo"];

                                    if (photoObj != DBNull.Value && photoObj is byte[] bytes && bytes.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(bytes))
                                        {
                                            pictureBox1.Image = Image.FromStream(ms);
                                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        }
                                    }
                                    else
                                    {
                                        pictureBox1.Image = null; // or set a placeholder image.. idk?
                                    }

                                    if (reader["date_of_birth"] != DBNull.Value)
                                    {
                                        dateTimePicker2.Value = Convert.ToDateTime(reader["date_of_birth"]);
                                    }
                                    else
                                    {
                                        dateTimePicker2.Value = DateTime.Today; // or disable it, etc.
                                    }

                                    switch (Gen)
                                    {
                                        case "M":
                                            comboBox2.Text = "Male";
                                            break;
                                        case "F":
                                            comboBox2.Text = "Female";
                                            break;
                                        case "O":
                                            comboBox2.Text = "Other";
                                            break;
                                    }

                                    textBox1.Text = Sur;
                                    textBox2.Text = Fn;
                                    textBox3.Text = Mi;
                                    textBox4.Text = phn;
                                    textBox5.Text = email;
                                    comboBox1.Text = Sfx;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No Faculty found.");
                            }
                        }
                    }
                }
            }
        }
        private void insertGuardian()
        {
            string insertQuery = @"INSERT INTO student_guardian
                (guardian, surname, firstname, middle_int, phone, email)
                VALUES (
                    @GRD,
                    @SN,
                    @FN,
                    @MI,
                    @PHN,
                    @EM
                )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@GRD", textBox3.Text);
                command.Parameters.AddWithValue("@SN", comboBox6.Text);
                command.Parameters.AddWithValue("@FN", comboBox7.Text);
                command.Parameters.AddWithValue("@MI", textBox4.Text);
                command.Parameters.AddWithValue("@PHN", textBox8.Text);
                command.Parameters.AddWithValue("@EM", textBox9.Text);

                try
                {
                    connection.Open();
                    int rowsInserted = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsInserted} row(s) inserted.");
                    Console.WriteLine($"{rowsInserted} row(s) inserted.");
                    Debug.WriteLine($"{rowsInserted} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void insertStudent()
        {
            string insertQuery = @"INSERT INTO students
(first_name, last_name, middle_name, suffix, phone, email, date_of_birth, gender, status)
VALUES (
    @FN,
    @SN,
    @MN,
    @SFX,
    @PHN,
    @EM,
    @DoB,
    @GD,
    @Stat
)";

            long studentId;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@FN", textBox2.Text);
                command.Parameters.AddWithValue("@SN", textBox1.Text);
                command.Parameters.AddWithValue("@MN", textBox3.Text);
                command.Parameters.AddWithValue("@SFX", comboBox1.Text);
                command.Parameters.AddWithValue("@PHN", textBox4.Text);
                command.Parameters.AddWithValue("@EM", textBox5.Text);
                command.Parameters.AddWithValue("@DoB", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Stat", comboBox10.Text);

                switch (comboBox2.Text)
                {
                    case "Male":
                        command.Parameters.AddWithValue("@GD", "M");
                        break;
                    case "Female":
                        command.Parameters.AddWithValue("@GD", "F");
                        break;
                    case "Other":
                        command.Parameters.AddWithValue("@GD", "O");
                        break;
                    default:
                        command.Parameters.AddWithValue("@GD", DBNull.Value);
                        break;
                }

                try
                {
                    connection.Open();
                    int rowsInserted = command.ExecuteNonQuery();
                    studentId = command.LastInsertedId;
                    this.newStudentId = command.LastInsertedId;
                    MessageBox.Show($"{rowsInserted} row(s) inserted.");
                    Console.WriteLine($"{rowsInserted} row(s) inserted.");
                    Debug.WriteLine($"{rowsInserted} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                    return;
                }
            }

            // Get the latest guardian_id using LastInsertedId (if inserting guardian was done right before this)
            // Assuming guardian was just inserted and LastInsertedId is valid:
            long guardianId;

            string getGuardianIDQuery = "SELECT MAX(id) AS guardian_id FROM student_guardian";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(getGuardianIDQuery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            guardianId = reader.GetInt64("guardian_id");
                        }
                        else
                        {
                            MessageBox.Show("No guardian record found.");
                            return;
                        }
                    }
                }
            }

            string updateQuery = @"UPDATE student_guardian
SET guardian_id = @GID
WHERE student_id = @SID;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@SID", studentId);
                command.Parameters.AddWithValue("@GID", guardianId);

                try
                {
                    connection.Open();
                    int rowsUpdated = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsUpdated} row(s) updated.");
                    Console.WriteLine($"{rowsUpdated} row(s) updated.");
                    Debug.WriteLine($"{rowsUpdated} row(s) updated.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void insertEnrollment()
        {
            string insertQuery = @"INSERT INTO enrollment
(student_id, academic_term, semester, course_code, enrollment_date, payment_plan, status)
VALUES (
    @SID,
    @AT,
    @SEM,
    @CC,
    @ED,
    @PP,
    @STAT
)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@SID", this.newStudentId);
                command.Parameters.AddWithValue("@AT", comboBox5.Text);
                command.Parameters.AddWithValue("@SEM", comboBox6.Text);
                command.Parameters.AddWithValue("@CC", comboBox7.Text);
                command.Parameters.AddWithValue("@PP", comboBox9.Text);
                command.Parameters.AddWithValue("@STAT", comboBox10.Text);
                command.Parameters.AddWithValue("@ED", dateTimePicker2.Value);

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
