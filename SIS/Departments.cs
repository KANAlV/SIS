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
    public partial class Departments : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Departments()
        {
            InitializeComponent();
            string query = @"
            SELECT 
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
                                string Code = reader["code"].ToString();
                                string DeptName = reader["department_name"].ToString();
                                string HoD = reader["head_of_department"].ToString();
                                string email = reader["email"].ToString();
                                string phn = reader["phone"].ToString();
                                string stat = reader["status"].ToString();

                                dataGridView1.Rows.Add(Code, DeptName, HoD, email, phn, stat);
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

        }
    }
}
