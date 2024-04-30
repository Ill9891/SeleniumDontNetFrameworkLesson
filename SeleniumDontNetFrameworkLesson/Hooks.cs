using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ComponentManager.Instance.OneTimeInitialize();
            ComponentManager.Instance.Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseLogger.Info($"End of test {TestContext.CurrentContext.Test.MethodName}.");

            if (TestContext.CurrentContext.Result.FailCount > 0)
            {
                WebDriverUtils.TakesScreenshot();
            }

            WebDriverManager.Driver.Quit();
        }
    }
}
