using OpenQA.Selenium.DevTools.V114.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Core.Builders;
using System.Xml.Linq;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace FacebookAutomationTask
{
    class Login
    {
        IWebDriver driver;
      
        [SetUp]
        public void InitializeBrowser() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.facebook.com/");
            driver.Manage().Window.Maximize();
            
        }
        [Test]
        public void InvalidCredentials(String username, String password)
        {
            //arrange 
            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            driver.FindElement(By.Id("loginbutton")).Click();
            //act 

            //assert
            //Assert.assertTrue("User logged in successfully? ", driver.getTitle().trim().equals("expected title");
           // Assert.IsFalse(driver.FindElement(By.Id("Home")));

        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
          
        }

        //@DataProvider(name= “searchProvider”);
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

