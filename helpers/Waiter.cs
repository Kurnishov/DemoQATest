using DemoQATest.config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQATest.helpers;

public class Waiter
{
    public static string WaitForTableRowData(string name, TimeSpan? timeout = null)
    {
        var wait = new WebDriverWait(DriverContext.Driver, timeout ?? TimeSpan.FromSeconds(10));
        return wait.Until(d =>
        {
            var row = d.FindElements(By.CssSelector(".rt-tr-group"))
                .FirstOrDefault(r => r.Text.Contains(name));
            return row?.Text;
        });
    }

    public static void WaitForTableRowDeletion(IWebDriver driver, string name, TimeSpan? timeout = null)
    {
        var wait = new WebDriverWait(driver, timeout ?? TimeSpan.FromSeconds(10));
        wait.Until(d =>
            !d.FindElements(By.CssSelector(".rt-tr-group"))
                .Any(row => row.Text.Contains(name)));
    }
}