using System;

namespace Factory
{
    public abstract class Product
    {
        public virtual double GetPrice()
        {
            return 0;
        }
    }
}
