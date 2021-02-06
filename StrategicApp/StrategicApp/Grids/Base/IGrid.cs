using StrategicApp.Units;

namespace StrategicApp.Grids.Base
{
    public interface IGrid
    {
        string GetName();
        int GetMoveCost(UnitAreaType unitAreaType);
        bool IsBuilding();
    }
}
