# :deciduous_tree: Parks Lookup

#### C# Building an API Independent Project, 3 April 2020
 
#### By **_Jieun Kang_**
---

## Description
An API that allows users to GET, POST, PUT and DELETE for state and national parks of the United States. 

---

## Specifications : 
You can test the API directly using an applicaion such as `Postman`. All endpoints use host `localhost:5000`
#### PARKS
|| Spec  | API Endpoint  |
|-| :---------------- | :----- | 
|1| User can READ all parks api call | `GET` /api/parks |
|2| User can READ a certain park | `GET` /api/parks/{id} |
|2| User can SEARCH parks by park name and/or state codes | `GET` /api/parks?parkname=yellowstone |
|3| User can CREATE a new park | `POST` /api/parks |
|4| User can UPDATE a existing park information | `PUT` /api/parks/{id} |
|5| User can DELETE a certain park | `DELETE` /api/parks/{id} |
|6| User can READ a random park | `GET` /api/parks/random |
|7| User need Token to send HTTP POST, PUT and DELETE request | 

#### USERS : Token-Basked Authentication and Authorization (JWT)
|| Spec  | API Endpoint  |
|-| :---------------- | :----- | 
|1| Public route that accepts HTTP POST requests containing the username and password in the body. If the username and password are correct then a JWT authentication token and the user detials are returned. | `POST` /api/users/authenticate |
|2| Secure route that accepts HTTP GET requests and returns a list of all the users in the application if the HTTP Authorization header contains a valid JWT token. If there is no auth token or the token is invalid then a 401 Unauthorized response is returned. | `GET`/ api/users |
|3| Secure route restricted to authenticated users in any role, it accepts HTTP GET requests and returns the user record for the specified "id" parameter if authorization is successful. <br> "Admin" users can access all user records, while other roles(e.g."User") can only access their own user record. | `GET` /api/users/{id} |
|4| Public route that accepts HTTP POST requests to create user account | `POST` /api/users/register |
|5| Secure route that accepts HTTP PUT requests to update user information. "Admin" users can access all users records, while other roles(e.g."User") can only access their own user record. | `PUT` /api/users/{id} |
|6| Secure route that accepts HTTP DELETE requests to delete user account. "Admin" users can access all users records, while other roles(e.g."User") can only access their own user record. | `DELETE` /api/users/{id} |
---

## Setup/Installation 
### :small_orange_diamond: Installing C# and .NET

* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

### :small_orange_diamond: Installing and Configuring MySQL
Follow the installation instructions below to installing **MySQL Community Server** and **MySQL Workbench**
#### MacOS  

1. _Download from the [MySQL Community Server Page](https://dev.mysql.com/downloads/file/?id=484914)_ (Use the No thanks, just start my download link.)
2. _Download from the [MySQL Workbench Page](https://dev.mysql.com/downloads/file/?id=484391)_ (Use the No thanks, just start my download link.)
3. Configure ternminal by opening terminal and entering the command: <br>`echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`<br>`source ~/.bash_profile` 
4. Verity MySQL installation <br>`$ mysql -uroot -pYOURPASSWORD`

#### Windows 10

1. _Download the [MySQL Web Installer](https://dev.mysql.com/downloads/file/?id=484919)_ (Use the No thanks, just start my download link.)
2. Add the MySQL environment variable to the System PATH.
    * Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
    * Then select PATH..., click Edit..., then Add.
    * Add the exact location of your MySQL installation, and click OK.
3. Add the exact location of your MySQL installation, and click OK.
4. Verity MySQL installation by opening terminal and entering the command: <br>`$ mysql -uroot -pYOURPASSWORD`

### :small_orange_diamond: Run this project

1. Clone this project
    * `$ git clone https://github.com/jieunkang-101/ParksLookup.Solution`
2. go to the project root folder
    * `$ cd ParksLookup.Solutionl`
    * `$ cd ParksLookupApi`
3. Restore all dependencies
    * `$ dotnet restore` 
4. Re-create the database    
    * `$ dotnet ef database update` 
5. Start the API   
    * `$ dotnet build` 
    * `$ dotnet run` 
6. To Test API with JWT authentication and authorization in `Postman`
    * Send a POST request to http://localhost:5000/api/users/authenticate. <br> In the request `Body`, select `row : JSON `<br> Enter following JSON format object
    ```
    {
        "username": "admin",
        "password": "admin"
    }  
    ```
    * Copy token value
    * Send a GET request to http://localhost:5000/api/users with Token <br>In the request `Auth`, selet Type `Bearer Token` and paste token value
---

## Technologies Used

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)
* [ASP.NET Core MVC 2.2](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2)
* [MySQL](https://www.mysql.com/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.2)
---

### License
*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*
Copyright (c) 2020 **_Jieun Kang_**