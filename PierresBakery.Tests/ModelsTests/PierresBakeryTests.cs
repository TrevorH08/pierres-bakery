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

  [TestClass]
  public class PastryCostTests
  {
    [TestMethod]
    public void Pastry_PastryQuantityEqualsUserInput_True()
    {
      Pastry testPastry = new Pastry(4);
      Assert.AreEqual(4, testPastry.PastryQuantity);
    }
    [TestMethod]
    public void Pastry_PastryQuantityMultipliableByPriceWithoutDiscount_True()
    {
      Pastry testPastry = new Pastry(2);
      Assert.AreEqual(4, testPastry.PastryCost());
    }
    [TestMethod]
    public void Pastry_PastryQuantityApplyDiscountEveryThree_True()
    {
      Pastry testPastry = new Pastry(6);
      Assert.AreEqual(10, testPastry.PastryCost());
    }
  }
}
