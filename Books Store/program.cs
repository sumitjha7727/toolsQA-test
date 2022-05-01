using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Books_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.Navigate().GoToUrl("https://demoqa.com/login");
            Driver.Manage().Window.Maximize();


            /*
            Driver.FindElement(By.Id("newUser")).Click();
            Thread.Sleep(2000);
            
            // Register //button[@id='register']

            Driver.FindElement(By.XPath("//input[@id='firstname']")).SendKeys("Sumit");

            Driver.FindElement(By.XPath("//input[@id='lastname']")).SendKeys("Jha");

            Driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("sumitjha");

            Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Skj@123");

            //Driver.FindElement(By.XPath("//button[@id='register']")).Click();
            //Thread.Sleep(2000);

            


            String framename = Driver.FindElement(By.XPath("//input[@id='password']")).GetAttribute("name");
            Driver.SwitchTo().Frame(framename);
            Driver.FindElement(By.XPath("//span[@id='recaptcha-anchor']")).Click();

            */

            // Login  

            //Driver.FindElement(By.XPath("//button[@id='gotologin']")).Click();
            //Thread.Sleep(2000);
            Driver.FindElement(By.Id("userName")).SendKeys("userone");
            Driver.FindElement(By.Id("password")).SendKeys("Userone@1");
            Driver.FindElement(By.XPath("//button[@id='login']")).Click();
            Thread.Sleep(2000);

            //Books Menu  

            Driver.Navigate().GoToUrl("https://demoqa.com/books");
            Driver.FindElement(By.XPath("//span[@id='see-book-Git Pocket Guide']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");

            //Add Book
            Driver.FindElement(By.XPath("//button[text()='Add To Your Collection']")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.XPath("//button[text()='Back To Book Store']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[@id='see-book-Learning JavaScript Design Patterns']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");

            Driver.FindElement(By.XPath("//button[text()='Add To Your Collection']")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.XPath("//button[text()='Back To Book Store']")).Click();
            Thread.Sleep(2000);


            //Profile
            //Del books

            Driver.Navigate().GoToUrl("https://demoqa.com/profile");
            Driver.FindElement(By.XPath("//span[@id='delete-record-undefined']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();    

            Driver.FindElement(By.XPath("//span[@id='delete-record-undefined']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();

            //Logout  
            Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
            Thread.Sleep(2000);


            Driver.Close();
            Driver.Quit();


        }
    }
}
