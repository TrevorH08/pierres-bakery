using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread( int amount )
    {
      Amount = amount;
    }

    public int Cost()
    {
      int price = 5;
      if (Amount % 3 == 0 )
      {
        int finalCost = Amount * price - Amount / 3 * price;
        return finalCost;
      }
      else
      {
        int normalCost = Amount * price;
        return normalCost;
      }
    }
  }
}