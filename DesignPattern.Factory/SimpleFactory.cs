using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    /// <summary>
    /// 产品枚举
    /// </summary>
    public enum CarEnum
    {
        BMW,
        BYD
    }

    /// <summary>
    /// 简单工厂方法：如果新增产品则需要修改工厂方法，需要增加工厂的Swith分支，不符合开放封闭原则
    /// </summary>
    public class SimpleFactory
    {
        public static Car Create(CarEnum carEnum)
        {
            switch (carEnum)
            {
                case CarEnum.BMW:
                    return new BmwCar();
                case CarEnum.BYD:
                    return new BydCar();
                default:
                    return null;
            }
        }
    }
}
