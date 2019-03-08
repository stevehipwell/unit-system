using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Loader
{
  public interface IUnitDimensionComponentData
  {
    string Code { get; set; }

    int Power { get; set; }
  }
}
