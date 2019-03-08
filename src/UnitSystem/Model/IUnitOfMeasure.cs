using System;

namespace UnitSystem.Model
{
  public interface IUnitOfMeasure
  {
    IUnitDimension Dimension { get; }

    string Code { get; }

    double Scale { get; }

    double Offset { get; }
  }
}
