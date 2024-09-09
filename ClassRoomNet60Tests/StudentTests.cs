using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void StudentSeasonTest(int month)
        {
            Student s = new Student("Test", month, 15);
            string output = s.Season;
            Assert.AreEqual("Winter", output); 
        }
    }
}