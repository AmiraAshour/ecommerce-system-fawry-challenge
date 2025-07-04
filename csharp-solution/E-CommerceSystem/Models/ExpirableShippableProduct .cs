using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class ExpirableShippableProduct : ExpirableProduct, IShippable
  {
    private double Weight;
    public ExpirableShippableProduct(string name, double price, int quantiy, DateTime expiryDate,double weight) 
      : base(name, price, quantiy, expiryDate)
    {
      Weight = weight;
    }
    public string GetName() => Name;
    public double GetWeight() => Weight;
  }
}
