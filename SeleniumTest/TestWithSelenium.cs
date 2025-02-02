using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


class Program
{
    static void Main()
    {
        // Inicializar el driver
        IWebDriver driver = new ChromeDriver();
        
        // Abrir una página
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        System.Threading.Thread.Sleep(3000);

        // Escribir Usuario
        IWebElement userField = driver.FindElement(By.Name("username"));
        userField.SendKeys("Admin");

        // Escribir Usuario
        IWebElement passwordField = driver.FindElement(By.Name("password"));
        passwordField.SendKeys("admin123");
        passwordField.Submit();

        System.Threading.Thread.Sleep(3000);

        // Seleccionar casilla Admin
        IWebElement adminButton = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a"));
        adminButton.Click();
        System.Threading.Thread.Sleep(3000);

        // Seleccionar boton add
        IWebElement addButton = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button"));
        addButton.Click();
        System.Threading.Thread.Sleep(3000);

        // Escribir usuario a crear
        IWebElement adminButtonCreator = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input"));
        adminButtonCreator.SendKeys("Josue");

        System.Threading.Thread.Sleep(3000);


        driver.Quit();
    }
}