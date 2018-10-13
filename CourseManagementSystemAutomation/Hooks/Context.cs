using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;

namespace CourseManagementSystemAutomation.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        string baseURL = "http://localhost/CourseManagementSystem/enrollment";

        public void SetUp()
        {
            driver = new ChromeDriver(); //specifying Chrome as chosen driver
            driver.Navigate().GoToUrl(baseURL); //This will call the baseURL specified above on the browser
            driver.Manage().Window.Maximize(); //maximise the chrome browser window
            Thread.Sleep(2000); //Means: wait for 2 seconds before proceeding
        }

        public void ShutDown()
        {
            driver.Quit(); //This is to close the browser upon test finish. Whether result is pass or fail
            driver.Dispose(); //This clears the computer memory
        }
    }
}
