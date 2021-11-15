using System;

namespace Builder
{
    internal class Weels : IWeels
    {
        private int _size;

        public Weels(int size)
        {
            _size = size;
        }

        public double GetDistanceByTurn(double count)
        {
            return 2 * Math.PI * _size / 2 * count;
        }
    }
}