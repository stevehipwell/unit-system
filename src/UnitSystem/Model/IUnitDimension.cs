using System;
using System.Collections.Generic;

namespace UnitSystem.Model
{
  public interface IUnitDimension
  {
    string Code { get; }

    IUnitOfMeasureCollection Units { get; }
  }
}
