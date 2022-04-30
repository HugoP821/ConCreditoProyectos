using Humanizer.Localisation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject1
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

            Console.WriteLine("\nTitulo Pagina Inicio:\n" + driver.Title);
            Console.WriteLine("URL Pagina Inicio:\n"+ driver.Url);
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}