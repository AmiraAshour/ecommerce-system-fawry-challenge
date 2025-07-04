using E_CommerceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer("Amira", 500000);

      var cheese = new ExpirableShippableProduct("Cheese", 70, 10, DateTime.Now.AddDays(5), 400);
      var biscuits = new ExpirableShippableProduct("Biscuits", 100, 15, DateTime.Now.AddDays(20), 700);
      var tv = new ShippableProduct("TV", 5000, 5, 6000);
      var scratchCart = new Product("Scratch Cart", 50, 100);

      var cart = new Cart();
      cart.Add(cheese, 2);
      cart.Add(biscuits, 1);
      cart.Add(tv, 2);
      cart.Add(scratchCart, 1);
       
      CheckoutService.Checkout(customer, cart);

    }
  }
}
