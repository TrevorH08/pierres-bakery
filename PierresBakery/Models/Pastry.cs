using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }

    public Pastry( int pastryQuantity )
    {
      PastryQuantity = pastryQuantity;
    }

    public int PastryCost()
    {
      int price = 2;
      int discountPrice = price / 2;
      int discount = PastryQuantity / 3 * discountPrice;
      return PastryQuantity * price - discount;
    }
  }
}