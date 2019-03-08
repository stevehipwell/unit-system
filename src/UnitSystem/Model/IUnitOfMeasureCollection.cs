using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitOfMeasureCollection : IReadOnlyCollection<IUnitOfMeasure>
  {
    IUnitOfMeasure this[int index] { get; }

    IUnitOfMeasure this[string code] { get; }
  }
}
