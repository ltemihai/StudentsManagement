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
            MySqlConnection connection = new MySqlConnection(MainMenu.connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Nu esti conectat la baza de date");
                connection.Close();
            }
            MySqlCommand command = new MySqlCommand("Update courses SET name='" + textBox2.Text + "', teacher='" + textBox3.Text + "',study_year='" + textBox4.Text + "' WHERE idcourses =" + textBox1.Text, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cursul cu id-ul " + textBox1.Text + " a fost updatat cu succes");
            this.Close();
        }
    }
}
