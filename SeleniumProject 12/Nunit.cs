using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookAutomationTask
{
    class Nunit
    {
        IWebDriver webDriver;
        [SetUp]
        public void InitializeBrowser()
        {
            webDriver = new ChromeDriver();
        }

        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Close();
        }
    }
}