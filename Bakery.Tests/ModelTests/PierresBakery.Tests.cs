using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests 
{
[TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void Bread_CreatesABreadObject_Bread()
  {
    Bread testBread = new Bread(1);
    Assert.AreEqual(typeof(Bread), testBread.GetType());
  }
    
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesAPastryObject_Pastry()
    {
      Pastry testBread = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testBread.GetType());
    }

  }

}