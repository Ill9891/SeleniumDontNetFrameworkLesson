using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTestProject;
using OpenQA.Selenium.DevTools.V121.DOM;
using OpenQA.Selenium.Interactions;

namespace SeleniumDontNetFrameworkLesson
{
    public static class PageHelpers
    {
        public static void SelectFromDropDownByText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);

            select.SelectByText(text);
        }

        public static void CloseAlert(string message = null)
        {
            try
            {
                if (message != null)
                {
                    var text = WebDriverManager.Driver.SwitchTo().Alert().Text;
                    WebDriverManager.Driver.SwitchTo().Alert().SendKeys(message);
                }

                WebDriverManager.Driver.SwitchTo().Alert().Accept();
            }
            catch
            {

            }
        }

        public static void ScrollToElement(IWebElement element)
        {
            Actions actions = new Actions(WebDriverManager.Driver);

            actions.MoveToElement(element).Click().Build().Perform();
        }
    }
}
