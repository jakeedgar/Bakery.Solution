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
        if (i % 3 == 0)
        {
          BreadPrice += 0;
        }
        else if (i % 3 == 2) 
        {
          BreadPrice += 5;
        }
        else if (i % 3 == 1)
        {
          BreadPrice += 5;
        }

      }
      return BreadPrice;
    }
  }


  // if (BreadAmount <= 2) 
  // {
  //   breadPrice = BreadAmount * 5;
  // }
  // else if 
  // (BreadAmount % 3 == 0) 
  // {
  //   breadPrice = (BreadAmount / 3) * 10;
  // }
  // return breadPrice;

  public class Pastry 
  {
    public int PastryAmount { get; set; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
  }
}
