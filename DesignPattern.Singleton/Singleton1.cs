using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 简单单例模式
    /// </summary>
    public class Singleton1
    {
        /// <summary>
        /// 静态变量保证线程安全，每个线程共享一个实例
        /// </summary>
        private static Singleton1 singleton = new Singleton1();

        /// <summary>
        /// 不能通过new实例化
        /// </summary>
        private Singleton1() { }

        public static Singleton1 Instance()
        {
            return singleton;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
}
