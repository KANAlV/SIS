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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SIS
{
    public partial class Edit_Department : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        Form Dep;
        string id;
        public Edit_Department(Form Dep, string id)
        {
            InitializeComponent();
            this.Dep = Dep;
            this.id = id;
            readEsKewEl();
        }
        private void readEsKewEl()
        {
            string query = $@"SELECT department_name, code, head_of_department, email, phone, status, updated_at FROM department WHERE department_id = {this.id}";
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
                                string DeptName = reader["department_name"]?.ToString();
                                string DeptCode = reader["code"]?.ToString();
                                string HoD = reader["head_of_department"]?.ToString();
                                string Email = reader["email"]?.ToString();
                                string Phn = reader["phone"]?.ToString();
                                string Stat = reader["status"]?.ToString();
                                string Last = reader["updated_at"]?.ToString();
                                textBox1.Text = DeptName;
                                textBox2.Text = DeptCode;
                                textBox3.Text = Email;
                                textBox4.Text = Phn;
                                comboBox1.Text = HoD;
                                comboBox6.Text = Stat;
                                label7.Text = Last;
                            }
                        }
                    }
                }
            }
            query = $@"SELECT surname, firstname, middle_name FROM faculty";
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
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox6.Enabled = true;
            this.Text = "Edit_Department";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (Cont == true)
            {
                string insertQuery = @"UPDATE department SET
                    department_name = @DN,
                    code = @CD,
                    head_of_department = @HoD,
                    email = @EM,
                    phone = @PN,
                    status = @STS
                WHERE department_id = @ID;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@ID", this.id);
                    command.Parameters.AddWithValue("@DN", textBox1.Text);
                    command.Parameters.AddWithValue("@CD", textBox2.Text);
                    command.Parameters.AddWithValue("@HoD", comboBox1.Text);
                    command.Parameters.AddWithValue("@EM", textBox3.Text);
                    command.Parameters.AddWithValue("@PN", textBox4.Text);
                    command.Parameters.AddWithValue("@STS", comboBox6.Text);
                    try
                    {
                        connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsUpdated} row(s) updated.");
                        Console.WriteLine($"{rowsUpdated} row(s) updated.");
                        Debug.WriteLine($"{rowsUpdated} row(s) updated.");
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        comboBox1.Enabled = false;
                        comboBox6.Enabled = false;
                        button3.Visible = true;
                        this.Text = "Faculty";
                        readEsKewEl();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Edit_Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dep.Visible = true;
        }
    }
}
