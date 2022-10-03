using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models.Tests
{
  [TestClass]
  public class BreadCostTests
  {
    [TestMethod]
    public void Bread_BreadQuantityEqualsUserInput_True()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(3, testBread.BreadQuantity);
    }
    [TestMethod]
    public void Bread_BreadQuantityMultipliableByPriceWithoutDiscount_True()
    {
      Bread testBread = new Bread(2);
      Assert.AreEqual(10, testBread.BreadCost());
    }
    [TestMethod]
    public void Bread_BreadQuantityDivisibleByThree_True()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(10, testBread.BreadCost());
    }
  }
}
