using OpenQA.Selenium;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class DocumentationPage : BasePage
    {
        public static IWebElement SauceApiButton => WebDriverManager.Driver.FindElement(By.XPath("//button[text() = 'Sauce REST API']"));
    }
}
