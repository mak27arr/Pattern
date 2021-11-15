namespace Builder
{
    interface IBuilder
    {
        void AddWeels();
        void AddEnging();
        void AddFuelTank();
        IMachine GetResult();
    }
}
