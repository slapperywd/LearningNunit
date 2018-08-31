using System;
using NUnit.Framework;

namespace LearningNunit
{
    using LearningNunit.Assertions;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver _driver;
        [SetUp]
        public void TestInitialize()
        {
            //Console.WriteLine("Browser : " + TestContext.Parameters.Get("browser"));
            this._driver = Driver.Instance;
            this._driver.Manage().Window.Maximize();
            this._driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void TestMethod1()
        {
            Console.WriteLine(TestContext.CurrentContext.Test.Name);
            IWebElement luckButton = this._driver.FindElement(By.XPath("//input[@name='btnI']"));

            Verify.AreEqual(luckButton.Text, "blabla", true);
            luckButton.Click();

            IWebElement latestCard = this._driver.FindElement(By.CssSelector("#latest .card"));
            Verify.AreEqual(latestCard.Text, "ssss", true);
            latestCard.Click();

            Verify.AreEqual(6, 7);
           // Assert.AreEqual(6, 4);


        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(20, 20);
        }

        [TearDown]
        public void CleanUp()
        {
            this._driver.Quit();
        }
    }
}
