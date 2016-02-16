using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace ParallelLocal
{
    [TestFixture]
    public class ParallelLocal
    {
        [Test]
        public void Test1()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.FindElementByXPath("//a[contains(text(),'Follow')]").Click();
        }
    }
}
