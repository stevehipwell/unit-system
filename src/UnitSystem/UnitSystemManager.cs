using System;
using System.Collections.Generic;
using System.Linq;

using UnitSystem.Models;
using UnitSystem.Loader;
using UnitSystem.Models.Implementation;

namespace UnitSystem
{
  public sealed class UnitSystemManager
  {
    private static IUnitSystemLoader Loader;
    private static IUnitSystemManager InstanceField;
    private static readonly object InstanceThreadLock = new object();
    private static readonly object LoaderThreadLock = new object();

    public static IUnitSystemManager Instance
    {
      get
      {
        if (InstanceField == null)
        {
          lock (InstanceThreadLock)
          {
            if (InstanceField == null)
            {
              InstanceField = new BaseUnitSystemManager(Loader);
            }
          }
        }

        return InstanceField;
      }
    }

    public static void SetLoader(IUnitSystemLoader loader)
    {
      lock (LoaderThreadLock)
      {
        Loader = loader;
        ClearInstance();
      }
    }

    private static void ClearInstance()
    {
      lock (InstanceThreadLock)
      {
        if (InstanceField != null)
        {
          InstanceField = null;
        }
      }
    }
  }
}
