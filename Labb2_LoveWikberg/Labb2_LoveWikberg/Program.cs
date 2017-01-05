using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LoveWikberg
{
    class Program
    {
        static IWebDriver driver;


        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.lyko.se/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            driver.FindElement(By.Name("q")).SendKeys("schampoo");
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.ClassName("A69wSs")).Click();
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.CssSelector("div._1Nvacq:nth-child(1) > button:nth-child(2)")).Click();
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.CssSelector("._1w9fSZ")).Click();
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.CssSelector("a._3itYIP:nth-child(2)")).Click();
            System.Threading.Thread.Sleep(10000);

            for (int i = 0; i < 9; i++)
            {
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".YwJvmF")).Click();
            }

            bool lykologo = driver.FindElement(By.CssSelector(".jmb20U")).Displayed;
            if (lykologo == true)
            {
                Console.WriteLine("The logo exists");
                driver.FindElement(By.CssSelector(".jmb20U")).Click();
            }
        }
    }
}
