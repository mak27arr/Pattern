using Builder.Class;

namespace Builder
{
    internal class DieselEnging : IEngine
    {
        private IFuel _fuel;
        private float _horsePower;

        public DieselEnging(float horsePower)
        {
            _fuel = new Diesel();
            _horsePower = horsePower;
        }
    }
}