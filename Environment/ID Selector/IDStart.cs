using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ID_Selector
{
    class IDStart
    {
        static void Main(string[] args)
        {
            //variables
            string url = "http://testing.todorvachev.com/selectors/name/";
            string ID = "testImage";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement IDElement = driver.FindElement(By.Id(ID));

            if (IDElement.Displayed)
            {
                ResultMessage("ID Element Visible", IDElement.Displayed);
            }
            else
            {
                ResultMessage("ID Element not visible", IDElement.Displayed);
            }

            driver.Quit();
        }

        //Change format of text based on results
        private static void ResultMessage(string message, bool result)
        {
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS: " + message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: " + message);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
