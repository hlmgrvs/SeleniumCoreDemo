using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Tests
{
    class LoginTest
    {
        // Browser Driver
        IWebDriver webDriver = new ChromeDriver(@"C:\ChromeDriver");

        //Hooks i NUnit
        [SetUp]
        public void Setup()
        {
            // Navigate to the site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");


            //Assertion
            Assert.That(homePage.isEmployeeDetailsExist, Is.True);
        }
        [TearDown]

        public void TearDown() => webDriver.Quit();
    }
}
