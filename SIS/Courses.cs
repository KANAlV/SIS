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
    public partial class Courses : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Courses()
        {
            InitializeComponent();
            string query = @"
            SELECT 
                c.course_id,
                c.status,
                c.course_code,
                c.course_name,
                c.units,
                c.program_type,
                d.code AS department_code,
                c.level,
                c.semester_offered,
                c.prerequisite_ids
            FROM 
                course c
            LEFT JOIN 
                department d ON c.department_code = d.code;
            ";

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
                                string id = reader["course_id"].ToString();
                                string status = reader["status"].ToString();
                                string courseCode = reader["course_code"].ToString();
                                string courseName = reader["course_name"].ToString();
                                string departmentCode = reader["department_code"].ToString();
                                string units = reader["units"].ToString();
                                string type = reader["program_type"].ToString();
                                string level = reader["level"].ToString();
                                string semester = reader["semester_offered"].ToString();
                                string prerequisites = reader["prerequisite_ids"].ToString();

                                dataGridView1.Rows.Add(id, status, courseCode, courseName, units, semester, level, type, departmentCode, prerequisites);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No courses found.");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    c.course_id,
                    c.status,
                    c.course_code,
                    c.course_name,
                    c.units,
                    c.program_type,
                    d.code AS department_code,
                    c.level,
                    c.semester_offered,
                    c.prerequisite_ids
                FROM 
                    course c
                LEFT JOIN 
                    department d ON c.department_code = d.code
                WHERE 1=1"; // Always true; allows safe dynamic ANDs

            // Add filters if provided
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                query += " AND c.course_name LIKE @course";
                parameters.Add(new MySqlParameter("@course", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                query += " AND c.course_code LIKE @code";
                parameters.Add(new MySqlParameter("@code", "%" + textBox5.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                query += " AND c.level = @level";
                parameters.Add(new MySqlParameter("@level", textBox3.Text));
            }

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                query += " AND c.prerequisite_ids LIKE @prereq";
                parameters.Add(new MySqlParameter("@prereq", "%" + textBox4.Text + "%"));
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Clear old data

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string id = reader["course_id"].ToString();
                                string status = reader["status"].ToString();
                                string courseCode = reader["course_code"].ToString();
                                string courseName = reader["course_name"].ToString();
                                string departmentCode = reader["department_code"].ToString();
                                string units = reader["units"].ToString();
                                string type = reader["program_type"].ToString();
                                string level = reader["level"].ToString();
                                string semester = reader["semester_offered"].ToString();
                                string prerequisites = reader["prerequisite_ids"].ToString();

                                dataGridView1.Rows.Add(id, status, courseCode, courseName, units, semester, level, type, departmentCode, prerequisites);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Course add_Course = new Add_Course(this);
            this.Visible = false;
            add_Course.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    c.course_id,
                    c.status,
                    c.course_code,
                    c.course_name,
                    c.units,
                    c.program_type,
                    d.code AS department_code,
                    c.level,
                    c.semester_offered,
                    c.prerequisite_ids
                FROM 
                    course c
                LEFT JOIN 
                    department d ON c.department_code = d.code
                WHERE 1=1"; // Always true; allows safe dynamic ANDs

            // Add filters if provided
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                query += " AND c.course_name LIKE @course";
                parameters.Add(new MySqlParameter("@course", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                query += " AND c.code LIKE @code";
                parameters.Add(new MySqlParameter("@code", "%" + textBox5.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                query += " AND c.level = @level";
                parameters.Add(new MySqlParameter("@level", textBox3.Text));
            }

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                query += " AND c.prerequisite_ids LIKE @prereq";
                parameters.Add(new MySqlParameter("@prereq", "%" + textBox4.Text + "%"));
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Clear old data

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string id = reader["course_id"].ToString();
                                string status = reader["status"].ToString();
                                string courseCode = reader["course_code"].ToString();
                                string courseName = reader["course_name"].ToString();
                                string departmentCode = reader["department_code"].ToString();
                                string units = reader["units"].ToString();
                                string type = reader["program_type"].ToString();
                                string level = reader["level"].ToString();
                                string semester = reader["semester_offered"].ToString();
                                string prerequisites = reader["prerequisite_ids"].ToString();

                                dataGridView1.Rows.Add(id, status, courseCode, courseName, units, semester, level, type, departmentCode, prerequisites);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["course_id"].Value?.ToString();
                Edit_Course edit_course = new Edit_Course(this, id);
                this.Visible = false;
                edit_course.Show();
            }
        }
    }
}
