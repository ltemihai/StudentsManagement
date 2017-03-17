using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace StudentsManagement
{
    public class CourseGateway
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public void AddCourseQuery(string name, string teacher, string studyYear)
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
            command = new MySqlCommand("INSERT INTO courses(name,teacher,study_year) VALUES (@name,@teacher,@study_year)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@teacher", teacher);
            command.Parameters.AddWithValue("@study_year", studyYear);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cursul " + name + " a fost adaugat cu succes");
        }

        public void RemoveCourseQuery(string id)
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
            command = new MySqlCommand("DELETE FROM courses WHERE idcourses = " + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cursul cu id-ul " + id + " a fost sters cu succes");
        }

        public void UpdateCourseQuery(string id, string name, string teacher, string studyYear)
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
            command = new MySqlCommand("Update courses SET name='" + name + "', teacher='" + teacher + "',study_year='" + studyYear + "' WHERE idcourses =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cursul cu id-ul " + id + " a fost updatat cu succes");
        }

        public DataTable FindCoursesByStudents(string name)
        {
            connection = new MySqlConnection(MainMenu.connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT C.name FROM enrolment E, courses C, students S WHERE E.idCourse = C.idcourses and E.idStudent = S.idstudents and S.name = '" + name + "'", MainMenu.connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
