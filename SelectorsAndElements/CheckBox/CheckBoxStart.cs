using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CheckBox
{
    class CheckBoxStart
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement currentCheckBox;

        //For working with check boxes on website
        static void Main(string[] args)
        {
            //variables
            string url = "https://testing.todorvachev.com/special-elements/check-button-test-3/";
            //Value for both check boxes
            string checkBox1 = "1";
            string checkBox2 = "3";

            driver.Navigate().GoToUrl(url);
            //Must find check box by css selector, name will get entire group of check boxes
            currentCheckBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + checkBox1 + ")"));
            //Check if box is checked.
            if(currentCheckBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("This checkbox is checked");
            }
            else
            {
                Console.WriteLine("This checkbox is not checked");
            }
            //Checks or unchecks the check box based on current value
            currentCheckBox.Click();
            //Check if box is checked.
            if (currentCheckBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("This checkbox is checked");
            }
            else
            {
                Console.WriteLine("This checkbox is not checked");
            }
            driver.Quit();
        }
    }
}
