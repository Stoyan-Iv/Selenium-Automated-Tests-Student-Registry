using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Student_Regisrty_Automated_Test.PageObject
{
    class ViewStudentsage : BasePage
    {
        public ViewStudentsage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";
        public IReadOnlyCollection <IWebElement> ListItemsStudents => driver.FindElements(By.CssSelector("Body > ul > li"));
        public string[] GetRegisteredStudents()
        {
            var elementsStudents = this.ListItemsStudents.Select(s=>s.Text).ToArray();
            return elementsStudents;
        }
    }
}