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
        IWebDriver driver;
        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.facebook.com/");
        }


        [Test]
        public void InvalidRegisterCredentials(String username, String password)
        {
            //arrange 
            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            driver.FindElement(By.Id("loginbutton")).Click();
            //act 
            //driver.Click_Elementv

            //assert
            //Assert.assertTrue("User logged in successfully? ", driver.getTitle().trim().equals("expected title");
            // Assert.IsFalse(driver.FindElement(By.Id("Home")));

        }

        [TearDown]
        public void CloseBrowser()
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
