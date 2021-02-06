namespace StrategicApp.Units.Base
{
    public interface IUnit
    {
        string GetName();
        string GetUniqueName();
        string GetShortName();
        int GetMaxMobility();
        float GetMaxLife();
        float GetLife();
        void SetLife(float life);
        void SetLifeDelta(float lifeDelta);
        bool IsNeutralized();
        bool CanJoin(IUnit other);
    }
}
