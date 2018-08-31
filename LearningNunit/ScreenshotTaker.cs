using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNunit
{
    using NUnit.Framework;

    using OpenQA.Selenium;

    public class ScreenshotTaker
    {
        public static void TakeScreenshot()
        {
            var screenshot = ((ITakesScreenshot)Driver.Instance).GetScreenshot();
            string filePath = $@"D:\NunitScreenshots\{TestContext.CurrentContext.Test.Name}{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.jpg";
            screenshot.SaveAsFile(filePath);
            TestContext.AddTestAttachment(filePath);
        }
    }
}
