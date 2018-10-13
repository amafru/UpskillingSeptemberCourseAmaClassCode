Feature: Student

# Method 1: The baby way of writing scenarios

Scenario: Verify that a new student record can be created
Given that Course Management System is loaded
When a user clicks on Student link
And a user clicks on Create New link
And a user fills in Family Name field with Tom
And a user fills in First Name field with Brett
And a user fills in Enrollment Date field with 13/10/2018
And a user clicks on Create Button
Then a new student record should be created 

# Method 2. The better method but ...Without Scenario outline
	
Scenario: Verify that a user can create a new student record
Given that Course Management System is loaded 
When a user clicks on Student link
And a user clicks on Create New link 
And a user fills in a form with the following data
| FamilyName | FirstName | EnrollmentDate |
| Tom        | Brett     | 13/10/2018     |
And a user clicks on Create button
Then a new student record should be created 

# Method 2. The big boy method ...With Scenario outline

Scenario Outline: Verify that a user can valide different conditions around creation of student record
Given that Course Management System is loaded
When a user clicks student link
And a user creates Create New link
And a user fills in a form for <FamilyName>, <FirstName> <EnrollmentDate>, fields
And a user clicks on Create button
Then an expected result is equal to <ExpectedResults>
Examples: 
| FamilyName | FirstName | EnrollmentDate | ExpectedResult                                       |  
| Brett      | Tom       | 13/10/2018     | A new student record should be created               |
|            | Tom       | 13/10/2018     | Family Name is required                              |
| Brett      |           | 13/10/2018     | First Name is required                               |
| Brett      | Tom       |                | Enrollment date is required                          |
| Brett      |           |                | First name is required, Enrollment date is required  |
|            |           | 13/10/2018     | Family name is required, First name is required      |
|            | Tom       |                | Family name is required, Enrollment date is required |




	
