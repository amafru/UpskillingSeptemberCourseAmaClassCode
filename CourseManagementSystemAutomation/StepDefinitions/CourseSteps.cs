using System;
using TechTalk.SpecFlow;

namespace CourseManagementSystemAutomation.StepDefinitions
{
    [Binding]
    public class CourseSteps
    {
        [When(@"a user clicks on Course link from the menu")]
        public void WhenAUserClicksOnCourseLinkFromTheMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user clicks on Create New Course link")]
        public void WhenAUserClicksOnCreateNewCourseLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user inputs (.*) to a Course Number field")]
        public void WhenAUserInputsToACourseNumberField(string courseNumber)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user fills in the Title field with (.*)")]
        public void WhenAUserFillsInTheTitleFieldWithTestAutomation(string courseName)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user fills in (.*) in credit field")]
        public void WhenAUserFillsInInCreditField(string credit)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user selects (.*) from Department drop down menu")]
        public void WhenAUserSelectsGeographyFromDepartmentDropDownMenu(string subject)
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
    }
}
