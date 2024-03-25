README
——————
Starting with creating project asp.net core web app(mvc)
————
Checking controller, models and views with homecontroller, errorviewmodel.cs
————————
Changes in startup.cs, editted lines
——————————-
Part-1 setting up the projects
Given files in assignment-2 folder doing changes in bootstrap.css and footer
Remove the navbar-light to navbar dark and remove text from all lines
Doing changes after that went to step-2
Debugging
———————————
After the checking of homecontroller.cs
Going with somechanges
———————
Moving forward with bootwatch.com
Go to this site and add a theme of my choice added a theme and replace the name of existed one and added the one which I downloaded it.
——————
Going to Views<shared
In the place of bootstrap.min.css doing changes replace that with bootstrap.css
————-
Setting up the projects and modify them adding projects from console
Give them names
OnkarBooks.DataAccess
OnkarBooks.Models
OnkarBooks.Utility
Copy the Data Folder paste to DataAccess
————————————
Install some Packages of 5.0.11
MicrosoftEntity.FrameworkRelational and CoreSqL
Delete the existed migration as we will add them later
—————————————-
Install Nuget package
Identity.EntityFramework.Core
Modify the namespace to reflect the project
Delete the default classes that already build with projects and build the project 
Make sure there is no error
—————————
Move the models folder into Onkar.Models
Delete the original one
Modify the namespaces in Views< shared<errorViewModel
And then after that replace the name of models folder with Viewmodels
README
——————
Starting with creating project asp.net core web app(mvc)
————
Checking controller, models and views with homecontroller, errorviewmodel.cs
————————
Changes in startup.cs, editted lines
——————————-
Part-1 setting up the projects
Given files in assignment-2 folder doing changes in bootstrap.css and footer
Remove the navbar-light to navbar dark and remove text from all lines
Doing changes after that went to step-2
Debugging
———————————
After the checking of homecontroller.cs
Going with somechanges
———————
Moving forward with bootwatch.com
Go to this site and add a theme of my choice added a theme and replace the name of existed one and added the one which I downloaded it.
——————
Going to Views<shared
In the place of bootstrap.min.css doing changes replace that with bootstrap.css
————-
Setting up the projects and modify them adding projects from console
Give them names
OnkarBooks.DataAccess
OnkarBooks.Models
OnkarBooks.Utility
Copy the Data Folder paste to DataAccess
————————————
Install some Packages of 5.0.11
MicrosoftEntity.FrameworkRelational and CoreSqL
Delete the existed migration as we will add them later
—————————————-
Install Nuget package
Identity.EntityFramework.Core
Modify the namespace to reflect the project
Delete the default classes that already build with projects and build the project 
Make sure there is no error
—————————
Move the models folder into Onkar.Models
Delete the original one
Modify the namespaces in Views< shared<errorViewModel
And then after that replace the name of models folder with Viewmodels

For the next part prepare the whole code.
Make sure that there is no error, every code is running without error as this is the time of adding migration to pm console.
Review the appsettings.json
Create the migration to used code-first where changes are pushed to the database and modify the database name and save that.
Adding the migration in pm console make sure, use the nuget package manage console
Mkae sure dataaccess is there not the bookstore.
Add the new migration file name entry in the README.
Review the file pf SQL.
Note the tables related to Asp.net entity.
Once the migration is complete, the database needs to be updated.
And then review the sql table.
Check for errors and run the application.
After that in part -2(repository)
Creating a class category.cs
Add a new folder Repository and IRepository.cs inside the Repository folder.
Modify it so it can be used the Category class to do all the CRUD operation.
Get the items from DB list of categories and add objects

Modify the code to create the constructors and Dependency Injection, following in the assignment-2 folder.
Create the individual repo for all the potential models.
CategoryRepository.cs 
And Interface ICategoryRepository
Build, fix any error and push commits to github.
Add a new Interface in the IRepository folder
