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

* Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
* Add an animal to the system. An animal should have a name, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
* List animals by breed or type alphabetically.
* List animals starting with the ones who have been in the shelter the longest.

* Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
* Add an animal to the system. An animal should have a name, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
* List animals by breed or type alphabetically.
* List animals starting with the ones who have been in the shelter the longest.

![Screenshot of Databases](AnimalShelter/wwwroot/images/db.png)

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->


## Setup/Installation Requirements

* Clone this repo to your workspace.
* Open MySqlWorkbench [Click here for instructions to download]
  * Under Admin Tab, select Data Import/Restore
    * Select 'Import from Self Contained File'
    * Select SQL_DUMP_FILENAME
    * Change Default Target Schema to 'DB_NAME'
    * Click 'Start Import'
* In root directoy of project, create file 'appsettings.json'
  * add the Default Connection settings
  * chan 
* Navigate to program directory ``` $ cd HairSalon ```
* Navigate to PROJECT_NAME folder & run ```$ dotnet restore ```
* To build & run program in development mode ``` $ dotnet run ```
* To build & run program in production mode ``` dotnet run --launch-profile "production" ```


## Known Bugs

* No known bugs. 
* If any issues are discovered, please email jenniferlholcomb@gmail.com


## License

MIT License

Copyright (c) 2022 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
