using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BrowserStackParallelTests
{
    [TestFixture]
    [Parallelizable]
    public class BrowserstackTest3
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability("browserstack.user", "nikolayadvolodki1");
            capability.SetCapability("browserstack.key", "ux6rpccX5ku7W7tRmsiZ");
            capability.SetCapability("browserName", "android");
            capability.SetCapability("platform", "Android");
            capability.SetCapability("device", "Samsung Galaxy S5");

            driver = new RemoteWebDriver(
                new Uri("http://hub.browserstack.com/wd/hub/"), capability
                );
        }

        [Test]
        public void BrowserStackTest3()
        {
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("idExample")).Click();
            var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(elementCheck, "Element was not present");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}