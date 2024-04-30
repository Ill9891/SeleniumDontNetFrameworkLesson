using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverTestProject
{
    public static class WebDriverWaits
    {
        public static void SetImplicitWait(int seconds)
        {
            WebDriverManager.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void SetExplicitWait(int seconds, Func<IWebElement> element)
        {
            var wait = new WebDriverWait(WebDriverManager.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(x => element.Invoke().Displayed);
        }

        public static void SetFluentWait(int seconds, Func<IWebElement> element)
        {
            var wait = new WebDriverWait(WebDriverManager.Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromSeconds(3);

            wait.Until(x => element.Invoke().Displayed);
        }
    }
}
