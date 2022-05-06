using System;
using PierresBakery;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    while (true)
    {
    Console.WriteLine("Would you like to place an order today Y/N?");
    string userInput = Console.ReadLine().ToUpper();
    if (userInput == "Y")
    {
      Console.WriteLine("How many loaves of bread today?");
      int loafOrder = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(loafOrder);
      Console.WriteLine("How many pastries today?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(pastryOrder);
      int breadCost = newBread.GetBreadPrice();
      int pastryCost = newPastry.GetPastryPrice();
      int totalPrice = breadCost + pastryCost;
      Console.WriteLine(totalPrice);
      Console.WriteLine("Thank you for your order today.");
      Console.WriteLine("You ordered " + newPastry.PastryAmount + " pastries and " + newBread.BreadAmount + " loaves of bread it will cost you " + totalPrice + " dollars");
    }
    else if (userInput == "N")
    {
      Console.WriteLine("Have a nice day.");
      break;
    }
    else 
    {
      Console.WriteLine("Please select either bread or pastry.");
    }
    }
  }
}