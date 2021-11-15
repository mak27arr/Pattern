using System;

namespace Staregy
{
    class Circle : IObject
    {
        private float _radius;

        public float Radius {
            get
            {
                return _radius;
            }

            set
            {
                if (value > 0)
                    _radius = value;
            }
        }

        public float GetSquare()
        {
            return (float) (Radius * Radius * Math.PI);
        }
    }
}
