using DemoQATest.config;
using OpenQA.Selenium;

namespace DemoQATest.helpers;

public class Clicker
{
    // Click using JavaScript to avoid overlay issues
    public static void JsClick(IWebElement button) =>
    ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript("arguments[0].click();", button);
}