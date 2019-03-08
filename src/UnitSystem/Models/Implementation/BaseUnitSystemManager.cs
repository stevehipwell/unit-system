using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;
using UnitSystem.Loader;

namespace UnitSystem.Models.Implementation
{
  public class BaseUnitSystemManager : IUnitSystemManager
  {
    private IList<IUnitDimension> DimensionCol;

    public BaseUnitSystemManager(IUnitSystemLoader loader)
    {
      this.DimensionCol = loader != null ? loader.Dimensions.ToList() : new List<IUnitDimension>();
      this.Dimensions = new UnitDimensionCollection(this.DimensionCol);
    }

    public IUnitDimensionCollection Dimensions { get; private set; }

    public IEnumerable<IUnitOfMeasure> Units => this.Dimensions.SelectMany(d => d.Units);

    public IUnitOfMeasure FindUnitOfMeasure(string uomCode)
    {
      return this.Units.FirstOrDefault(u => string.Equals(u.Code, uomCode, StringComparison.OrdinalIgnoreCase));
    }

    public IUnitOfMeasure FindUnitOfMeasure(string dimensionCode, string uomCode)
    {
      return this.Dimensions.FirstOrDefault(d => string.Equals(d.Code, dimensionCode, StringComparison.OrdinalIgnoreCase))?.Units.FirstOrDefault(u => string.Equals(u.Code, uomCode, StringComparison.OrdinalIgnoreCase));
    }
  }
}
