using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Upload_and_download
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)Driver;

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl("https://demoqa.com/upload-download");

            Thread.Sleep(1000);

            Driver.FindElement(By.Id("downloadButton")).Click();

            Thread.Sleep(3000);

            Driver.FindElement(By.Id("uploadFile")).SendKeys(@"C:\Users\" + System.Environment.UserName + @"\Downloads\aaaa.jpeg");

            Thread.Sleep(3000);

            Driver.Close();
            Driver.Quit();
        }
    }
}
