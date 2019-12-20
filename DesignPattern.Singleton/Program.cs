using System;

namespace DesignPattern.Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton4 singleton = Singleton4.Instance;
            singleton.GetInfo();
            Console.Read();
        }
    }
}