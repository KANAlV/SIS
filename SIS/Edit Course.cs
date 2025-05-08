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

namespace SIS
{
    public partial class Edit_Course : Form
    {
        Form Cor;
        int unit;
        string id;
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Edit_Course(Form Cor, string id)
        {
            InitializeComponent();
            this.Cor = Cor;
            this.id = id;
            getSubCode();
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
            query = $@"SELECT * FROM course WHERE course_id={id}";
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
                                string status = reader["status"].ToString();
                                string description = reader["description"].ToString();
                                string courseCode = reader["course_code"].ToString();
                                string courseName = reader["course_name"].ToString();
                                string departmentCode = reader["department_code"].ToString();
                                string units = reader["units"].ToString();
                                string type = reader["program_type"].ToString();
                                string level = reader["level"].ToString();
                                string semester = reader["semester_offered"].ToString();
                                string prerequisites = reader["prerequisite_ids"].ToString();
                                string Last = reader["updated_at"].ToString();
                                textBox1.Text = courseName;
                                textBox2.Text = courseCode;
                                comboBox1.Text = type;
                                comboBox2.Text = level;
                                comboBox3.Text = semester;
                                comboBox4.Text = departmentCode;
                                label5.Text = units;
                                comboBox6.Text = status;
                                richTextBox1.Text = description;
                                label14.Text = Last;

                                var codes = prerequisites.Split(',')
                                    .Select(code => code.Trim())
                                    .ToList();
                                for (int i = 0; i < listBox1.Items.Count; i++)
                                {
                                    string item = listBox1.Items[i].ToString();
                                    if (codes.Contains(item))
                                    {
                                        listBox1.SetSelected(i, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // save btn
        {
            this.unit = 0;
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (string.IsNullOrWhiteSpace(comboBox1.Text)) { Cont = false; Debug.WriteLine("cb1"); }
            if (string.IsNullOrWhiteSpace(comboBox2.Text)) { Cont = false; Debug.WriteLine("cb2"); }
            if (string.IsNullOrWhiteSpace(comboBox3.Text)) { Cont = false; Debug.WriteLine("cb3"); }
            if (Cont == true)
            {
                string updateQuery = @"UPDATE course SET
                    course_code = @CC,
                    course_name = @CN,
                    description = @Desc,
                    units = @units,
                    department_code = @deptCD,
                    program_type = @PT,
                    level = @lvl,
                    semester_offered = @SO,
                    prerequisite_ids = @prereqs,
                    status = @stats
                WHERE
                    course_id = @ID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    var selectedItems = listBox1.SelectedItems.Cast<string>();
                    string prereq = string.Join(", ", selectedItems.Select(item => $"'{item}'")); // adds quotes
                    getUnitTotal(prereq);

                    command.Parameters.AddWithValue("@ID", this.id);
                    command.Parameters.AddWithValue("@CC", textBox2.Text);
                    command.Parameters.AddWithValue("@CN", textBox1.Text);
                    command.Parameters.AddWithValue("@Desc", richTextBox1.Text);
                    command.Parameters.AddWithValue("@units", null);
                    command.Parameters.AddWithValue("@deptCD", comboBox4.Text);
                    command.Parameters.AddWithValue("@PT", comboBox1.Text);
                    command.Parameters.AddWithValue("@lvl", comboBox2.Text);
                    command.Parameters.AddWithValue("@SO", comboBox3.Text);
                    command.Parameters.AddWithValue("@stats", comboBox6.Text);

                    try
                    {
                        connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsUpdated} row(s) updated.");
                        Console.WriteLine($"{rowsUpdated} row(s) updated.");
                        Debug.WriteLine($"{rowsUpdated} row(s) updated.");
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

        private void Edit_Course_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Cor.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) //Searchbox
        {
            getSubCode();
        }
        private void getSubCode()
        {
            string filter = textBox4.Text.Trim(); // get search input
            string query;

            if (string.IsNullOrEmpty(filter))
            {
                // No search term: get all subject codes
                query = @"SELECT subject_code FROM subjects";
            }
            else
            {
                // Search term exists: filter results (e.g., by subject_code)
                query = @"SELECT subject_code FROM subjects WHERE subject_code LIKE @filter";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        // Add parameter with wildcard for partial match
                        cmd.Parameters.AddWithValue("@filter", $"%{filter}%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox1.Items.Clear(); // clear previous results

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string subjectCode = reader["subject_code"].ToString();
                                listBox1.Items.Add(subjectCode);
                            }
                        }
                    }
                }
            }
        }
        private void getUnitTotal(string prereq)
        {
            string query = $@"SELECT units FROM subjects WHERE subject_code IN ({prereq})";
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
                                int units = Convert.ToInt32(reader["units"]);
                                this.unit += units;
                            }
                        }
                    }
                }
            }
        }
    }
}
