using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Implementation
{
  public abstract class UnitDimension : IUnitDimension
  {
    private readonly IList<IUnitOfMeasure> UnitCol;

    protected UnitDimension(string code)
    {
      this.Code = code;
      this.UnitCol = new List<IUnitOfMeasure>();
      this.Units = new UnitOfMeasureCollection(this.UnitCol);
    }

    public string Code { get; private set; }

    public IUnitOfMeasureCollection Units { get; private set; }

    protected void AddUnitBase(IUnitOfMeasure unit)
    {
      if (object.ReferenceEquals(unit.Dimension, this))
      {
        throw new ArgumentException("A unit must have the same dimension that it is added to.", nameof(unit));
      }

      this.UnitCol.Add(unit);
    }
  }
}
