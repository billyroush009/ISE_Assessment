# ISE_Assessment

## Setup:
This was done in Visual Studio Community 2019 with .NET Core 3.1. POST testing was done using 'Postman'
NuGet Packages:
1. Newtonsoft.Json
2. Microsoft.AspNetCore.Mvc.NewtonsoftJson

The project 'firstAPI' contains all the controllers and reactive APIs for this assigment
The project 'Req4' is purely for the fourth requirement, utilizing a console application to access and display info from the prior 3 requirements

### How to Use:
1. Load up and run 'firstAPI' under the 'IIS Express' option
2. Load up and run 'Req4' under the 'Req4' option

#### Notes:
* 'Req4' is only setup to run one time per the specifications. Including a (while true) loop would easily make it run indefinitely
* I tested this on Windows 10 using the built-in 'WebAPI' template through Visual Studio
* When 'firstAPI' is run it will launch a browser by default and fill it with dummy JSON info about the weather
* There are screenshots in the root directory as proof of functionality
* If I had more time I would definitely have polished this project more (and added a short video demo) :)
