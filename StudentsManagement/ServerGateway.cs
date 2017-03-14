using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagement
{
    class ServerGateway
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public void AddStudentQuery(string name, string birthdate, string address)
        {
            connection = new MySqlConnection(MainMenu.connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("You are not connected to the database");
                connection.Close();
            }
            command = new MySqlCommand("INSERT INTO students(name,birthdate,address) VALUES (@name,@birthdate,@address)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@birthdate", birthdate);
            command.Parameters.AddWithValue("@address", address);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul " + name + " a fost adaugat cu succes");
        }

        public void RemoveStudentQuery(string id)
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
            command = new MySqlCommand("DELETE FROM students WHERE idstudents = " + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul cu id-ul " + id + " a fost sters cu succes");
        }

        public void UpdateStudentQuery(string id, string name, string birthdate, string address)
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

            command = new MySqlCommand("Update students SET name='" + name + "', birthdate='" + birthdate + "',address='" + address + "' WHERE idstudents =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul cu id-ul " + id + " a fost updatat cu succes");
        }

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

        public DataTable FindStudent(string name)
        {
            connection = new MySqlConnection(MainMenu.connectionString);       
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM students WHERE name ='" + name+"'", MainMenu.connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable FindStudentsByCourses(string name)
        {
            connection = new MySqlConnection(MainMenu.connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT S.name FROM enrolment E, courses C, students S WHERE E.idCourse = C.idcourses and E.idStudent = S.idstudents and C.name = '" + name + "'", MainMenu.connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
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
