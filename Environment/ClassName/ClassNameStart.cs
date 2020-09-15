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
        IWebElement cssPathElement;
        IWebElement xPathElement;
        //cssPath check
        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                ResultMessage("CSS Path Element Visible", true);
            }
        }
        catch (NoSuchElementException)
        {
            ResultMessage("CSS Path Element not visible", false);
        }
        //xPath check
        try
        {
            xPathElement = driver.FindElement(By.XPath(xPath));
            if (xPathElement.Displayed)
            {
                ResultMessage("X Path Element Visible", true);
            }
        }
        catch (NoSuchElementException)
        {
            ResultMessage("X Path Element not visible", false);
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
