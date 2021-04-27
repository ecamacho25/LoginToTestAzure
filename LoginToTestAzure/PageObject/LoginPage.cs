using LoginToTestAzure.Helpers;
using OpenQA.Selenium;

namespace LoginToTestAzure.PageObject
{
    public class LoginPage : Helper
    {
        private readonly IWebDriver _driver;

        private readonly string urlHomePage = "http://sahitest.com/demo/training/login.htm";

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        //comment
        public void InputUsername(string username)
        {
            UsernameTextBox.Clear();
            UsernameTextBox.SendKeys(username);
        }

        public void InputPassword(string username)
        {
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys(username);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void OpenHomePage()
        {
            OpenPage(urlHomePage);

        }

      
        public IWebElement UsernameTextBox => _driver.FindElement(By.Name($"user"));

        public IWebElement PasswordTextBox => _driver.FindElement(By.Name($"password"));

        public IWebElement LoginButton => _driver.FindElement(By.CssSelector($"[value|=Login]"));

    }
}