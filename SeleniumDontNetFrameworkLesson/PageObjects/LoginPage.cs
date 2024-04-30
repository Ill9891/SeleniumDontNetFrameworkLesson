using OpenQA.Selenium;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class LoginPage : BasePage
    {

        public static IWebElement UserNameField => WebDriverManager.Driver.FindElement(By.Id("user-name"));
        public static IWebElement PasswordField => WebDriverManager.Driver.FindElement(By.Id("password"));
        public static IWebElement LoginButton => WebDriverManager.Driver.FindElement(By.Id("login-button"));

        public static void Login(string userName, string password)
        {
            UserNameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}