using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class Customer
  {
    public Customer(string name, double balance)
    {
      Name = name;
      Balance = balance;
    }

    public string Name { get; set; }
    public double Balance { get;private set; }
    public void Deduct(double amount)
    {
      Balance-=amount;
    }
   
  }
}
