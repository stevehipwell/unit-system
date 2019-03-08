using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Implementation;
using UnitSystem.Model;

namespace UnitSystem
{
  public sealed class UnitSystemManager
  {
    private static UnitSystemManager InstanceField;
    private static readonly object ThreadLock = new object();

    public static UnitSystemManager Instance
    {
      get
      {
        if (InstanceField == null)
        {
          lock (ThreadLock)
          {
            if (InstanceField == null)
            {
              InstanceField = new UnitSystemManager();
            }
          }
        }

        return InstanceField;
      }
    }

    private IList<IUnitDimension> DimensionCol;

    private UnitSystemManager()
    {
      this.DimensionCol = new List<IUnitDimension>();
      this.Dimensions = new UnitDimensionCollection(this.DimensionCol);
    }

    public IUnitDimensionCollection Dimensions { get; private set; }

    public IEnumerable<IUnitOfMeasure> Units => this.Dimensions.SelectMany(d => d.Units);

    public void AddDimension(IUnitDimension dimension)
    {
      this.DimensionCol.Add(dimension);
    }

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
