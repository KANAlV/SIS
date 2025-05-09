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
    public partial class Enrollment : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Enrollment()
        {
            InitializeComponent();
            string query = @"
            SELECT 
                e.status,
                e.enrollment_id,
                e.student_id,
                s.first_name,
                s.last_name,
                s.middle_name,
                e.payment_plan,
                e.academic_term,
                e.semester
            FROM 
                enrollment e
            LEFT JOIN 
                students s ON e.student_id = s.student_id;
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
                                string EID = reader["enrollment_id"].ToString();
                                string Stat = reader["status"].ToString();
                                string SID = reader["student_id"].ToString();
                                string NAME = $"{reader["last_name"].ToString()}, {reader["first_name"].ToString()} {reader["middle_name"].ToString()[0]}";
                                string PP = reader["payment_plan"].ToString();
                                string AT = reader["academic_term"].ToString();
                                string SEM = reader["semester"].ToString();

                                dataGridView1.Rows.Add(EID, Stat, SID, NAME, PP, AT, SEM);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll(this);
            enroll.Show();
        }
    }
}
