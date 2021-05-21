using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumGrid
{
    public class Tests
    {
        protected IWebDriver _driver;

        public Tests()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void TestPass()
        {
            var actual = 1;
            var expect = 1;
            _driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual(actual, expect);

        }
        [Test]
        public void TestFail()
        {
            var actual = 1;
            var expect = 2;
            _driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual(actual, expect);

        }
        [TearDown]
        public void End()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile("imageAsFileAttachment.jpg");
            }
            this._driver.Quit();
        }

    }
}
