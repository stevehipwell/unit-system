using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Implementation
{
  public class ScalarUnitOfMeasure : UnitOfMeasure, IScalarUnitOfMeasure
  {
    private readonly double ScaleValue;
    private readonly double OffsetValue;

    public ScalarUnitOfMeasure(IScalarUnitDimension dimension, string code, double scale, double offset) : base(dimension, code)
    {
      this.ScaleValue = scale;
      this.OffsetValue = offset;
    }

    public override double Scale => this.ScaleValue;

    public override double Offset => this.OffsetValue;
  }
}
