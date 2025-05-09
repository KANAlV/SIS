using System;
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
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class Edit_Faculty : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        Form Fac;
        string id;
        public Edit_Faculty(Form Fac, string id)
        {
            InitializeComponent();
            this.Fac = Fac;
            this.id = id;
            EsKewEl();
            faculty();
        }
        private void EsKewEl()
        {
            string query = $@"SELECT * FROM faculty WHERE staff_id = {this.id};";

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
                                string Id = reader["staff_id"].ToString();
                                string Code = reader["teacher_code"].ToString();
                                string Sur = reader["surname"].ToString();
                                string Fn = reader["firstname"].ToString();
                                char Mi = reader["middle_name"].ToString()[0];
                                string Sfx = reader["suffix"].ToString();
                                string Gen = reader["gender"].ToString();
                                string Dept = reader["department"].ToString();
                                string Emp = reader["employment_type"].ToString();
                                string Pos = reader["position"].ToString();
                                string Rol = reader["role"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();
                                string Last = reader["updated_at"].ToString();
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
                                    dateTimePicker1.Value = Convert.ToDateTime(reader["date_of_birth"]);
                                }
                                else
                                {
                                    dateTimePicker1.Value = DateTime.Today; // or disable it, etc.
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
                                textBox3.Text = Mi.ToString();
                                textBox4.Text = phn;
                                textBox5.Text = email;
                                comboBox1.Text = Sfx;
                                comboBox3.Text = Emp;
                                comboBox4.Text = Rol;
                                comboBox5.Text = Pos;
                                comboBox6.Text = Dept;
                                comboBox7.Text = stat;
                                label14.Text = Last;
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
        private void Edit_Faculty_Load(object sender, EventArgs e)
        {

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
                string insertQuery = @"UPDATE faculty SET
                    teacher_code = @TC,
                    surname = @SN,
                    firstname = @FN,
                    middle_name = @MN,
                    suffix = @SUF,
                    date_of_birth = @DoB,
                    gender = @Gen,
                    phone = @Phn,
                    email = @email,
                    employment_type = @ET,
                    role = @Rol,
                    position = @Pos,
                    department = @Dept,
                    status = @Stat,
                    photo = @Phot
                WHERE staff_id = @ID;";

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

                    command.Parameters.AddWithValue("@ID", this.id);
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
                        int rowsUpdated = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsUpdated} row(s) updated.");
                        Console.WriteLine($"{rowsUpdated} row(s) updated.");
                        Debug.WriteLine($"{rowsUpdated} row(s) updated.");
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        comboBox1.Enabled = false;
                        comboBox2.Enabled = false;
                        comboBox3.Enabled = false;
                        comboBox4.Enabled = false;
                        comboBox5.Enabled = false;
                        comboBox6.Enabled = false;
                        comboBox7.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        button1.Enabled = false;
                        button3.Visible = true;
                        this.Text = "Faculty";
                        EsKewEl();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Edit_Faculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Fac.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            dateTimePicker1.Enabled = true;
            button1.Enabled = true;
            this.Text = "Edit Faculty";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }
        private void faculty()
        {
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
    }
}
