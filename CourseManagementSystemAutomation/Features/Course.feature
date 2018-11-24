Feature: Course
	
Scenario Outline: Verify that a user can validate different conditions around the creation of a new Course record
Given that Course Management System is loaded
When a user clicks on Course link from the menu
And a user clicks on Create New Course link 
And a user inputs a CourseNumber to the Course Number field
And a user fills in the Title field with CourseTitle
And a user fills in the credit field with a credit value of NumberOfCredits
And a user selects a department name DepartmentId drop down menu 
And a user clicks on Create new course button
Then the expected results should be equal to ExpectedResults
Examples: 
| CourseNumber | CourseTitle    | NumberOfCredits | DepartmentId | ExpectedResults                      |
| 3            | TestAutomation | 4               | Biology      | TestAutomation                       |
|              | TestAutomation | 4               | Biology      | The Course Number field is required. |
| 3            |                | 4               | Biology      | Title is required                    |
| 3            | TestAutomation |                 |              | Number of credits is required.       |


