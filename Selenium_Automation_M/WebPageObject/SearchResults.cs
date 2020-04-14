using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_Automation_M.WebPageObject
{
    public class SearchResults
    {

        IWebDriver driver;
        public SearchResults(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);


        }

        [FindsBy(How =How.XPath, Using = "//h3[contains(text(),'SeleniumHQ Browser Automation')]")]
        public IWebElement SearchResultLink { get; set; }

        
        public SeleniumOrg gResultPage()
        {

            Thread.Sleep(5000);
            SearchResultLink.Click();
            return new SeleniumOrg(driver);
        }

    }
}
