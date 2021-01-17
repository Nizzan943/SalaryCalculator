using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SalaryCalculator.Parser
{
    public class Session
    {
        
        private User _user;
        public double regularTime = 0;
        public double extraTime = 0;
        public double regularPayment = 0;
        public double extraPayment = 0;
        public double totalTime = 0;
        public string strTotalTimeHH = null;
        public string strRegularTimeHH = null;
        public string strExtraTimeHH = null;
        public double totalPayment = 0;

        public Session(User user)
        {
            this._user = user;
        }

       
        public void GetInfo(User user)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            
            var driver =
               new ChromeDriver(chromeOptions)
               {
                   Url = user.Site
               };

            driver.FindElement(By.Name("comp")).SendKeys(user.CompanyId);
            driver.FindElement(By.Name("name")).SendKeys(user.UserId);
            driver.FindElement(By.Name("pw")).SendKeys(user.Password);
            driver.FindElement(By.Name("B1")).Click();

            IWebElement attendance = driver.FindElement(By.XPath("//a[contains(text(),'נוכחות')]"));
            attendance.Click();
            var popUpWindow = driver.WindowHandles;
            driver.SwitchTo().Window(popUpWindow[1]);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(driver.PageSource);
            //HtmlNodeCollection trElements = doc.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/span[1]/table[3]/tbody[1]/tr[36]");
            //HtmlNodeCollection trElements2 = doc.DocumentNode.SelectNodes("//html[1]/body[1]/div[1]/span[1]/table[3]/tbody[1]/tr[37]");
            var timeHourlyPath = "//html[1]/body[1]/div[1]/span[1]/table[3]/tbody[1]/tr[36]";
            var timeDecimalPath = "//html[1]/body[1]/div[1]/span[1]/table[3]/tbody[1]/tr[37]";

            var strTotalTime = doc.DocumentNode.SelectSingleNode($"{timeDecimalPath}/td[2]").InnerText.Split(';')[1];
            var strRegularTime = doc.DocumentNode.SelectSingleNode($"{timeDecimalPath}/td[5]").InnerText.Split(';')[1];
            var strExtraTime = doc.DocumentNode.SelectSingleNode($"{timeDecimalPath}/td[6]").InnerText.Split(';')[1];
            // HtmlNode testNode = doc.DocumentNode.SelectSingleNode(".//*[contains(text(),'סה\"כ חודשי')]");
            strTotalTimeHH = doc.DocumentNode.SelectSingleNode($"{timeHourlyPath}/td[2]").InnerText.Split(';')[1];
            strRegularTimeHH = doc.DocumentNode.SelectSingleNode($"{timeHourlyPath}/td[5]").InnerText.Split(';')[1];
            strExtraTimeHH = doc.DocumentNode.SelectSingleNode($"{timeHourlyPath}/td[6]").InnerText.Split(';')[1];
            totalTime= double.Parse(strTotalTime);
            regularTime= double.Parse(strRegularTime);
            extraTime = double.Parse(strExtraTime);

            regularPayment = regularTime * user.Rate;
            extraPayment = extraTime * user.Rate * 1.5;
            totalPayment = regularPayment + extraPayment;

        }
    }
}
