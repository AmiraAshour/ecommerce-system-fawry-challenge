using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class Product
  {
    public Product(string name, double price, int quantiy)
    {
      Name = name;
      Price = price;
      Quantiy = quantiy;
    }
  
    public string Name { get; protected set; }

    public double Price { get; protected set; }

    public int Quantiy { get; protected set; }

    public bool IsAvailable (int amount)
    {
      return Quantiy >= amount;        
    }
    public void ReduceQuantity(int amount)
    {
        Quantiy -= amount;
    }
    public virtual bool IsExpired()
    {
      return false;
    }

  }
}
