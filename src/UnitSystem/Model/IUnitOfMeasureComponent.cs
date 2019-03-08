using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitOfMeasureComponent
  {
    IUnitOfMeasure Unit { get; }

    int Power { get; }
  }
}
