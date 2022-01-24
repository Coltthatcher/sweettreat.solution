#### Created By _**Colton Thatcher**_

#### _SweetTreat_

## Technologies Used


* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _GIT_
* _Identity_


## Description

_Project for a bakery so admins can add different flavors to treats, using many to many relationships, the project also utilizes authentication and authorization functionality_

## Setup/Installation Requirements
* _Install .NET 5.0 [Here](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)_
* _Clone the GitHub [repository]() or download and open the Zip on your local machine._
* _inside Git or Terminal navigate to the project directory using `cd SweetTreat.Solution`._
* _Then you will want to be in the root project folder so `cd SweetTreat` in Git or Terminal._
* _Create an `appsettings.json` file in the folder listed above by typing `touch appsettings.json`._
* _Add the code listed below to your `appsettings.json` file._
* _{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}_
* _Note `[YOUR DATABASE]` and `[YOUR PASSWORD]` are the same as your personal database._
* _Open `localhost5000` in the terminal to view and use the website._

## Setting Up A Database

* Add the name of your database and password to the appsettings.json file_
* _To update the database, run the command: `dotnet ef database update`._



## Running the website

* _Go to the SweetTreat Root folder with the command `cd SweetTreat` in Git or Terminal._
* _You will need to run `dotnet restore` in the file above to add bin/obj files which are required for your program to run correctly._
* _The last step to see the website running is `dotnet run` in Git or terminal (you will still be in the root directory), you will need to follow the link provided by `localhost:5000` to see the website._
* _Once you have the website up and running, make sure to create an account with `create an account` link on the home.
* _You will be prompted to enter email and a password_
* _After that you can switch between viewing Treats and Flavors using the hyperlinks provided to use functionality on the website_




## Known Bugs

__

## Future Updates

* __

## License

_[MIT](https://opensource.org/licenses/MIT)_
Copyright (c) _2021_ _Colt Thatcher_

## Support and Contact Details
* _[colt.thatcher303@gmail.com](colt.thatcher303@gmail.com)_

