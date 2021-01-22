using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/special-elements/radio-button-test/";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)"));
        if(element.GetAttribute("checked")=="true")
        {
            System.Console.WriteLine("Check-Box is checked ");
        }
        else
        {
            System.Console.WriteLine("Check-Box is not checked");
        }
        Thread.Sleep(3000);
        driver.Quit();

    }
}

