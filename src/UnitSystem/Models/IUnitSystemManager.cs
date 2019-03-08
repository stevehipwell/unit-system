using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models
{
  public interface IUnitSystemManager
  {
    IUnitDimensionCollection Dimensions { get; }

    IEnumerable<IUnitOfMeasure> Units { get; }

    IUnitOfMeasure FindUnitOfMeasure(string unitCode);

    IUnitOfMeasure FindUnitOfMeasure(string dimensionCode, string unitCode);
  }
}
