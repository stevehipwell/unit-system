using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Loader
{
  public interface IUnitSystemLoader
  {
    IEnumerable<IUnitDimension> Dimensions { get; }
  }
}
