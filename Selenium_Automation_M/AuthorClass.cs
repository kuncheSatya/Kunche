using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using System.Collections;

namespace Selenium_Automation_M
{
    [TestFixture]
    public class AuthorClass
    {
        
        [Test, Author("satya")]
        //[Author("Satya", "satya@gmail.com")]
        [TestCaseSource("DDTesting")]
        public void Test1(string urlName)
        {
            IWebDriver driver = null;

            try
            {
                driver = new ChromeDriver();
                //driver.Url = "https://www.facebook.com";
                driver.Manage().Window.Maximize();
                driver.Url = urlName;

                IWebElement emailText = driver.FindElement(By.Id("email"));
                emailText.SendKeys("satti.k07@gmail.com");

                Thread.Sleep(10000);
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("D:\\Neudesic_Automation\\Selenium_Automation_M\\Selenium_Automation_M\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                if(driver!=null)
                {
                    driver.Quit(); 
                }
            }
            
        }


        static IList DDTesting()
        {
            ArrayList List = new ArrayList();
            List.Add("https://www.facebook.com");
            //List.Add("https://www.youtube.com");
            //List.Add("https://www.gmail.com");

            return List;
        }

        //[Test, Author("satya")]
        ////[Author("Satya", "satya@gmail.com")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://www.facebook.com";
        //    IWebElement emailText = driver.FindElement(By.Id("email"));
        //    emailText.SendKeys("satti.k07@gmail.com");

        //    Thread.Sleep(10000);
        //    driver.Close();
        //}

    }
}
