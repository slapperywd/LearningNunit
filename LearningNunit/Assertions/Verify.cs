namespace LearningNunit.Assertions
{
    using System;

    using NUnit.Framework;
    using NUnit.Framework.Internal;

    public static class Verify
    {
        public static bool AreEqual(object expected, object actual, bool screenshotOnFail = false)
        {
            try
            {
                Assert.AreEqual(expected, actual);
                return true;
            }
            catch (AssertionException ex)
            {
                Console.WriteLine(ex);
                if (screenshotOnFail) ScreenshotTaker.TakeScreenshot();
                return false;
            }
        }

        public static bool AreEqual(double expected, double actual, double delta, bool screenshotOnFail = false)
        {
            try
            {
                Assert.AreEqual(expected, actual, delta);
                return true;
            }
            catch (AssertionException ex)
            {
                Console.WriteLine(ex.Message);
                if (screenshotOnFail) ScreenshotTaker.TakeScreenshot();
                return false;
            }
        }
    }
}
