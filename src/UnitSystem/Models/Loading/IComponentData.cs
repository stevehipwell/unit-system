using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Loading
{
  public interface IComponentData
  {
    string Code { get; set; }

    int OffsPoweret { get; set; }
  }
}
