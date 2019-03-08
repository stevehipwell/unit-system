using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IScalarUnitDimension : IUnitDimension
  {
    void AddUnit(IScalarUnitOfMeasure unit);
  }
}
