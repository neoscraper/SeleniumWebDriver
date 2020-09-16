using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace InputText
{
    class InputTextStart
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textBox;

        //For working with text boxes on website
        static void Main(string[] args)
        {
            //variables
            string url = "https://testing.todorvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);
            //Name of text box
            textBox = driver.FindElement(By.Name("username"));
            //Sends string to text box
            textBox.SendKeys("Test text");
            Thread.Sleep(3000);
            //Text is placed under attribute value, not text
            //Can get other information from GetAttribute about the text box
            Console.WriteLine(textBox.GetAttribute("value"));
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
