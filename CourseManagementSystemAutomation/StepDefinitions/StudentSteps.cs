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
            /*The model class is used to model data from specflow in a situation where we want to use a table
             * to specify our test data but don't want to implement a scenario outline*/
              
            var tableData = table.CreateInstance<StudentModel>(); 
            studentPage.FillInFamilyNameField(tableData.FamilyName);
            studentPage.FillInFirstNameField(tableData.FirstName);
            studentPage.FillInEnrollmentDateField(tableData.EnrollmentDate);
        }

        [When(@"a user fill-in a form for (.*), (.*), (.*) fields")]
        public void WhenAUserFill_InAFormForBrettTomFields(string familyName, string firstName, string enrollmentDate)
        {
            studentPage.FillInFamilyNameField(familyName);
            studentPage.FillInFirstNameField(firstName);
            studentPage.FillInEnrollmentDateField(enrollmentDate);
        }


        [Then(@"an expected result is equal to (.*)")]
        public void ThenAnExpectedResultIsEqualTo(string expectedResult)
        {
            string actualResult = string.Empty; //this is same as.... string = "";
            string actualResult1 = "";
            string actualResult2 = string.Empty;

            if (expectedResult.Equals("Brett"))
            {
                actualResult = studentPage.StudentRecordTable();
            }
            else if (expectedResult.Equals("Last name is required"))
            {
                actualResult = studentPage.FamilyNameErrorMsg();
            }
            else if (expectedResult.Equals("First name is required"))
            {
                //We can use var instead of string datatype when we're not sure what the data type for the variable in question is. 
                //e.g. the values might contain special xters, numbers etc (like a web link)

                actualResult = studentPage.FirstNameErrorMsg();
            }
            else if (expectedResult.Equals("Enrollment date is required"))
            {
                actualResult = studentPage.EnrollmentDateErrorMsg();
            }
            else if (expectedResult.Equals("First name is required, Enrollment date is required"))
            {
                actualResult1 = studentPage.FirstNameErrorMsg();
                actualResult2 = studentPage.EnrollmentDateErrorMsg();
                actualResult = actualResult1 + "," + actualResult2; //The comma is in here cuz our spectflow scenario Expected Result table definition contains a comma too
            }
            else if (expectedResult.Equals("Last name is required, First name is required"))
            {
                actualResult1 = studentPage.FamilyNameErrorMsg();
                actualResult2 = studentPage.FirstNameErrorMsg();
                actualResult = actualResult1 + "," + actualResult2;
            }
            else if (expectedResult.Equals("Last name is required, Enrollment date is required"))
            {
                actualResult1 = studentPage.FamilyNameErrorMsg();
                actualResult2 = studentPage.EnrollmentDateErrorMsg();
                actualResult = actualResult1 + "," + actualResult2;
            }
            Assert.IsTrue(expectedResult.Equals(actualResult), "Expected result " + " " + expectedResult + " " + "is different to the Actual Result" + actualResult);

        }

    }
}
