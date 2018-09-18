﻿using System;

namespace DesignPattern.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = SimpleFactory.Create(CarEnum.BYD);
            car.GetInfo();

            IFactory factory = new BMWFactory();
            var bmw = factory.Create();
            bmw.GetInfo();


            var bmwFactory = new BmwFactory();
            bmwFactory.CreateBus().GetInfo();
            bmwFactory.CreateCar().GetInfo();

            Console.Read();
        }
    }
}
