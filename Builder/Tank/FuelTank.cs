namespace Builder.Class
{
    class FuelTank : ITank
    {
        private ILiquid _type;
        private float _count;

        public FuelTank(IFuel fuel)
        {
            _type = fuel;
        }

        public void SetType(ILiquid type)
        {
            _type = type;
        }

        public void Add(float count)
        {
            if (count > 0)
                _count += count;
        }

        public bool Get(float count)
        {
            var after = _count - count;

            if (after >= 0)
            {
                _count = after;

                return true;
            }

            return false;
        }
    }
}
