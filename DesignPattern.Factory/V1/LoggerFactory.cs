using System;

namespace DesignPattern.Factory.V1
{
    /// <summary>
    /// 简单工厂方法
    /// </summary>
    public class LoggerFactory
    {
        public ILogger CreateLogger(string args)
        {
            if (args.Equals("db", StringComparison.OrdinalIgnoreCase))
            {
                return new DatabaseLogger();
            }
            else if (args.Equals("file", StringComparison.OrdinalIgnoreCase))
            {
                return new FileLogger();
            }
            return null;
        }
    }
}