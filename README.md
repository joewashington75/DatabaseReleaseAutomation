# Introduction 
This repository shows how to update SQL database using both DbUp and EF Core Migrations. This [blog post](https://joeblogs.technology/2020/05/techniques-for-automating-sql-database-releases-using-azure-devops/) helps explain step-by-step how the different methods can be implemented, and discusses how this can be baked into the CI/CD using Azure DevOps. 

# Getting Started
A docker-compose file has been added to run SQL Server locally. This will allow you to run the DbUp migrations and the EF Core migrations locally. If you already have a local instance of SQL Server, update the connection strings in the appsettings.json file before running the projects.

An ARM project (DatabaseReleaseAutomation.Infrastructure) and Azure DevOps pipelines (/cicd/azure-pipelines...yml) have been included to help deploy into Azure.

More info [here](https://joeblogs.technology/2020/05/techniques-for-automating-sql-database-releases-using-azure-devops/)
