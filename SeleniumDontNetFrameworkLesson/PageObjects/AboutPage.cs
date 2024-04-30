using OpenQA.Selenium;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class AboutPage : BasePage
    {
        public static IWebElement DevelopersDrpDwn => WebDriverManager.Driver.FindElement(By.XPath("//span[text() = 'Developers']"));
        public static IWebElement DocumentationLink => WebDriverManager.Driver.FindElement(By.LinkText("Documentation"));
    }
}
