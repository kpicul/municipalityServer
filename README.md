# municipalityServer

This is a web api for getting the data from the ms sql municipalities database. 

## Requirements

* .NET Framework 4.7.2 
* Newsoft.json
* MS SQL Express 2019 

## Setting up
* First database municipalities should be created and database should be imported from db.sql file
* Change the sqlServer connection string in Web.config to reflect your setting of the database. By default datasource
is DESKTOP-N4UUB40\SQLEXPRESS and user is kaliopa with password kaliopa. Grant user full access to the database and tables.
* Run the server from visual studio. Server starts on https://localhost:44300/

## Description

* In MunicipalitiesController is definet get request routing for getting the data from the database. 
https://localhost:44300/municipalities is the get request that returns the list of municipalities from the database.
* Municipality.cs and MunicipalityList.cs are files that hold the data about the municipalities
* Queries.cs is an object that holds the database operations (queries)
