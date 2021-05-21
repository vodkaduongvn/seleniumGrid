using NUnit.Framework;
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

        [Test]
        public void Test1()
        {
            var chromeOptions = new ChromeOptions();
            //chromeOptions.BrowserVersion = "90";
            //chromeOptions.PlatformName = "windows";
            IWebDriver driver = new RemoteWebDriver(new Uri("http://192.168.1.2:4444/wd/hub"), chromeOptions);
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Quit();
        }
    }
}
