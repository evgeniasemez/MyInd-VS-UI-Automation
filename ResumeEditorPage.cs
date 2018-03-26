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
    public class ResumeEditorPage
    {
        private RemoteWebDriver driver;

        public ResumeEditorPage(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement AddResumeIcon
        {
            get
            {
                IWebElement container = driver.FindElement(By.Id("container"));
                IWebElement icon = container.FindElement(By.XPath(".//img[@class='add-icon']"));
                return icon;
            }
        }
        public IWebElement AddJobTitleField
        {
            get
            {
                IWebElement container = driver.FindElement(By.Id("container"));
                IWebElement field = container.FindElement(By.XPath(".//input[@data-shield-id='job-title-field']"));
                return field;
            }
        }
        public IWebElement AddCompanyField
        {
            get
            {
                IWebElement container = driver.FindElement(By.Id("container"));
                IWebElement field = container.FindElement(By.XPath(".//input[@data-shield-id='company-field']"));
                return field;
            }
        }
        public IWebElement AddWorkCityField
        {
            get
            {
                IWebElement container = driver.FindElement(By.Id("container"));
                IWebElement field = container.FindElement(By.XPath(".//input[@data-shield-id='work-city-field']"));
                return field;
            }
        }
        public IWebElement SaveButton
        {
            get
            {
                IWebElement container = driver.FindElement(By.Id("container"));
                IWebElement field = container.FindElement(By.XPath(".//button[@class='toggleable-link-save btn']"));
                return field;
            }
        }
    }
}
