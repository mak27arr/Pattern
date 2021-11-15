namespace Factory
{
    internal class ProductB : Product
    {
        public override double GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
}
