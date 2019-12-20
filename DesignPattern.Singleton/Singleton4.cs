using System;

namespace DesignPattern.Singleton
{
    public class Singleton4
    {
        private Singleton4()
        {
        }

        public static Singleton4 Instance => GenericSingleton<Singleton4>.Instance();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", GetType().Name));
        }
    }

    public class GenericSingleton<T> where T : class
    {
        private static T _instance;

        private static readonly object _lock = new object();

        public static T Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            return _instance;
        }
    }
}