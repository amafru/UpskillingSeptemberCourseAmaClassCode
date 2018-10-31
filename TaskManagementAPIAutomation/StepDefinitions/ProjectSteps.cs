using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using RestSharp;

namespace TaskManagementAPIAutomation.StepDefinitions
{
    [Binding]
    class ProjectSteps
    {
        [Given(@"that Task Manamgement Systeme API service is up and running")]
        public void GivenThatTaskManamgementSystemeAPIServiceIsUpAndRunning()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user makes GET call to the resource (.*)")]
        public void WhenAUserMakesGETCallToTheResourceProjects()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the status code for GET call is equal to (.*)")]
        public void ThenTheStatusCodeForGETCallIsEqualToOK()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the response description for GET call is equal to (.*)")]
        public void ThenTheResponseDescriptionForGETCallIsEqualToOK()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the following records should be retrieved")]
        public void ThenTheFollowingRecordsShouldBeRetrieved(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user makes POST call to the resource (.*)")]
        public void WhenAUserMakesPOSTCallToTheResourceProjects()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the status code for POST call is equal to (.*)")]
        public void ThenTheStatusCodeForPOSTCallIsEqualToCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the response description for POST call is equal to (.*)")]
        public void ThenTheResponseDescriptionForGETCallIsEqualToCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user makes PUT call to the resource (.*)")]
        public void WhenAUserMakesPUTCallToTheResourceProjects()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the status code for PUT call is equal to (.*)")]
        public void ThenTheStatusCodeForPUTCallIsEqualToNoContent()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the response description for PUT call is equal to (.*)")]
        public void ThenTheResponseDescriptionForPUTCallIsEqualToNoContent()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user makes DELETE call to the resource (.*)")]
        public void WhenAUserMakesDELETECallToTheResourceProjects()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the status code for DELETE call is equal to (.*)")]
        public void ThenTheStatusCodeForDELETECallIsEqualToOK()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the response description for DELETE call is equal to (.*)")]
        public void ThenTheResponseDescriptionForDELETECallIsEqualToOK()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
