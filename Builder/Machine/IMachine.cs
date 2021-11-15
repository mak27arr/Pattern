namespace Builder
{
    interface IMachine
    {
        void SetEngine(IEngine engine);
        void SetWeels(IWeels weels);
        void SetFuelTank(ITank fuelTank);
    }
}
