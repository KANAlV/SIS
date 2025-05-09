using System;
using System.Collections;
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
    public partial class Add_Subjects : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        public Add_Subjects()
        {
            InitializeComponent();
            getPrereq();
            getDept();
        }
        private void getDept()
        {
            string query = @"SELECT code FROM department WHERE status = 'Active'";
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
        private void getPrereq()
        {
            string filter = textBox4.Text.Trim(); // get search input
            string query;

            if (string.IsNullOrEmpty(comboBox2.Text))//empty
            {
                if (string.IsNullOrEmpty(filter) || filter == "Search...")
                {
                    query = @"SELECT subject_code FROM subjects";
                }
                else
                {
                    query = @"SELECT subject_code FROM subjects WHERE subject_code LIKE @filter";
                }
            } else if (comboBox2.Text == "11" || comboBox2.Text ==  "12") //Senior High
            {
                if (string.IsNullOrEmpty(filter) || filter == "Search...")
                {
                    query = $@"SELECT subject_code FROM subjects WHERE year_level > 4 AND year_level < {Int32.Parse(comboBox2.Text)}";
                }
                else
                {
                    query = $@"SELECT subject_code FROM subjects WHERE year_level > 4 AND year_level < {Int32.Parse(comboBox2.Text)} AND subject_code LIKE @filter";
                }
            }
            else // college
            {
                if (string.IsNullOrEmpty(filter) || filter == "Search...")
                {
                    query = $@"SELECT subject_code FROM subjects WHERE year_level < {Int32.Parse(comboBox2.Text)}";
                }
                else
                {
                    query = $@"SELECT subject_code FROM subjects WHERE year_level < {Int32.Parse(comboBox2.Text)} AND subject_code LIKE @filter";
                }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            getPrereq();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (string.IsNullOrWhiteSpace(comboBox1.Text)) { Cont = false; Debug.WriteLine("cb1"); }
            if (Cont == true)
            {
                string insertQuery = @"INSERT INTO subjects
                (subject_code, subject_name, units, year_level, department, prerequisites, description)
                VALUES (
                    @SC,
                    @SN,
                    @units,
                    @Lvl,
                    @Dept,
                    @Pre,
                    @Desc
                )";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    command.Parameters.AddWithValue("@SC", textBox2.Text);
                    command.Parameters.AddWithValue("@SN", textBox1.Text);
                    command.Parameters.AddWithValue("@units", comboBox1);
                    command.Parameters.AddWithValue("@Lvl", comboBox2.Text);
                    command.Parameters.AddWithValue("@Dept", comboBox4.Text);
                    command.Parameters.AddWithValue("@Desc", richTextBox1.Text);

                    var selectedItems1 = listBox1.SelectedItems.Cast<string>();
                    string prereq1 = string.Join(", ", selectedItems1);
                    command.Parameters.AddWithValue("@Pre", prereq1);

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

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            getPrereq();
        }
    }
}
