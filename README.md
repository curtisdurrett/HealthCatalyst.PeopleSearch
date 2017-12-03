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
  * Created with Visual Studio for Mac 2017 
  * .NET Core 2
  * SQLite Db
  * Micrsoft Entity Framework Core 2
  To start the Web API up:
   * Open the HealthCatalyst.PeopleSearch.snl with Visual Studio
   * Right click on the HealthCatalyst.Web.Api project and select 'Set As Startup Project'
   * Click the 'Run' button on the Visual Studio tool bar
   * This should open a browser window pointed to http://localhost:5000/api/values
   * If you would like to test API endpoint the follow URL should return data              http://localhost:5000/api/v1/person/searchByName/c
  
#### Web UI
  * Create with Visual Studio Code for Mac
  * Angular 4
  * Served via Node
  To start the Web UI up
     * Open a console window in the HealthCatalyst.Web.UI directory and Run: npm install
     * Once the NPM packages have been installed Run: ng serve -o, which will open a browser window pointed to                      http://localhost:4200/
 
![ScreenShot] (https://github.com/curtisdurrett/HealthCatalyst.PeopleSearch/blob/master/searchApp.png)
