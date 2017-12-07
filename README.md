![ScreenShot](https://github.com/curtisdurrett/HealthCatalyst.PeopleSearch/blob/master/HealthCatalyst.Web.UI/src/assets/images/healthcatlyst.svg)

## The People Search Application

### Business Requirements

 * The application accepts search input in a text box and then displays in a pleasing style a list of people where any part of their first or last name matches what was typed in the search box (displaying at least name, address, age, interests, and a picture). 
 * Solution should either seed data or provide a way to enter new users or both
 * Simulate search being slow and have the UI gracefully handle the delay

### Technical Requirements

 * A Web Application using WebAPI and a front-end JavaScript framework (e.g., Angular, AngularJS, React, Aurelia, etc.) 
 * Use an ORM framework to talk to the database
 * Unit Tests for appropriate parts of the application
 
### Application Tooling
 
#### API / Service / Data Access
  * Created with Visual Studio Community for Mac (I tested on a Windows 10 machine using Visual Studio 2017 build 15.5.0) 
  * .NET Core 2
  * SQLite Db
  * Micrsoft Entity Framework Core 2
   * To start the Web API up:
   * Install Visual Studio 2017 if you havn't already
   * Open the HealthCatalyst.PeopleSearch.snl with Visual Studio
   * Right click on the HealthCatalyst.Web.Api project and select 'Set As Startup Project'
   * Click the 'Run' button on the Visual Studio tool bar
   * This should open a browser window pointed to http://localhost:5000/api/values
   * If you would like to test API endpoint the follow URL should return data              http://localhost:5000/api/v1/person/searchByName/c
  
#### Web UI
  * Created with Visual Studio Code for Mac
  * Angular 4
  * Served via Node
     * To start the Web UI up
     * Install NPM if you havn't already (Download node at https://nodejs.org/en/download/)
     * Open a console window in the HealthCatalyst.Web.UI directory and Run: npm install
     * In the same console windows Run: npm install -g @angular/cli
     * Once the NPM packages have been installed Run: ng serve -o   (will open a browser window pointed to                      http://localhost:4200/)
     
   Note: I did my best to make sure the repository / solution would load, build and run without problems.  I starting building the solution in Visual Studio for Mac but I did test opening, building and running it in Visual Studio Community 2017 15.5 on a Windows 10 VM.  If you run into an issue loading, building or running please ping me at curtis.durrett@gmail.com and I'd be happy to correct the issue.      
     
 #### Things About the App
     * The App already has data loaded into the SQLite DB however if you would like to re-seed the data you can use the http://localhost:5000/api/v1/person/seedData endpoint.  I was going to add a button in the UI to call it but it just didn't seem right so I didn't.  
     * To simulate slow searchesI included a 1 second delay in the UI after it returns from the http call.  The delay can be changed by changing the value of _millisecondToDelay in search.service.ts file.  
 
 #### Sample Screen Shot:
![ScreenShot](https://github.com/curtisdurrett/HealthCatalyst.PeopleSearch/blob/master/searchApp.png)

#### Things I wanted to do but ran out of time...
  To Do:

  UI.
  1. Setup config swapping of search service / test search service
  2. Add unit test for search service
  3. Bootstrap responsive design, mobile tags
  4. Load image from image byte array returned from api service
  5. Add paging support
  6. Create a logging service and log, log, log
  7. Generally improve the look

  Service
  1. Define the data types in EF
  2. Build integration test

  Web.Api
  1. Add Swagger
  2. Move configuration settings to appsettings.json 
  3. Add log4net and log, log, log
  4. Handle special chars in search
  5. Build intergration test 

  Repository
  1. Check to make sure you can pull the solution down and easy run it
  2. Figure out a better way to launch seed data process
  3. Store image DB
  4. Move DB connection string to appsetting.json 
