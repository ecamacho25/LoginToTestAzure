using LoginToTestAzure.Helpers;
using OpenQA.Selenium;
using Shouldly;

namespace LoginToTestAzure.PageObject
{
    public class BooksPage : Helper
    {
        private readonly IWebDriver _driver;

        public BooksPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ValidateBooksPageHasTextTitle()
        {
            var tableTitle = "All available books";
            TableTitleText.Text.ShouldBe(tableTitle);
        }

        public void ValidateTableBooksExist()
        {
            TableBooks.Displayed.ShouldBeTrue();
        }

        public IWebElement TableTitleText => _driver.FindElement(By.XPath("//h2[text()='All available books']"));

        public IWebElement TableBooks => _driver.FindElement(By.Id("listing"));

    }
}