using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IUnitOfMeasureComponent
  {
    IUnitOfMeasure Unit { get; }

    int Power { get; }
  }
}
