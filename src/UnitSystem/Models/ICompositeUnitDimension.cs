using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface ICompositeUnitDimension : IUnitDimension
  {
    IUnitDimensionComponentCollection Components { get; }

    void AddUnit(ICompositeUnitOfMeasure unit);
  }
}
