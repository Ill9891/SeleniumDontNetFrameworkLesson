using Core;
using NUnit.Framework;
using SeleniumDontNetFrameworkLesson.Models;
using SeleniumDontNetFrameworkLesson.PageObjects;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDontNetFrameworkLesson.TestSteps
{
    [Binding]
    public class LoginPageTestSteps
    {
        ScenarioContext _scenarioContext;
        public LoginPageTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"logged in to the site with '([^']*)' and '([^']*)'")]
        public void GivenLoggedInToTheSiteWithAnd(string userName, string password)
        {
            var expectedResult = "Products";

            BaseLogger.Info("Step 1: Logging to main page.");

            LoginPage.Login(userName, password);

            var actualResult = MainPage.ProductLabel.Text;
            BaseLogger.Info("Successfully logged in.");
            Assert.AreEqual(expectedResult, actualResult);

            _scenarioContext.Add("expectedResult", expectedResult);
        }

        [Given(@"we have a table")]
        public void GivenWeHaveATable(Table table)
        {
            var data = table.CreateSet<ExampleTestTable>().ToList();
            var test = data[0].FourthValue;
        }

    }
}
