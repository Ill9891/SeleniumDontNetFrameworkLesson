using OpenQA.Selenium.Chrome;

namespace WebDriverTestProject
{
    public static class WebDriverManager
    {
        public static ChromeDriver Driver;

        public static void Initialize()
        {
            Driver = new ChromeDriver();
        }

        public static void Setup()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            //Driver.Navigate().GoToUrl("https://demo.automationtesting.in/Alerts.html");
            Driver.Manage().Window.Maximize();
        }
    }
}
