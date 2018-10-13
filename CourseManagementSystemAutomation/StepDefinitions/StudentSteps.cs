using CourseManagementSystemAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace CourseManagementSystemAutomation.StepDefinitions
{
    [Binding] //specflow annotation (labelling)
    class StudentSteps
    {

        Context context; 

        public StudentSteps(Context _context) //This is a constructor
        {
            context = _context;
        }


        [Given(@"that Course Management System is loaded")]
        public void GivenThatCourseManagementSystemIsLoaded()
        {
            context.SetUp();
        }

        [AfterScenario] //any code here would be executed after test run
        public void CloseApplicationUnderTest()
        {
            context.ShutDown();
        }

        [When(@"a user clicks on Student link")]
        public void WhenAUserClicksOnStudentLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user clicks on Create New link")]
        public void WhenAUserClicksOnCreateNewLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in Family Name field with (.*)")]
        public void WhenAUserFillsInFamilyNameFieldWithTom(string familyName)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in First Name field with (.*)")]
        public void WhenAUserFillsInFirstNameFieldWithBrett(string firstName)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in Enrollment Date field with (.*)")]
        public void WhenAUserFillsInEnrollmentDateFieldWith(string enrollmentDate)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user clicks on Create Button")]
        public void WhenAUserClicksOnCreateButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a new student record should be created")]
        public void ThenANewStudentRecordShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in a form with the following data")]
        public void WhenAUserFillsInAFormWithTheFollowingData(Table table)
        {
            ScenarioContext.Current.Pending();
        }

       

        [When(@"a user clicks student link")]
        public void WhenAUserClicksStudentLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user creates Create New link")]
        public void WhenAUserCreatesCreateNewLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills in a form for (.*), (.*), (.*)")]
        public void WhenAUserFillsInAFormForBrettTomFields(string familyName, string firstName, string enrollmentDate)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"an expected result is equal to (.*)")]
        public void ThenAnExpectedResultIsEqualTo(string expectedResult)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
