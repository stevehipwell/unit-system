using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IUnitOfMeasureCollection : IReadOnlyCollection<IUnitOfMeasure>
  {
    IUnitOfMeasure this[int index] { get; }

    IUnitOfMeasure this[string code] { get; }
  }
}
