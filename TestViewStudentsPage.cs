using NUnit.Framework;
using Student_Regisrty_Automated_Test.PageObject;

namespace Student_Regisrty_Automated_Test.Test
{
    public class TestViewStudentsPage : BaseTest
    { 
        [Test]
        public void TestViewStudentPageContent()
        {
            var page = new ViewStudentsage(driver);
            page.Open();
            Assert.AreEqual("Students", page.GetPageTitle());
            Assert.AreEqual("Registered Students", page.GetPageHeadingText());
            var students = page.GetRegisteredStudents();
            foreach (string st in students)
            {
                Assert.IsTrue(st.IndexOf("(") > 0);
                Assert.IsTrue(st.IndexOf(")") == st.Length - 1);
            }

        }

        [Test]
        public void TestHomePageLinks()
        {
            var ViewStudentsage = new ViewStudentsage(driver);

            ViewStudentsage.Open();
            ViewStudentsage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());

            ViewStudentsage.Open();
            ViewStudentsage.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());

            ViewStudentsage.Open();
            ViewStudentsage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsage(driver).IsOpen());



        }

        
    }

}