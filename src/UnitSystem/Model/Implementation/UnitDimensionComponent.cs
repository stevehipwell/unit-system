using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Model.Implementation
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
