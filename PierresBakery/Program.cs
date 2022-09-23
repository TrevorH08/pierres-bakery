using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace Checkout
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello");
      Console.WriteLine("Enter Desired amount of bread: ");
      int amount = int.Parse(Console.ReadLine());
      Bread buyBread = new Bread(amount);
      Console.WriteLine("Price: " + buyBread.Cost());

    }
  }
}