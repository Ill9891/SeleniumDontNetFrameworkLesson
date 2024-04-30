using Core;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumDontNetFrameworkLesson.Helpers;
using SeleniumDontNetFrameworkLesson.Models;
using SeleniumDontNetFrameworkLesson.PageObjects;
using System.Linq;
using System.Threading;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.SmokeTests
{
    [TestFixture]
    public class Smoke : TestBase
    {
        const string StandartUserName = "standard_user";
        const string Password = "secret_sauce";

        [TestCase]
        public void LoginVerification()
        {
            var employee = new Employees();
            employee.JobTitle = "Software Developer";
            employee.Name = "John Sanders";
            employee.Level = 3;


            DbHelper.Insert(employee);
             //ApiHelper.GetRequest();

            

            var expectedResult = "Products";

            BaseLogger.Info("Step 1: Logging to main page.");

            LoginPage.Login(StandartUserName, Password);

            var actualResult = MainPage.ProductLabel.Text;
            BaseLogger.Info("Successfully logged in.");
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase]
        public void AddToCartitemVerification()
        {
            var expectedResult = "1";

            BaseLogger.Info("Step 1: Logging to main page.");
            LoginPage.Login(StandartUserName, Password);

            BaseLogger.Info("Step 2: Going to add item to the cart.");
            MainPage.ClickAddToCartButton();

            var actualResult = MainPage.ShoppingCartCounter.Text;

            BaseLogger.Info("The item was added to the cart.");

            Assert.AreEqual(expectedResult, actualResult);

            var priceLowToHigh = "Price (low to high)";

            PageHelpers.SelectFromDropDownByText(MainPage.FilterDropDown, priceLowToHigh);

        }

        [TestCase]
        public void AlertTest()
        {
            LoginPage.Login(StandartUserName, Password);

            WebDriverWaits.SetExplicitWait(20, () => MainPage.AppLogo);
            MainPage.AppLogo.Click();









            //MainPage.AboutLnk.Click();
            //AboutPage.DevelopersDrpDwn.Click();
            //AboutPage.DocumentationLink.Click();

            //var mainWindowHandle = WebDriverManager.Driver.CurrentWindowHandle;
            //var windowHandles = WebDriverManager.Driver.WindowHandles.ToList();

            //foreach (var window in windowHandles)
            //{
            //    if(window != mainWindowHandle)
            //    {
            //        WebDriverManager.Driver.SwitchTo().Window(window);
            //    }
            //}

            //DocumentationPage.SauceApiButton.Click();

            //WebDriverManager.Driver.SwitchTo().Window(mainWindowHandle);
        }
    }
}