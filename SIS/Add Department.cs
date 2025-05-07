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

namespace SIS
{
    public partial class Add_Department : Form
    {
        Form Dpt;
        public Add_Department(Form Dpt)
        {
            InitializeComponent();
            this.Dpt = Dpt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { Cont = false; Debug.WriteLine("tb1"); }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { Cont = false; Debug.WriteLine("tb2"); }
            if (Cont == true)
            {

            }
        }

        private void Add_Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dpt.Visible = true;
        }
    }
}
