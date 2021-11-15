namespace Builder
{
    internal class Car : IMachine
    {
        private IEngine _engine;
        private ITank _fuelTank;
        private IWeels _weels;

        public void SetEngine(IEngine engine)
        {
            _engine = engine;
        }

        public void SetFuelTank(ITank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public void SetWeels(IWeels weels)
        {
            _weels = weels;
        }
    }
}