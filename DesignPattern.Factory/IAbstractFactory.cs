namespace DesignPattern.Factory
{
    /// <summary>
    /// 抽象工厂模式：抽象工厂是应对产品族概念的，应对产品族概念而生，增加新的产品线很容易，但是无法增加新的产品
    /// </summary>
    public interface IAbstractFactory
    {
        Car CreateCar();

        Bus CreateBus();
    }

    public class BmwFactory : IAbstractFactory
    {
        public Bus CreateBus()
        {
            return new BmwBus();
        }

        public Car CreateCar()
        {
            return new BmwCar();
        }
    }

    public class BydFactory : IAbstractFactory
    {
        public Bus CreateBus()
        {
            return new BydBus();
        }

        public Car CreateCar()
        {
            return new BydCar();
        }
    }
}