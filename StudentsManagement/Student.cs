using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement
{
    class Student
    {
        private int idstudents;
        private string name;
        private string birthdate;
        private string address;

        public Student(int idstudents, string name, string birthdate, string address)
        {
            this.idstudents = idstudents;
            this.name = name;
            this.birthdate = birthdate;
            this.address = address;
        }

        public int Idstudents
        {
            get
            {
                return idstudents;
            }

            set
            {
                idstudents = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}
