namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;

    //Runs test scenarios with an invalid password
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            //Creates driver that will be interacted with
            Actions.InitializeDriver();
            //Goes to login page
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [Test]
        public void LessThan5Chars()
        {
            //Puts in information
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, 
                Config.Credentials.Invalid.Password.FourCharacters);
            Thread.Sleep(1000);

            //Switches to alert in order to see result
            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            //Checks result
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            //Closes alert
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }
        
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}