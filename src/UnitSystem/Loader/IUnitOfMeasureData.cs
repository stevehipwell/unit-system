using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Model;

namespace UnitSystem.Loader
{
  public interface IUnitOfMeasureData
  {
    string Code { get; set; }

    bool IsComposite { get; set; }

    double Scale { get; set; }

    double Offset { get; set; }

    IEnumerable<string> Components { get; set; }
  }
}
