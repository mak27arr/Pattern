using System;

namespace Staregy
{
    class Rectangle : IObject
    {
        private float _height;
        private float _wight;

        public float Wight
        {
            get
            {
                return _wight;
            }

            set
            {
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException(nameof(value));

                if (value > 0)
                    _wight = value;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException(nameof(value));

                if (value > 0)
                    _height = value;
            }
        }

        public float GetSquare()
        {
            return Wight * Height;
        }
    }
}
