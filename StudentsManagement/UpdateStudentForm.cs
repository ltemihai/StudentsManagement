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
            MySqlCommand command = new MySqlCommand("Update students SET name='" + textBox2.Text + "', birthdate='"+textBox3.Text+"',address='"+textBox4.Text+"' WHERE idstudents =" + textBox1.Text, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul cu id-ul " + textBox1.Text + " a fost updatat cu succes");
            this.Close();
        }
    }

}
