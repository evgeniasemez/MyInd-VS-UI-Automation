using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeDriver driver = null;
            driver = new ChromeDriver();
            SingIn(driver);
            NavigateToResumePage(driver);
            AddWorkExperience(driver);
            SearchJobs(driver);
            driver.Close();
            driver.Dispose();
           
        }
        private static void SearchJobs(RemoteWebDriver driver)
        {
            try
            {
                string url = "https://www.indeed.com/";
                driver.Navigate().GoToUrl(url);
                IndeedHomePage indeed = new IndeedHomePage(driver);
                IWebElement searchWhat = indeed.SearchWhat;
                IWebElement searchWhere = indeed.SearchWhere;
                IWebElement findJobs = indeed.FindJobs;
                searchWhat.SendKeys("QA Engineer");
                searchWhere.Click();
                searchWhere.Clear();
                searchWhere.SendKeys("Seattle, WA");
                findJobs.Click();
            }
            catch
            {
                //ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                //Screenshot screenshot = screenshotDriver.GetScreenshot();
                //screenshot.SaveAsFile("c:/esemez/userlogin.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        private static void SingIn(RemoteWebDriver driver)
        {
            try
            {
                string url = "https://www.indeed.com/";
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                IndeedHomePage indeed = new IndeedHomePage(driver);
                // click Sign in 
                IWebElement singin = indeed.InitialNavBar.SingIn;
                singin.Click();
                SigningPage signinPage = new SigningPage(driver);
                signinPage.EmailAddress.SendKeys("");
                signinPage.Password.SendKeys("");
                signinPage.SigningButton.Click();
            }
            catch (Exception e)
            {
                string message = e.Message;
                //ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                //Screenshot screenshot = screenshotDriver.GetScreenshot();
               // screenshot.SaveAsFile("c:/junk/userlogin.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        private static void NavigateToResumePage(RemoteWebDriver driver)
        {
            try
            {
                string url = "https://my.indeed.com/resume";
                driver.Navigate().GoToUrl(url);

            }
            catch (Exception e)
            {
                string message = e.Message;
                driver.Quit();
            }
        }
        private static void AddWorkExperience(RemoteWebDriver driver)
        {
            try
            {
                ResumeEditorPage page = new ResumeEditorPage(driver);
                page.AddResumeIcon.Click();
                page.AddJobTitleField.SendKeys("QA Engineer");
                page.AddCompanyField.SendKeys("Indeed");
                page.AddWorkCityField.SendKeys("Seattle");
                page.SaveButton.Click();

                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                string message = e.Message;
                driver.Quit();
            }
        }
    }
}
