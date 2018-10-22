using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementSystemAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;

namespace CourseManagementSystemAutomation.Pages
{
    public class StudentPage
    {
        //Reference Context class so as to make Selenium WebDriver available in it 
        Context context;

        public StudentPage(Context _context)
        {
            context = _context;
        }

        //Define all locators to use later in methods
        By studentLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[1]/a");
        By createNewLink = By.XPath("/html/body/div[2]/p/a");
        By familyName = By.Id("LastName");
        By firstName = By.Id("FirstName");
        By enrollmentDate = By.Id("EnrollmentDate");
        By createStudentBtn = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");
        By studentRecordTable = By.XPath("/html/body/div[2]/table");
        By studentTableRow = By.TagName("tr");
        By studentTableData = By.TagName("td");

        public void ClickOnStudentLink()
        {
            //Please Note "Thread.Sleep" has been added as a novelty to make the tests run slower so we can see what's happening
            //This will increase the overall run time of the tests
            //And in the course of running multiple tests can be come very resource heavy
            //So please delete and comment out from a live framework at work as necessary. 

            Thread.Sleep(2000);
            context.driver.FindElement(studentLink).Click();
        }

        public void ClickOnCreateNewLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(createNewLink).Click();
        }

        public void FillInFamilyNameField(string familyNameData)
        {
            //You'll need 2 actions for every sendKeys activity. Clear the field then write the value to the field.

            //context.driver.FindElement(familyNameField).Clear();
            //context.driver.FindElement(familyNameField).SendKeys(familyName);

            //Better way to write the above code below.... 

            Thread.Sleep(2000);
            IWebElement familyNameField = context.driver.FindElement(familyName);
            familyNameField.Clear();
            familyNameField.SendKeys(familyNameData);
        }

        public void FillInFirstNameField(string firstNameData)
        {
            Thread.Sleep(2000);
            IWebElement firstNameField = context.driver.FindElement(firstName);
            firstNameField.Clear();
            firstNameField.SendKeys(firstNameData);

        }

        public void FillInEnrollmentDateField(string enrollmentDateData)
        {
            Thread.Sleep(2000);
            IWebElement enrollmentDateField = context.driver.FindElement(enrollmentDate);
            enrollmentDateField.Clear();
            enrollmentDateField.SendKeys(enrollmentDateData);
        }

        public void ClickOnCreateStudentButton()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(createStudentBtn).Click();
            Thread.Sleep(2000);
        }

        public string StudentRecordTable()
        {
            //you can use the whole table(by locator), table row (using tagname(tr-tablerow)), table data(using tagname(td-tabledata))

            IWebElement tableElement = context.driver.FindElement(studentRecordTable); //This is to find the whole table using it's XPath
            var row = tableElement.FindElements(studentTableRow).Skip(1);
            string actualData = "";

            foreach (IWebElement studentRow in row)
            {
                var rowData = studentRow.FindElements(studentTableData);

                foreach (var data in rowData)
                {
                    actualData = data.Text;
                    break;
                }
                break;
            }
            return actualData;
        }


    }
}
