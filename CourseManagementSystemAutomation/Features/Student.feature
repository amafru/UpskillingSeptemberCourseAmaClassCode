Feature: Student

# Given is/are pre-requisite(s)
# When is/are action(s)
# Then is/are expected result(s)


Scenario: Verify that a new student record can be created 
Given that Course Management System is loaded 
When a user clicks on Student link
And a user clicks on Create New link
And a user fill-in Family Name field with Brett
And a user fill-in First Name field with Tom
And a user fill-in Enrollment Date field with 12/10/2018
And a user clicks on Student Create Button
Then a new student record Tom should be created
	
#Better way to write a scenario with test data
Scenario: Verify that a user can create a new student record
Given that Course Management System is loaded
When a user clicks on Student link
And a user clicks on Create New link
And a user fill-in a form with the following data:
| FamilyName | FirstName | EnrollmentDate |
| Brett      | Tom       | 13/10/2018     |
And a user clicks on Student Create Button 
Then a new student record should be created

Scenario Outline: Verify that a user can validate different conditions around creation of student record
Given that Course Management System is loaded
When a user click on Student link
And a user clicks on Create New link
And a user fill-in a form for <FamilyName>, <FirstName>, <EnrollmentDate> fields
And a user clicks on Student Create Button 
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