namespace DesignPattern.Factory
{
    /// <summary>
    /// 工厂方法:符合开放封闭原则
    /// 工厂方法是针对每一种产品提供一个工厂类。通过不同的工厂实例来创建不同的产品实例
    /// 在同一等级结构中，支持增加任意产品。
    /// 符合【开放封闭原则】，但随着产品类的增加，对应的工厂也会随之增多
    /// </summary>
    public interface IFactory
    {
        Car Create();
    }

    public class BMWFactory : IFactory
    {
        public Car Create()
        {
            return new BmwCar();
        }
    }

    public class BYDFactory : IFactory
    {
        public Car Create()
        {
            return new BydCar();
        }
    }
}