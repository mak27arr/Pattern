using System;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new Object();

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            lock (syncRoot)
            {
                if (instance == null)
                    instance = new Singleton();
            }

            return instance;
        }
    }
}
