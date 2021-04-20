using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("test case started ");
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://cargocrm.mysoft.com.tr/");
            IWebElement username = driver.FindElement(By.Name("Username"));
            IWebElement password = driver.FindElement(By.Name("Password"));
            //enter the value in the google search text box  
          
        }
    }
}