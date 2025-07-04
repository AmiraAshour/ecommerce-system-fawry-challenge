using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class ShippingService
  {
    public static void Ship(List<IShippable>items)
    {
      Dictionary<string,int>count=new Dictionary<string,int>();
      double totalWeight = 0;

      foreach (var item in items)
      {
        if(count.ContainsKey(item.GetName()))
          count[item.GetName()]++;
        else 
          count.Add(item.GetName(), 1);
        totalWeight += item.GetWeight();
      }

      Console.WriteLine("** Shipment notice **");
      Console.WriteLine($"{"Qty",- 4} {"Product",-20} {"Weight"}");

      foreach (var item in count)
      {
        double weight = items.FirstOrDefault(x => x.GetName() == item.Key).GetWeight();
        Console.WriteLine($"{item.Value,-4} {item.Key,-20} {weight:f2}g");
      }

      Console.WriteLine($"Total package weight {totalWeight / 1000.0}Kg");

    }
  }
}
