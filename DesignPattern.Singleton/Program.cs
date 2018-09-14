using System;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton4 singleton = Singleton4.Instance;
            singleton.GetInfo();
            Console.Read();
        }
    }
}
