using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class CheckoutService
  {
    private const double ShappingFee = 60.0;
    public static void Checkout(Customer customer,Cart cart)
    {
      if (cart.isEmpty)
        throw new InvalidOperationException("Cart is empty");
      double Subtotal = 0;
      List<IShippable> shipItems=new List<IShippable>();
      foreach (var item in cart.GetItems())
      {
        var product = item.Key;
        var quntity=item.Value;

        if (product.IsExpired())
          throw new InvalidOperationException($"{product.Name} is expired!");

        if (!product.IsAvailable(quntity))
          throw new InvalidOperationException($"{product.Name} out of stock!");

        Subtotal += product.Price * quntity;

        if(product is IShippable shippableProduct)
        {
          for (int i = 0;i<quntity;i++)
            shipItems.Add(shippableProduct);
        }

      }
      double Shipping = (shipItems.Count == 0 ? 0 : ShappingFee);
        double Amount = Subtotal + Shipping;
        if (customer.Balance < Amount)
          throw new InvalidOperationException("Insufficient balance");

        if (shipItems.Count > 0)
          ShippingService.Ship(shipItems);

        foreach (var item in cart.GetItems())
        {
          item.Key.ReduceQuantity(item.Value);
        }
        customer.Deduct(Amount);

      Console.WriteLine("\n** Checkout receipt **");
      Console.WriteLine($"{"Qty",-4} {"Product",-20} {"Price"}");

      foreach (var item in cart.GetItems())
      {
        Console.WriteLine($"{item.Value,-4} {item.Key.Name,-20} {item.Key.Price}"); 
      }

      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine($"Subtotal = {Subtotal}");
      Console.WriteLine($"Shipping = {Shipping}");
      Console.WriteLine($"Amount = {Amount}");

    }
  }
}
