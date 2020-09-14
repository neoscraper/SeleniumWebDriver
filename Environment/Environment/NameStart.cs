using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class NameStart
{
    static void Main()
    {
        //variables
        string url = "http://testing.todorvachev.com/selectors/name/";
        //name of name element
        string name = "myName";

        //Sets browser type
        IWebDriver driver = new ChromeDriver();
        //Navigate to URL
        driver.Navigate().GoToUrl(url);
        //Store text box on website
        IWebElement nameElement = driver.FindElement(By.Name(name));
        //Check to see if text box is visible
        if(nameElement.Displayed)
        {
            ResultMessage("Name Element Visible", nameElement.Displayed);
        }
        else
        {
            ResultMessage("Name Element not visible", nameElement.Displayed);
        }
        //Close driver
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
