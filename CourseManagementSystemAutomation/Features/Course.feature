Feature: Course
	
Scenario: Verify that a user can create a new Course record
Given that Course Management System is loaded
When a user clicks on Course link from the menu
And a user clicks on Create New Course link 
And a user inputs 3 to a Course Number field
And a user fills in the Title field with Test Automation
And a user fills in 4 in credit field
And a user selects Geography from Department drop down menu 
And a user clicks on Create new course button
Then a new course record Test Automation should be created

