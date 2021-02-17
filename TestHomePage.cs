using NUnit.Framework;
using Student_Regisrty_Automated_Test.PageObject;

namespace Student_Regisrty_Automated_Test.Test
{
    public class TestHomePage : BaseTest
    {
     

        [Test]
        public void TestHomePageContent()
        {
            var page = new HomePage(driver);
            page.Open();
            Assert.AreEqual("MVC Example", page.GetPageTitle());
            Assert.AreEqual("Students Registry", page.GetPageHeadingText());
            page.GetSTudentsCount();
            Assert.Pass();
        }

        [Test]
        public void TestHomePageLinks()
        {
            var homePage = new HomePage(driver);

            homePage.Open();
            homePage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());

            homePage.Open();
            homePage.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());

            homePage.Open();
            homePage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsage(driver).IsOpen());



        }

        
    }

}