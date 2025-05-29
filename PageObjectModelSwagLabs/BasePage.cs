using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelSwagLabs
{
   public class BasePage 
    {
        public static  IWebDriver driver;
        public static void SeleniumInit()
        {
            driver = new ChromeDriver();
        }
        public static void Write(By by , string Text)
        {
            driver.FindElement(by).SendKeys(Text);
        }
        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }
    } 
}
