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
