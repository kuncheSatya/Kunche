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
    public class GoogleSearch
    {

        IWebDriver driver;

        //Initialize
        public GoogleSearch(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How =How.XPath, Using = "//*[@name = 'q']")]
        public IWebElement SearchBox { get; set; }


        [FindsBy(How =How.XPath, Using = "//*[@name = 'btnK']")]
        public IWebElement SearchButton { get; set; }



        public SearchResults NavigateResultPage()
        {
            SearchBox.SendKeys("seleniumhq.org");
            Thread.Sleep(5000); 
            SearchButton.Click();
            Thread.Sleep(5000);
            return new SearchResults(driver);
        }


    }
}
