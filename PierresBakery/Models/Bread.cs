using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }

    public Bread( int breadQuantity )
    {
      BreadQuantity = breadQuantity;
    }

    public int BreadCost()
    {
      int price = 5;
      int discount = BreadQuantity / 3 * price;
      return BreadQuantity * price - discount;
      // if (BreadQuantity % 3 == 0 )
      // {
      //   int discountCost = BreadQuantity * price - BreadQuantity / 3 * price;
      //   return discountCost;
      // }
      // else
      // {
      //   int normalCost = (BreadQuantity * price) - discount;
      //   return normalCost;
      // }
    }
  }
}