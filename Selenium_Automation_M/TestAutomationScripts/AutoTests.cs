using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenium_Automation_M.Base;
using Selenium_Automation_M.WebPageObject;

namespace Selenium_Automation_M.TestAutomationScripts
{

    [TestFixture]
    public class AutoTests : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
           var gSearchPage = new GoogleSearch(driver);
           var gResultsearchpage = gSearchPage.NavigateResultPage();
           var SelOrgPage = gResultsearchpage.gResultPage();
            
           string  ActualLogoName = SelOrgPage.getLogName();
           string ExpectedLogName = "Projects";
           Console.WriteLine("Actual " + ActualLogoName);
           Console.WriteLine("Expected " + ExpectedLogName);

           Assert.IsTrue(ActualLogoName.Equals(ExpectedLogName));
           Thread.Sleep(5000);


        }

    }
}
