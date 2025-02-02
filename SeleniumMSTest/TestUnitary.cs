using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;


namespace SeleniumMSTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        IWebDriver driver = new FirefoxDriver();
        driver.Url = "https://www.google.com";
    }

    [TestMethod]
    public void TestMethod2()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://www.google.com";
        driver.Quit();
    }




}
