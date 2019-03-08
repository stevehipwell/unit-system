using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitOfMeasureComponentCollection : IReadOnlyCollection<IUnitOfMeasureComponent>
  {
    IUnitOfMeasureComponent this[int index] { get; }
  }
}
