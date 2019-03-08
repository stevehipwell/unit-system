using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class CompositeUnitDimension : UnitDimension, ICompositeUnitDimension
  {
    public CompositeUnitDimension(string code, IEnumerable<IUnitDimensionComponent> components) : base(code)
    {
      if (components.Count() > 2)
      {
        throw new ArgumentException("A composite unit dimension can only have one or two dimensions.", nameof(components));
      }

      this.Components = new UnitDimensionComponentCollection(components.ToList());
    }

    public IUnitDimensionComponentCollection Components { get; private set; }

    public void AddUnit(ICompositeUnitOfMeasure unit)
    {
      this.AddUnitBase(unit);
    }
  }
}
