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
    public partial class FindStudentForm : Form
    {
        public FindStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentGateway serverGateway = new StudentGateway();
            DataTable dataTable = serverGateway.FindStudent(textBox1.Text);
            dataGridView1.DataSource = dataTable;
        
        }
    }
}
