using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementSystemAutomation.Hooks;
using CourseManagementSystemAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseManagementSystemAutomation.StepDefinition
{
    [Binding] //SpecFlow Annotation
    class StudentSteps
    {
        Context context; //The Context class which we call here and severally below is housed within the 'Hooks' folder
        StudentPage studentPage;
        DatabaseHelper databaseHelper;

        //Use Constructor 'Dependency Injection' approach to get an instance of a class(object)
        //This is same as defining an object of a class and using it to call methods from that class. 
        //Just another way of doing it 

        public StudentSteps(Context _context, StudentPage _studentPage, DatabaseHelper _dbHelper) // This is a constructor 
        {
            context = _context;
            studentPage = _studentPage;
            databaseHelper = _dbHelper;
        }

        [BeforeScenario] //any code here would be executed before test run
        public void BeforeTestRunActivity()
        {

        }

        [AfterScenario] //any code here would be executed after test run
        public void CloseApplicationUnderTest()
        {
            context.ShutDown();
        }



        [Given(@"that Course Management System is loaded")]
        public void GivenThatCourseManagementSystemIsLoaded()
        {
            context.SetUp();
        }

        [When(@"a user clicks on Student link")]
        public void WhenAUserClicksOnStudentLink()
        {
            databaseHelper.ClearTable("Person");
            studentPage.ClickOnStudentLink();
        }

        [When(@"a user clicks on Create New link")]
        public void WhenAUserClicksOnCreateNewLink()
        {
            studentPage.ClickOnCreateNewLink();
        }

        [When(@"a user fill-in Family Name field with (.*)")]
        public void WhenAUserFill_InFamilyNameFieldWithBrett(string familyName)
        {
            studentPage.FillInFamilyNameField(familyName);
        }

        [When(@"a user fill-in First Name field with (.*)")]
        public void WhenAUserFill_InFirstNameFieldWithTom(string firstName)
        {
            studentPage.FillInFirstNameField(firstName);
        }

        [When(@"a user fill-in Enrollment Date field with (.*)")]
        public void WhenAUserFill_InEnrollmentDateFieldWith(string enrollmentDate)
        {
            studentPage.FillInEnrollmentDateField(enrollmentDate);
        }

        [When(@"a user clicks on Student Create Button")]
        public void WhenAUserClicksOnStudentCreateButton()
        {
            studentPage.ClickOnCreateStudentButton();
        }

        [Then(@"a new student record (.*) should be created")]
        public void ThenANewStudentRecordShouldBeCreated(string expectedResult)
        {
            string actualResult = studentPage.StudentRecordTable();
            Assert.IsTrue(expectedResult.Equals(actualResult), "Expected result " + " " + expectedResult + " " + "is different to the Actual Result" + actualResult); //empty ""s are simply for spacing 
        }








        [When(@"a user fill-in a form with the following data:")]
        public void WhenAUserFill_InAFormWithTheFollowingData(Table table)
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"a user click on Student link")]
        public void WhenAUserClickOnStudentLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fill-in a form for (.*), (.*), (.*) fields")]
        public void WhenAUserFill_InAFormForBrettTomFields(string familyName, string firstName, string enrollmentDate)
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
