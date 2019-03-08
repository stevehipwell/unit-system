using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class UnitDimensionComponentCollection : ReadOnlyCollection<IUnitDimensionComponent>, IUnitDimensionComponentCollection
  {
    public UnitDimensionComponentCollection(IList<IUnitDimensionComponent> list) : base(list)
    {
    }
  }
}
