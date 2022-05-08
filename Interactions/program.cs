using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Actions actionProvider = new Actions(Driver);

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl("https://demoqa.com/sortable");

            Thread.Sleep(3000);

            //TestNormalList(Driver, actionProvider);

            TestGrid(Driver, actionProvider);

            //_ = 0;

            Driver.Close();
            Driver.Quit();
        }

        private static void TestGrid(IWebDriver driver, Actions action)
        {
            IWebElement ClickGridTab = driver.FindElement(By.Id("demo-tab-grid"));
            ClickGridTab.Click();

            var GridItems = driver.FindElements(By.XPath("//div[@id='demo-tabpane-grid']//div[contains(@class,'list-group-item')]"));

            action.MoveToElement(GridItems[0])
                .ClickAndHold()
                .MoveToElement(GridItems[3])
                .MoveToElement(GridItems[4])
                .MoveToElement(GridItems[5])
                .MoveToElement(GridItems[8])
                .MoveToElement(GridItems[6])
                .MoveToElement(GridItems[2])
                .MoveToElement(GridItems[1])
                .Release()
                .Build()
                .Perform();
        }

        static void TestNormalList(IWebDriver driver, Actions action)
        {
            var ListItems = driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class,'list-group-item')]"));

            action.MoveToElement(ListItems[1])
                .ClickAndHold()
                .MoveToElement(ListItems[3])
                .Release()
                .MoveToElement(ListItems[4])
                .ClickAndHold()
                .MoveToElement(ListItems[5])
                .Release()
                .MoveToElement(ListItems[0])
                .ClickAndHold()
                .MoveToElement(ListItems[3])
                .Release()
                .Build()
                .Perform();
        }

    }
}
