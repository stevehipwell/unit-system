using System;
using System.Collections.Generic;

namespace UnitSystem.Models
{
  public interface IUnitDimension
  {
    string Code { get; }

    IUnitOfMeasureCollection Units { get; }
  }
}
