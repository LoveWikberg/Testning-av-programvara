using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace Labb1_LoveWikberg
{
    class Program
    {
        static IWebDriver driver;
        static IWait<WebDriverWait> wait;

        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("_fZl")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            string result = driver.FindElement(By.Id("resultStats")).Text;
            Console.WriteLine(result); 
        }
    }
}
