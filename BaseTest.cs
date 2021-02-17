using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Student_Regisrty_Automated_Test.Test
{
    public class BaseTest
    {
       protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
    }
}
