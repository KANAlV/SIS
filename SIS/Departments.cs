using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class Departments : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Departments()
        {
            InitializeComponent();
            string query = @"
            SELECT 
                department_id,
                code,
                department_name,
                head_of_department,
                email,
                phone,
                status
            FROM department;
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
                                string ID = reader["department_id"].ToString();
                                string Code = reader["code"].ToString();
                                string DeptName = reader["department_name"].ToString();
                                string HoD = reader["head_of_department"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();

                                dataGridView1.Rows.Add(ID, Code, DeptName, HoD, email, phn, stat);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Departments found.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Department add_Department = new Add_Department(this);
            this.Visible = false;
            add_Department.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EsKewEl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EsKewEl();
        }

        private void EsKewEl()
        {
            string query = @"
            SELECT 
                department_id,
                code,
                department_name,
                head_of_department,
                email,
                phone,
                status
            FROM department
                WHERE 1=1"; // Always true; allows safe dynamic ANDs

            // Add filters if provided
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                query += " AND code LIKE @code";
                parameters.Add(new MySqlParameter("@code", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                query += " AND department_name LIKE @Dept";
                parameters.Add(new MySqlParameter("@Dept", "%" + textBox2.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                query += " AND head_of_department = @HoD";
                parameters.Add(new MySqlParameter("@HoD", textBox3.Text));
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
                                string ID = reader["department_id"].ToString();
                                string Code = reader["code"].ToString();
                                string DeptName = reader["department_name"].ToString();
                                string HoD = reader["head_of_department"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();

                                dataGridView1.Rows.Add(ID, Code, DeptName, HoD, email, phn, stat);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No department found matching your filters.");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["department_id"].Value?.ToString();
                Edit_Department edit_department = new Edit_Department(this, id);
                this.Visible = false;
                edit_department.Show();
            }
        }
    }
}
