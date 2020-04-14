// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Automation_M.Base;
using Selenium_Automation_M.Utilities;

namespace Selenium_Automation_M
{
    [TestFixture]
    public class ParallelTest 
    {
        IWebDriver driver;

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod1()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod2()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod3()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod4()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod5()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod6()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }

        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod7()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }
        [Test, Category("Prod Testing"), Category("Module_1 Testing")]
        public void TestMethod8()
        {
            var Driver = new Browserutility().Init(driver);
            IWebElement emailText = Driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            Thread.Sleep(10000);
            Driver.Quit();
        }
    }
}
