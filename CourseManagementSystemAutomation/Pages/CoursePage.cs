using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementSystemAutomation.Hooks;

namespace CourseManagementSystemAutomation.Pages
{
    public class CoursePage
    {
        Context context;

        public CoursePage(Context _context)
        {
            context = _context;
        }


        By CourseLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[2]/a");
        By CourseCreateNewLink = By.XPath("//a[contains(.,'Create New')]");
        By CourseNumberDropdownArrows = By.XPath("//input[contains(@data-val-number,'The field Course Number must be a number.')]");
        By CourseTitleField = By.XPath("//input[contains(@data-val-maxlength-max,'50')]");
        By CourseCreditsField = By.XPath("//input[contains(@data-val-maxlength-max,'50')]");
        By DepartmentIdDropdownArrow = By.XPath("//select[contains(@class,'form-control')]");
        By CourseCreateBtn = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");
        By CourseNumberErrorMsg = By.XPath("//span[@class='field-validation-error text-danger'][contains(.,'The Course Number field is required.')]");
        By TitleFieldErrorMsg = By.XPath("//span[@class='field-validation-error text-danger'][contains(.,'The Course Number field is required.')]");
        By CreditsFieldErrorMsg = By.XPath("//span[@class='field-validation-error text-danger'][contains(.,'Title is required')]");

        public void ClickOnCourseLink()
        {
            context.driver.FindElement(CourseLink).Click();
        }

        public void CreateNewCourseLink()
        {
            context.driver.FindElement(CourseCreateNewLink).Click();
        }

        public void FillInCourseDetails()
        {
            //IWebElement 
        }

    }
}
