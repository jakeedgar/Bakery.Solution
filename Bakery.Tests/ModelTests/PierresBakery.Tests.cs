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

  [TestMethod]
  public void Bread_ReturnsBreadAmountOne_Int()
  {
    Bread testBread = new Bread(1);
    Assert.AreEqual(1, testBread.BreadAmount);
  }

  [TestMethod]
  public void BreadPrice_ReturnsPriceOfOneBread_int()
  {
    Bread testBread = new Bread(1);
    Assert.AreEqual(5, testBread.GetBreadPrice());
  }

  [TestMethod]
  public void BreadPrice_ReturnsPriceOfTwoBread_int()
  {
    Bread testBread = new Bread(2);
    Assert.AreEqual(10, testBread.GetBreadPrice());
  }

  [TestMethod]
  public void BreadPrice_ReturnsPriceOfThreeBread_int()
  {
    Bread testBread = new Bread(3);
    Assert.AreEqual(10, testBread.GetBreadPrice());
  }

    [TestMethod]
    public void BreadPrice_ReturnsPriceOfSixBread_int()
    {
      Bread testBread = new Bread(6);
      Assert.AreEqual(20, testBread.GetBreadPrice());
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

    [TestMethod]
    public void Pastry_ShouldReturnPriceOfOnePastry_Int()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(2, testPastry.GetPastryPrice());
    }
  }
}