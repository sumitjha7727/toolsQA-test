using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Threading;

namespace CheckBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            Thread.Sleep(2000);

            ExpandArrow(Driver);

            Thread.Sleep(2000);

            SelectCheckBox(Driver);

            Thread.Sleep(2000);

            RightCollapseBtn(Driver);

            Thread.Sleep(2000);

            RightExpandBtn(Driver);

            Thread.Sleep(5000);

            Driver.Close();
            Driver.Quit();
        }

        static void ExpandArrow(IWebDriver driver)
        {
            driver.FindElements(By.XPath("//button[@title='Toggle']"))[0].Click();
            Thread.Sleep(2000);

            driver.FindElements(By.XPath("//button[@title='Toggle']"))[1].Click();
            Thread.Sleep(2000);

            driver.FindElements(By.XPath("//button[@title='Toggle']"))[2].Click();
            Thread.Sleep(2000);

            driver.FindElements(By.XPath("//button[@title='Toggle']"))[3].Click();
            Thread.Sleep(2000);

            driver.FindElements(By.XPath("//button[@title='Toggle']"))[4].Click();
            Thread.Sleep(2000);

            driver.FindElements(By.XPath("//button[@title='Toggle']"))[5].Click();
            Thread.Sleep(2000);
        }

        static void SelectCheckBox(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//span[text()='Home']")).Click();
        }

        static void RightExpandBtn(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("rct-option-expand-all")).Click();
        }

        static void RightCollapseBtn(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("rct-option-collapse-all")).Click();
        }
    }
}
