using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Loader
{
  public interface IUnitSystemLoader
  {
    IEnumerable<IUnitDimension> Dimensions { get; }
  }
}
