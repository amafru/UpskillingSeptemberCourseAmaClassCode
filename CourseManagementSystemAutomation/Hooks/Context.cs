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
using System.Configuration;
using System.Diagnostics;

namespace CourseManagementSystemAutomation.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        //string baseURL = "http://localhost/CourseManagementSystem/";

        //Here's a better way to add the base url in a framework
        //We use the AppConfig file in Solution explorer

        string baseURL = ConfigurationManager.AppSettings["URL"];
        string browser = ConfigurationManager.AppSettings["browser"];

        //public void SetUp()
        //{
        //    driver = new ChromeDriver(); //call a Chrome Browser
        //    driver.Navigate().GoToUrl(baseURL); //Go to url specified above ^^ (baseURL)
        //    driver.Manage().Window.Maximize(); //Maximise the Chrome browser Window
        //    Thread.Sleep(2000); //Wait for 2 seconds 
        //}

            //ANOTHER WAY TO IMPLEMENT THE SETUP METHOD ABOVE
            //Implementing AppConfig to nominate our baseURL and browsers
            //Then calling them using a switch case statement

        public void SetUp()
        {
            ////code to clear all the unkilled browser's driver
            ////NOT ESSENTIAL BUT CAN BE HANDY
            //var ChromeDriverProcesses = Process.GetProcessesByName("Chrome");
            //foreach (var ChromeDriverProcess in ChromeDriverProcesses)
            //{
            //    try
            //    {
            //        ChromeDriverProcess.Kill();
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e.Message);
            //    }
            //}

            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver();
                    break;
            }
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }


        public void ShutDown() //This is to close the browser 
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
