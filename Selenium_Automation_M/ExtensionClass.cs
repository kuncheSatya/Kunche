using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


namespace Selenium_Automation_M
{

    [TestFixture]
    public class ExtensionClass
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\Neudesic_Automation\Selenium_Automation_M\Selenium_Automation_M\ExtentReports\04092020.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();
        }


        [Test]
        public void TestExt1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("TestExt1").Info("Execution Started");
                driver = new ChromeDriver();
                
                driver.Url = "https://www.facebook.com";
                test.Log(Status.Info, "Application launched");
                driver.Manage().Window.Maximize();
                IWebElement emailText = driver.FindElement(By.Id("email"));
                emailText.SendKeys("satti.k07@gmail.com");
                test.Log(Status.Info, "Email entered into text box");
                test.Log(Status.Pass, "Test cases Passed");
                Thread.Sleep(10000);
                driver.Quit();


            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test cases Failed");
                throw;
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }

        [Test]
        public void TestExt2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("TestExt2").Info("Execution Started");
                driver = new ChromeDriver();

                driver.Url = "https://www.facebook.com";
                test.Log(Status.Info, "Application launched");
                driver.Manage().Window.Maximize();
                IWebElement emailText = driver.FindElement(By.Id("email1"));
                emailText.SendKeys("satti.k07@gmail.com");
                test.Log(Status.Info, "Email entered into text box");
                test.Log(Status.Pass, "Test cases Passed");
                Thread.Sleep(10000);
                driver.Quit();


            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }

    }
}
