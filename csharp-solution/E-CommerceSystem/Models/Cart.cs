using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class Cart
  {
    private Dictionary<Product, int> items = new Dictionary<Product, int>();
    public void Add(Product product, int quntity)
    {
      if (!product.IsAvailable(quntity))
        throw new InvalidOperationException("Requested quantity exceeds stock.");

      if (items.ContainsKey(product))
        items[product] += quntity;
      else
        items.Add(product, quntity);
    }
    public Dictionary<Product, int> GetItems() => items;
    public bool isEmpty => items.Count == 0;
  }
}
