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
    Bread testBread = new Bread();
    Assert.AreEqual(typeof(Bread), testBread.GetType());
  }
    
  }

}