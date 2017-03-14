﻿using System;
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
    public partial class FindStudentsByCourses : Form
    {
        public FindStudentsByCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerGateway serverGateway = new ServerGateway();
            DataTable dataTable = serverGateway.FindStudentsByCourses(textBox1.Text);
            dataGridView1.DataSource = dataTable;
        }
    }
}
