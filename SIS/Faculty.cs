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
    }
}
