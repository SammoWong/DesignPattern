using System;

namespace DesignPattern.Factory
{
    public abstract class Car
    {
        protected abstract void Run();

        public string Color { get; set; }

        public abstract void GetColor();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }

    public class BmwCar : Car
    {
        public override void GetColor()
        {
            Console.WriteLine("BMW:BLACK");
        }

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class BydCar : Car
    {
        public override void GetColor()
        {
            Console.WriteLine("BYD:BLUE");
        }

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }
}