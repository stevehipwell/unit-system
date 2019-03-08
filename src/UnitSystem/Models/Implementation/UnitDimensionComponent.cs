using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Implementation
{
  public class UnitDimensionComponent : IUnitDimensionComponent
  {
    public UnitDimensionComponent(IUnitDimension dimension, int power)
    {
      this.Dimension = dimension;
      this.Power = power;
    }

    public IUnitDimension Dimension { get; private set; }

    public int Power { get; private set; }
  }
}
