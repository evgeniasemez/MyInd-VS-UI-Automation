using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace ConsoleApp
{
    public class SigningPage
    {
        private RemoteWebDriver driver;
        public SigningPage(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
      
        public IWebElement EmailAddress
        {
            get
            {
                return driver.FindElement(By.Id("signin_email"));
            }
        }
        public IWebElement Password
        {
            get
            {
                return driver.FindElement(By.Id("signin_password"));
            }
        }
        public IWebElement SigningButton
        {
            get
            {
                IWebElement listNav1 = driver.FindElement(By.XPath("//button[@type='submit'][text()='Sign In']"));
                return listNav1;
            }
        }
    }
}