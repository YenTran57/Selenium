using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Class1
    {
        public IWebDriver driver = new ChromeDriver();
        public String Login()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError ="-"+ " | " + "12345678 "+ " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text;
            return messageError;
        }
        public String Login1()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("hotrungdong912");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "hotrungdong912 " + " | " + "-" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text; 
            return messageError;
        }
        public String Login2()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "-" + " | " + "-" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text;
            return messageError;
        }
        public String Login3()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("hotrungdong912");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("1234567");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "hotrungdong912 " + " | " + "1234567" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text;
            return messageError;

        }
        public String Login4()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("hotrungdong");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("1234567");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "hotrungdong" + " | " + "1234567" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text;
            return messageError;
        }
        public String Login5()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys(" ");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys(" ");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "*" + " | " + "*" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text + "(Success)";
            return messageError;
        }
        public String Login6()
        {
            driver.Navigate().GoToUrl("https://localhost:44374/Login");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("username")).SendKeys("hotrungdong912");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();

            String messageError = "hotrungdong912 " + " | " + "12345678" + " | " + driver.FindElement(By.XPath("/html/body/div/div[1]")).Text+"(Success)";
            return messageError;
        }
    }
}
