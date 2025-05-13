using DemoQATest.config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQATest.Tests
{
    public abstract class BaseTest : IDisposable
    {
        protected IWebDriver Driver { get; private set; }

        protected BaseTest()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            // options.AddArgument("--headless");

            Driver = new ChromeDriver(options);
            DriverContext.Driver = Driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}