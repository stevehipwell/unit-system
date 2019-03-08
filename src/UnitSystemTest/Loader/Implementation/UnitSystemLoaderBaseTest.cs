using System;
using FakeItEasy;
using Xunit;

using UnitSystem.Models;
using UnitSystem.Loader.Implementation;
using UnitSystem.Loader;

namespace UnitSystemTest.Models.Implementation
{
  public class UnitSystemLoaderBaseTest
  {
    [Fact]
    public void UnitSystemLoaderBaseLoadsNothingFromEmptySourceData()
    {
      var fakeData = new IUnitDimensionData[] { };
      var loader = A.Fake<UnitSystemLoaderBase>(o => o.WithArgumentsForConstructor(new object[] { fakeData }).CallsBaseMethods());

      Assert.Empty(loader.Dimensions);
    }
  }
}
