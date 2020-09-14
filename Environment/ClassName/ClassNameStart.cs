using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class NameStart
{
    static void Main()
    {
        //variables
        string url = "https://testing.todorvachev.com/selectors/css-path/";
        //paths that tell website where to navigate too
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));
        //cssPath check
        if (cssPathElement.Displayed)
        {
            ResultMessage("CSS Path Element Visible", cssPathElement.Displayed);
        }
        else
        {
            ResultMessage("CSS Path Element not visible", cssPathElement.Displayed);
        }
        //xPath check
        if (xPathElement.Displayed)
        {
            ResultMessage("X Path Element Visible", xPathElement.Displayed);
        }
        else
        {
            ResultMessage("X Path Element not visible", xPathElement.Displayed);
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
