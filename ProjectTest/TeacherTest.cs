using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TestTeacher()
            {
            var teacher = new Teacher();
            teacher.TId = 3;
            teacher.TName = "Surya";
            Assert.AreEqual(3, teacher.TId);
            Assert.AreEqual("Surya", teacher.TName);
        }
    }
}
