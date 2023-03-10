# Hair Salon

#### By Jennifer Holcomb

#### An application for salon owner to manage salon, Eau Claire's Salon. (fictitious)

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* mySQL
* mySQL Workbench
* LINQ

## Description

This application allows salon owner to see a list of all stylists working at the salon, see details about each stylist, and a list of all clients that belong to that stylist. Salon owner is also able to add stylists and clients to a database.

### Objectives (MVP)

* Setup hair_salon as a schema. Stylists should be one table in our hair_salon schema. Add columns to stylists table with columns StylistId, Name, Specialty, SpecialtyRate.
* Add a clients table to hair_salon schema. Clients should have columns that include StylistId, ClientId, Name, Service History, Birthday.
* Stylists should list alphabetically.
* Clients should list alphabetically.


![Screenshot of Databases](HairSalon/wwwroot/images/db_hair_salon.png)


## Setup/Installation Requirements

* Clone this repo to your workspace.
* Open MySqlWorkbench 
  * Under Admin Tab, select Data Import/Restore
    * Select 'Import from Self Contained File'
    * Select jennifer_holcomb.sql
    * Change Default Target Schema to 'jennifer_holcomb'
    * Click 'Start Import'
* Navigate to program directory  (HairSalon.Solution)
  * add .gitignore file to this directory
    * add bin, obj, appsettings.json to file
    * push this file to GitHub first
* Navigate to production directory (HairSalon)
  * Create a file appsettings.json
    * Add the following to appsettings.json,
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=jennifer_holcomb;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    * In appsettings.json, replace '[YOUR-USERNAME-HERE]' with your SQL username, and '[YOUR-PASSWORD-HERE]' with your SQL password
* In production directory, on command line run $ dotnet restore.
* In production directory, run $ dotnet watch run in command line to start project in development mode in watcher.
* Open brower to https://localhost:5001

## Known Bugs

* No known bugs. 
* If any issues are discovered, please email jenniferlholcomb@gmail.com


## License

MIT License

Copyright (c) 2023 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
