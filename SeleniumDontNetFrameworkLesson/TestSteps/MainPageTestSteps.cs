using Core;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDontNetFrameworkLesson.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumDontNetFrameworkLesson.TestSteps
{
    [Binding]
    public class MainPageTestSteps
    {
        ScenarioContext _scenarioContext;
        public MainPageTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Then(@"'([^']*)' item added to the cart")]
        [When(@"'([^']*)' item added to the cart")]
        [Then(@"'([^']*)' items added to the cart")]
        [When(@"'([^']*)' items added to the cart")]
        [When(@"'([^']*)' items added to the cart")]
        public void WhenItemAddedToTheCart(string itemsCount)
        {
            BaseLogger.Info("Step 2: Going to add item to the cart.");
            MainPage.ClickAddToCartButton();
        }

        [Then(@"the '([^']*)' item in the cart")]
        public void ThenTheItemInTheCart(string itemsCount)
        {
            var actualResult = MainPage.ShoppingCartCounter.Text;

            BaseLogger.Info("The item was added to the cart.");

            Assert.AreEqual(itemsCount, actualResult);

            var sc = _scenarioContext.Get<string>("expectedResult");
        }

    }
}
