using NUnit.Core.Builders;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAutomationTask
{
    class Register
    {
        IWebDriver webDriver;
        [SetUp]
        public void InitializeBrowser()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("www.facebook.com/");
        }


        [Test]


        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Close();
        }



        public Object[][] PassData()
        {
            Object[][] data = new Object[1][];
            data[0][0] = " ";
            data[0][1] = " ";

            data[1][0] = "invalid@email.com";
            data[1][1] = " invalidPassword123";

            return data;
        }
    }
   
}
