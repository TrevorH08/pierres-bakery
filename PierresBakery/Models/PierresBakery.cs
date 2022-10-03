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
      if (BreadQuantity % 3 == 0 )
      {
        int discountCost = BreadQuantity * price - BreadQuantity / 3 * price;
        return discountCost;
      }
      else
      {
        int normalCost = (BreadQuantity * price) - discount;
        return normalCost;
      }
    }
  }
  
//   public class Pastry
//   {
//     public int PastryQuantity { get; set; }

//     public Pastry( int pastryQuantity )
//     {
//       PastryQuantity = pastryQuantity;
//     }

//     public int PastryCost()
//     {
//       int price = 2;
//     }
//   }
}