using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Implementation
{
  public class CompositeUnitOfMeasure : UnitOfMeasure, ICompositeUnitOfMeasure
  {
    private readonly ICompositeUnitDimension CompositeDimension;

    public CompositeUnitOfMeasure(ICompositeUnitDimension dimension, string code, IList<string> components) : base(dimension, code)
    {
      this.CompositeDimension = dimension;

      if (components.Count != this.CompositeDimension.Components.Count)
      {
        throw new ArgumentException("A composite unit of measure needs the same number of components as it's dimension.", nameof(components));
      }

      this.Components = new UnitOfMeasureComponentCollection(GetComponentUnits(components));
    }

    public UnitOfMeasureComponentCollection Components { get; private set; }

    public override double Scale => this.Components.Select(c => Math.Pow(c.Unit.Scale, c.Power)).Aggregate(1d, (x, y) => x * y);

    public override double Offset => 0;

    private IList<IUnitOfMeasureComponent> GetComponentUnits(IList<string> components)
    {
      var componentCol = new List<IUnitOfMeasureComponent>();

      for (int i = 0; i < this.CompositeDimension.Components.Count; i++)
      {
        var component = this.CompositeDimension.Components[i];
        var componentDimension = component.Dimension;
        var componentUnit = componentDimension.Units[components[i]];

        if (componentUnit == null)
        {
          throw new ArgumentException(string.Format("The specified unit '{0}', does not exist in the dimension '{1}',", componentUnit.Code, componentDimension.Code), nameof(components));
        }

        componentCol.Add(new UnitOfMeasureComponent(componentUnit, component.Power));
      }

      return componentCol;
    }
  }
}
