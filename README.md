# ISE_Assessment

## Setup:
* This was done in Visual Studio Community 2019 with .NET Core 3.1. POST testing was done using 'Postman'

### NuGet Packages:
1. Newtonsoft.Json
2. Microsoft.AspNetCore.Mvc.NewtonsoftJson

* The project 'firstAPI' contains all the controllers and reactive APIs for this assigment
* The project 'Req4' is purely for the fourth requirement, utilizing a console application to access and display info from the prior 3 requirements

### How to Use:
1. Load up firstAPI in Visual Studio and run 'firstAPI' under the 'IIS Express' option
* Using Postman, send int-arrays (as a POST) to 'https://localhost:XXXXX/api/ReqX' as JSON with the field labeled as "int_array"
* * {"int_array" : [2,5,4,1,3]}
2. Load up Req4 in Visual Studio and run 'Req4'
* Enter in a series of integers, seperated by commas (no spaces) and hit enter to view results
* * Needs firstAPI running to work, port# also hard-coded here

#### Notes:
* Req3 and Req4 have a statically referenced port # (44394) for making the POST requests
* * I believe there's a way to default Visual Studio to default to a specific port and I'm sure there's a way to dynamically call these which would be better practice
* When 'firstAPI' is run it will launch a browser by default and fill it with dummy JSON info about the weather
* * The URL contains the randomly generated port # you'll probably need to send POSTs with Postman
* 'Req4' is only setup to run one time per the specifications. Including a (while true) loop would easily make it run indefinitely
* I tested this on Windows 10 using the built-in 'WebAPI' template through Visual Studio
* I'm not entirely sure I used LINQ in the way you guys specified, apologies but that's a new concept to me!
* There are screenshots in the root directory as proof of functionality
* If I had more time I would definitely have polished this project more (and added a short video demo) :)
