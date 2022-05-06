using System;
using System.Collections.Generic;

namespace PierresBakery 
{
  public class Bread 
  {
    public int BreadAmount {get; set;}

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
    }

    public static int BreadPrice (int BreadAmount)
    {
      int breadPrice = 0;
      if ((BreadAmount == 1) || (BreadAmount == 2)) 
      {
        breadPrice = BreadAmount * 5;
      } 
      return breadPrice;
    }
  }

  public class Pastry 
  {
    public int PastryAmount { get; set; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
  }
}
