using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Selenium_Automation_M.Utilities
{
    public class Browserutility
    {
        public IWebDriver Init(IWebDriver driver)
        {

        driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
            return driver;


        }

    }
}
