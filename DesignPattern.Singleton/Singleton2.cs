namespace DesignPattern.Singleton
{
    /// <summary>
    /// 单例模式：延迟初始化
    /// </summary>
    public class Singleton2
    {
        private static Singleton2 singleton2;

        private Singleton2()
        {
        }

        public static Singleton2 Instance()
        {
            return singleton2 ?? (singleton2 = new Singleton2());
        }
    }
}