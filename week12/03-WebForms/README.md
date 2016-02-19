# Asp.Net Web Forms Problems

## Click Counter
Create a new Asp.Net application called ClickCounter. Use the empty template with WebForms features enabled.
* Add a new web page Default.aspx and in it:
	* Add a label and a text field to prompt the user for their name
	* Add a button which on submit navigates the user to the ClickCounter.aspx page
* Add a new web page ClickCounter.aspx and in it:
	* On the top display a welcome message: Welcome, <name> (the name entered on the previous page)
	* Add a button with text "Click"
	* After each click of the button show below it a message that:
		* Shows the number of clicks the user has made
		* The total number of clicks all users running the application have made
* Deploy the application as a new web application "ClickCounter" inside IIS

## ClickCounter Revised
Add some more stuff to the above application:
* On the first page add a validation for the user name - it should not be empty
* On the second page below the button add an html table that displays the number of clicks of each user of the application
	* Use inline expression syntax to generate the html table

## Employee Editor
Create a program which lists all employees from the HackCompany database you created in week08.

List all employees from the table in a GridView.

Add a Delete button that deletes a selected employee.

Add an edit page to add new or edit an existing employee (Name/Email/BirthDate).

Use appropriate editors for each field and try to validate the input in the email field.

Showing a validation error if the field contains incorrect data.
