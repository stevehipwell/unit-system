using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IUnitOfMeasureComponentCollection : IReadOnlyCollection<IUnitOfMeasureComponent>
  {
    IUnitOfMeasureComponent this[int index] { get; }
  }
}
