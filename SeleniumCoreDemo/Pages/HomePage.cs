using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    public class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }
        
        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();

        public bool isEmployeeDetailsExist => lnkEmployeeDetails.Displayed;
    }
}
