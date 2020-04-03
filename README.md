# Parks Lookup

#### C# Building an API Independent Project, 3 April 2020
 
#### By **_Jieun Kang_**
---

## Description
An API that allows users to GET, POST, PUT and DELETE for state and national parks of the United States. 

---

## Specifications : user sotries
You can test the API directly using an applicaion such as `Postman`
|| Spec  | API Endpoint  |
|-| :---------------- | :----- | 
|1| User can READ all parks api call | `GET` /api/parks |
|2| User can READ a certain park | `GET` /api/parks/{id} |
|2| User can SEARCH parks by park name and/or state codes | `GET` /api/parks?parkname=yellowstone |
|3| User can CREATE new park | `POST` /api/parks |
|4| User can UPDATE exist park api info | `PUT` /api/parks/{id} |
|5| User can DELETE a certain park | `DELETE` /api/parks/{id} |
|6| User can READ a random park | `GET` /api/parks/random |

* Further Exploration 
  * Token-Basked Authentication and Authorization (JWT)
  * API Versioning
  * Using Swagger for Documentaion
---

## Setup/Installation 
### :small_orange_diamond: Installing C# and .NET

* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

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
---

## Technologies Used

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)
* [ASP.NET Core MVC 2.2](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2)
* [Entity Framework Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.2)
* [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio)
* [RestSharp API](http://restsharp.org/)
* [Newtonsoft.Json](https://www.newtonsoft.com/json)
* [Swagger](https://swagger.io/)
* [Bootstrap v4.4](https://getbootstrap.com/docs/4.4/getting-started/introduction/)
---

### License
*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*
Copyright (c) 2020 **_Jieun Kang_**