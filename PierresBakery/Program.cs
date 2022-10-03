using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace Checkout
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Prices: ");
      Console.WriteLine("-------");
      Console.WriteLine("Bread: $5 (Buy 2 Get 3rd Free!!)");
      Console.WriteLine("Pastries: $2 (Buy 2 Get 3rd for $1!!");
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Enter desired amount of bread: ");
      int breadQuantity = int.Parse(Console.ReadLine());
      Bread buyBread = new Bread(breadQuantity);
      Console.WriteLine("Here's how much that amount of Bread will cost: $" + buyBread.BreadCost());
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Enter desired amount of Pastries: ");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry buyPastry = new Pastry(pastryQuantity);
      Console.WriteLine("Here's how much that amount of Pastries will cost: $" + buyPastry.PastryCost());
      Console.WriteLine("---------------------------------");
      int finalCost = buyBread.BreadCost() + buyPastry.PastryCost();
      Console.WriteLine("Your final Total is: $" + finalCost);
      Console.WriteLine("Would you like to place your order? (Y/N?)");
      string response = Console.ReadLine().ToString().ToLower();
      if (response == "y")
      {
        Console.WriteLine("Thank you so much! Your order will be ready within the hour!");
      }
      else
      {
        Console.WriteLine("We hope to see you soon!");
      }
    }
  }
}