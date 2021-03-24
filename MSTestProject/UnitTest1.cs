using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MSTestProject
{
    [TestClass]
    public class Login
    {
        //IWebDriver driver = null;
        IWebDriver driver = new ChromeDriver(@"D:\MSTest\MSTestProject\MSTestProject\Driver");

        [TestInitialize()] //Used to initialize the test before running each Test Method
        public void Initialize()
        {
            // InitializeDriver("CHROME");

            //IWebDriver driver = new ChromeDriver(@"D:\SeleniumRegressionAutomation\SeleniumRegressionAutomation\Driver");
        }


        [TestMethod]
        [TestCategory("Smoke")]
        public void Navigate_To_Page()
        {
            driver.Navigate().GoToUrl("https://www.guru99.com/use-autoit-selenium.html#1");
        }

        [TestMethod]
        [TestCategory("Regression")]
        public void Perform_Click_Operation_On_Element()
        {
            driver.Navigate().GoToUrl("https://gmail.com");           
        }

    }
}
