using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementAPIAutomation.Hooks;
using TechTalk.SpecFlow;
using TaskManagementAPIAutomation.Model;
using TechTalk.SpecFlow.Assist;

namespace TaskManagementAPIAutomation.StepDefinitions
{
    [Binding]
    class PersonSteps
    {
        Context context;
        DatabaseHelper dbHelper;

        public PersonSteps(Context _context, DatabaseHelper _dbHelper)
        {
            context = _context;
            dbHelper = _dbHelper;
        }

        [When(@"the API service is up and running GET method with endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningGETMethodWithEndpointPerson(string resource)
        {
            dbHelper.ClearTable("People");
            dbHelper.PopulateMultipleRecordsToPeopleTable();
            context.GetRequest(resource);
        }

        [Then(@"the status code for our GET call is equal to (.*)")]
        public void ThenTheStatusCodeForOurGETCallIsEqualToOK(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for our GET call is equal to (.*)")]
        public void ThenTheResponseDescriptionForOurGETCallIsEqualToOK(string expectedResponseDescription)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));
        }

        [Then(@"the records below should be retrieved")]
        public void ThenTheRecordsBelowShouldBeRetrieved(Table table)
        {
            var expectedData = table.CreateSet<PersonModel>();
            string actualAPIContent = context.actualContent; //Needs to be deserialized. (See ProjectsSteps class for some more info)
            var actualResult = JsonConvert.DeserializeObject<List<PersonModel>>(actualAPIContent);
            Assert.IsTrue(CompareTwoLists(expectedData, actualResult));

        }

        public bool CompareTwoLists(object firstList, object secondList)
        {
            var objectOne = JsonConvert.SerializeObject(firstList);
            var objectTwo = JsonConvert.SerializeObject(secondList);
            return objectOne == objectTwo;
        }

        [When(@"the API service is up and running POST a post method with endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningPOSTAPostMethodWithEndpointPerson(string resource)
        {
            Dictionary<string, string> dataToPost = new Dictionary<string, string>();
            dataToPost.Add("LastName", "Adams");
            dataToPost.Add("FirstName", "Bryan");
            dbHelper.ClearTable("People");
            context.PostRequest(resource, dataToPost);

        }

        [Then(@"the status code for our POST call is equal to (.*)")]
        public void ThenTheStatusCodeForOurPOSTCallIsEqualToCreated(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode)); 
        }

        [Then(@"the response description for our POST call is equal to (.*)")]
        public void ThenTheResponseDescriptionForOurPOSTCallIsEqualToCreated(string expectedResponseDescription)
        {
            string actuaResponselDescription = context.actualResponseDescription;
            Assert.IsTrue(actuaResponselDescription.Equals(expectedResponseDescription));
        }

        [When(@"the API service is up and running a PUT method with endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningAPUTMethodWithEndpointPerson(string resource)
        {
            dbHelper.ClearTable("People");
            dbHelper.PopulateOneRecordPeopleTable();
            int id = dbHelper.SelectARecordFromTable("People");
            //retrieve newly created record ID and append it to the resource
            Dictionary<string, string> dataToPut = new Dictionary<string, string>();
            dataToPut.Add("id", id.ToString());
            dataToPut.Add("LastName", "King");
            dataToPut.Add("FirstName", "John");
            string resourceWithId = resource + "/" + id;
            context.PutRequest(resourceWithId, dataToPut);
        }

        [Then(@"the status code for our PUT call is equal to (.*)")]
        public void ThenTheStatusCodeForOurPUTCallIsEqualToNoContent(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for our PUT call is equal to (.*)")]
        public void ThenTheResponseDescriptionForOurPUTCallIsEqualToNoContent(string expectedResponseDescription)
        {
            Assert.IsTrue(context.actualResponseDescription.Equals(expectedResponseDescription));
        }

        [When(@"the API service is up and running DELETE method with endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningDELETEMethodWithEndpointPerson(string resource)
        {
            dbHelper.ClearTable("People");
            dbHelper.PopulateOneRecordPeopleTable();
            int id = dbHelper.SelectARecordFromTable("People");
            //retrieve newly created record ID and append it to the resource
            string resourceWithId = resource + "/" + id;
            context.DeleteRequest(resourceWithId);
        }

        [Then(@"the status code for our DELETE call is equal to (.*)")]
        public void ThenTheStatusCodeForOurDELETECallIsEqualToOK(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for our DELETE call is equal to (.*)")]
        public void ThenTheResponseDescriptionForOurDELETECallIsEqualToOK(string expectedResponseDescription)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));
        }

    }
}
