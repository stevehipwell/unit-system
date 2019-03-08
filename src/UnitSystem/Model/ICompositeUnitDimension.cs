using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface ICompositeUnitDimension : IUnitDimension
  {
    IUnitDimensionComponentCollection Components { get; }

    void AddUnit(ICompositeUnitOfMeasure unit);
  }
}
