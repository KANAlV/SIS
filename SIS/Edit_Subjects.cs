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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS
{
    public partial class Edit_Subjects : Form
    {
        string connectionString = "server=localhost;database=sis;user=root;password=;";
        string id;
        Form Sub;
        public Edit_Subjects(Form Sub, string id)
        {
            InitializeComponent();
            this.id = id;
            this.Sub = Sub;
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
                string insertQuery = @"UPDATE faculty SET
                    subject_code = @SC,
                    subject_name = @SN,
                    units = @units,
                    year_level = @Lvl,
                    department = @Dept,
                    prerequisites = @Pre,
                    description = @Desc
                WHERE staff_id = @ID;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    command.Parameters.AddWithValue("@SC", textBox2.Text);
                    command.Parameters.AddWithValue("@SN", textBox1.Text);
                    command.Parameters.AddWithValue("@units", comboBox1.Text);
                    command.Parameters.AddWithValue("@Lvl", comboBox2.Text);
                    command.Parameters.AddWithValue("@Dept", comboBox4.Text);
                    command.Parameters.AddWithValue("@Desc", richTextBox1.Text);
                    command.Parameters.AddWithValue("@ID", this.id);

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

        private void getData()
        {
            string query = $@"SELECT * FROM course WHERE course_id={this.id}";
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

                                var codes = prerequisites.Split(',')
                                    .Select(code => code.Trim())
                                    .ToList();
                                for (int i = 0; i < listBox1.Items.Count; i++)
                                {
                                    string item = listBox1.Items[i].ToString();
                                    if (codes.Contains(item))
                                    {
                                        listBox1.SetSelected(i, true);
                                    }
                                }
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

            if (string.IsNullOrEmpty(filter)||filter == "Search...")
            {
                // No search term: get all subject codes
                query = @"SELECT subject_code FROM subjects";
            }
            else
            {
                // Search term exists: filter results (e.g., by subject_code)
                query = @"SELECT subject_code FROM subjects WHERE subject_code LIKE @filter";
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
    }
}
