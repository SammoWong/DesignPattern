using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 单例模式：锁机制
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 singleton3;

        private static readonly object _lock = new object();

        private Singleton3(){}

        public static Singleton3 Instance()
        {
            if(singleton3 == null)
            {
                lock (_lock)
                {
                    if(singleton3 == null)
                    {
                        singleton3 = new Singleton3();
                    }
                }
            }
            return singleton3;
        }
    }
}
