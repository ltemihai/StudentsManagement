using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentsManagement
{
    public partial class MainMenu : Form
    {
        public const string connectionString = "SERVER=localhost;DATABASE=schooldb;uid=mihai;password=mihai";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.schooldbDataSet.students);
            this.coursesTableAdapter.Fill(this.schooldbDataSet1.courses);
            this.coursesTableAdapter1.Fill(this.schooldbDataSet2.courses);
            this.enrolmentTableAdapter.Fill(this.schooldbDataSet3.enrolment);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schooldbDataSet3.enrolment' table. You can move, or remove it, as needed.
            this.enrolmentTableAdapter.Fill(this.schooldbDataSet3.enrolment);
            // TODO: This line of code loads data into the 'schooldbDataSet2.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter1.Fill(this.schooldbDataSet2.courses);
            // TODO: This line of code loads data into the 'schooldbDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.schooldbDataSet1.courses);
            // TODO: This line of code loads data into the 'schooldbDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.schooldbDataSet.students);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            studentForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveStudentForm studentForm = new RemoveStudentForm();
            studentForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateStudentForm studentForm = new UpdateStudentForm();
            studentForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnrollForm enrollForm = new EnrollForm();
            enrollForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCourseForm courseForm = new AddCourseForm();
            courseForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveCourseForm courseForm = new RemoveCourseForm();
            courseForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateCourseForm courseForm = new UpdateCourseForm();
            courseForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FindStudentForm findForm = new FindStudentForm();
            findForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FindCoursesByStudents findForm = new FindCoursesByStudents();
            findForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            FindStudentsByCourses findForm = new FindStudentsByCourses();
            findForm.Show();
        }
    }
}
