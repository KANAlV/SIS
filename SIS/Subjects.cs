using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIS
{
    public partial class Subjects : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Subjects()
        {
            InitializeComponent();
            EsKewEl();
        }

        private void EsKewEl()
        {
            string query = @"
            SELECT 
                subject_id,
                status,
                subject_code,
                subject_name,
                units,
                year_level,
                semester,
                prerequisites,
                department
            FROM subjects;
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
                                string id = reader["subject_id"].ToString();
                                string status = reader["status"].ToString();
                                string Code = reader["subject_code"].ToString();
                                string Sub = reader["subject_name"].ToString();
                                string units = reader["units"].ToString();
                                string level = reader["year_level"].ToString();
                                string dept = reader["department"].ToString();
                                string semester = reader["semester"].ToString();
                                string prerequisites = reader["prerequisites"].ToString();

                                dataGridView1.Rows.Add(id, status, Sub, Code, units, semester, level, dept, prerequisites);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No subject found.");
                        }
                    }
                }
            }
        }
        private void search()
        {
            string query = @"
            SELECT 
                subject_id,
                status,
                subject_code,
                subject_name,
                units,
                year_level,
                semester,
                prerequisites,
                department
            FROM subjects
            WHERE 1=1"; // Always true; allows safe dynamic ANDs

            // Add filters if provided
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                query += " AND subject_name LIKE @Sub";
                parameters.Add(new MySqlParameter("@Sub", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                query += " AND subject_code LIKE @code";
                parameters.Add(new MySqlParameter("@code", "%" + textBox5.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                query += " AND year_level = @level";
                parameters.Add(new MySqlParameter("@level", textBox3.Text));
            }

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                query += " AND prerequisites LIKE @prereq";
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
                                string id = reader["subject_id"].ToString();
                                string status = reader["status"].ToString();
                                string Code = reader["subject_code"].ToString();
                                string Sub = reader["subject_name"].ToString();
                                string units = reader["units"].ToString();
                                string level = reader["year_level"].ToString();
                                string dept = reader["department"].ToString();
                                string semester = reader["semester"].ToString();
                                string prerequisites = reader["prerequisites"].ToString();

                                dataGridView1.Rows.Add(id, status, Sub, Code, units, semester, level, dept, prerequisites);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No subject found matching your filters.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Subjects add_Subjects = new Add_Subjects();
            add_Subjects.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["subject_id"].Value?.ToString();
                Edit_Subjects edit_Subjects = new Edit_Subjects(this, id);
                this.Visible = false;
                edit_Subjects.Show();
            }
        }
    }
}
