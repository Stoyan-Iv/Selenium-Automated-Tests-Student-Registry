using OpenQA.Selenium;

namespace Student_Regisrty_Automated_Test.PageObject
{
    class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";

        public IWebElement FieldName => driver.FindElement(By.Id("name"));
        public IWebElement FieldEmail => driver.FindElement(By.Id("email"));
        public IWebElement ButtonAdd => driver.FindElement(By.CssSelector("body > form > button"));
        public IWebElement ErrorMsg => driver.FindElement(By.CssSelector("body > div"));

        public void AddStudent(string name, string email)
        {
            this.FieldName.SendKeys(name);
            this.FieldEmail.SendKeys(email);
            this.ButtonAdd.Click();
        }

    }
}