namespace StrategicApp.Units.Base
{
    public abstract class BaseInfantry : BaseUnit, IInfantry
    {
        protected abstract int MaxOccpancyCapability_ { get; }

        public int GetMaxOccupancyCapability()
        {
            return MaxOccpancyCapability_;
        }

        public float CalcEffectiveOccpancyCapability()
        {
            return MaxOccpancyCapability_ * Life_ / MaxLife_;
        }
    }
}
