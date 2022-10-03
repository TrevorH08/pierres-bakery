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
      // int discount = price / 2;
      return PastryQuantity * price;
    }
  }
}