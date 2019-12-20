using System;

namespace DesignPattern.Factory
{
    public abstract class Bus
    {
        protected abstract void Run();

        public string Color { get; set; }

        public abstract void GetColor();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }

    public class BmwBus : Bus
    {
        public override void GetColor()
        {
            throw new NotImplementedException();
        }

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class BydBus : Bus
    {
        public override void GetColor()
        {
            throw new NotImplementedException();
        }

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }
}