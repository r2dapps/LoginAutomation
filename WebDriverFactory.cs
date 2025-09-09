using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginAutomation
{
    public class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--dns-prefetch-disable");

            return new ChromeDriver(options);
        }
    }
}
