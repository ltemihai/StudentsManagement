using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagement
{
    public partial class UpdateCourseForm : Form
    {
        public UpdateCourseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseGateway serverGateway = new CourseGateway();
            serverGateway.UpdateCourseQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Close();
        }
    }
}
