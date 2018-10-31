using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementAPIAutomation.Hooks
{
    public class Context
    {
        string baseURL = "http://localhost/TaskManagementAPI/api";
        public string actualContent;
        public string actualStatusCode;
        public string actualResponseDescription;

        public void GetCall(string resource)
        {
            var client = new RestClient(baseURL);
            var request = new RestRequest(resource, Method.GET);
            var queryResult = client.Execute(request);

            actualContent = queryResult.Content;
            actualStatusCode = queryResult.StatusCode.ToString();
            actualResponseDescription = queryResult.StatusDescription;

        }

        public void PostCall(string resource, string dataBody)
        {
            var client = new RestClient(baseURL);
            var request = new RestRequest(resource, Method.POST);
            request.AddBody(dataBody);
            request.AddHeader("Content Type", "application/json");
            var queryResult = client.Execute(request);
            actualStatusCode = queryResult.StatusCode.ToString();
            actualResponseDescription = queryResult.StatusDescription;

        }

        public void PutCall(string resource, string dataBody)
        {
            var client = new RestClient(baseURL);
            var request = new RestRequest(resource, Method.PUT);
            request.AddBody(dataBody);
            request.AddHeader("Content Type", "application/json");
            var queryResult = client.Execute(request);
            actualStatusCode = queryResult.StatusCode.ToString();
            actualResponseDescription = queryResult.StatusDescription;
        }

        public void DeleteCall(string resource)
        {
            var client = new RestClient(baseURL);
            var request = new RestRequest(resource, Method.DELETE);
            var queryResult = client.Execute(request);
            actualStatusCode = queryResult.StatusCode.ToString();
            actualResponseDescription = queryResult.StatusDescription;
        }
    }
}
