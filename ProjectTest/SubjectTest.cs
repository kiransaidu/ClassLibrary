using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void TestSubjectId()
        {
            Subject sub = new Subject();
            sub.SubId = 1;
            int subjectId = sub.SubId;
            Assert.AreEqual(1, subjectId);

        }
        [Test]
        public void TestSubjectName()
        {
            Subject sub = new Subject();
            sub.SubName = "Telugu";
            string subjectName = sub.SubName;
            Assert.AreEqual("Telugu", subjectName);

        }
    }
}
