namespace SIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
