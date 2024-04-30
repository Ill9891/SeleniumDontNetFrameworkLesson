using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class BasePage
    {
        public static void SelectFromDropDownByText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);

            select.SelectByText(text);
        }
    }
}
