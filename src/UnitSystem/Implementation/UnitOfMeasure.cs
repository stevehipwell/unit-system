using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public abstract class UnitOfMeasure : IUnitOfMeasure
  {
    protected UnitOfMeasure(IUnitDimension dimension, string code)
    {
      this.Dimension = dimension;
      this.Code = code;
    }

    public IUnitDimension Dimension { get; private set; }

    public string Code { get; private set; }

    public abstract double Scale { get; }

    public abstract double Offset { get; }
  }
}
