using System;
using FakeItEasy;
using Xunit;

using UnitSystem.Models;
using UnitSystem.Models.Implementation;

namespace UnitSystemTest.Models.Implementation
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
