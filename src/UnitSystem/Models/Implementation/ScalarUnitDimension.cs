using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Implementation
{
  public class ScalarUnitDimension : UnitDimension, IScalarUnitDimension
  {
    public ScalarUnitDimension(string code) : base(code)
    {
    }

    public void AddUnit(IScalarUnitOfMeasure unit)
    {
      this.AddUnitBase(unit);
    }
  }
}
