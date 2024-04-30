using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson.PageObjects
{
    public class MainPage : BasePage
    {
        public static IWebElement ProductLabel => WebDriverManager.Driver.FindElement(By.ClassName("product_label"));
        public static List<IWebElement> AddToCartButtons => WebDriverManager.Driver.FindElements(By.ClassName("btn_inventory")).ToList();
        public static IWebElement ShoppingCartCounter => WebDriverManager.Driver.FindElement(By.ClassName("shopping_cart_badge"));
        public static IWebElement FilterDropDown => WebDriverManager.Driver.FindElement(By.ClassName("product_sort_container"));
        public static IWebElement FooterText => WebDriverManager.Driver.FindElement(By.XPath("//div[text() = '© 2020 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy']"));
        public static IWebElement BurgerMenu => WebDriverManager.Driver.FindElement(By.XPath("//button[text() = 'Open Menu']"));
        public static IWebElement AboutLnk => WebDriverManager.Driver.FindElement(By.Id("about_sidebar_link"));
        public static IWebElement AppLogo => WebDriverManager.Driver.FindElement(By.ClassName("app_logo"));


        public static void ClickAddToCartButton()
        {
            AddToCartButtons[0].Click();
        }

        public static void SelectFromFilterDropDownByText(string text)
        {
            
        }
    }
}