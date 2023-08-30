using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.Selenium_with_C_
{
    public class Class1
    {
        private static object obj;

        public static object Chromedriver { get; private set; }
        public static IWebDriver ChromedriverObj { get; private set; }
        public static object Obj { get; private set; }

        public static void Main(string[] args)
        {
            // Creating a ChromeDriver instance
            IWebDriver chromeDriver = new ChromeDriver();

            // Storing the ChromeDriver instance in the ChromedriverObj property
            Chromedriver driver = chromeDriver;
            Obj.Url = "https://www.flipkart.com/";
        }
    }
}