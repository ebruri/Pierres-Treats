# **Pierre's Treats**
#### _a C# MVC Bakery application._

#### by **Ebru Rice**
#### April 10, 2022

## Technologies Used
- C#
- .NET 5.0
- REPL
- MySQL
- Razor
- ASP.NET Core


## Description
A website where users can add, view, edit and delete treats and flavors for a bakery.

## Project Setup/Installation Instructions

### Install C#, .NET, MySQL Community Server and MySQL Workbench
- Open the terminal on your local machine
- If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions here [here](https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-c-and-net).
- If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-and-configuring-mysql).


### Clone the project
- Open the terminal on your local computer.
- Navigate to the parent directory of your preference.
- Clone this project using `$ git clone https://github.com/ebruri/Pierres-Treats`
- Navigate to the directory: ```$ cd Pierres-Treats```
- Open in Vs code: ```$ code .```

### Create the database
- Navigate to Factory: ```$ cd Factory``` and type the following command in the terminal ```$ touch appsettings.json```
- Navigate to the appsettings.json file ```$ cd appsettings.json``` and enter:
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
- If you haven't installed dontet ef tool, install it by running the command ```$ dotnet tool install --global dotnet-ef --version 3.0.0```
- Run the command ```$ dotnet ef migrations add Initial``` to create a migration in Factory folder.
- Run the command ```$ dotnet ef database update``` to apply migrations.


### Run the project
- Navigate to Factory: ```$ cd Pierres``` and type the following command in the terminal ```$ dotnet build```
- Run the program in the console with the command ```$ dotnet run```

## Known Bugs
- _None._

## License
[MIT License](https://opensource.org/licenses/MIT) © 2022 _Ebru Rice_

## Contact
Ebru Rice: [ebruerenb@gmail.com](mailto:ebruerenb@gmail.com)
