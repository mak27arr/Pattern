namespace Factory
{
    class CreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductB();
        }
    }
}
