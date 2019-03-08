using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Loader
{
  public interface IUnitDimensionComponentData
  {
    string Code { get; set; }

    int Power { get; set; }
  }
}
