using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreDemo
{
/*    public class Test
    {   
        //Hooks i NUnit
        [SetUp]
        public void Setup()
        {   
        }

        [Test]
        public void Test1()
        {
            // Open Browser
            IWebDriver webDriver = new ChromeDriver(@"C:\ChromeDriver");

            // Navigation to the site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            // Identify Login
            // IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            //Operation
            // lnkLogin.Click();

            //Identify the element to assert
            var txtUserName = webDriver.FindElement(By.Name("UserName"));

            //Assertion
            Assert.That(txtUserName.Displayed, Is.True);

            txtUserName.SendKeys("admin");

            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

            //var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            //Assert.That(lnkEmployeeDetails.Displayed, Is.True);

        }
    }*/
}