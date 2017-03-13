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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
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
            MySqlCommand command = new MySqlCommand("DELETE FROM courses WHERE idcourses = " + textBox1.Text, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cursul cu id-ul " + textBox1.Text + " a fost sters cu succes");
            this.Close();
        }
    }
}
