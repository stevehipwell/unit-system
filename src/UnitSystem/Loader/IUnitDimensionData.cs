using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Loader
{
  public interface IUnitDimensionData
  {
    string Code { get; set; }

    bool IsComposite { get; set; }

    IEnumerable<IUnitDimensionComponentData> Components { get; set; }

    IEnumerable<IUnitOfMeasureData> Units { get; set; }
  }
}
