using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DropDown
{
    class DropDownStart
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropDown;
        static IWebElement dropDownElement;

        //For working with check boxes on website
        static void Main(string[] args)
        {
            //variables
            string url = "https://testing.todorvachev.com/special-elements/drop-down-menu-test/";
            string elementPath = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

            driver.Navigate().GoToUrl(url);
            //Can find by name, but individual elements must be selected by CSS Path
            dropDown = driver.FindElement(By.Name("DropDownTest"));
            //Display currently shown value
            Console.WriteLine(dropDown.GetAttribute("value"));
            dropDownElement = driver.FindElement(By.CssSelector(elementPath));
            Console.WriteLine(dropDownElement.GetAttribute("value"));
            //Change drop down menu to select current element
            dropDownElement.Click();
            Console.WriteLine(dropDown.GetAttribute("value"));

            driver.Quit();
        }
    }
}
