using Core;
using NUnit.Framework;
using WebDriverTestProject;

namespace SeleniumDontNetFrameworkLesson
{
    public class ComponentManager
    {
        private static ComponentManager _componentManager;

        public static ComponentManager Instance => _componentManager ?? (new ComponentManager());

        public void Initialize()
        {
            WebDriverManager.Initialize();
            BaseLogger.Info($"Startup and setup of test {TestContext.CurrentContext.Test.MethodName}.");
            WebDriverManager.Setup();
        }

        public void OneTimeInitialize()
        {
            BaseLogger.Initialize();
        }
    }
}
