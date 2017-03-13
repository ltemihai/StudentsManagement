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
    public partial class EnrollForm : Form
    {
        public EnrollForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            MySqlCommand command = new MySqlCommand("INSERT INTO enrolment(date,idStudent,idCourse) VALUES (@date,@idStudent,@idCourse)", connection);
            command.Parameters.AddWithValue("@date", textBox3.Text);
            command.Parameters.AddWithValue("@idStudent", textBox1.Text);
            command.Parameters.AddWithValue("@idCourse", textBox2.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul cu ID-ul " + textBox1.Text + " a fost inrolat la cursul cu ID-ul" + textBox2.Text);
            this.Close();
        }
    }
}
