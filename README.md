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

- RESTful endpoints to retrieve weather forecast data by location
- Database integration via Entity Framework
- 80 weather forecast records across 5 Irish destinations and 
  multiple dates included as seed data

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
- Condition — weather condition (Sunny, Rainy, Cloudy, Windy, 
  Foggy and Stormy)
- Temperature — temperature value in Celsius

## Database

The file `T-SQL_APIBrazsToursWeatherDB.sql` contains the full 
database schema and seed data for this API, including 80 weather 
forecast records for:
- Wicklow Mountains
- Cliffs of Moher
- Giants Causeway
- Malahide Castle
- Newgrange

To restore the database:
1. Open SQL Server Management Studio (SSMS)
2. Run the script `T-SQL_APIBrazsToursWeatherDB.sql`
3. Update the connection string in Web.config if needed

## Academic Context

Developed at Atlantic Technological University (ATU), Sligo — 
BSc (Hons) Computer Science, 2nd Semester, Web Design Module.
