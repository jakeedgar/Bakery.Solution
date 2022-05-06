# _Pierre's Bakery_

## By: Jake Edgar

#### A Console Application for purchasing baked goods at a local bakery.

## _Technologies Used:_

* C#
* MSTest
* .NET
* Markdown
* REPL

## Description 

An application that runs in the console. The application modifies the total price of the pastries and bread that are sold at the bakery and returns a price that takes special sales into account. 

## Installation and Setup Requirements

* Navigate to your preferred code Editing Software.
* Clone this repository to your desktop by using the command *git clone* followed by this link https://github.com/jakeedgar/Bakery.Solution
* Navigate to the top level of the directory. 
* Run *dotnet --version* in your command terminal to check what version of dotnet you are running. If it is not 5.0 or newer, please review the information at this link: *https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer* and update your version. This will ensure that both C# and dotnet are installed and updated on your machine. 
* Make sure the dotnet script REPL is installed or run *dotnet tool install -g dotnet-script* to install it globally on your machine. 
* Navigate to the root directory of Bakery.Solution and use a launch command to open the directory in your preferred editing software. I recommend VSCode, especially for C# and dotnet projects. 
* To install the testing environment navigate to the directory titled: Bakery.Tests in your command line, and run the command *dotnet restore*. 
* Run *dotnet test* to confirm the environment is working correctly. 
* After updating the testing environment, navigate to the directory titled: Bakery in your command line, and then run *dotnet run*.
* Enjoy the exciting console based bakery!


## Known Bugs
* There are No Known Bugs at this time. 

## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar

**TESTS**

[Bread Tests] <br>
Describe: It should return a Bread object when instantiated in the test.

Code: 
Bread testBread = new Bread(1);
Assert.AreEqual(typeof(Bread), testBread.GetType());
Expected Result: Bread.

Describe: It should return an integer amount of Bread according to input in the test.

Code:
Bread testBread = new Bread(1);
Assert.AreEqual(1, testBread.BreadAmount);
Expected Result: 1.

Describe: It should return 5 for the price of a single Bread Purchased.

Code:
Bread testBread = new Bread(1);
Assert.AreEqual(5, testBread.GetBreadPrice());
Expected Result: 5.

Describe: It should return 10 for the price of two Bread Purchased.

Code: 
Bread testBread = new Bread(2);
Assert.AreEqual(10, testBread.GetBreadPrice());
Expected Result: 10.

Describe: It should return 10 for the price of three Bread Purchased.

Code: 
Bread testBread = new Bread(3);
Assert.AreEqual(10, testBread.BreadPrice());
Expected Result: 10.

Describe: It should return 20 for the price of six Bread Purchased.

Code:
Bread testBread = new Bread(6);
Assert.AreEqual(20, testBread.BreadPrice());
Expected Result: 20.

[Pastry Tests] <br>
Describe: It should return a Pastry object when instantiated in the test.

Pastry testBread = new Pastry(1);
Assert.AreEqual(typeof(Pastry), testBread.GetType());
Expected Result: Pastry.

Describe: It should return 2 for the price of a single pastry Purchased.

Code:
Pastry testBread = new Pastry(1);
Assert.AreEqual(2, testPastry.GetPastryPrice());
Expected Result: 2.

Describe: It should return 4 for the price of two pastries Purchased.

Code:
Pastry testBread = new Pastry(2);
Assert.AreEqual(4, testPastry.GetPastryPrice());
Expected Result: 4.

Describe: It should return 4 for the price of two pastries Purchased.

Code:
Pastry testBread = new Pastry(3);
Assert.AreEqual(5, testPastry.GetPastryPrice());
Expected Result: 5.

Code:
Pastry testBread = new Pastry(6);
Assert.AreEqual(10, testPastry.GetPastryPrice());
Expected Result: 10.
