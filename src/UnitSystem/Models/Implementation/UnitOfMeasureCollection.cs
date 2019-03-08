using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Implementation
{
  public class UnitOfMeasureCollection : ReadOnlyCollection<IUnitOfMeasure>, IUnitOfMeasureCollection
  {
    public UnitOfMeasureCollection(IList<IUnitOfMeasure> list) : base(list)
    {
    }

    public IUnitOfMeasure this[string code] => this.Items.FirstOrDefault(u => string.Equals(u.Code, code, StringComparison.OrdinalIgnoreCase));
  }
}
