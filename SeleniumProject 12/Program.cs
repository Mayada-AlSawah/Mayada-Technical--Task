using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Antlr4.Runtime.Misc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V114.Debugger;

namespace FacebookAutomationTask
{
    class Program
    {
        public static void Navigate_To(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.facebook.com");

        }

        public static void Click_Element(WebDriver wd, String loc, String locString)
        {
            switch (loc)
            {
                case "Xpath": wd.FindElement(By.XPath(locString)).Click(); break;
                case "ID": wd.FindElement(By.Id(locString)).Click(); break;
                case "name": wd.FindElement(By.Name(locString)).Click(); break;
            }

        }
        public static void Send_Keys(WebDriver wd, String loc,
            String locString, String data)
        {
            switch (loc)
            {
                case "Xpath":
                    wd.FindElement(By.XPath(locString)).Clear();
                    wd.FindElement(By.XPath(locString)).SendKeys(data); break;
                case "ID":
                    wd.FindElement(By.Id(locString)).Clear();
                    wd.FindElement(By.Id(locString)).SendKeys(data); break;
                case "name":
                    wd.FindElement(By.Name(locString)).Clear();
                    wd.FindElement(By.Name(locString)).SendKeys(data); break;


            }
        }

       /* public void getTitle()
        {

        }
        
       /*
        public static void Select_Element(WebDriver wd, String loc,
            String locString, String data)
        {
            WebElement we = null;
            switch(loc)
            {
                case "Xpath": wd.FindElement(By.XPath(locString)).Click(); break;
                case "ID": wd.FindElement(By.Id(locString)).Click(); break;
                case "name": wd.FindElement(By.Name(locString)).Click(); break;
            }
             = new Select(we);
            SelectBox.SelectByVisibleText(data);
        }
       */
    }
}
