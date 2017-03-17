using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Tests
{
    [TestClass()]
    public class ServerGatewayTests
    {
        [TestMethod()]
        public void AddStudentQueryTest()
        {
            StudentGateway serverGateway = new StudentGateway();
            serverGateway.AddStudentQuery("TestUnit", "2000-01-01", "TestAddress");
            DataTable dataTable = serverGateway.FindStudent("TestUnit");
            Assert.IsFalse(dataTable.Rows.Count == 0);
        }

        [TestMethod()]
        public void RemoveStudentQueryTest()
        {
            StudentGateway serverGateway = new StudentGateway();
            serverGateway.AddStudentQuery("TestUnit", "2000-01-01", "TestAddress");
            serverGateway.RemoveStudentQuery("23");
            DataTable dataTable = serverGateway.FindStudent("TestUnit");
            Assert.IsFalse(dataTable.Rows.Count == 0);
        }
        


    }
}