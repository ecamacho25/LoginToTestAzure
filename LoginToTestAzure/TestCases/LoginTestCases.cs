using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using LoginToTestAzure.PageObject;


namespace LoginToTestAzure.TestCases
{
    [TestFixture]
    public class LoginTestCases
    {

        private readonly IWebDriver _driver;

        private readonly LoginPage _loginPage;

        private readonly BooksPage _booksPage;

        public LoginTestCases()
        {

            _driver = new ChromeDriver();

            _loginPage = new LoginPage(_driver);

            _booksPage = new BooksPage(_driver);
        }

        [SetUp]
        public void OneTimeSetUp()
        {
            _loginPage.OpenHomePage();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LoginSuccessfullyInSahiTestPage()
        {
            _loginPage.InputUsername("test");
            _loginPage.InputPassword("secret");
            _loginPage.ClickLoginButton();
            _booksPage.ValidateBooksPageHasTextTitle();
        }

        //This test case must failed
        [Test]
        public void LoginFailed()
        {
            _loginPage.InputUsername("test");
            _loginPage.InputPassword("secret");
            _booksPage.ValidateBooksPageHasTextTitle();

        }



    }
}