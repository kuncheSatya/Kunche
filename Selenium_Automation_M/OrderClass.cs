// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Selenium_Automation_M.Base;

namespace Selenium_Automation_M
{
    [TestFixture]
    public class OrderClass
    {
        [Test, Order(2), Category("OrderIgnoreAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            
            Thread.Sleep(10000);
            driver.Close();
            
        }

        [Test, Order(0), Category("OrderIgnoreAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("for time being" );

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");

            Thread.Sleep(10000);
            driver.Close();

        }

        [Test, Order(1), Category("OrderIgnoreAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");

            Thread.Sleep(10000);
            driver.Close();

        }

    }
}
