// TESTS //

[Bread Tests]
Describe: It should return a Bread object when instantiated in the test.

Code: 
Bread testBread = new Bread();
Assert.AreEqual(typeof(Bread), testBread.GetType());
Expected Result: Bread.

Describe: It should return an integer amount of Bread according to input in the test.

Code:
Assert.AreEqual(1, testBread.BreadAmount);
Expected Result: 1.

Describe: It should return 5 for the price of a single Bread Purchased.

Code: 
Assert.AreEqual(5, Bread.BreadPrice(1));
Expected Result: 5.

Describe: It should return 10 for the price of two Bread Purchased.

Code: 
Assert.AreEqual(10, Bread.BreadPrice(2));
Expected Result: 10.

Describe: It should return 10 for the price of three Bread Purchased.

Code: 
Assert.AreEqual(10, Bread.BreadPrice(3));
Expected Result: 10.



[Pastry Tests]
Describe: It should return a Pastry object when instantiated in the test.

Pastry testBread = new Pastry(1);
Assert.AreEqual(typeof(Pastry), testBread.GetType());
Expected Result: Pastry.




## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar