using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;

namespace UnitSystem.Models.Loading
{
  public interface IUnitSystemLoader
  {
    IList<IUnitDimension> LoadData();
  }
}
