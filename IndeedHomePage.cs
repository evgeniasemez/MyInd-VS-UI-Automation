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
    public class IndeedHomePage
    {
        private RemoteWebDriver driver;
        public IndeedHomePage(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        public NavBar NavBar
        {
            get
            {
                return new NavBar(driver);
            }
        }
        public InitialNavBar InitialNavBar
        {
            get
            {
                return new InitialNavBar(driver);
            }
        }
        public IWebElement SearchWhat
        {
            get
            {
                return driver.FindElement(By.Id("text-input-what"));
            }
        }
        public IWebElement SearchWhere
        {
            get
            {
                return driver.FindElement(By.Id("text-input-where"));
            }
        }
        public IWebElement FindJobs
        {
            get
            {
                IWebElement whatWhere = driver.FindElement(By.Id("whatWhere"));
                return whatWhere.FindElement(By.XPath(".//button[@class='icl-WhatWhere-button']"));
            }
        }
    }
    public class NavBar
    {
        private RemoteWebDriver driver;
        public NavBar(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        private IReadOnlyCollection<IWebElement> NavElements
        {
            get
            {
                IWebElement navTopDiv = driver.FindElement(By.Id("p_nav"));
                IReadOnlyCollection<IWebElement> listNav = navTopDiv.FindElements(By.XPath(".//span[@class='navBi']"));
                return listNav;
            }
        }
        public IWebElement FindJobs
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(0);
            }
        }
        public IWebElement CompanyReviews
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(1);
            }
        }
        public IWebElement FindSalaries
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(2);
            }
        }
        public IWebElement FindResumes
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(3);
            }
        }
        public IWebElement EmployersPostJob
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(4);
            }
        }
        public IWebElement UploadYourResume
        {
            get
            {
                IWebElement navTopDiv = driver.FindElement(By.Id("navpromo"));
                IWebElement listNav = navTopDiv.FindElement(By.XPath(".//a"));
                return listNav;
            }
        }
        public IWebElement SingIn
        {
            get
            {
                IWebElement signin = driver.FindElement(By.Id("userOptionsLabel"));
               
                return signin;
            }
        }
    }
    public class InitialNavBar
    {
        private RemoteWebDriver driver;
        public InitialNavBar(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        private IReadOnlyCollection<IWebElement> NavElements
        {
            get
            {
                IWebElement navTopDiv = driver.FindElement(By.Id("p_nav"));
                IReadOnlyCollection<IWebElement> listNav = navTopDiv.FindElements(By.XPath(".//span[@class='navBi']"));
                return listNav;
            }
        }
        public IWebElement FindJobs
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(0);
            }
        }
        public IWebElement CompanyReviews
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(1);
            }
        }
        public IWebElement FindSalaries
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(2);
            }
        }
        public IWebElement FindResumes
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(3);
            }
        }
        public IWebElement EmployersPostJob
        {
            get
            {
                IReadOnlyCollection<IWebElement> navElements = NavElements;
                return navElements.ElementAt(4);
            }
        }
        public IWebElement UploadYourResume
        {
            get
            {
                IWebElement navTopDiv = driver.FindElement(By.Id("navpromo"));
                IWebElement listNav = navTopDiv.FindElement(By.XPath(".//a"));
                return listNav;
            }
        }
        public IWebElement SingIn
        {
            get
            {
                IWebElement listNav = driver.FindElement(By.XPath(".//a[@class='icl-DesktopGlobalHeader-link' and @href = 'http://www.indeed.com/m/account/login?dest=%2F']"));
                return listNav;
            }
        }
    }
}
