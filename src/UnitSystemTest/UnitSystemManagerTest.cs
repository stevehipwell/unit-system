using System;
using Xunit;

using UnitSystem;

namespace UnitSystemTest
{
  public class UnitSystemManagerTest
  {
    [Fact]
    public void UnitSystemManagerIsSingletonInstance()
    {
      Assert.Same(UnitSystemManager.Instance, UnitSystemManager.Instance);
    }

    [Fact]
    public void UnitSystemManagerHasDimensionCollection()
    {
      Assert.Empty(UnitSystemManager.Instance.Dimensions);
    }
  }
}
