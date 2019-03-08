using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitDimensionComponentCollection : IReadOnlyCollection<IUnitDimensionComponent>
  {
    IUnitDimensionComponent this[int index] { get; }
  }
}
