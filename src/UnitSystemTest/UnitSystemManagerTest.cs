using System;
using FakeItEasy;
using Xunit;

using UnitSystem;
using UnitSystem.Models;
using UnitSystem.Models.Implementation;
using UnitSystem.Loader;

namespace UnitSystemTest
{
  public class UnitSystemManagerTest
  {
    public UnitSystemManagerTest()
    {
      UnitSystemManager.SetLoader(null);
    }

    [Fact]
    public void UnitSystemManagerCreatesInstance()
    {
      Assert.NotNull(UnitSystemManager.Instance);
      Assert.IsType<BaseUnitSystemManager>(UnitSystemManager.Instance);
    }

    [Fact]
    public void UnitSystemManagerHasSingletonInstance()
    {
      Assert.Same(UnitSystemManager.Instance, UnitSystemManager.Instance);
    }

    [Fact]
    public void UnitSystemManagerHasEmptyDimensionCollectionWithoutLoader()
    {
      Assert.Empty(UnitSystemManager.Instance.Dimensions);
    }

    [Fact]
    public void UnitSystemManagerSetLoaderResetsInstance()
    {
      var fakeDimension = A.Fake<IUnitDimension>();
      var fakeLoader = A.Fake<IUnitSystemLoader>();

      UnitSystemManager.SetLoader(fakeLoader);
      var instance = UnitSystemManager.Instance;

      A.CallTo(() => fakeLoader.Dimensions).MustHaveHappened();
    }
  }
}
