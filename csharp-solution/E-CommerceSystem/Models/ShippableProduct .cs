using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class ShippableProduct : Product, IShippable
  {
    private double Weight;
    public ShippableProduct(string name, double price, int quantiy, double weight) : base(name, price, quantiy)
    {
      Weight = weight;
    }

    public string GetName() => Name;
    public double GetWeight() => Weight;
  }
}
