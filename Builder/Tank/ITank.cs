namespace Builder
{
    internal interface ITank
    {
        void SetType(ILiquid type);
        void Add(float count);
        bool Get(float count);
    }
}