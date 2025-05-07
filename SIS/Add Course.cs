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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class Add_Course : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Add_Course()
        {
            InitializeComponent();
            string query = @"SELECT course_code FROM course";
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
                                string courseCode = reader["course_code"].ToString();
                                listBox1.Items.Add(courseCode);
                            }
                        }
                    }
                }
            }
            query = @"SELECT code FROM department";
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (string.IsNullOrWhiteSpace(comboBox5.Text)) { Cont = false; Debug.WriteLine("cb5"); }
            if (string.IsNullOrWhiteSpace(comboBox1.Text)) { Cont = false; Debug.WriteLine("cb1"); }
            if (string.IsNullOrWhiteSpace(comboBox2.Text)) { Cont = false; Debug.WriteLine("cb2"); }
            if (string.IsNullOrWhiteSpace(comboBox3.Text)) { Cont = false; Debug.WriteLine("cb3"); }
            if (Cont == true)
            {
                string insertQuery = @"INSERT INTO course
                (course_code, course_name, description, units, department_code, program_type, level, semester_offered, prerequisite_ids)
                VALUES (
                    @CC,
                    @CN,
                    @Desc,
                    @units,
                    @deptCD,
                    @PT,
                    @lvl,
                    @SO,
                    @prereqs
                )";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@CC", textBox2.Text);
                    command.Parameters.AddWithValue("@CN", textBox1.Text);
                    command.Parameters.AddWithValue("@Desc", richTextBox1.Text);
                    command.Parameters.AddWithValue("@units", comboBox5.Text);
                    command.Parameters.AddWithValue("@deptCD", comboBox4.Text);
                    command.Parameters.AddWithValue("@PT", comboBox1.Text);
                    command.Parameters.AddWithValue("@lvl", comboBox2.Text);
                    command.Parameters.AddWithValue("@SO", comboBox3.Text);

                    var selectedItems = listBox1.SelectedItems.Cast<string>();
                    string prereq = string.Join(", ", selectedItems);
                    command.Parameters.AddWithValue("@prereqs", prereq);

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

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Search...")
            {
                textBox4.Clear();
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string query = @"SELECT course_code FROM Course WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                query += " AND course_code LIKE @CC";
                parameters.Add(new MySqlParameter("@CC", "%" + textBox4.Text + "%"));
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string courseCode = reader["course_code"].ToString();
                                listBox1.Items.Add(courseCode);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No courses found matching your filters.");
                        }
                    }
                }
            }
        }
    }
}
