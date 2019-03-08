using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class UnitOfMeasureComponent : IUnitOfMeasureComponent
  {
    public UnitOfMeasureComponent(IUnitOfMeasure unit, int power)
    {
      this.Unit = unit;
      this.Power = power;
    }

    public IUnitOfMeasure Unit { get; private set; }

    public int Power { get; private set; }
  }
}
