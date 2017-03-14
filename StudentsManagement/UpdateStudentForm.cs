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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerGateway serverGateway = new ServerGateway();
            serverGateway.UpdateStudentQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Close();
        }
    }

}
