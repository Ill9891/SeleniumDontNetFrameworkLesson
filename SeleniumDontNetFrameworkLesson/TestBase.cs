using Core;
using NUnit.Framework;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson
{
    public class TestBase
    {
 

        [SetUp]
        public void SetUp()
        {
            ComponentManager.Instance.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            BaseLogger.Info($"End of test {TestContext.CurrentContext.Test.MethodName}.");

            if (TestContext.CurrentContext.Result.FailCount > 0)
            {
                WebDriverUtils.TakesScreenshot();
            }
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ComponentManager.Instance.OneTimeInitialize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverManager.Driver.Quit();
        }
    }
}