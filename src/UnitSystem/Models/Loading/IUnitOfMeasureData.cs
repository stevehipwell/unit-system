using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Loading
{
  public interface IUnitOfMeasureData
  {
    string Code { get; set; }

    bool IsComposite { get; set; }

    double Scale { get; set; }

    double Offset { get; set; }

    IEnumerable<IComponentData> Components { get; set; }
  }
}
