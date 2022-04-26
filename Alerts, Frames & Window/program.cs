using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alerts___Frames_n_Windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)Driver;
            Driver.Manage().Window.Maximize();
            
            //Browse Windows

            Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Thread.Sleep(1000);
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Driver.FindElement(By.XPath("//button[@id='windowButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            //wait.Until(driver => driver.Url.Contains("desired_url_or_a_substring_of_it"));
            Driver.Close();
            
            //Alerts

            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(5000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Alert().SendKeys("abcsd");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            

            //Modal       

            Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
            Driver.FindElement(By.XPath("//button[@id='showSmallModal']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='closeSmallModal']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='showLargeModal']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            Thread.Sleep(2000);



            Driver.Close();
            Driver.Quit();

        }
    }
}
