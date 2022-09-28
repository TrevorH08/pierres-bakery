using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models.Tests
{
  [TestClass]
  public class BreadCostTests
  {
    [TestMethod]
    public void Bread_BreadQuantityDivisibleByThree_True()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(true, testBread.BreadCost());
    }
  }
}
