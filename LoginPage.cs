using OpenQA.Selenium;

namespace LoginAutomation
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Username => _driver.FindElement(By.Id("username"));
        private IWebElement Password => _driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => _driver.FindElement(By.Id("submit"));

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginBtn.Click();
        }
    }
}
