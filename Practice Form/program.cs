using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)Driver;
            Driver.Manage().Window.Maximize();

            //Practice form

            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form/");

            Driver.FindElement(By.Id("firstName")).SendKeys("Sumit");
            Driver.FindElement(By.Id("lastName")).SendKeys("Jha");
            Driver.FindElement(By.Id("userEmail")).SendKeys("sumitjha@gmail.com");

            Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//input[@id='gender-radio-1']")).Click();
            Driver.FindElement(By.XPath("//label[@for='gender-radio-1']")).Click();
            //Thread.Sleep(2000);  

            Driver.FindElement(By.Id("userNumber")).SendKeys("70707");

            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
            //Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Null);
            //Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Chord(Keys.Control, "a", Keys.Delete));
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
           
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
           
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            
            Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Backspace);
            Thread.Sleep(2000);

            //Js.ExecuteScript("window.scrollBy(0,300)");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("14 MAR 1999");
            //Thread.Sleep(2000);

            
            Driver.FindElement(By.XPath("//div[@id='subjectsContainer']"));
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='subjectsContainer']")).SendKeys("m");

            Driver.FindElement(By.XPath("//div[@id='subjectsContainer']")).SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("hobbies-checkbox-3")).Click();

            Driver.FindElement(By.Id("currentAddress")).SendKeys("jghfkuadfgjlasgdfl jsjhdgdffkjsgfl");

            Driver.Close();
            Driver.Quit();

        }
    }
}
