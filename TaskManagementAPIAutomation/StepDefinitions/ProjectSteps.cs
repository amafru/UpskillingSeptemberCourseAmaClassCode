using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using RestSharp;
using TaskManagementAPIAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagementAPIAutomation.Model;
using Newtonsoft.Json;
using System.IO;

namespace TaskManagementAPIAutomation.StepDefinitions
{
    [Binding]
    class ProjectSteps
    {
        Context context;
        DatabaseHelper databaseHelper;

        public ProjectSteps(Context _context, DatabaseHelper _databasehelper)
        {
            context = _context;
            databaseHelper = _databasehelper;
        }

        [When(@"the API service is up and running with GET endpoint (.*)")]
        public void GivenThatTaskManamgementSystemeAPIServiceIsUpAndRunning(string resource)
        {
            
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateMultipleRecordsToProjectTable();
            context.GetRequest(resource);
        }
        
        [Then(@"the status code for GET call is equal to (.*)")]
        public void ThenTheStatusCodeForGETCallIsEqualToOK(string expectedResult)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedResult));
        }

        [Then(@"the response description for GET call is equal to (.*)")]
        public void ThenTheResponseDescriptionForGETCallIsEqualToOK(string expectedResult)
        {
            string actuaResponselDescription = context.actualResponseDescription;
            Assert.IsTrue(actuaResponselDescription.Equals(expectedResult));

        }

        [Then(@"the following records should be retrieved")]
        public void ThenTheFollowingRecordsShouldBeRetrieved(Table table)
        {
            var expectedData = table.CreateSet<ProjectModel>();
            string actualAPIContent = context.actualContent; //This comes back in the form of json data format and needs to be deserialised (google it!)
            var actualResult = JsonConvert.DeserializeObject<List<ProjectModel>>(actualAPIContent);
            Assert.IsTrue(CompareTwoLists(expectedData, actualResult));
        }

        public bool CompareTwoLists(object firstList, object secondList)
        {
            var objectOne = JsonConvert.SerializeObject(firstList);
            var objectTwo = JsonConvert.SerializeObject(secondList);
            return objectOne == objectTwo;
        }

        

        [Then(@"the status code for POST call is equal to (.*)")]
        public void ThenTheStatusCodeForPOSTCallIsEqualToCreated(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for POST call is equal to (.*)")]
        public void ThenTheResponseDescriptionForGETCallIsEqualToCreated(string expectedResponseDescription)
        {
            string actuaResponselDescription = context.actualResponseDescription;
            Assert.IsTrue(actuaResponselDescription.Equals(expectedResponseDescription));
        }

        [Then(@"the status code for PUT call is equal to (.*)")]
        public void ThenTheStatusCodeForPUTCallIsEqualToNoContent(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for PUT call is equal to (.*)")]
        public void ThenTheResponseDescriptionForPUTCallIsEqualToNoContent(string expectedResponseDescription)
        {
            //string actualResponseDescription = context.actualResponseDescription;
            //Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));

            Assert.IsTrue(context.actualResponseDescription.Equals(expectedResponseDescription));
        }

        [Then(@"the status code for DELETE call is equal to (.*)")]
        public void ThenTheStatusCodeForDELETECallIsEqualToOK(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for DELETE call is equal to (.*)")]
        public void ThenTheResponseDescriptionForDELETECallIsEqualToOK(string expectedResponseDescription)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));
        }

        [When(@"the API service is up and running with POST endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningWithPOSTEndpointProjects(string resource)
        {
            //databaseHelper.ClearTable("Projects");
            //context.PostRequest(resource, File.ReadAllText(@"PostToProject.json"));

            Dictionary<string, string> dataToPost = new Dictionary<string, string>();
            dataToPost.Add("Name", "Load Testing");
            databaseHelper.ClearTable("Projects");
            context.PostRequest(resource, dataToPost);
        }

        [When(@"the API service is up and running with PUT endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningWithPUTEndpointProjects(string resource)
        {
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateOneRecordProjectTable();
            int id = databaseHelper.SelectARecordFromProjectTable();
            //retrieve newly created record ID and append it to the resource
            Dictionary<string, string> dataToPut = new Dictionary<string, string>();
            dataToPut.Add("id", id.ToString());
            dataToPut.Add("Name", "Performance Testing");
            string resourceWithId = resource + "/" + id;
            context.PutRequest(resourceWithId, dataToPut);

        }

        [When(@"the API service is up and running with DELETE endpoint (.*)")]
        public void WhenTheAPIServiceIsUpAndRunningWithDELETEEndpointProjects(string resource)
        {
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateOneRecordProjectTable();
            int id = databaseHelper.SelectARecordFromProjectTable();
            //retrieve newly created record ID and append it to the resource
            string resourceWithId = resource + "/" + id;
            context.DeleteRequest(resourceWithId);
        }
    }
}
