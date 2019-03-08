using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IScalarUnitDimension : IUnitDimension
  {
    void AddUnit(IScalarUnitOfMeasure unit);
  }
}
