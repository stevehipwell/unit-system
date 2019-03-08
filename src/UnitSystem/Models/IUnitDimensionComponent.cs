using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IUnitDimensionComponent
  {
    IUnitDimension Dimension { get; }

    int Power { get; }
  }
}
