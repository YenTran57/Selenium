using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Class2
    {
        public IWebDriver driver = new ChromeDriver();
        public void Regiter()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login/Register");

            driver.FindElement(By.Name("Name")).SendKeys("ngo chi quoc");

            driver.FindElement(By.Name("TaxCode")).SendKeys("");

            driver.FindElement(By.Name("SDT")).SendKeys("1");

            driver.FindElement(By.Name("Diachi")).SendKeys("1");

            driver.FindElement(By.Name("Email")).SendKeys("1");

            driver.FindElement(By.Name("UserName")).SendKeys("");

            driver.FindElement(By.Name("PassWord")).SendKeys("12345");

            driver.FindElement(By.Name("Login")).Click();
        }
         public void Regiter2()
         {
            driver.Navigate().GoToUrl("https://localhost:44374/Login/Register");

            driver.FindElement(By.Name("Name")).SendKeys("aaaa");

            driver.FindElement(By.Name("TaxCode")).SendKeys("1");

            driver.FindElement(By.Name("SDT")).SendKeys("1");

            driver.FindElement(By.Name("Diachi")).SendKeys("1");

            driver.FindElement(By.Name("Email")).SendKeys("1");

            driver.FindElement(By.Name("UserName")).SendKeys("test1");

            driver.FindElement(By.Name("PassWord")).SendKeys("12345");

            driver.FindElement(By.Name("Login")).Click();

        }
        public void Regiter3()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login/Register");

            driver.FindElement(By.Name("Name")).SendKeys("ngo chi quoc");

            driver.FindElement(By.Name("TaxCode")).SendKeys("");

            driver.FindElement(By.Name("SDT")).SendKeys("1");

            driver.FindElement(By.Name("Diachi")).SendKeys("1");

            driver.FindElement(By.Name("Email")).SendKeys("1");

            driver.FindElement(By.Name("UserName")).SendKeys(" ");

            driver.FindElement(By.Name("PassWord")).SendKeys(" ");

            driver.FindElement(By.Name("Login")).Click();

        }
        public void Regiter4()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login/Register");

            driver.FindElement(By.Name("Name")).SendKeys("ngo chi quoc");

            driver.FindElement(By.Name("TaxCode")).SendKeys("");

            driver.FindElement(By.Name("SDT")).SendKeys("1");

            driver.FindElement(By.Name("Diachi")).SendKeys("1");

            driver.FindElement(By.Name("Email")).SendKeys("1");

            driver.FindElement(By.Name("UserName")).SendKeys("test2");

            driver.FindElement(By.Name("PassWord")).SendKeys("");

            driver.FindElement(By.Name("Login")).Click();

        }
        public void Regiter5()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login/Register");

            driver.FindElement(By.Name("Name")).SendKeys("");

            driver.FindElement(By.Name("TaxCode")).SendKeys("");

            driver.FindElement(By.Name("SDT")).SendKeys("");

            driver.FindElement(By.Name("Diachi")).SendKeys("");

            driver.FindElement(By.Name("Email")).SendKeys("");

            driver.FindElement(By.Name("UserName")).SendKeys("");

            driver.FindElement(By.Name("PassWord")).SendKeys("");

            driver.FindElement(By.Name("Login")).Click();
        }
    }
}
