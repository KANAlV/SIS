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
    public partial class Add_Department : Form
    {
        Form Dpt;
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Add_Department(Form Dpt)
        {
            InitializeComponent();
            this.Dpt = Dpt;
            string query = $@"SELECT surname, firstname, middle_name FROM faculty";
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
                                string middle_name = reader["middle_name"]?.ToString();
                                char initial = !string.IsNullOrEmpty(middle_name) ? middle_name[0] : '-';
                                string name = $"{reader["surname"]}, {reader["firstname"]} {initial}.";
                                comboBox1.Items.Add(name);
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
            if (Cont == true)
            {
                string insertQuery = @"INSERT INTO department
                (department_name, code, email, phone, head_of_department, status)
                VALUES (
                    @DeptName,
                    @DeptCode,
                    @Email,
                    @Phn,
                    @HoD,
                    @Stat
                )";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@DeptName", textBox1.Text);
                    command.Parameters.AddWithValue("@DeptCode", textBox2.Text);
                    command.Parameters.AddWithValue("@Email", textBox3.Text);
                    command.Parameters.AddWithValue("@Phn", textBox4.Text);
                    command.Parameters.AddWithValue("@HoD", comboBox1.Text);
                    command.Parameters.AddWithValue("@Stat", comboBox6.Text);
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

        private void Add_Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dpt.Visible = true;
        }
    }
}
