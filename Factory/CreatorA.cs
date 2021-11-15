namespace Factory
{
    internal class CreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductA();
        }
    }
}
