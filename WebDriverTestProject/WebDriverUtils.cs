using OpenQA.Selenium;
using System;

namespace WebDriverTestProject
{
    public static class WebDriverUtils
    {
        static ITakesScreenshot _takesScreenshot  = WebDriverManager.Driver;

        public static void TakesScreenshot()
        {
            var screenshotName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            _takesScreenshot.GetScreenshot().SaveAsFile($"D:\\QALightsLessons\\Lesson1\\SeleniumLesson\\Screenshots\\{screenshotName}.png");
        }
    }
}