using OpenQA.Selenium;
using System;

namespace Student_Regisrty_Automated_Test.PageObject
{
     public class BasePage
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)

        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public IWebElement LinkHomePage => driver.FindElement(By.XPath("//a[contains(., 'Home')]"));
        public IWebElement LinkViewStudentsPage => driver.FindElement(By.CssSelector("body > a:nth-child(3)"));
        public IWebElement LinkAddStudentsPage => driver.FindElement(By.CssSelector("body > a:nth-child(5)"));
        public IWebElement ElementTextHeading => driver.FindElement(By.CssSelector("body > h1"));

        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }
        public bool IsOpen()
        {
            return
            driver.Url == this.PageUrl;
        }
        public string GetPageTitle()
        {
            return driver.Title;

        }

        public string GetPageHeadingText()
        {
            return ElementTextHeading.Text;
        }
    }
}
