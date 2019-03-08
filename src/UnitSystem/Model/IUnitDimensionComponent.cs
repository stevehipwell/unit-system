using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitDimensionComponent
  {
    IUnitDimension Dimension { get; }

    int Power { get; }
  }
}
