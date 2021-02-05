using System;
using System.Collections.Generic;
using System.Text;
using StrategicApp.Units;

namespace StrategicApp.Grids.Base
{
    interface IGrid
    {
        string GetName();
        int GetMoveCost(UnitAreaType unitAreaType);
        bool IsBuilding();
    }
}
