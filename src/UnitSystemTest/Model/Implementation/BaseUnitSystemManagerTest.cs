using System;
using FakeItEasy;
using Xunit;

using UnitSystem.Model;
using UnitSystem.Model.Implementation;

namespace UnitSystemTest.Model.Implementation
{
  public class BaseUnitSystemManagerTest
  {
    [Fact]
    public void BaseUnitSystemManagerLoadsNothingWithNullLoader()
    {
      var manager = new BaseUnitSystemManager(null);

      Assert.Empty(manager.Dimensions);
    }
  }
}
