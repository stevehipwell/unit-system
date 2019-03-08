using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitDimensionCollection : IReadOnlyCollection<IUnitDimension>
  {
    IUnitDimension this[int index] { get; }

    IUnitDimension this[string code] { get; }
  }
}
