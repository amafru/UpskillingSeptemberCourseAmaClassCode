Feature: Project


Scenario: API_Project_01_Verify that existing project records can be retrieved from the database
Given that Task Manamgement Systeme API service is up and running
When a user makes GET call to the resource /Projects
Then the status code for GET call is equal to OK
And the response description for GET call is equal to OK
Then the following records should be retrieved
| Name            |
| Test Automation |
| Manual Testing  |
| Unit Testing    |
| API Testing     |

Scenario: API_Project_02_Verify that a new record can be created in the database
Given that Task Manamgement Systeme API service is up and running
When a user makes POST call to the resource /Projects
Then the status code for POST call is equal to Created
And the response description for POST call is equal to Created


Scenario: API_Project_03_Verify that existing project records can be modified in the database
Given that Task Manamgement Systeme API service is up and running
When a user makes PUT call to the resource /Projects
Then the status code for PUT call is equal to No Content
And the response description for PUT call is equal to No Content

Scenario: API_Project_04_Verify that existing project records can be deleted from the database
Given that Task Manamgement Systeme API service is up and running
When a user makes DELETE call to the resource /Projects
Then the status code for DELETE call is equal to OK
And the response description for DELETE call is equal to OK
