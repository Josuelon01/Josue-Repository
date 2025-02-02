using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using static System.Net.WebRequestMethods;
using static OpenQA.Selenium.BiDi.Modules.Session.ProxyConfiguration;

namespace pruebas_unitarias_con_csharp
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Close();

        }
        [TestMethod]
        public void TestMethod2()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            IWebElement searchButton = driver.FindElement(By.Name("q"));
            searchButton.SendKeys("Selenium C#");
            searchButton.Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Close();

        }

        [TestMethod]
        public void TestMethod3()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            IWebElement usernameField = driver.FindElement(By.Id("user-name"));
            usernameField.SendKeys("standard_user");
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("secret_sauce");
            passwordField.Submit();
            IWebElement actual = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/span"));
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(actual.Text.Contains("Products"));
            driver.Close();

        }

        [TestMethod]
        public void TestMethod4()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://news.ycombinator.com/";
            string actual = driver.Title;
            IWebElement firstLink = driver.FindElement(By.XPath("/html/body/center/table/tbody/tr[3]/td/table/tbody/tr[1]/td[3]/span/a"));
            firstLink.Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreNotEqual(actual, driver.Title);
            driver.Close();

        }

        [TestMethod]
        public void TestMethod5()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoblaze.com/index.html";
            System.Threading.Thread.Sleep(3000);
            IWebElement firstProduct = driver.FindElement(By.PartialLinkText("Samsung galaxy s6"));
            firstProduct.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement addButton = driver.FindElement(By.PartialLinkText("Add to cart"));
            addButton.Click();
            driver.Navigate().Refresh(); //Sale una ventana emergente y no se como solucionarlo.
            System.Threading.Thread.Sleep(3000);
            IWebElement cartButton = driver.FindElement(By.XPath("/html/body/nav/div/div/ul/li[4]/a"));
            cartButton.Click();
            System.Threading.Thread.Sleep(6000);
            bool productName = driver.PageSource.Contains("Samsung galaxy s6");
            Assert.IsTrue(productName, "No Found");
            driver.Close();

        }
        

    }

}