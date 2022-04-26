using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Widgets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)Driver;

            Driver.Manage().Window.Maximize();
            
            //Accordian

            
            Driver.Navigate().GoToUrl("https://demoqa.com/accordian");

            Driver.FindElement(By.XPath("//div[@id='section1Heading']")).Click();
            
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();

            Thread.Sleep(2000);

            Js.ExecuteScript("window.scrollBy(0,400)");//Scroll

            Driver.FindElement(By.XPath("//div[@id='section3Heading']")).Click();

            Thread.Sleep(2000);


            
            //Auto Complete

            
            Driver.Navigate().GoToUrl("https://demoqa.com/auto-complete");

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).Click();

            Thread.Sleep(2000);

            Driver.FindElement(By.Id("autoCompleteMultipleContainer")).SendKeys("Red");

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.ArrowDown);

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys("blue");

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.ArrowDown);

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//div[@id='autoCompleteSingleContainer']")).SendKeys("yellow");

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.ArrowDown);

            Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            



            //Date pikker

            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.FindElement(By.Id("datePickerMonthYearInput")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("datePickerMonthYearInput")).Clear();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("datePickerMonthYearInput")).SendKeys("01/01/2020");

            Thread.Sleep(2000);

            


            //Progress Bar


            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");

            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();

            Thread.Sleep(10000);

            Driver.FindElement(By.XPath("//button[@id='resetButton']")).Click();

            Thread.Sleep(2000);


            //Tabs   

            Driver.Navigate().GoToUrl("https://demoqa.com/tabs");

            Driver.FindElement(By.XPath("//a[@id='demo-tab-what']")).Click();

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")).Click();

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-use']")).Click();

            Thread.Sleep(2000);
            

            //Hover   

            Driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
            Actions actions = new Actions(Driver);
            WebElement target = (WebElement)Driver.FindElement(By.XPath("//button[@id='toolTipButton']"));
            actions.MoveToElement(target).Perform();
            Thread.Sleep(2000);
            
            /*
            //Menu         

            Driver.Navigate().GoToUrl("https://demoqa.com/select-menu");

            Driver.FindElement(By.XPath("//div[@id='withOptGroup']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='withOptGroup']")).SendKeys(Keys.ArrowDown);

            Driver.FindElement(By.XPath("//div[@id='withOptGroup']")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            */


            Driver.Close();
            Driver.Quit();

        }   
    }
}
