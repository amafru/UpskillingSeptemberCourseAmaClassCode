Feature: Person
#Note the dbo table for this is actually called 'People'

Scenario: API_Person_01_Verify that existing person record can be retrieved from the database
When the API service is up and running GET method with endpoint /Person
Then the status code for our GET call is equal to OK
And the response description for our GET call is equal to OK
And the records below should be retrieved
| LastName  | FirstName |
| Oladipo   | James     |
| Nolan     | Sarah     |
| Lawrence  | Amy       |
| Princeton | Jeff      |


Scenario: API_Person_02_Verify that a new Person record can be created in the database
When the API service is up and running POST a post method with endpoint /Person
Then the status code for our POST call is equal to Created
And the response description for our POST call is equal to Created


Scenario: API_Person_03_Verify that existing Person record can be modified in the database
When the API service is up and running a PUT method with endpoint /Person
Then the status code for our PUT call is equal to NoContent
#NoContent above needs to remain concatenated as is. Research why
And the response description for our PUT call is equal to No Content

Scenario: API_Person_04_Verify that existing Person record can be deleted from the database
When the API service is up and running DELETE method with endpoint /Person
Then the status code for our DELETE call is equal to OK
And the response description for our DELETE call is equal to OK
	

