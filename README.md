# CatalogoAPI

## Required Installations
- Install .NET 7 SDK
- Install Visual Studio 2022 or Visual Studio Code
- Install MySQL Community Server
- Install MySQL Workbench Community Edition

## Build and Run
Open the project in the IDE of your choice, and checkout to "development" branch.

Create a new database in MySQL command line client:
`CREATE DATABASE CatalogoAPI;`

Create a new MySQL user:
`CREATE USER 'catalogoapi'@'localhost' IDENTIFIED WITH mysql_native_password BY '#root123';`

Grant all permissions to the new user:
`GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, INDEX, DROP, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES, REFERENCES ON CatalogoAPI.* TO 'catalogoapi'@'localhost';`

Install Dotnet Entity Framework tool:
`dotnet tool install --global dotnet-ef`

Change directory to APICatalogo project folder
`cd /APICatalogo`

Update database with Dotnet EF migrations:
`dotnet ef database update`

Now you're good to go and run the project!
