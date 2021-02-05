using System;
using System.Collections.Generic;
using System.Text;

namespace StrategicApp.Units.Base
{
    interface IUnit
    {
        string GetName();
        int GetMaxMobbility();
        float GetLife();
    }
}
