using DemoQATest.config;
using OpenQA.Selenium;

namespace DemoQATest.helpers;

public class Screenshoter
{
    public static void TakeScreenshot()
    {
        var screenshot = ((ITakesScreenshot)DriverContext.Driver).GetScreenshot();
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        var fileName = $"Screenshot_{timestamp}.png";

        var screenshotsDir = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
        Directory.CreateDirectory(screenshotsDir);

        screenshot.SaveAsFile(Path.Combine(screenshotsDir, fileName));
    }
}