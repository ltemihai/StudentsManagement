using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagement
{
    

    public class EnrollGateway

    {
        private MySqlConnection connection;
        private MySqlCommand command;
        public void EnrollQuery(string idStudent, string idCourse, string date)
        {
            connection = new MySqlConnection(MainMenu.connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Nu esti conectat la baza de date");
                connection.Close();
            }
            command = new MySqlCommand("INSERT INTO enrolment(date,idStudent,idCourse) VALUES (@date,@idStudent,@idCourse)", connection);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@idStudent", idStudent);
            command.Parameters.AddWithValue("@idCourse", idCourse);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul cu ID-ul " + idStudent + " a fost inrolat la cursul cu ID-ul " + idCourse);
        }
    }
}
