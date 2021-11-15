namespace Factory
{
    internal class ProductA : Product
    {
        public override double GetPrice()
        {
            return base.GetPrice() + 1;
        }
    }
}
