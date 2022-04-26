using Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Find_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            string name = "abcd";
            string email = "abcd@gmail.com";
            string Cadd = "aaaaaaaaa";
            string Padd = "bbbbbbbbbb";

            Thread.Sleep(2000);
            

            //Text Box



            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            Thread.Sleep(1000);

            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("userName")).SendKeys(name);

            Driver.FindElement(By.Id("userEmail")).SendKeys(email);

            Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);

            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");

            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();

            Task.Delay(10000).Wait();


            
            
            // radio button

            Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            Thread.Sleep(1000);

            IWebElement YesBtn = Driver.FindElement(By.Id("yesRadio"));

            Thread.Sleep(2000);

            js.ExecuteScript("arguments[0].click()", YesBtn);

            Thread.Sleep(2000);


            //Web table


            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            Driver.FindElement(By.Id("addNewRecordButton")).Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.Id("firstName")).SendKeys("Sumit");

            Thread.Sleep(1000);
            Driver.FindElement(By.Id("lastName")).SendKeys("Jha");

            Thread.Sleep(1000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("zeus@gmail.com");

            Thread.Sleep(1000);
            Driver.FindElement(By.Id("age")).SendKeys("22");

            Thread.Sleep(1000);
            Driver.FindElement(By.Id("salary")).SendKeys("420000");

            Thread.Sleep(1000);
            Driver.FindElement(By.Id("department")).SendKeys("CSE");

            IWebElement submit1 = Driver.FindElement(By.Id("submit"));
            submit1.Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.Id("searchBox")).SendKeys("Alden");
            Thread.Sleep(2000);




            //  Buttons



            // double click

            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");

            Thread.Sleep(1000);

            IWebElement doubleclickLink = Driver.FindElement(By.Id("doubleClickBtn"));

            Actions actions = new Actions(Driver);

            Thread.Sleep(1000);

            actions.DoubleClick(doubleclickLink).Build().Perform();

            Thread.Sleep(1000);

            // right click


            IWebElement rightclick = Driver.FindElement(By.Id("rightClickBtn"));

            Actions actions1 = new Actions(Driver);

            Thread.Sleep(1000);

            actions1.ContextClick(rightclick).Build().Perform();

            Thread.Sleep(1000);




            Console.Write("Test Case Closed:");

            Driver.Close();
            Driver.Quit();

        }
    }
}
