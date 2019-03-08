using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class UnitDimensionCollection : ReadOnlyCollection<IUnitDimension>, IUnitDimensionCollection
  {
    public UnitDimensionCollection(IList<IUnitDimension> list) : base(list)
    {
    }

    public IUnitDimension this[string code] => this.Items.FirstOrDefault(d => string.Equals(d.Code, code, StringComparison.OrdinalIgnoreCase));
  }
}
