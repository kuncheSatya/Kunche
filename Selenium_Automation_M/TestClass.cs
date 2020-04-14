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

namespace Selenium_Automation_M
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k07@gmail.com");
            IWebElement MDDL = driver.FindElement(By.Name("birthday_month"));
            SelectElement elemnt = new SelectElement(MDDL);
            elemnt.SelectByIndex(4);
            Thread.Sleep(10000);


        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k02@gmail.com");

        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailText = driver.FindElement(By.Id("email"));
            emailText.SendKeys("satti.k03@gmail.com");

        }
    }
}
