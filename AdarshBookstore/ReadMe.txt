Part 1
*************************************************************************************

2023-03-03

1510
ASP.NET  core web app with individual account authentication
- Build it
- Created the README
- Test it

******************************************************
Sorry sir that I didn't enter the timing of my work ,
because on of my classmate told me that this the default time and date sir told us to add in the readme , 
so i got confused and didn't write it.
******************************************************

 Confirmed that the application works
 Changed the content of home page
 Created the Github Repo
 Confirmed the Repo

 started again next day.  let's test it
 Added bootstrap theme from bootswatch.com
 Added the dopdown button menu
 tested the app, it's running great and the theme is awesome

march break started

 Added those css files provided in the assignment 2 folder on blackboard
 tested the application

 Added three new projects (class Library) in the application
      -AdarshBookstore.DataAccess
      -AdarshBookstore.Models
      -AdarshBookstore.Utility

 installed the Microsoft.EntityFramework Core.Relational and Core.SqlServer packages
 deleted the migration folder as told in the assignment 2 ppt
 it's time to install nuget package 
       Identity.EntityFramework Core

 Modified the namespaces in the projects that i created within the main project.
      let's build it and run it.
      the build is successful in the second time because in the first time it says that you didn't install
      one of the nuget package.

updated the github repo

Modified every project and build the solution and it's time to run it
        it's working just fine
 Updated the github repo



Part 2
Redoing from start 20-4-23 because of errors I got.
*************************************************************************************



Started the MVC application in my class

 just started doing part 2 for assignment 2 sitting at riverside , having a nice view and evening
 added the migration file in dataaccess project (old 20230420200853_AddDefaultIdentityMigration) 
                                                (new 20230421191321_AddDefaultIdentityMigration)
 updated the database and it's time to run the application 
      

 after building the project it showed this error- CS0311	The type 'SanjaysBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 'SanjaysBooks.DataAccess.Repository.UnitOfWork' to 'IUnitOfWork'.	SanjaysBookStore	C:\Users\W0770698\Source\Repos\sanjayAnand0770698\SanjaysBookStore\SanjaysBookStore\Startup.cs	39	Active
  Commented out services.AddScoped<IUnitOfWork, UnitOfWork>(); And now it works

 Started the category CRUD part
 Addded the category controller in adrea/admin/Controllers folder 
 there is some error showing even after using the "using" statement
 Error- CS0122	'IUnitOfWork' is inaccessible due to its protection level	


 Added a new index view in to the category folder  and copied the indexview.txt file content into it.
 it's time to run the application and it didn't run when i click on the category button.
 i reesolved the issue- the issue was that i created that index view file in views folder instead i had to make it in areas/admin folder
      so i tranferred the file and it is good and it's running just fine.

 Added the category button in the dropdown button

 The application is running and now i see my category button in the dropdown button.

 Made commits to the github and pushed them.

 Made some changes in index file of the category, added the font from font awesome and checked them in the browser and then deleted the code and made the
      javascript file for category and the copied the code provided by sir in the assignment 2 folder for js.

      21-04-23

      I am in my ASP Class and now starting my rest of the assignment
 Made my upsert.cshtml and add the code given in assignment 2 files.
 Now createing a partial view name _CreateAndBackToListButton.
  added the following code givenin the ppt
   update the uprset.cshtml 

   # I am having error in the category that there is no table.
     so Friend helped me and delet the current migration table and create new one .. but the error is still the same 
       (20230421191357_AddCategoryToDb , 20230421191321_AddDefaultIdentityMigration)

       I am trying so hard but its still the same.. 
       So i am submitting the file with part 2.

