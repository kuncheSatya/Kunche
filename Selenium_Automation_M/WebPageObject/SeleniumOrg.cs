using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_Automation_M.WebPageObject
{
    public class SeleniumOrg
    {
        IWebDriver driver;

        public SeleniumOrg(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How =How.XPath, Using = "//a[contains(text(),'Projects')]")]
        public IWebElement LogoSeleniumOrg { get; set; }



        public string getLogName()
        {
            return LogoSeleniumOrg.Text;
               
        }
        
    }
}
