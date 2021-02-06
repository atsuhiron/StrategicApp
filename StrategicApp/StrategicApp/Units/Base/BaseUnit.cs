namespace StrategicApp.Units.Base
{
    public abstract class BaseUnit : IUnit
    {
        protected abstract string Name_ { get; }
        protected abstract int Id_ { get; set; }
        protected abstract int MaxMobility_ { get; }
        protected abstract float MaxLife_ { get; }
        protected abstract UnitAction Actions_ { get; }
        protected float Life_ { get; set; }
        
        public string GetName()
        {
            return Name_;
        }

        public string GetUniqueName()
        {
            return Name_ + "_" + Id_.ToString();
        }

        public virtual string GetShortName()
        {
            return Name_.Substring(0, 3);
        }

        public int GetMaxMobility()
        {
            return MaxMobility_;
        }

        public float GetMaxLife()
        {
            return MaxLife_;
        }

        public float GetLife()
        {
            return Life_;
        }

        public void SetLife(float life)
        {
            Life_ = life;
            if (Life_ > MaxLife_)
            {
                Life_ = MaxLife_;
            }
        }

        public void SetLifeDelta(float lifeDelta)
        {
            Life_ += lifeDelta;
            if (Life_ > MaxLife_)
            {
                Life_ = MaxLife_;
            }
        }

        public bool IsNeutralized()
        {
            return Life_ <= 0;
        }

        public bool CanJoin(IUnit other)
        {
            if (!GetName().Equals(other.GetName()))
            {
                return false;
            }
            return (GetLife() + other.GetLife()) <= GetMaxLife();
        }
    }
}
