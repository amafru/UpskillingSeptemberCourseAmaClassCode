using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementSystemAutomation.Hooks;
using CourseManagementSystemAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;
using CourseManagementSystemAutomation.Model;

namespace CourseManagementSystemAutomation.StepDefinitions
{
    [Binding]
    public class CourseSteps
    {
        Context context;
        CoursePage coursePage;
        DatabaseHelper databaseHelper;

        public CourseSteps(Context _context, CoursePage _coursepage, DatabaseHelper _dbhelper)
        {
            context = _context;
            coursePage = _coursepage;
            databaseHelper = _dbhelper;
        }

        [When(@"a user clicks on Course link from the menu")]
        public void WhenAUserClicksOnCourseLinkFromTheMenu()
        {
            databaseHelper.ClearTable("Course");
            coursePage.ClickOnCourseLink();
        }
        
        [When(@"a user clicks on Create New Course link")]
        public void WhenAUserClicksOnCreateNewCourseLink()
        {
            coursePage.CreateNewCourseLink();
            
        }
        
        [When(@"a user fills in the Title field with (.*)")]
        public void WhenAUserFillsInTheTitleFieldWithTestAutomation(string courseName)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user clicks on Create new course button")]
        public void WhenAUserClicksOnCreateNewCourseButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a new course record (.*) should be created")]
        public void ThenANewCourseRecordTestAutomationShouldBeCreated(string subject)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user inputs a (.*) to the Course Number field")]
        public void WhenAUserInputsACourseNumberToTheCourseNumberField(int courseNumber)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in the credit field with a credit value of (.*)")]
        public void WhenAUserFillsInTheCreditFieldWithACreditValueOfCreditValue(int numberOfCredits)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user selects a department name (.*) drop down menu")]
        public void WhenAUserSelectsADepartmentNameDepartmentIdDropDownMenu(string departmentName)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the expected results should be equal to (.*)")]
        public void ThenTheExpectedResultsShouldBeEqualToExpectedResults(string expectedResults)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
