using System;
using Builder.Class;

namespace Builder
{
    class CarBuilder : IBuilder
    {
        IMachine _carMachine = new Car();
        public void AddWeels()
        {
            var weels = new Weels(15);
            _carMachine.SetWeels(weels);
        }

        public void AddEnging()
        {
            var engine = new DieselEnging(10);
            _carMachine.SetEngine(engine);
        }

        public void AddFuelTank()
        {
            var fuelTank = new FuelTank(new Diesel());
            _carMachine.SetFuelTank(fuelTank);
        }

        public IMachine GetResult()
        {
            return _carMachine;
        }
    }
}
