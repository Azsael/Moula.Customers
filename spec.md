# Moula.Customers

Please write a simple MVC type code project. The code should satisfy the following user stories:

As a user I want to add a customer.
Required fields: First name, Last name, Email
Email must be valid
Validation errors are shown
Successful saving is reported to the user
Failure to save is reported to the user
On successful save the new customer should be visible in the list

As a user I want to see the top 5 oldest customers.
The list contains the columns Full Name, Email, DOB, CustCode
The list is ordered by last name
The CustCode field is their full name with no spaces and lowercased followed by their DOB in the format “yyyyMMdd”

Notes:

You can use any technology or combination of technologies you want.
Use any data store that you want, either In-memory data that resets every run, a local file or even SQL or any Azure storage 
(bonus points for the last two although please ensure your code is easily configurable to work with a local or remote DB)
We are keen to see properly tested code with good coverage (e.g. unit testing, e2e/functional testing).
We’re interested in how you approach the organisation and layering of your code, feel free to  provide a brief description of the choices you made.
Assume that this is an enterprise level application that will be worked on by many people,  so we’re looking for extensibility, readability and clean code. 
It is important to add a few comments to describe how you thought about these details and what assumptions you made
Assume that this application will be deployed through CI to both a UAT and Live environment. Your setup should accommodate for different configurations.
Upload your code in an online public repo of your choice and provide us with a link along with instructions on how to build and run
Please don’t spend too much time on the look and feel of the UI – we’re mostly interested in discussing your approach and style of code, quality and architecture

