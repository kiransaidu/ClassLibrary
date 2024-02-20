using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudentId()
    {
        Student std = new Student();
        std.StuId = 1;
        int studentId = std.StuId;
        Assert.AreEqual(1, studentId);

    }
    [Test]
        public void TestStudentName()
        {
            Student std = new Student();


            // std.StuId = 1;
            std.StuName = "kiran";
            string studentName = std.StuName;
            Assert.AreEqual("kiran", studentName);
        }
        [Test]
        public void TestStudentLocation()
        {
            Student std = new Student();
            std.StuLocation = "Andhra Pradesh";
            string studentLocation = std.StuLocation;
            Assert.AreEqual("Andhra Pradesh", studentLocation);
        
    }
    }
}
