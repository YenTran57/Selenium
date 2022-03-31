using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using ConsoleApp1;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 loginclass = new Class1();

            string fileLPath = @"D:\file1.txt";

            string[] lines = new string[7];
            lines[0] = loginclass.Login();
            Thread.Sleep(2000);
            lines[1] = loginclass.Login1();
            Thread.Sleep(2000);
            lines[2] = loginclass.Login2();
            Thread.Sleep(2000);
            lines[3] = loginclass.Login3();
            Thread.Sleep(2000);
            lines[4] = loginclass.Login4();
            Thread.Sleep(2000);
            lines[5] = loginclass.Login5();
            Thread.Sleep(2000);
            lines[6] = loginclass.Login6();

            System.IO.File.WriteAllLines(fileLPath, lines);
            Thread.Sleep(4000);

            Class2 regeter = new Class2();
            regeter.Regiter();
            Thread.Sleep(2000);
            regeter.Regiter2();
            Thread.Sleep(2000);
            regeter.Regiter3();
            Thread.Sleep(2000);
            regeter.Regiter4();
            Thread.Sleep(2000);
            regeter.Regiter5();
        }
    }
}
