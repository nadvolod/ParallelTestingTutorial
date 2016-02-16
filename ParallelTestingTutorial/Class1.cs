using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace LocalTesting
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void SimpleTest1()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.FindElement(By.XPath("//a[contains(text(),'Follow')]")).Click();
        }

    }
}
