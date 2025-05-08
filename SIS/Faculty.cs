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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class Faculty : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Faculty()
        {
            InitializeComponent();
            string query = @"
            SELECT 
                staff_id,
                teacher_code,
                surname,
                firstname,
                middle_name,
                suffix,
                gender,
                department,
                position,
                role,
                phone,
                email,
                status
            FROM faculty;
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
                                string Id = reader["staff_id"].ToString();
                                string Code = reader["teacher_code"].ToString();
                                string Sur = reader["surname"].ToString();
                                string Fn = reader["firstname"].ToString();
                                char Mi = reader["middle_name"].ToString()[0];
                                string Sfx = reader["suffix"].ToString();
                                string Gen = reader["gender"].ToString();
                                string Dept = reader["department"].ToString();
                                string Pos = reader["position"].ToString();
                                string Rol = reader["role"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();

                                dataGridView1.Rows.Add(Id, stat, Code, Sur, Fn, Mi, Sfx, Gen, Dept, Rol, Pos, phn, email);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Faculty add_Faculty = new Add_Faculty(this);
            this.Visible = false;
            add_Faculty.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                staff_id,
                teacher_code,
                surname,
                firstname,
                middle_name,
                suffix,
                gender,
                department,
                position,
                role,
                phone,
                email,
                status
            FROM faculty
                WHERE 1=1"; // Always true; allows safe dynamic ANDs

            // Add filters if provided
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                query += " AND teacher_code LIKE @code";
                parameters.Add(new MySqlParameter("@code", "%" + textBox5.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                query += " AND surname LIKE @surname";
                parameters.Add(new MySqlParameter("@surname", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                query += " AND firstname = @firstname";
                parameters.Add(new MySqlParameter("@firstname", textBox3.Text));
            }

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                query += " AND position LIKE @position";
                parameters.Add(new MySqlParameter("@position", "%" + textBox4.Text + "%"));
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
                                string Id = reader["staff_id"].ToString();
                                string Code = reader["teacher_code"].ToString();
                                string Sur = reader["surname"].ToString();
                                string Fn = reader["firstname"].ToString();
                                char Mi = reader["middle_name"].ToString()[0];
                                string Sfx = reader["suffix"].ToString();
                                string Gen = reader["gender"].ToString();
                                string Dept = reader["department"].ToString();
                                string Pos = reader["position"].ToString();
                                string Rol = reader["role"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();

                                dataGridView1.Rows.Add(Id, stat, Code, Sur, Fn, Mi, Sfx, Gen, Dept, Rol, Pos, phn, email);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["staff_id"].Value?.ToString();
                Edit_Faculty edit_fac = new Edit_Faculty(this, id);
                this.Visible = false;
                edit_fac.Show();
            }
        }
    }
}
