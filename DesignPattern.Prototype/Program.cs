using System;

namespace DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new ApplePrototype("Apple");
            var apple2 = (ApplePrototype)apple.Clone();

            var sumsung = new SumsungPrototype("Sumsung");
            var sumsung2 = (SumsungPrototype)sumsung.Clone();

            Console.WriteLine(apple2.Brand);
            Console.WriteLine(sumsung2.Brand);

            Console.Read();
        }
    }
}
