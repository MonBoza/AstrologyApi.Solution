# Astrology API

### An api with personality information for different astrological signs.

#### By Brianca Knight

## Technologies Used

* C#
* .Net 6
* Entity Framework Core
* MySQL
* MySQL Workbench
* Swagger
* Postman

## Description

An API that holds personality information of different astrological signs. API has full CRUD functionality. This API gives information of the expression, descriptions, and concentrations of each sign. Users can reach endpoints through postman and swagger. This API was designed for use of [PROJECT NAME HERE], you can find more information about this project at [PROJECT URL HERE].

## Setup/Installation Requirements

### Cloning, Database, and AppSettings
* Clone this repo from `https://github.com/BriancaKnight/AstrologyApi.Solution`.

* In the production sub directory (named `AstrologyApi`) create a file named `appsettings.json` and add the following code to it:

 ```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=astrology_api;uid=[USERNAME];pwd=[PASSWORD];"
  }
}
   ```

  Make sure to update the stringS with your own values for [USERNAME] and [PASSWORD] without square brackets.

* In the terminal run the commands `dotnet restore` to install dependencies. 

* To set up the database schema run the command `dotnet ef database update`. 

* Run the command `dotnet run` to have access to the API in the broser via Swagger or in Postman. 

### API Use and Documentation

#### API Endpoints

Base URL: `https://localhost:5001`

##### HTTP REQUEST STRUCTURE
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id} 
```

##### Example Query
```
https://localhost:5001/api/signs/1
```

##### Sample JSON Response
```
{
    "boothId": 1,
    "signName": "Aries",
    "expression": "extroverted",
    "description": "idealistic",
    "concentration": "action",
}
```

##### Signs

Access info on astrological signs.

##### HTTP Request
```
GET /api/signs
POST /api/signs
GET /api/signs/{id}
PUT /api/signs/{id}
DELETE /api/signs/{id}
```

##### Path Parameters
| Parameter | Type | Required | Description |
| :---: | :---: | :---: | --- |
| signName | string | true | Return matches by sign name.
| expression | string | true | Return matches by sign expression. 
| description | string | true | Return matches by sign description.
| concentration | string | true | Return matches by sign concentration.|


##### Example Query
```
https://localhost:5001/api/signs?expression=extroverted&description=social
```

#### Sample JSON Response
```
    {
        "signId": 3,
        "signName": "Gemini",
        "expression": "extroverted",
        "description": "social",
        "concentration": "learning",
    }
```

## Known Bugs
* None.

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2023 Brianca Knight
