using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class UnitOfMeasureComponentCollection : ReadOnlyCollection<IUnitOfMeasureComponent>, IUnitOfMeasureComponentCollection
  {
    public UnitOfMeasureComponentCollection(IList<IUnitOfMeasureComponent> list) : base(list)
    {
    }
  }
}
