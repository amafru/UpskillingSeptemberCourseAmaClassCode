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
        string baseURL = "http://localhost/CourseManagementSystem/";

        public void SetUp()
        {
            driver = new ChromeDriver(); //call a Chrome Browser
            driver.Navigate().GoToUrl(baseURL); //Go to url specified above ^^ (baseURL)
            driver.Manage().Window.Maximize(); //Maximise the Chrome browser Window
            Thread.Sleep(2000); //Wait for 2 seconds 
        }

        public void ShutDown() //This is to close the browser 
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
