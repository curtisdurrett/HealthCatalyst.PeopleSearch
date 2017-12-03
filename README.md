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
  
#### Web UI
  * Create with Visual Studio Code for Mac
  * Angular 4
  * Served via Node
  To start the Web UI up
     * Open a console window in the HealthCatalyst.Web.UI directory and Run: npm install
     * Once the NPM packages have been installed Run: ng serve -o, which will open a browser window pointed to                      http://localhost:4200/
 
