# Hair Salon 57

### Created by William Mentzer

## Links

* [Repository](https://github.com/WiiliamMentzer/HairSalon)

## Description
  Will allow you to create, display, and track all Stylists and Clients at the Hair Salon.


## Features
  Each Stylist can have multiple clients listen on their details page.

## Technologies Used

* Built in VS Code (v.1.70.1) using the following languages:
	* C#
	* .NET
	* MSTest
  * HTML
  * MySQL
  * Entity

## Installation

* Download [Git Bash](https://git-scm.com/downloads)
* Input the following into Git Bash to clone this repository onto your computer:

		>git clone https://github.com/WiiliamMentzer/HairSalon

* Enter the cloned project folder "EauClaireSalon.Solution\HairSalon" and type:

    $dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0

    $dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2

* Once completed then type:

		$ dotnet restore

* Create a file named "appsettins.json"

  After so you can put the following code into the json.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=william_mentzer;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```

* To add the database please open up MySql and select "server" on the toolbar and then select "Data Import"

* Check "Import from self contained file" option and select the file path of the Database within HairSalon, then "Import"

* After such you can type:

		$dotnet run



## Known Bugs

* 

## License

MIT License

Copyright (c) [2022] [William Mentzer]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _10/17/2022_ _William Mentzer_