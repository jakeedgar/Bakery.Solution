// TESTS //

[Bread Tests]
Describe: It should return a Bread object when instantiated in the test.

Code: 
Bread testBread = new Bread();
Assert.AreEqual(typeof(Bread), testBread.GetType());
Expected Result: Bread.

Describe: It should return an integer amount of Bread according to input in the test.

Code:
Bread testBread = new Bread(1);
Assert.AreEqual(1, testBread.BreadAmount);
Expected Result: 1.



[Pastry Tests]
Describe: It should return a Pastry object when instantiated in the test.

Pastry testBread = new Pastry(1);
Assert.AreEqual(typeof(Pastry), testBread.GetType());
Expected Result: Pastry.




## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar