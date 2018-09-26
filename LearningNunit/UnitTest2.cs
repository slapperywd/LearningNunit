using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNunit
{
    using System.Threading;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTest2
    {
        /// <summary>
        /// Driver is annotated with [ThreadStatic] attribute 
        /// in order to close all instances properly while parallel test execution
        /// </summary>
        [ThreadStatic]
        private static IWebDriver Driver;



        [SetUp]
        public void TestInitialize()
        {
            //Console.WriteLine("Browser : " + TestContext.Parameters.Get("browser"));
            Driver = new ChromeDriver();//Driver.Instance;
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void TestMethodToParallize1()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToParallize2()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToParallize3()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToParallize4()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToParallize5()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToParallize6()
        {
            Assert.AreEqual(20, 20);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
