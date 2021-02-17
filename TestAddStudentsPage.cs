using NUnit.Framework;
using Student_Regisrty_Automated_Test.PageObject;
using System;

namespace Student_Regisrty_Automated_Test.Test
{
    public class TestAddStudentsPage : BaseTest
    {
        [Test]
        public void Test_AddStudentPage_Links()
        {
            var AddStudentPage = new AddStudentPage(driver);

            AddStudentPage.Open();
            AddStudentPage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());

            AddStudentPage.Open();
            AddStudentPage.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());

            AddStudentPage.Open();
            AddStudentPage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsage(driver).IsOpen());
        }
        [Test]
        public void TestAddStudentsPageContent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            Assert.AreEqual("Add Student", page.GetPageTitle());
            Assert.AreEqual("Register New Student", page.GetPageHeadingText());
            Assert.AreEqual("", page.FieldName.Text);
            Assert.AreEqual("", page.FieldEmail.Text);
            Assert.AreEqual("Add", page.ButtonAdd.Text);


        }
        [Test]
        public void TestAddStudentPage_AddValidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "Pesho" + DateTime.Now.Ticks;
            string email = "pesho" + DateTime.Now.Ticks + "@gmail.com";
            page.AddStudent(name, email);
            var viewStudentsPage = new ViewStudentsage(driver);
            Assert.IsTrue(viewStudentsPage.IsOpen());
            var students = viewStudentsPage.GetRegisteredStudents();
            string NewStudent = name + " (" + email + ")";
            Assert.Contains(NewStudent, students);

        }
        [Test]
        public void TestAddStudentPage_AddInvalidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "";
            string email = "pesho" + DateTime.Now.Ticks + "@gmail.com";
            page.AddStudent(name, email);
            Assert.IsTrue(page.IsOpen());
            Assert.IsTrue(page.ErrorMsg.Text.Contains("Cannot add student. Name and email fields are required!"));

        }
    }

}