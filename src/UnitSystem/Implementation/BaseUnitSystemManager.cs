using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;
using UnitSystem.Models.Loading;

namespace UnitSystem.Implementation
{
  public class BaseUnitSystemManager : IUnitSystemManager
  {
    private IList<IUnitDimension> DimensionCol;

    public BaseUnitSystemManager(IUnitSystemLoader loader)
    {
      this.DimensionCol = loader != null ? loader.LoadData() : new List<IUnitDimension>();
      this.Dimensions = new UnitDimensionCollection(this.DimensionCol);

      this.LoadData(loader);
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

    private void LoadData(IUnitSystemLoader loader)
    {
      if (loader == null)
      {
        return;
      }


    }
  }
}
