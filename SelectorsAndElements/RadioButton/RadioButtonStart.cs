using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace RadioButton
{
    class RadioButtonStart
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement currentButton;

        //For working with check boxes on website
        static void Main(string[] args)
        {
            //variables
            string url = "https://testing.todorvachev.com/special-elements/radio-button-test/";
            //Value for radio button options
            string[] button = { "1", "3", "5" };

            driver.Navigate().GoToUrl(url);
            //Find the selected radio button
            for (int i = 0; i < button.Length; i++)
            {
                //Must find radio button by css selector, name will get entire group of check boxes
                currentButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + button[i] + ")"));
                //Check if button is selected
                if (currentButton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("The "+ currentButton.GetAttribute("value") +" radio button is selected");
                }
                else
                {
                    Console.WriteLine("This radio button is not selected");
                } 
            }
            driver.Quit();
        }
    }
}
