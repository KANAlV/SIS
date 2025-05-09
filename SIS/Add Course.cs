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
        Form crs;
        int unit;
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Add_Course(Form Crs)
        {
            InitializeComponent();
            this.crs = Crs;
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
        }
        private void getSubCode()
        {
            string filter = textBox4.Text.Trim(); // get search input
            string query;

            if (string.IsNullOrEmpty(filter) || filter == "Search...")
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
                        cmd.Parameters.AddWithValue("@filter", $"%{filter}%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
        private void button1_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (string.IsNullOrWhiteSpace(comboBox1.Text)) { Cont = false; Debug.WriteLine("cb1"); }
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
                    var selectedItems = listBox1.SelectedItems.Cast<string>();
                    string prereq = string.Join(", ", selectedItems.Select(item => $"'{item}'")); // adds quotes
                    getUnitTotal(prereq);

                    command.Parameters.AddWithValue("@CC", textBox2.Text);
                    command.Parameters.AddWithValue("@CN", textBox1.Text);
                    command.Parameters.AddWithValue("@Desc", richTextBox1.Text);
                    command.Parameters.AddWithValue("@units", this.unit.ToString());
                    command.Parameters.AddWithValue("@deptCD", comboBox4.Text);
                    command.Parameters.AddWithValue("@PT", comboBox1.Text);
                    command.Parameters.AddWithValue("@lvl", comboBox2.Text);
                    command.Parameters.AddWithValue("@SO", comboBox3.Text);

                    var selectedItems1 = listBox1.SelectedItems.Cast<string>();
                    string prereq1 = string.Join(", ", selectedItems1);
                    command.Parameters.AddWithValue("@prereqs", prereq1);

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
            string filter = textBox4.Text.Trim(); // get search input
            string query;

            if (string.IsNullOrEmpty(filter) || filter == "Search...")
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

        private void Add_Course_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.crs.Visible = true;
        }
        private void getUnitTotal(string prereq)
        {
            if (string.IsNullOrWhiteSpace(prereq))
            {
                return; // or handle it gracefully (e.g., set units to 0, show message, etc.)
            }

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
