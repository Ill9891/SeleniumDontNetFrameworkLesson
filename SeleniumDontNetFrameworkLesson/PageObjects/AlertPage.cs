using OpenQA.Selenium;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class AlertPage : BasePage
    {
        public static IWebElement AlertWithOkAndCancel => WebDriverManager.Driver.FindElement(By.XPath("//a[text() = 'Alert with OK & Cancel ']"));
        public static IWebElement AlertWithTextBox => WebDriverManager.Driver.FindElement(By.XPath("//a[text() = 'Alert with Textbox ']"));
        public static IWebElement BtnToDisplayConfirmBox => WebDriverManager.Driver.FindElement(By.XPath("//button[text() = 'click the button to display a confirm box ']"));
        public static IWebElement BtnToDemonstrateThePromBox => WebDriverManager.Driver.FindElement(By.XPath("//button[text() = 'click the button to demonstrate the prompt box ']"));
    }
}
