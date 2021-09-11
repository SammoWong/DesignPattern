using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            FatPersonBuilder fatPersonBuilder = new FatPersonBuilder();
            ThinPersonBuilder thinPersonBuilder = new ThinPersonBuilder();
            PersonDirector fatPersonDirect = new PersonDirector(fatPersonBuilder);
            PersonDirector thinPersonDirect = new PersonDirector(thinPersonBuilder);
            var fatPerson = fatPersonDirect.BuildPerson();
            var thinPerson = thinPersonDirect.BuildPerson();

            Console.ReadKey();
        }
    }
}
