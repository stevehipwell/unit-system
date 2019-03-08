using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;
using UnitSystem.Loader;
using UnitSystem.Models.Implementation;

namespace UnitSystem.Loader.Implementation
{
  public abstract class UnitSystemLoaderBase : IUnitSystemLoader
  {
    private IEnumerable<IUnitDimensionData> SourceData;
    private IList<IUnitDimension> DimensionCol;

    public IEnumerable<IUnitDimension> Dimensions
    {
      get
      {
        if (this.DimensionCol == null)
        {
          LoadData();
        }

        return this.DimensionCol;
      }
    }

    protected abstract IEnumerable<IUnitDimensionData> LoadSourceData();

    private void LoadData()
    {
      this.SourceData = this.LoadSourceData();
      this.DimensionCol = new List<IUnitDimension>();

      this.LoadDimensions();
    }

    private void LoadDimensions()
    {
      foreach (var sourceDimension in this.SourceData.OrderBy(d => d.IsComposite))
      {
        if (!this.DimensionCol.Any(d => string.Equals(d.Code, sourceDimension.Code, StringComparison.OrdinalIgnoreCase)))
        {
          this.AddDimension(sourceDimension);
        }
      }
    }

    private IUnitDimension AddDimension(IUnitDimensionData sourceDimension)
    {
      IUnitDimension dimension;
      if (sourceDimension.IsComposite)
      {
        dimension = this.GetCompositeDimension(sourceDimension);
      }
      else
      {
        dimension = this.GetScalarDimension(sourceDimension);
      }

      this.DimensionCol.Add(dimension);

      return dimension;
    }

    private IScalarUnitDimension GetScalarDimension(IUnitDimensionData sourceDimension)
    {
      var dimension = new ScalarUnitDimension(sourceDimension.Code);

      foreach (var sourceUnit in sourceDimension.Units)
      {
        dimension.AddUnit(this.GetScalarUnit(dimension, sourceUnit));
      }

      return dimension;
    }

    private ICompositeUnitDimension GetCompositeDimension(IUnitDimensionData sourceDimension)
    {
      var dimension = new CompositeUnitDimension(sourceDimension.Code, sourceDimension.Components.Select(c => this.GetCompositeDimensionComponent(c)));

      foreach (var sourceUnit in sourceDimension.Units)
      {
        dimension.AddUnit(this.GetCompositeUnit(dimension, sourceUnit));
      }

      return dimension;
    }

    private IUnitDimensionComponent GetCompositeDimensionComponent(IUnitDimensionComponentData sourceComponent)
    {
      return new UnitDimensionComponent(this.GetRequiredDimension(sourceComponent.Code), sourceComponent.Power);
    }

    private IScalarUnitOfMeasure GetScalarUnit(IScalarUnitDimension dimension, IUnitOfMeasureData sourceUnit)
    {
      return new ScalarUnitOfMeasure(dimension, sourceUnit.Code, sourceUnit.Scale, sourceUnit.Offset);
    }

    private ICompositeUnitOfMeasure GetCompositeUnit(ICompositeUnitDimension dimension, IUnitOfMeasureData sourceUnit)
    {
      return new CompositeUnitOfMeasure(dimension, sourceUnit.Code, sourceUnit.Components);
    }

    private IUnitDimension GetRequiredDimension(string code)
    {
      var dimension = this.DimensionCol.FirstOrDefault(d => string.Equals(d.Code, code, StringComparison.OrdinalIgnoreCase));

      if (dimension == null)
      {
        dimension = this.AddDimension(this.SourceData.First(d => string.Equals(d.Code, code, StringComparison.OrdinalIgnoreCase)));
      }

      return dimension;
    }
  }
}
