using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace MyTest
{
    public class Tests
    {
        [Test]
        public void KatologaConversionButtonTest()
        {
            IWebDriver driver = new ChromeDriver("D:/programs/chromedriver.exe");
            driver.Url = "https://avidreaders.ru/";

            driver.FindElement(By.XPath("//a[text()='Жанры']")).Click();
            driver.FindElement(By.XPath("//a[text()='Астрология']")).Click();

            driver.FindElement(By.XPath("//div[@class='sort_btn btn_pic']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }


    }
}