# Braz's Tours Weather API

A RESTful Web API for weather forecast data developed as part of 
the 2nd Semester Web Design module at Atlantic Technological 
University (ATU), Sligo, Ireland.

## About the Project

BrazsToursWeatherWebApi is a RESTful Web API built with ASP.NET 
Web API framework, designed to serve weather forecast data to 
client applications. The API connects to a SQL Server database 
using Entity Framework and follows standard REST conventions.

## Features

- RESTful endpoints to retrieve weather forecast data
- Database integration via Entity Framework
- WeatherForecast model with Location, Date, Condition 
  and Temperature fields
- JSON data format for API responses

## Technologies Used

- C# / ASP.NET Web API
- Entity Framework 6
- SQL Server Express
- .NET Framework 4.7.2
- JSON data format

## Data Model

The WeatherForecast entity includes:
- Id — unique identifier
- Location — forecast location
- Date — forecast date
- Condition — weather condition description
- Temperature — temperature value

## Academic Context

Developed at Atlantic Technological University (ATU), Sligo — 
BSc (Hons) Computer Science, 2nd Semester, Web Design Module.

## Note

This API requires a local SQL Server Express instance to run. 
Connection string and database configuration are defined in 
Web.config.
