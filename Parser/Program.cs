using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SalaryCalculator;


namespace SalaryCalculator.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver =
                new ChromeDriver(
                    @"C:\Users\Nizza\source\repos\SalaryCalculator\packages\Selenium.WebDriver.ChromeDriver.87.0.4280.8800\driver\win32");

            driver.Url = "https://www.google.com/";
        }
    }
}
