# Library Management System
A Library Management System in .NET 6 using Clean Architecture, Generic Repository Pattern and UnitOfWork

The Clean Architecture is motivated from [Clean Architecture In ASP.NET Core](https://www.c-sharpcorner.com/article/clean-architecture-in-asp-net-core-web-api/) article.

## 1. Prepare your environment
Get the latest code from `develop` branch and proceed with the following instructions to run the application. Ensure that the required tools are installed in your environment.
- [SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [.NET 6.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## 2. Run the application
- Open LibraryManagementSystem.sln with Visual Studio.
- Configure DefaultConnection in the ConnectionStrings section of the appsettings.json file.
- Open Package Manager Console and make sure that Default Project is LMS.Infrastracture.
- Run the commands:
```
update-database InitialMigration.
```
- Set LMS.Web as StartUp Project
- You are ready!
