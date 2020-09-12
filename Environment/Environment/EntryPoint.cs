using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        //Sets browser type
        IWebDriver driver = new ChromeDriver();
        //Website to test
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        //Wait 3 seconds and let page load and appead
        Thread.Sleep(3000);
        //Closes browser
        driver.Quit();
    }
}
