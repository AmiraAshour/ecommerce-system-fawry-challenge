﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem.Models
{
  public interface IShippable
  {
    string GetName();
    double GetWeight();
  }
}
