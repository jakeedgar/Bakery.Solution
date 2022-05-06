using System;
using System.Collections.Generic;

namespace PierresBakery 
{
  public class Bread 
  {
    public int BreadAmount {get; set;}
    public int BreadPrice {get; set;}

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
      BreadPrice = 0;
    }

    public int GetBreadPrice ()
    {
      for (int i = 1; i <= BreadAmount; i++)
      {
        int incrementor = (i % 3 != 0) ? BreadPrice += 5 : BreadPrice += 0;
      }
      return BreadPrice;
    }
  }

  public class Pastry 
  {
    public int PastryAmount { get; set; }
    public int PastryPrice {get; set;}

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      PastryPrice = 0;
    }

    public int GetPastryPrice() 
    {
      for (int i = 1; i <= PastryAmount; i++)
      {
        int incrementor = (i % 3 != 0) ? PastryPrice += 2 : PastryPrice += 1;
      }
      return PastryPrice;
    }
  }
}
