using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AlertBox
{
    class AlertBoxStart
    {
        static IWebDriver driver = new ChromeDriver();
        static IAlert alert;
        static IWebElement image;

        static void Main(string[] args)
        {
            //variables
            string url = "https://testing.todorvachev.com/special-elements/alert-box/";

            driver.Navigate().GoToUrl(url);
            //Necessary to initialize alert
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            //Clicks on alert
            alert.Accept();
            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            //If alert is accepted, the page will load and the image should be displayed.
            try
            {
                if(image.Displayed)
                {
                    Console.WriteLine("Alert accepted, image successfuly loaded");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Something went wrong");
            }
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
