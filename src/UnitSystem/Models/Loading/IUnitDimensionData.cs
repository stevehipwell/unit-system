using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Loading
{
  public interface IUnitDimensionData
  {
    string Code { get; set; }

    bool IsComposite { get; set; }

    IEnumerable<IComponentData> Components { get; set; }

    IEnumerable<IUnitOfMeasureData> Units { get; set; }
  }
}
