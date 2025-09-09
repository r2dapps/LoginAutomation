using NUnit.Framework;
using OpenQA.Selenium;

namespace LoginAutomation
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = WebDriverFactory.Create();
            _driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        }

        [Test]
        public void ValidLoginTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.Login("student", "Password123");

            // Wait briefly for page to load (basic)
            System.Threading.Thread.Sleep(1000);

            // Assertion: Check for "Log out" link or success message
            Assert.IsTrue(_driver.PageSource.Contains("Logged In Successfully") ||
                          _driver.PageSource.Contains("Log out"),
                          "Login failed or success message not found.");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
