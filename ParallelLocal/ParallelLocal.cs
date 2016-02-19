using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace ParallelLocal
{
    [TestFixture]
    [Parallelizable]
    public class ParallelLocal
    {
        [Test]
        public void Test1()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            driver.FindElementById("idExample").Click();
            var elementCheck = driver.FindElementByXPath("//p[contains(text(),'Button success')]").Displayed;
            Assert.IsTrue(elementCheck, "Element was not present");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ParallelLocal2
    {
        [Test]
        public void Test2()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            driver.FindElementByClassName("buttonClassExample").Click();
            var elementCheck = driver.FindElementByXPath("//p[contains(text(),'Button success')]").Displayed;
            Assert.IsFalse(elementCheck, "Element was not present");
        }
    }
}
