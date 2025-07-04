using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public class ExpirableProduct:Product
  {
    public ExpirableProduct(string name, double price, int quantiy,DateTime expiryDate):base(name,price,quantiy)
    {
      ExpiryDate = expiryDate;
    }

    private DateTime ExpiryDate;
    public override bool IsExpired()
    {
      return ExpiryDate < DateTime.Now.Date;
    }

  }
}
