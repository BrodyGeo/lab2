January 28th, 2019

Lab 2 - ASP.NET MVC Fundamentals

This lab is to check your ability to successfully create a new mvc web application and use some basic MVC Concepts  To complete the lab:

- Create a new solution called Lab2. Do NOT include any Authentication or Unit Testing but check off Create New Git Repository / Add to Source Control
- On the site template, change both the page title and the main application link in the navbar to say "COMP2084 - Lab 2"
- Also on the template, include your full name and student number in the footer
- Add a new controller called CategoriesController
- Create view the Categories/Index that shows this list of categories:
	- Food
	- Tech
	- Sports
- Each category links to /categories/details and passes the category name as a link parameter.
- In your controller, add a method called Details that accepts 1 string parameter.  This method sends back a string to the view using the ViewBag that says "You selected category: [paramater-value-here]"
- Create the Categories/Details view that uses the ViewBag to display the message set in the controller Details method
- Create a comp2084-lab2 repository, include the template .gitignore (marks deducted for failing to do this), and push your code to GitHub
- Submit a link to your comp2084-lab2 repository on Blackboard. 

Brody Aldersley 200387040