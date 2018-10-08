using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Remote;

namespace SeleniumAkash
{
    [TestClass]
    public class UnitTest2
    {
        static IWebDriver driveFF;
        static IWebDriver driveGC;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            ICapabilities capabilities = DesiredCapabilities.Firefox();
            string gridUrl = context.Properties["gridUrl"].ToString();
            driveFF = new RemoteWebDriver(new Uri(gridUrl), capabilities);

        }

        [TestMethod]
        public void TestFireFoxDriver()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();
            
        }


        [TestMethod]
        public void TestFireFoxDriver1()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }

        [TestMethod]
        public void TestFireFoxDriver2()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }

        [TestMethod]
        public void TestFireFoxDriver3()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }

        [TestMethod]
        public void TestFireFoxDriver4()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }

        [TestMethod]
        public void TestFireFoxDriver5()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }

        [TestMethod]
        public void TestFireFoxDriver6()
        {
            //System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(10000); driveFF.Quit();

        }


    }
}
