using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameTwist.Pages
{
    [TestFixture]
    class Driver
    {
        public static IWebDriver driver;


       [SetUp]
        public void launchBrowser()
        {
            try
            {
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("disable-infobars");
                driver = new ChromeDriver(option);
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.gametwist.com/en/");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        [TearDown]
        public void QuitDriver()
        {
            try
            {
                driver.Quit();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
              
            }
        }
    }
}
