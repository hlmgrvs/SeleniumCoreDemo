using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }
        private IWebDriver Driver { get; }

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

    }
}
