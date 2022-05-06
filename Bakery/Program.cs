using System;
using PierresBakery;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Would you like bread or pastry today?");
    string userInput = Console.ReadLine().ToLower();
    if (userInput == "bread")
    {
      Console.WriteLine("How many loaves of bread today?");
      int loafOrder = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(loafOrder);
      return newBread;
    }
    else if (userInput == "pastry")
    {
      Console.WriteLine("How many pastries today?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(pastryOrder);
      return newPastry;
    }
    else 
    {
      Console.WriteLine("Please select either bread or pastry.");
    }
    int totalPrice = newBread.BreadPrice + newPastry.PastryPrice;
    Console.WriteLine("Thank you for your order today.");
    Console.WriteLine("You ordered " + newPastry.PastryAmount + " of pastries and " + newBread.BreadAmount + " loaves of bread it will cost you " + totalPrice + " dollars");
  }
}