// TESTS //

[Bread Tests]
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



[Pastry Tests]
Describe: It should return a Pastry object when instantiated in the test.

Pastry testBread = new Pastry(1);
Assert.AreEqual(typeof(Pastry), testBread.GetType());
Expected Result: Pastry.

Describe: It should return 2 for the price of a single pastry Purchased.

Code:
Pastry testBread = new Pastry(1);
Assert.AreEqual(2, testPastry.GetPastryPrice());
Expected Result: 2.


## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar