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
  }
}